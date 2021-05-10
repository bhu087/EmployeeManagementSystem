using EmployeeManagement.Models;
using EmployeeManagement.View;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeView employeeView= new EmployeeView();
        public ActionResult Login(int employeeId, long mobile)
        {
            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeID = employeeId;
            employee.Mobile = mobile;
            try
            {
                bool responce = employeeView.Login(employee);
                if (responce)
                {
                    return this.Ok(responce);
                }
                return this.BadRequest(false);
            }
            catch
            {
                return this.BadRequest(false);
            }
        }
    }
}
