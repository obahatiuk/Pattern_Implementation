using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class HireEmployee : Strategy
    {
        public void HRProcess(Worker worker)
        {
            worker.WorkersId = Farm.Instance().Workers.Count();
            Farm.Instance().Workers.Add(worker);
            Console.WriteLine("Worker Id " + worker.WorkersId + " was hired");
        }
    }
}
