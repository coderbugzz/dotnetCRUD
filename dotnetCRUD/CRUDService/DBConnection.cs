using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotnetCRUD.CRUDService
{
    public class DBConnection
    {
        public string ConnectionString { get; set; }
        public DBConnection()
        {
            ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CRUDDemoConnection"].ConnectionString;
        }
    }
}