using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubberDinner.Core;
using BubberDinner.Core.Entities;

namespace BubberDinner.Application.Common.Interfaces.Persistence
{
    public interface IUserRepo
    {
        User? GetUserByEmail(string email);
        void AddUser(User user);
    }
}
