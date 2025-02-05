using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Fauna
{
    public class Chicken : Bird
    {
        public Chicken()
        {
            Console.WriteLine("Chicken was created");
            HatchEggs();
        }

        protected void HatchEggs()
        {
            Console.WriteLine("The mother begins to hatch eggs immediately.");
        }
    }
}