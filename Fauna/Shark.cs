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
        }
        
        protected void SharkBite()
        {
            Console.WriteLine("Shark bited you!");
        }
    }
}