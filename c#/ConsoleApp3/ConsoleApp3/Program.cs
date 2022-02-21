using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Increment(int i)
        {
            i = 1 + i;
        }
        static void Main()
        {
            int x = 1;
            Increment(x);
            Console.WriteLine("The value of x is :"+ x);
            Console.Read();
        }
       
    }
}
