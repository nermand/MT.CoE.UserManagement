using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoRepository;

namespace MT.CoE.UserManagement.Models
{
    public class Job : Entity
    {
        public int JobId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string AreasOfExpertise { get; set; }
    }
}