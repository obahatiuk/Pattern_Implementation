using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public abstract class FarmAnimal //: ICloneable
    {
        private int animalId;
        private string breedName;
        private string gender;
        private string purposeOfBreeding;
        private string food;
        private double amountOfFood;
        
        public int AnimalId { get => animalId; set => animalId = value; }
        public string BreedName { get => breedName; set => breedName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PurposeOfBreeding { get => purposeOfBreeding; set => purposeOfBreeding = value; }
        public string Food { get => food; set => food = value; }
        public double AmountOfFood { get => amountOfFood; set => amountOfFood = value; }

        public FarmAnimal(int animalId, string breedName, string gender, string purposeOfBreeding, string food, double amountOfFood)
        {
            this.animalId = animalId;
            this.breedName = breedName;
            this.gender = gender;
            this.purposeOfBreeding = purposeOfBreeding;
            this.food = food;
            this.amountOfFood = amountOfFood;
        }

        public FarmAnimal() { }
        
        public void ConsumeFood(string food, string time)
        {
            Console.WriteLine(this.animalId + " consumed " + food + " at " + time);
        }

        public virtual FarmAnimal CloneImplementation()
        {
            var copy = (FarmAnimal)MemberwiseClone();

            return copy;
        }

        //public object Clone()
        //{
        //    return (FarmAnimal)this.MemberwiseClone();
        //}
    }
}
