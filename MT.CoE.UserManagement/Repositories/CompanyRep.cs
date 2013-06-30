using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class CompanyRep : MongoRepository<Company>
    {
        readonly static MongoRepository<Company> Company = new MongoRepository<Company>();

        public static IQueryable<Company> GetAllCompanies()
        {
            return Company.All();
        }
    }
}