using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MT.CoE.UserManagement.ViewModels.Admin
{
    public class UserList
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string JobDescription { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public string PicUrl { get; set; }
    }
}