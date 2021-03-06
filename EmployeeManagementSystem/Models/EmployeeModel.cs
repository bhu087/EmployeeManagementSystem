using System;

namespace EmployeeManagement.Models
{
    public class EmployeeModel 
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private long mobile;
        private string email;
        private string city;

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}