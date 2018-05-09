using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    [Serializable()]
    class Prototype : IPrototype<Prototype>
    {
        public int AnimalId { get; set; }
        public string AnimalType { get; set; }
        public string BreedName { get; set; }
        public string Gender { get; set; }
        public string PurposeOfBreeding { get; set; }
        public string Food { get; set; }
        public double AmountOfFood { get; set; }

        public Prototype(int animalId, string animalType, string breedName, string gender, string purposeOfBreeding, string food, double amountOfFood)
        {
            AnimalId = animalId;
            AnimalType = animalType;
            BreedName = breedName;
            Gender = gender;
            PurposeOfBreeding = purposeOfBreeding;
            Food = food;
            AmountOfFood = amountOfFood;
        }

        public override string ToString()
        {
            return AnimalId + "\t\t" + AnimalType + "\t\t" + BreedName + "\t\t" + Gender + "\t\t" + PurposeOfBreeding + "\t\t" + Food + "\t\t" + AmountOfFood;
        }
    }
}
