using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    abstract class AbstractFactory
    {
        public abstract IAgeOfAnimal getAge(String age);
        public abstract IAnimalType getAnimalType(String type);
    }
}
