using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Plane : Vehicle
    {
        public Plane() : base ("Plane")
        {
            Console.WriteLine("Plane flies");
        }
    }
}