using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Alien : Creature
    {
        public Alien()
        {
            Console.WriteLine("Alien was created");
        }

        public void Photo()
        {
            Console.WriteLine("No photos");
            Console.WriteLine("test");
        }
    }
}