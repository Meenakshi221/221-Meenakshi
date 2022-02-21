using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class AccountClass
    {
        public AccountClass()
        {
            Console.WriteLine("Account Constructor");
        }
        public void Name()
        {
            Console.WriteLine("Savings");
        }
        public void Number()
        {
            Console.WriteLine("7689");
        }
        public virtual void Ifsc()
        {
            Console.WriteLine("indi75");
        }
    }
    class CustomerClass : AccountClass
    {
        public CustomerClass()
        {
            Console.WriteLine("customer Thoushif");
        }
        public override void Ifsc()
        {
            Console.WriteLine("92564");
        }
    }
}
