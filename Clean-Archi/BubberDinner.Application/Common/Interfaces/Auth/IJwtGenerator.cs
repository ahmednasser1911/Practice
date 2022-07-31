using BubberDinner.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Application.Common.Interfaces.Auth
{
    public interface IJwtGenerator
    {
        public string GenerateToken(User user);
    }
}
