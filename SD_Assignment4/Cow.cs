using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class Cow : FarmAnimal, IComponent, IAnimalType
    {
        private string food;

        public new string Food
        {
            get { return "Grass"; }

        }

        private double amountOfFood;

        public new double AmountOfFood
        {
            get { return 20.1; }

        }

        public Cow(int animalId, string BreedName, string gender, string purposeOfBreeding, string food = "Grass", double amountOfFood = 20.1) : base(animalId, BreedName, gender, purposeOfBreeding, food, amountOfFood)
        {
        }

        public Cow() { }

        public void Add(FarmAnimal animal)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public void Remove(FarmAnimal animal)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.BreedName);
        }

        public void ChoseAnimalType()
        {
            Console.WriteLine("The method declares cow type of an animal");
        }
    }
}
