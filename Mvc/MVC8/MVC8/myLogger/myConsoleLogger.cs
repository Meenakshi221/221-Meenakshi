
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC8.myLogger
{
    public class myConsoleLogger : ILog 
    {
        public void info(string str)
        {
            Console.WriteLine(str);
        }
    }
}
