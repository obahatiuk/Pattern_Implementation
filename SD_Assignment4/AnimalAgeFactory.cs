using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class AnimalAgeFactory : AbstractFactory
    {
        public override IAgeOfAnimal getAge(string age)
        {
            if (age == null)
            {
                return null;
            }

            if (age.ToLower() == "adult")
            {
                return new AdultAnimal();
            }
            else if (age.ToLower() == "baby")
            {
                return new BabyAnimal();
            }
            else
            {
                return null;
            }
        }

        public override IAnimalType getAnimalType(string type)
        {
            return null;
        }
    }
}
