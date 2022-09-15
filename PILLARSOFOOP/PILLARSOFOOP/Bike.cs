using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILLARSOFOOP
{
    internal class Bike : Vehicle
    {
        //properties
        public string Brand { get; set; }
        public override int Speed { get; set; }
        public override int TopSpeed { get; set; }
        public  override decimal Cost { get; set; }

        //Constructor 
        public Bike()
        {
            Brand = "Schwinn";
            Speed = 0;
            TopSpeed = 50;
            Cost = 300;
        }

        //Methods
        public override void ChangeCost(decimal cost)
        {
            Cost = cost;
        }

        public override string ToStringRepresentation()
        {
            return $"Brand : {Brand} \nTop Speed : {TopSpeed} \nCost : {Cost}";
        }

        public static void RingBell()
        {
            Console.WriteLine("BRINGBRING!!");
            Console.Beep();
        }
    }
}
