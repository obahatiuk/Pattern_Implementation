using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public interface IComponent
    {
        void Add(FarmAnimal animal);
        void Remove(FarmAnimal animal);
        void Display(int depth);
    }
}
