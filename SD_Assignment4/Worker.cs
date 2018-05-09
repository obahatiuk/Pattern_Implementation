using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class Worker 
    {
        private int workersId;
        private string workerName;
        private List<string> duties;

        public int WorkersId { get => workersId; set => workersId = value; }
        public string WorkerName { get => workerName; set => workerName = value; }
        public List<string> Duties { get => duties; set => duties = value; }

        public Worker(int workersId, string workerName, List<string> duties)
        {
            this.workersId = workersId;
            this.workerName = workerName;
            this.duties = duties;
        }

        public Worker() { }

        public void FeedCow(Cow cow, string time)
        {
            Console.WriteLine("Worker " + this.workerName + " fed " + cow.AnimalId + " with " + cow.AmountOfFood + " of "  + cow.Food + " at " + time);
        }

        public void FeedPig(Pig pig, string time)
        {
            Console.WriteLine("Worker " + this.workerName + " fed " + pig.AnimalId + " with " + pig.AmountOfFood + " of " + pig.Food + " at " + time);
        }

        public void FeedChicken(Chicken chicken, string time)
        {
            Console.WriteLine("Worker " + this.workerName + " fed " + chicken.AnimalId + " with " + chicken.AmountOfFood + " of " + chicken.Food + " at " + time);
        }
    }
}
