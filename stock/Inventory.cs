using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace stock
{
    class Inventory
    {
        public static void ReadInput()
        {
            //creating object for inventory manager class
            InventoryManager manager = new InventoryManager();
            //setting the filepath of json
            String filePath = @"C:\Users\user\source\repos\stock\stock\Inventory.json";
            //deserialization of json objects
            InventoryUtility InventoryUtility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(filePath));
            Console.WriteLine("Display\n1. Rice\n2. Wheat\n3.Pulse");

            //getting choise from user 
            int choice = Convert.ToInt32(Console.ReadLine());
            
            //getting options for methods to call
            switch(choice)
            {
                case 1:
                    manager.DisplayInventory(InventoryUtility.riceList);
                    break;

                case 2:
                    manager.DisplayInventory(InventoryUtility.wheatList);
                    break;

                case 3:
                    manager.DisplayInventory(InventoryUtility.pulseList);
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }
    }
    
}
