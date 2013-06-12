using System.Collections.Generic;

namespace MT.CoE.UserManagement.Models
{
    public class User_old
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int Age { get; set; }
        public List<Skill_old> Skills { get; set; }
    }
}