using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class ProductBuilder
    {

        public void MakePork()
        {
            Pork pork = new Pork();
            Console.WriteLine("Pork is created");            
        }

        public void MakeBeef()
        {
            Beef beef = new Beef();
            Console.WriteLine("Beef is created");
        }

        public void MakePoult()
        {
            Poult poult = new Poult();
            Console.WriteLine("Poult is created");
        }
    }
}
