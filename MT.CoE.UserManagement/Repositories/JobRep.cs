using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class JobRep : Entity
    {
        static MongoRepository<Job> Job = new MongoRepository<Job>();

        public static IQueryable<Job> GetAllJobs()
        {
            return Job.All();
        }
        
        public void Save(Job item)
        {
            Job.Add(item);
        }
    }
}