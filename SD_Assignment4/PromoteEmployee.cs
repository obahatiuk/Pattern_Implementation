using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class PromoteEmployee : Strategy
    {
        public void HRProcess(Worker worker)
        {
            Console.WriteLine("Worker Id " + worker.WorkersId + " get promotion");
        }
    }
}
