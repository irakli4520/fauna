using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Vehicle
    {
        public string Name { get; set; }
        public Vehicle(string nameOfVehicle)
        {
            Console.WriteLine($"Vehicle: {nameOfVehicle} is moving");
        }
    }
}