using Microsoft.AspNetCore.Mvc;
using MVC_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_4.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { CustomerId = 1234, CustomerName = "Thoushif", CustomerAddress = "Tvr" });
            customers.Add(new Customer() { CustomerId = 4567, CustomerName = "Mohamed", CustomerAddress = "Karur" });
            customers.Add(new Customer() { CustomerId = 7894, CustomerName = "Mohamed", CustomerAddress = "Nag" });

            ViewData["Customers"] = customers;

            return View();
        }
    }
}
