using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoRepository;

namespace MT.CoE.UserManagement.Models
{
    public class Technology : Entity
    {
        public int TechID { get; set; }
        public string TechName { get; set; }
        public string Description { get; set; }
    }
}