using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class CertRep : MongoRepository<Certificate>
    {
        readonly static MongoRepository<Certificate> Cert = new MongoRepository<Certificate>();

        public static IQueryable<Certificate> GetAllCerts()
        {
            return Cert.All();
        }
    }
}