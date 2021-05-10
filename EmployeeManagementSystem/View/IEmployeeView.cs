using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.View
{
    public interface IEmployeeView
    {
        bool Login(EmployeeModel employeeModel);
    }
}
