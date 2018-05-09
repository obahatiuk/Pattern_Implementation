using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class AnimalTypeFactory : AbstractFactory
    {
        public override IAgeOfAnimal getAge(string age)
        {
            return null;
        }

        public override IAnimalType getAnimalType(string type)
        {
            if (type == null)
            {
                return null;
            }

            if (type.ToLower() == "pig")
            {
                return new Pig();
            }
            else if (type.ToLower() == "cow")
            {
                return new Cow();
            }else if (type.ToLower() == "chicken")
            {
                return new Chicken();
            } else
            {
                return null;
            }
        }
    }
}
