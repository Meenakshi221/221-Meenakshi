using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc2.Controllers
{
    public class GetStudentId : Controller
    {
        public string Index()
        {
            return "Student Details";
        }
        public string GetStudenti()
        {
            return "Student ID: 1234";
        }
        public string GetStudentName()
        {
            return "Student Name : Thoushif";
        }
    }
}
