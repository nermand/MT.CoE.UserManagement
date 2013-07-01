using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class HighschoolRep : Entity
    {
        readonly static MongoRepository<HighSchool> HighSchool = new MongoRepository<HighSchool>();

        public static IQueryable<HighSchool> GetAllHighSchools()
        {
            return HighSchool.All();
        }
    }
}