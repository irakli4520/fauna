using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Shark : Fish
    {
        public Shark(string name) : base(name)
        {
            Console.WriteLine("Shark was created");
            SharkBite();
            Name = name;
        }
        
        protected void SharkBite()
        {
            Console.WriteLine("Shard bited you!");
        }
    }
}