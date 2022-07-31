using BubberDinner.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Application.Models.Auth
{
    public class AuthResponseModel
    {
        public User? User { get; set; }
        public string? Token { get; set; } = string.Empty;
    }
}
