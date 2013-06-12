using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MvcGit.Helpers
{
    public class ConfigHelper
    {
        internal static string MongoDbLoggerConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["mongoConnectionString"].ConnectionString; }
        }

        public static string MongoEntityDatabase
        {
            get { return ConfigurationManager.AppSettings["MongoEntityDatabase"]; }
        }

        public static string MongoEntityCollection
        {
            get { return ConfigurationManager.AppSettings["MongoEntityCollection"]; }
        }
    }
}