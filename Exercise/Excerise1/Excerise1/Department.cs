using System;
using System.Collections.Generic;
using System.Text;

namespace Excerise1
{
    class Department
    {
        public void GetDepartmentName()
        {
            Console.WriteLine("Enter the Department Name :");
            Console.ReadLine();
        }
        public void GetNumberofDepartment()
        {
            Console.WriteLine("Enter the Number of Department in the group :");
            Console.ReadLine();

        }
        public virtual void GetDepartmentDetails()
        {
            Console.WriteLine("The Department Details ");
            Console.WriteLine(" 1.The Team Name is front end developer team");
            Console.WriteLine(" 2.Adhul Khan is the project manager");
            Console.WriteLine(" 3.There are 10 project developer in our team");
        }
    }

}

