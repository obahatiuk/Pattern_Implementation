using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    //internal delegate void FeedAnimal();

    class FarmWorker : Worker, ITarget
    {
        Worker worker = new Worker();

        public void Feed(FarmAnimal animal, string time)
        {
            string caseSwitch = animal.GetType().ToString();

            switch (caseSwitch)
            {
                case "SD_Assignment4.Cow":
                    Cow cow = (Cow)animal;
                    worker.FeedCow(cow, time);
                    break;
                case "SD_Assignment4.Pig":
                    Pig pig = (Pig)animal;
                    worker.FeedPig(pig, time);
                    break;
                case "SD_Assignment4.Chicken":
                    Chicken chicken = (Chicken)animal;
                    worker.FeedChicken(chicken, time);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
