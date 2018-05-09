using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    interface Component
    {
        void Add(FarmAnimal animal);
        void Remove(FarmAnimal animal);
        void Display(FarmAnimal animal);
    }
}
