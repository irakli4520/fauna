using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Insect : Creature
    {
        public Insect()
        {
            Console.WriteLine("Insect was created");
            SizeOfInsect();
        }

        protected void SizeOfInsect()
        {
            Console.WriteLine("Insect is small");
        }
        
    }
}