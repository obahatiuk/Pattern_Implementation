using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class FarmPigs : Pig
    {
        public List<Pig> pigs = new List<Pig>();
        private string name;

        public string Name { get => "FarmPigs"; }

        public FarmPigs() //: base()
        {
            this.name = Name;
        }

        public void Add(Pig pig)
        {
            pigs.Add(pig);
        }

        public void Remove(Pig pig)
        {
            pigs.Add(pig);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.Name);

            foreach (Pig pig in pigs)
            {
                pig.Display(depth + 2);
            }
        }

        public int Count()
        {
            return pigs.Count();
        }
    }
}
