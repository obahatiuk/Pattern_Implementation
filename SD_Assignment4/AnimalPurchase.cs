using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class AnimalPurchase
    {
        public static AbstractFactory buyNewAnimalOnTheFair(String choice)
        {
            if (choice.ToLower() == "age")
            {
                return new AnimalAgeFactory();
            }
            else if (choice.ToLower() == "type")
            {
                return new AnimalTypeFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
