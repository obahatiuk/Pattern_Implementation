using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class PrototypeClient : IPrototype<Prototype>
    {
        public static void Report(Prototype p)
        {
            Console.WriteLine("Prototype " + p);
        }
    }
}
