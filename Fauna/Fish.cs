using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Fish : Creature
    {
        public Fish(string name)
        {
            Console.WriteLine($"Fish {name} was created");
            Name = name;
        }

        public void AboutFish()
        {
            Console.WriteLine("Fish lives in water");
        }
    }
}