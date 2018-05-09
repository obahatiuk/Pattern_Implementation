using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    internal class FarmChicken : Chicken
    {
        public List<Chicken> chickens = new List<Chicken>();
        private string name;

        public string Name { get => "FarmChicken"; }

        public FarmChicken()
        {
            this.name = Name;
        }

        public void Add(Chicken chicken)
        {
            chickens.Add(chicken);
        }

        public void Remove(Chicken chicken)
        {
            chickens.Remove(chicken);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.Name);

            foreach (Chicken chicken in chickens)
            {
                chicken.Display(depth + 2);
            }
        }
    }
}
