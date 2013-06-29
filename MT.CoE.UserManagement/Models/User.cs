using System;
using MongoRepository;

namespace MT.CoE.UserManagement.Models
{
    public class User : Entity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public int HighSchoolId { get; set; }
        public int FacultyId { get; set; }
        public int CertId { get; set; }
        public int TechId { get; set; }
        public int JobId { get; set; }
        public int CompanyId { get; set; }
        public string Hobby { get; set; }
        public string PersonalSkills { get; set; }
    }
}