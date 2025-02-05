using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Spider : Insect
    {
        public Spider()
        {
            Console.WriteLine("Spider was created");
            Web();
        }

        protected void Web()
        {
            Console.WriteLine("Spider crated web");
        }
    }
}