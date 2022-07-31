using Microsoft.AspNetCore.Mvc;
using BubberDinner.Contracts.Auth;
using BubberDinner.Application.Services;
using BubberDinner.Application.Models.Auth;
using BubberDinner.Core.Entities;

namespace BubberDinner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        private readonly IAuthServices authServices;

        public Auth(IAuthServices authServices)
        {
            this.authServices = authServices;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var res = authServices.Login(new LoginModel { Email = request.Email, Password = request.Password });
            return Ok(res);
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var res = authServices.Register(new RegisterModel
            {
                user = new User
                {
                    Email = request.user.Email,
                    Password = request.user.Password,
                    FirstName = request.user.FirstName,
                    LastName = request.user.LastName,
                }

            });
            return Ok(res);
        }
    }
}
