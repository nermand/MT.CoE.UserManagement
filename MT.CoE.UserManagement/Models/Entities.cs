using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoRepository;
using Newtonsoft.Json;

namespace MT.CoE.UserManagement.Models
{
    public class User : Entity
    {

        [JsonProperty(PropertyName = "id")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "birthDate")]
        public DateTime BirthDate { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "phoneNo")]
        public string PhoneNo { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

    }
}