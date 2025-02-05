using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Eagle : Bird
    {
        public Eagle(string name)
        {
            Console.WriteLine($"Eagle {name} was created");
            Name = name;
        }
    }
}