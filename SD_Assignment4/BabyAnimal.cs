using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class BabyAnimal : IAgeOfAnimal
    {
        public void declareAge()
        {
            Console.WriteLine("The method declares baby animal");
        }
    }
}
