using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILLARSOFOOP
{
    // abstraction - making a generic class that can be inherited by children classes by lending functionality
    internal abstract class Vehicle
    {
        //when we use abstract on a property we are declaring
        //the getters and setters abstract. NOT the property itsself.
        public abstract int Speed { get; set; }
        public abstract int TopSpeed { get; set; }
        public abstract decimal Cost { get; set; }
        // because we used the abstract keyword, we were able to leave the implementation of these methods out
        public abstract string ToStringRepresentation();
        public abstract void ChangeCost(decimal cost);

        //but since we are in a class we can implement methods if we'd like
        
        public static void Travel(int Distance)
        {
            Console.WriteLine($"You Travelled {Distance} Miles!");
        }


    }
}
