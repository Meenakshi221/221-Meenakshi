using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Increment(ref int i)
        {
            i = 1 + i;
        }
        static void Main()
        {
            int x = 1;
            Increment(ref x);
            Console.WriteLine("The value of x is :" + x);
            Console.Read();
        }

    }
}
