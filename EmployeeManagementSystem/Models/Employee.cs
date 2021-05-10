using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        private int serialNumber;
        private int employeeID;
        private string firstName;
        private string lastName;
        private long mobile;
        private string email;
        private string city;
        public int SerialNumber { get; set; }
        public int EmployeeID { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int Mobile { get; set; }
        public int Email { get; set; }
        public int City { get; set; }
    }
}
