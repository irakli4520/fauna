using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Bee : Insect
    {
        public Bee()
        {
            Console.WriteLine("Bee was created");
        }
        
        public void Honey()
        {
            Console.WriteLine("Bee giving honey");
        }
    }
}