using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    interface IBike
    {
        void BikeModel(); // interface method (does not have a body)
    }

    // RE "implements" the I interface
    class RE : IBike
    {
        public void BikeModel()
        {
            // The body of BikeModel() is provided here
            Console.WriteLine("The Bike Model: Royal Enfield Classic");
        }
    }
}
