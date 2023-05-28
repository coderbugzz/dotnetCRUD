using dotnetCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace dotnetCRUD.CRUDService
{
    public class Delete : DBConnection
    {
        public int DeleteEmployee(int id)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = string.Format("DELETE employees where ID = {0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            var result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    }
}