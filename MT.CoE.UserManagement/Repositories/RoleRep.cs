using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class RolesRep : Entity
    {
        readonly static MongoRepository<Role> Role = new MongoRepository<Role>();

        public static IQueryable<Role> GetAllRoles()
        {
            return Role.All();
        }
    }
}