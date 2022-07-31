using BubberDinner.Application.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Application.Services
{
    public interface IAuthServices
    {
        AuthResponseModel Login(LoginModel input);
        AuthResponseModel Register(RegisterModel input);
    }
}
