﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Contracts.Auth
{
    public class LoginRequest
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
