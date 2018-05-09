using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public static class Facade
    {
        public static FarmingSubSystem farmingSubSystem = new FarmingSubSystem();
        public static OfficeSubSystem officeSubSystem = new OfficeSubSystem();
        public static HRSubSystem hrSubSystem = new HRSubSystem();
        
        public static void HireEmployee(Worker worker)
        {
            hrSubSystem.HireEmployee(worker);
        }

        public static void FireEmployee(Worker worker)
        {
            hrSubSystem.FireEmployee(worker);
        }

        public static void PromoteEmployee(Worker worker)
        {
            hrSubSystem.PromoteEmployee(worker);
        }
    }
}
