using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class UserRep : Entity, IUserRep
    {
        readonly static MongoRepository<User> User = new MongoRepository<User>();

        public IQueryable<User> GetAllUsers()
        {
            return User.All();
        }

        public void InsertUser(User newUser)
        {
            User.Add(newUser);
        }
    }
}