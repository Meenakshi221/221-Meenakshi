using Microsoft.AspNetCore.Mvc;
using MVC7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC7.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            IList<Department> Dep = new List<Department>();
            Dep.Add(new Department() { DepartmentId = 1234, DepartmentName = "Front-End", DepartmentLocation = "1st" });
            Dep.Add(new Department() { DepartmentId = 4567, DepartmentName = "Back-End", DepartmentLocation = "2nd" });
            Dep.Add(new Department() { DepartmentId = 7894, DepartmentName = "Testing", DepartmentLocation = "3rd" });

            ViewData["Dep"] = Dep;

            ViewBag.TotalDepartment = Dep.Count();
            return View();
        }
    }
}
