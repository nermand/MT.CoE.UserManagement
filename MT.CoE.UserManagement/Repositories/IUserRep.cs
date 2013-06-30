using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;

namespace MT.CoE.UserManagement.Repositories
{
    public interface IUserRep
    {
        IQueryable<User> GetAllUsers();
        void InsertUser(User newUser);
    }
}