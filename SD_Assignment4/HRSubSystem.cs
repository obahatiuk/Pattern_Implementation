using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class HRSubSystem
    {
        static Farm farm = Farm.Instance();
        public HireEmployee hireEmployee = new HireEmployee();
        public PromoteEmployee promoteEmployee = new PromoteEmployee();
        public FireEmployee fireEmployee = new FireEmployee();
        private FarmWorker farmWorker = new FarmWorker();

        private Worker worker;
        
        public Worker Worker {
            get
            {
                return worker;
            }
            set { worker = value; }
        }

        public Worker CreateNewWorker()
        {
            Worker worker = new Worker();
            farm.Workers.Add(worker);
            return worker;
        }

        public void HireEmployee(Worker worker)
        {
            hireEmployee.HRProcess(worker);
        }

        public void FireEmployee(Worker worker)
        {
            fireEmployee.HRProcess(worker);
        }

        public void PromoteEmployee(Worker worker)
        {
            promoteEmployee.HRProcess(worker);
        }
    }
}
