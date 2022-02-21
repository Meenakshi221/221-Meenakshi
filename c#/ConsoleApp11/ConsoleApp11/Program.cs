using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            double currentBalance = obj.GetBalance();

            obj.balance = 200000000000;
        }
    }
}
