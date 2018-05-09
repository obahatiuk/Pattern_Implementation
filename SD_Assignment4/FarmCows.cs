using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class FarmCows : Cow
    {
        public List<Cow> cows = new List<Cow>();
        private string name;

        public string Name { get => "FarmCows"; }

        public FarmCows() //: base()
        {
            this.name = Name;
        }

        public void Add(Cow cow)
        {
            cows.Add(cow);
        }

        public void Remove(Cow cow)
        {
            cows.Remove(cow);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.Name);

            foreach (Cow cow in cows)
            {
                cow.Display(depth + 2);
            }
        }
    }
}
