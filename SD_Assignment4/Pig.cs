using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class Pig : FarmAnimal, IComponent, IAnimalType
    {
        private string food;

        public new string Food
        {
            get { return "Plants"; }

        }

        private double amountOfFood;

        public new double AmountOfFood
        {
            get { return 11.5; }

        }

        public Pig(int animalId, string BreedName, string gender, string purposeOfBreeding, string food = "Plants", double amountOfFood = 11.5) : base(animalId, BreedName, gender, purposeOfBreeding, food, amountOfFood)
        {
        }

        public Pig() { }

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
            Console.WriteLine(new String('-', depth) + this.AnimalId);
        }

        public void ChoseAnimalType()
        {
            Console.WriteLine("The method declares pig type of an animal");
        }
    }
}
