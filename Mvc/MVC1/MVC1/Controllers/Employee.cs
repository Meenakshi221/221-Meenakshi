using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1.Controllers
{
    public class Employee : Controller
    {
        public string Index()
        {
            return "Employee Details";
        }
        public string Firstname()
        {
            return " First Name is : Thoushif ";
        }
        public string Lastname()
        {
            return "Last Name is : H";
        }

    }
}
