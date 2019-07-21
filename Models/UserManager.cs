using FinalProject_Blog.Database;
using FinalProject_Blog.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Models
{
    public class UserManager : IUserManager
    {
        DbContext dbContext = new DbContext();

        public User CheckLogin(string Email, string Password)
        {
            return dbContext.CheckLogin(Email, Password);
        }
    }
}
