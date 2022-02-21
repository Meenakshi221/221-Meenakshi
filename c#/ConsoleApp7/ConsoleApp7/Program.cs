using System;

namespace ConsoleApp7
{
   public class Program
    {
        static void Main(string[] args)
        {
            Mobile mb = new Mobile();
            string name = mb.GetName();
            string price = mb.GetPrice();
            Console.WriteLine(name + " price is " + price);
        }
    }
}
