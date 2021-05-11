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
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    SqlCommand command = new SqlCommand("spGetAllEmployees", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (employeeModel.EmployeeID.ToString().Equals(reader["EmployeeID"].ToString()))
                        {
                            if (employeeModel.Mobile.ToString().Equals(reader["Mobile"].ToString()))
                            {
                                connection.Close();
                                return true;
                            }
                        }
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Register(EmployeeModel employeeModel)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand sqlCommand = new SqlCommand("spAddEmployee", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("EmployeeId",employeeModel.EmployeeID);
                sqlCommand.Parameters.AddWithValue("FirstName", employeeModel.FirstName);
                sqlCommand.Parameters.AddWithValue("LastName", employeeModel.LastName);
                sqlCommand.Parameters.AddWithValue("Mobile", employeeModel.Mobile);
                sqlCommand.Parameters.AddWithValue("Email",employeeModel.Email);
                sqlCommand.Parameters.AddWithValue("City", employeeModel.City);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            return false;
        }

        public bool Update(EmployeeModel employeeModel)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand sqlCommand = new SqlCommand("spGetAllEmployees", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    if (employeeModel.EmployeeID.Equals(reader["EmployeeID"]))
                    {
                        sqlCommand = new SqlCommand("spUpdateEmployee", connection);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("EmployeeID", employeeModel.EmployeeID);
                        sqlCommand.Parameters.AddWithValue("FirstName", employeeModel.FirstName);
                        sqlCommand.Parameters.AddWithValue("LastName", employeeModel.LastName);
                        sqlCommand.Parameters.AddWithValue("Mobile", employeeModel.Mobile);
                        sqlCommand.Parameters.AddWithValue("Email", employeeModel.Email);
                        sqlCommand.Parameters.AddWithValue("City", employeeModel.City);
                        connection.Close();
                        connection.Open();
                        sqlCommand.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
