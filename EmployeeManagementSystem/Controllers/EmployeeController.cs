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

        [HttpPost]
        [Route("api/login")]
        public ActionResult Login(int employeeId, string mobile)
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
        [HttpPost]
        [Route("api/register")]
        public ActionResult Register(int id, string firstName, string lastName, string mobile, string email, string city)
        {
            EmployeeModel employee = new EmployeeModel { 
                EmployeeID = id,
                FirstName = firstName,
                LastName = lastName,
                Mobile = mobile,
                Email = email,
                City = city
            };
            bool responce = employeeView.Register(employee);
            if (responce)
            {
                return this.Ok("Registered Successfully");
            }
            return this.BadRequest("Not registered");
        }
        [HttpPut]
        [Route("api/update")]
        public ActionResult Update(int id, string mobile, string email, string city)
        {
            EmployeeModel employee = new EmployeeModel
            {
                EmployeeID = id,
                FirstName = "Dhanya",
                LastName = "Bhushan",
                Mobile = mobile,
                Email = email,
                City = city
            };
            bool responce = employeeView.Update(employee);
            if (responce)
            {
                return this.Ok("Registered Successfully");
            }
            return this.BadRequest("Not registered");
        }
    }
}
