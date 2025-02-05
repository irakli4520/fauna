using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Bird : Creature
    {
        public Bird()
        {
            Console.WriteLine("Bird was created");
            BirdFlies();
        }

        protected void BirdFlies()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}