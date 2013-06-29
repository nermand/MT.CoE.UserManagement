using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoRepository;

namespace MT.CoE.UserManagement.Models
{
    public class HighSchool : Entity
    {
        public int HighSchoolId { get; set; }
        public string SchoolName { get; set; }
        public int CityId { get; set; }
    }
}