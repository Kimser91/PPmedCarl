using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PPmedCarl
{
    internal class StoreOverview
    {
        List<Store> stores;
        public StoreOverview()
        {
            stores = new List<Store>()
            {
                new Store("Kapphal", "Clothes", 2),
                new Store("Cubus", "Clothes", 1),
                new Store("Name it", "Clothes", 3),
                new Store("Meny", "Food", 2),
                new Store("Jacobs utvalgte", "Food", 3),
                new Store("Rema 1000", "Food", 1),
                new Store("Ringo", "Toys", 2),
                new Store("Extra Leker", "Toys", 1),
                new Store("Yes vi leker", "Toys", 3)
            };


        }
        public void StoreStoreOverwiew()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Butikknavn:\n");
            Console.ResetColor();
            for (int i = 0; i < stores.Count; i++)
            {
                Console.WriteLine($"{i + 1}. " + stores[i].Name);
            }
            EnterStore();


        }

        public void AddStore()
        {
            Console.Write("Store Name: ");
            var storeName = Console.ReadLine();
            Console.Write("Store Type: ");
            var storeType = Console.ReadLine();
            Console.Write("Store Price class 1-3: ");
            int storePriceClass = int.Parse(Console.ReadLine());

            stores.Add(new Store(storeName, storeType, storePriceClass));
            StoreStoreOverwiew();
        }
        public void EnterStore()
        {
            Console.Write("\nWrite ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("X");
            Console.ResetColor();
            Console.Write(" to go back to Main menu or ");
            Console.Write("write list number of the store you want to enter: ");

            var userInput = Console.ReadLine();
            if (Int32.TryParse(userInput, out int index))
            {
                Console.Clear();
                index = index - 1;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Store: ");
                Console.ResetColor();
                Console.Write(stores[index].Name + "\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Type: ");
                Console.ResetColor();
                Console.Write(stores[index].Type + "\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Price Class: ");
                Console.ResetColor();
                Console.Write(stores[index].PriceClass + "\n");
                Console.ReadKey();
            }
            else if (userInput == "x".ToUpper())
            {

            }


        }

        public void FindStores()
        {
            Console.Clear();
            Console.Write("Desired Price Class (1-3): \n");
            var PC = int.Parse(Console.ReadLine());
            Console.Write("Type of store (Food, Clothes, Toys)");
            var Type = Console.ReadLine();
            if (PC != null)
            {
                var matchedStores = stores.Where(store => store.PriceClass == PC && store.Type == Type).ToList();
                int i = 1;
                foreach (var matchedStore in matchedStores)
                {

                    Console.WriteLine($"{i}. {matchedStore.Name}");
                }
                Console.WriteLine("Write X to go back to Main menu or ");
                Console.Write("write list number of the store you want to enter: ");

                var userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int index))
                {
                    Console.Clear();
                    index = index - 1;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Store: ");
                    Console.ResetColor();
                    Console.Write(matchedStores[index].Name + "\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Type: ");
                    Console.ResetColor();
                    Console.Write(matchedStores[index].Type + "\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Price Class: ");
                    Console.ResetColor();
                    Console.Write(matchedStores[index].PriceClass);
                    Console.ReadKey();
                }
            }
        }

    }
}
