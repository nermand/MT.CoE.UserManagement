using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class TechnologyRep : Entity
    {
        readonly static MongoRepository<Technology> Technology = new MongoRepository<Technology>();

        public static IQueryable<Technology> GetAllTechs()
        {
            return Technology.All();
        }
    }
}