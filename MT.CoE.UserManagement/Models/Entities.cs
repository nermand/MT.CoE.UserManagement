using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoRepository;

namespace MT.CoE.UserManagement.Models
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int Age { get; set; }
        public List<Skill> Skills { get; set; }

        public  User()
        {
            this.Skills = new List<Skill>();
        }
    }

    public class Skill
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Category { get; set; }
    }
}