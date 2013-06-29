using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoRepository;

namespace MT.CoE.UserManagement.Models
{
    public class Faculty : Entity
    {
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public int CityId { get; set; }
    }
}