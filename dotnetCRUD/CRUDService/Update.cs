using dotnetCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace dotnetCRUD.CRUDService
{
    public class Update : DBConnection
    {
        public int UpdateEmployee(Employee employee)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = string.Format("UPDATE employees SET Name = '{0}', Position = '{1}' where ID = {2}", employee.Name, employee.Position,employee.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            var result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    }
}