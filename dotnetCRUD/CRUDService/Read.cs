using dotnetCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace dotnetCRUD.CRUDService
{
    public class Read : DBConnection
    {

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = "Select * from employees";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    employees.Add(new Employee { ID = int.Parse(reader["ID"].ToString()), Name = reader["Name"].ToString(), Position = reader["Position"].ToString() });
                }
            }
            conn.Close();
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = string.Format("Select * from employees WHERE ID = {0}",id);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    employee.ID = int.Parse(reader["ID"].ToString());
                    employee.Name = reader["Name"].ToString();
                    employee.Position = reader["Position"].ToString();
                }
            }
            conn.Close();
            return employee;
        }
    }
}