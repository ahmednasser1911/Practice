using BubberDinner.Application.Common.Interfaces.Auth;
using BubberDinner.Application.Common.Interfaces.Persistence;
using BubberDinner.Application.Models.Auth;
using BubberDinner.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Application.Services
{
    public class AuthServices : IAuthServices
    {
        private readonly IJwtGenerator jwtGenerator;
        private readonly IUserRepo userRepo;

        public AuthServices(IJwtGenerator jwtGenerator, IUserRepo userRepo)
        {
            this.jwtGenerator = jwtGenerator;
            this.userRepo = userRepo;
        }
        public AuthResponseModel Login(LoginModel input)
        {
            // 1 - validate user exist
            if (userRepo.GetUserByEmail(input.Email) is not User user)
                throw new Exception("user dosn't exist!");
            // 2 - check for password
            if(user.Password != input.Password)
                throw new Exception("wrong password!");
            // 3 - create token
            var token = jwtGenerator.GenerateToken(user);

            return new AuthResponseModel()
            {
                Token = token,
                User = user
            };
        }

        public AuthResponseModel Register(RegisterModel input)
        {

            // 1 - validate user exist 
            if (userRepo.GetUserByEmail(input.user.Email) is not null) 
                throw new Exception("user exist!");

            // 2 - create user (generate uniqe id) & save to DB
            var user = new User
            {
                Email = input.user.Email,
                Password = input.user.Password,
                FirstName = input.user.FirstName,
                LastName = input.user.LastName,

            };
            
            userRepo.AddUser(user);

            // 3 - create token
            var token = jwtGenerator.GenerateToken(user);
            return new AuthResponseModel()
            {
                User = user,
                Token = token
            };
        }
    }
}
