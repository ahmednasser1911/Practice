using BubberDinner.Application.Common.Interfaces.Auth;
using BubberDinner.Core.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Infrastructure.Auth
{
    public class JwtGenerator : IJwtGenerator
    {
        private readonly JWTSettings _jwtSettings;
        public JwtGenerator(IOptions<JWTSettings> options)
        {
            _jwtSettings = options.Value;
        }

        public string GenerateToken(User user)
        {
            var signInCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)) ,
                SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub , user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName, user.FirstName),
                new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
                new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString()),
            };

            var securityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                expires: DateTime.Now.AddDays(int.Parse(_jwtSettings.Expiration)),
                claims: claims,
                signingCredentials: signInCredentials
                );

            return new JwtSecurityTokenHandler().WriteToken(securityToken);


        }
    }
}
