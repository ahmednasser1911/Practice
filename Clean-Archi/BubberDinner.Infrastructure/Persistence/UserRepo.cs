using BubberDinner.Application.Common.Interfaces.Persistence;
using BubberDinner.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Infrastructure.Persistence
{
    public class UserRepo : IUserRepo
    {
        private static readonly List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return users.SingleOrDefault(x => x.Email == email);
        }
    }
}
