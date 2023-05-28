using dotnetCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace dotnetCRUD.CRUDService
{
    public class Create : DBConnection
    {

        public int AddEmployee(Employee employee)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = string.Format("INSERT INTO employees(Name,Position) VALUES('{0}','{1}')",employee.Name, employee.Position);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            var result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    }
}