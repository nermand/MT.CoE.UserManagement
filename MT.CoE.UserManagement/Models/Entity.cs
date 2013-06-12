using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace MvcGit.Models
{
    public class Entity
    {
        public ObjectId Id { get; set; }
        [Key]
        public string Name { get; set; }
    }
}