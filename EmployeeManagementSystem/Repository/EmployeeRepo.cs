using EmployeeManagement.Models;
using EmployeeManagement.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private string con = ConnectionString.ConnectionName;
        public bool Login(EmployeeModel employeeModel)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand("spGetAllEmployees", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (employeeModel.EmployeeID.Equals(reader["FirstName"]))
                    {
                        if (employeeModel.Mobile.Equals(reader["Mobile"]))
                        {
                            connection.Close();
                            return true;
                        }
                    }
                }
                return false;            }
        }
    }
}
