using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Class1
    {
        static void Main()
        {
            Student std = new Student();
            string name = std.GetName();
            string location = std.GetLocation();
            Console.WriteLine(name + " is located at " + location);
        }
    }
}
