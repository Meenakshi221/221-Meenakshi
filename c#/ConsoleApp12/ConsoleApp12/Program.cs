using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData t = new TestData();
            int t1=t.Add(5,4,6);
            Console.WriteLine(t1);
            int t2=t.Add(5, 4);
            Console.WriteLine(t2);
        }
    }
}
