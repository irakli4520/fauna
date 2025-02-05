using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Car : Vehicle
    {
        public Car() : base("Car")
        {
            Console.WriteLine("Car drives");
        }

        public void StopTheCar()
        {
            Console.WriteLine("Car was stopped");
        }
    }
}