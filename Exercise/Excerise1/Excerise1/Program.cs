using System;

namespace Excerise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee dep = new Employee();
            dep.GetDepartmentName();
            dep.GetNumberofDepartment();
            dep.GetDepartmentDetails();
            string name1 = dep.GetEmployeeFistname();
            string name2 = dep.GetEmployeeLastname();
            Console.WriteLine("The Name of the employee is " + name1 + "  " + name2);

        }
    }
}
