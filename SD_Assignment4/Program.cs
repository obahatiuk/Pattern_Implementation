using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = Farm.Instance();

            GrassOrderCreator grassOrder = new GrassOrderCreator();
            SupplyOrder supplierA = grassOrder.FactoryMethod(2);
            Console.WriteLine(supplierA.SentTo.Name);
            SupplyOrder supplierB = grassOrder.FactoryMethod(6);
            Console.WriteLine(supplierB.SentTo.Name);

            Cow cow = new Cow(1, "Shorthorn", "female", "Milk");
            FarmCows farmCows = new FarmCows();
            farmCows.Add(cow);
            farmCows.Display(1);
            Console.ReadKey();

            //PrototypeManager prototypeManager = new PrototypeManager();
            //prototypeManager[1] = new Prototype(cow.AnimalId, cow.GetType().ToString(), cow.BreedName, cow.Gender, cow.PurposeOfBreeding, cow.Food, cow.AmountOfFood);
            //PrototypeClient.Report(prototypeManager[1]);
            //Console.ReadKey();

            //FarmWorker adapterTarget = new FarmWorker();
            //adapterTarget.Feed(chicken, "10AM");

            ////CustomerOrderBuillder customerOrderBuillder = new CustomerOrderBuillder();
            ////CustomerOrder customerOrder = new CustomerOrder();
            ////customerOrder.Goods = new List<Item> { new Item("Pork", 11.0F, 1) };
            ////customerOrderBuillder.ExecuteOrder(customerOrder);
            ////farmChicken.Display(1);
            ////Console.ReadKey();


            //PrototypeManager prototypeManager = new PrototypeManager();
            //prototypeManager[chicken.AnimalId] = new Prototype(chicken.AnimalId, chicken.GetType().ToString(), chicken.BreedName, chicken.Gender, chicken.PurposeOfBreeding, chicken.Food, chicken.AmountOfFood).DeepCopy();
            //PrototypeClient.Report(prototypeManager[chicken.AnimalId]);
            //Console.ReadKey();


            //AbstractFactory abstractFactory = AnimalPurchase.buyNewAnimalOnTheFair("Age");
            //abstractFactory.getAge("Baby").declareAge();
            //Console.ReadKey();
            //abstractFactory = AnimalPurchase.buyNewAnimalOnTheFair("type");
            //abstractFactory.getAnimalType("Cow").ChoseAnimalType();
            //Console.ReadKey();

            //BusinessUnit customer = new BusinessUnit();
            //Pork customerOrder = new Pork();
            //CustomerOrder order = new CustomerOrder(1, "4/29/2018", customer, farm, new List<Item> { customerOrder }, 100, false, false, null);
            //CustomerPayment customerPayment = new CustomerPayment(1, order, false);
            //order.CustomerPayment = customerPayment;
            //Console.WriteLine(order.IsPaid.ToString());
            //Console.ReadKey();
            //customerPayment.Attach(order);
            //customerPayment.IsPaid = true;
            //customerPayment.Notify();
            //Console.WriteLine(customerPayment.IsPaid);
            //Console.WriteLine(order.IsPaid);
            //Console.ReadKey();

            //Context context;
            //Worker worker = new Worker();
            //context = new Context(new HireEmployee());
            //context.ContextInterface(worker);
            //Console.ReadKey();
            //context = new Context(new PromoteEmployee());
            //context.ContextInterface(worker);
            //Console.ReadKey();
            //context = new Context(new FireEmployee());
            //context.ContextInterface(worker);
            //Console.ReadKey();

            //Facade.hrSubSystem.Worker = Facade.hrSubSystem.CreateNewWorker();
            //Facade.hrSubSystem.Worker.WorkerName = "John";
            //foreach (Worker w in farm.Workers)
            //{
            //    Console.WriteLine(w.WorkerName);
            //}
            //Console.ReadKey();

        }
    }
}
