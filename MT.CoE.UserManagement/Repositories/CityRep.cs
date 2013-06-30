using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class CityRep : MongoRepository<City>
    {
        readonly static MongoRepository<City> City = new MongoRepository<City>();

        public static IQueryable<City> GetAllCities()
        {
            return City.All();
        }
    }
}