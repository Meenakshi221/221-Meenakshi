using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1.Controllers
{
    public class HelloWorld : Controller
    {
        public string Index()
        {
            return " This is the default Action";
        }
        public string Welcome()
        {
            return " This is the Welcome Action";
        }


    }
}
