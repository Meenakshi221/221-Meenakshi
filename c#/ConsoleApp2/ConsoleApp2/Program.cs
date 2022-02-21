using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int Addition = cal.Add(4, 5);
            int Subtraction = cal.Sub(4, 5);
            int Multiplication = cal.Multiply(4, 5);
            int Division = cal.Div(10, 2);

            Console.WriteLine("Adiition of two number is :"+ Addition);
            Console.WriteLine("Subtraction of two number is :"+ Subtraction);
            Console.WriteLine("Multiplication of two number is :"+ Multiplication);
            Console.WriteLine("Division of two number is :"+ Division);
        }
    }
}
