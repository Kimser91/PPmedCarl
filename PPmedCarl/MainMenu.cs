using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedCarl
{
    internal class MainMenu
    {
        public MainMenu()
        {
            Menu();
        }

        public void Menu() 
        {
            var storeOwerview = new StoreOverview();
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Main Menu:\n");
                Console.ResetColor();

                Console.WriteLine("1. Show Store List");
                Console.WriteLine("2. Add new store");
                Console.WriteLine("3. Find Stores");

                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        storeOwerview.StoreStoreOverwiew();
                        break;
                    case "2":
                        storeOwerview.AddStore();
                        break;
                    case "3":
                        storeOwerview.FindStores();
                        break;
                }
            }
        }
    }
}
