using EmployeeManagement.Models;
using EmployeeManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.View
{
    public class EmployeeView : IEmployeeView
    {
        private IEmployeeRepo employee = new EmployeeRepo();
        public bool Login(EmployeeModel employeeModel)
        {
            return employee.Login(employeeModel);
        }
        public bool Register(EmployeeModel employeeModel)
        {
            return employee.Register(employeeModel);
        }
        public bool Update(EmployeeModel employeeModel)
        {
            return employee.Update(employeeModel);
        }
    }
}
