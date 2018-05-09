using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class Farm : BusinessUnit
    {
        private List<Customer> customers;
        private List<Supplier> suppliers;
        private List<Supplies> supplies;

        private FarmChicken chicken;
        private FarmCows cows;
        private FarmPigs pigs;
        private ArrayList animals;

        private static Farm _instance;
        internal List<Customer> Customers { get => customers; set => customers = value; }
        internal List<Supplier> Suppliers { get => suppliers; set => suppliers = value; }
        internal List<Supplies> Supplies { get => supplies; set => supplies = value; }
        internal List<Worker> Workers = new List<Worker>();
        internal FarmChicken Chicken { get => chicken; set => chicken = value; }
        internal FarmCows Cows { get => cows; set => cows = value; }
        internal FarmPigs Pigs { get => pigs; set => pigs = value; }
        public ArrayList Animals {
            get {
                animals = new ArrayList();
                animals.Add(Chicken);
                animals.Add(Cows);
                animals.Add(Pigs);
                return animals;
            }
        }

        protected Farm(int unitId, string name, string address, List<Customer> customers, List<Supplier> suppliers, List<Supplies> supplies,
            FarmChicken chicken, FarmCows cows, FarmPigs pigs) : base(unitId, name, address)
        {

            this.customers = customers;
            this.suppliers = suppliers;
            this.supplies = supplies;
            this.chicken = chicken;
            this.cows = cows;
            this.pigs = pigs;
 
        }
        protected Farm() { }

        public static Farm Instance()
        {
            if (_instance == null)
            {
                _instance = new Farm();
            }
            return _instance;
        }


    }
}
