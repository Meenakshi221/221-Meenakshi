using System;
using System.Collections;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrli1 = new ArrayList();
            arrli1.Add(1);
            arrli1.Add(" Two ");
            arrli1.Add(3);
            arrli1.Add(4.5);

            int firstElement = (int)arrli1[0];
            string secondElement = (string)arrli1[1];
            int thirdElement = (int)arrli1[2];
            double fourthElement = (double)arrli1[3];

            Console.WriteLine(firstElement);
            Console.WriteLine(secondElement);
            Console.WriteLine(thirdElement);
            Console.WriteLine(fourthElement);
        }
    }
}
