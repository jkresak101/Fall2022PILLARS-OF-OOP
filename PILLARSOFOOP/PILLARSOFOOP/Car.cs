using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILLARSOFOOP
{
    internal class Car : Vehicle
    {
        //properties
        public string Make { get; set; }
        public string Model { get; set; }
        public override int Speed { get; set; }
        public override int TopSpeed { get; set; }
        public override decimal Cost { get; set; }

        //Constructor
        public Car()
        {
            Make = "Chrysler";
            Model = "PT Cruiser";
            Speed = 0;
            TopSpeed = 150;
            Cost = -1500;
        }


        //Methods
        public void ChangeMake(string make)
        {
            Make = make;
        }

        public override void ChangeCost(decimal cost)
        {
            Cost = cost;
        }

        public override string ToStringRepresentation()
        {
            //alternative to string concatenation is string literals
            return $"Make: {Make} \nModel: {Model} \nTop Speed: {TopSpeed}";
        }
        public static void HonkHorn()
        {
            Console.WriteLine("HOOOOOONK!!!");
            Console.Beep();
        }
    }
}
