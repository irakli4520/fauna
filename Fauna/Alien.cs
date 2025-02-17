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
            Coco();
        }

        public void Photo()
        {
            Console.WriteLine("No photos");
        }

        protected void Coco()
        {
            Console.WriteLine("test");
        }
    }
}