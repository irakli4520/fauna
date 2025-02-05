using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Human : Creature
    {
        public Human(string name)
        {
            Console.WriteLine($"Hello, {name}");
            Name = name;
            Think();
        }

        protected void Think()
        {
            Console.WriteLine($"{Name} is thinking about something");
        }
    }
}