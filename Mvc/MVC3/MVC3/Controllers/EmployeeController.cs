using Microsoft.AspNetCore.Mvc;
using MVC3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC3.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 1234, FirstName = "Thoushif", LastName = "H" });
            employees.Add(new Employee() { ID = 4567, FirstName = "Mohamed", LastName = "Saif" });
            employees.Add(new Employee() { ID = 7894, FirstName = "Mohamed", LastName = "Safe" });

            ViewData["employees"] = employees;

            ViewBag.TotalEmployees = employees.Count();
            ViewBag.CompanyName = "Enterprise Minds";
            return View();
        }
    }
}
