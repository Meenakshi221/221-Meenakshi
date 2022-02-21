using System;
using System.Collections.Generic;
using System.Text;

namespace Excerise1
{
    class Employee : Department
    {
        public string GetEmployeeFistname()
        {
            return "Meenakshi";
        }
        public string GetEmployeeLastname()
        {
            return "Venkatesan";
        }
        public override void GetDepartmentDetails()
        {
            Console.WriteLine("The Department Details ");
            Console.WriteLine(" 1.The Team Name is BackEnd developer team");
            Console.WriteLine(" 2.Prasanna is the project manager");
            Console.WriteLine(" 3.There are 15 project developer in our team");
        }
    }

}
