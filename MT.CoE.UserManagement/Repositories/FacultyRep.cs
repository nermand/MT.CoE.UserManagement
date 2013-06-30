using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;


namespace MT.CoE.UserManagement.Repositories
{
    public class FacultyRep : MongoRepository<Faculty>
    {
        readonly static MongoRepository<Faculty> Faculty = new MongoRepository<Faculty>();

        public static IQueryable<Faculty> GetAllFaculties()
        {
            return Faculty.All();
        }
    }
}