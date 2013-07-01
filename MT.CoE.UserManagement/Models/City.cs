using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoRepository;

namespace MT.CoE.UserManagement.Models
{
    public class City : Entity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}