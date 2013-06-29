using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoRepository;

namespace MT.CoE.UserManagement.Models
{
    public class Certificate : Entity
    {
        public int CertId { get; set; }
        public string CertName { get; set; }
        public string Description { get; set; }
        public string CertAuthority { get; set; }
    }
}