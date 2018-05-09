using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class FireEmployee : Strategy
    {
        public void HRProcess(Worker worker)
        {
            Farm.Instance().Workers.Remove(worker);
            Console.WriteLine("Worker Id " + worker.WorkersId + " was fired");
        }
    }
}
