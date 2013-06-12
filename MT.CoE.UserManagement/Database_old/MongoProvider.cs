using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MT.CoE.UserManagement.Database_old;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MvcGit.Models;

namespace MvcGit.Database
{
    public class MongoProvider : IDbProvider
    {
        public MongoProvider()
        {
        }

        public IQueryable<T> All<T>()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Filter<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Contains<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Find<T>(params object[] keys)
        {
            var mongoConnectionString = Helpers.ConfigHelper.MongoDbLoggerConnectionString;
            var client = new MongoClient(mongoConnectionString);
            var server = client.GetServer();
            var database = server.GetDatabase(Helpers.ConfigHelper.MongoEntityDatabase);

            var collection = database.GetCollection<T>(Helpers.ConfigHelper.MongoEntityCollection);
            var query = Query<Entity>.EQ(e => e.Name, keys[0]);
            T newEntity = collection.FindOne(query);
            return newEntity;
        }

        public T Create<T>(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T t)
        {
            throw new NotImplementedException();
        }

        public int Delete<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Update<T>(T t)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public T Find<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate, string name)
        {
            throw new NotImplementedException();
        }


        public T Find<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}