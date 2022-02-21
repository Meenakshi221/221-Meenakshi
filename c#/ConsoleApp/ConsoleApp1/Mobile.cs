using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class Mobile : IProduct
    {
        public string GetName()
        {
            return "iphone 6";
        }

        public string GetAmount()
        {
            return "Ten Thousand";
        }
       
    }
}
