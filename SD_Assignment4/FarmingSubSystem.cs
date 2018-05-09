using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class FarmingSubSystem
    {
        private Chicken chicken;
        private Pig pig;
        private Cow cow;

        static Farm farm = Farm.Instance();

        public Chicken Chicken
        {
            get
            {
                farm.Chicken.Add(chicken);
                return chicken;
            }
            set { chicken = value; }
        }
        public Cow Cow
        {
            get
            {
                farm.Cows.Add(cow);
                return cow;
            }
            set { cow = value; }
        }
        public Pig Pig
        {
            get
            {
                farm.Pigs.Add(pig);
                return pig;
            }
            set { pig = value; }
        }

        public Chicken CreateChicken()
        {
            Chicken chicken = new Chicken();
            farm.Chicken.Add(chicken);
            return chicken;
        }
        public Pig CreatePig()
        {
            Pig pig = new Pig();
            farm.Pigs.Add(pig);
            return pig;
        }
        public Cow CreateCow()
        {
            Cow cow = new Cow();
            farm.Cows.Add(cow);
            return cow;
        }
    }
}
