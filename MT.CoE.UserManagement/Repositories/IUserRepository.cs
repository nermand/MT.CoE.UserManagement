using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;

namespace MT.CoE.UserManagement.Repositories
{
    public interface IUserRepository
    {
        void TestMongoProvider();
        IQueryable<User> GetUsers(Expression<Func<User, bool>> inCriteria);
    }
}