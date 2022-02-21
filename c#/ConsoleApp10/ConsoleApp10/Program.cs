using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountClass acc = new CustomerClass();
            acc.Name();
            acc.Number();
            acc.Ifsc();
        }
    }
}
