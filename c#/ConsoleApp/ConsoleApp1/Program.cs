using System;

namespace ConsoleApp1
{
   public class Program
    {
        static void Main()
        {
            Mobile prod = new IProduct(); 
            string name = prod.GetName();
            string price = prod.GetAmount();
            Console.WriteLine(name + " is located at " + price);
        }
    }
}
