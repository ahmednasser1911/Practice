using BubberDinner.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Contracts.Auth
{
    public class RegisterRequest
    {
        public User user { get; set; }

    }
}
