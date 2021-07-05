using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

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
            Console.WriteLine("\n 1)Display \n 2)Add Invnetory \n 3)Update Inventory \n 4)Delete Inventory");
            Console.WriteLine("enter your choice:");
            int choice= Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("enter the Inventory:");

            //getting choise from user 
            Console.WriteLine("\n 1) rice \n 2) Wheat \n 3)Pulse");
            int Inventory = Convert.ToInt32(Console.ReadLine());
            
            //getting options for methods to call
            switch(choice)
            {
                case 1:
                    //FOR DISPLAY
                    switch (Inventory)
                    {
                        case 1:
                            Console.WriteLine("DISPLAYING RICE INVENTORY");
                            manager.DisplayInventory(InventoryUtility.riceList);
                            break;
                        case 2:
                            Console.WriteLine("DISPLAYING WHEAT INVENTORY");
                            manager.DisplayInventory(InventoryUtility.riceList);
                            break;
                            

                        case 3:
                            Console.WriteLine("DISPLAYING PULSE INVENTORY");
                            manager.DisplayInventory(InventoryUtility.riceList);
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                    break;

                case 2:
                    // FOR ADDING 
                    switch(Inventory)
                    {
                        case 1:
                            Console.WriteLine("ADDING THE RICE INVENTORY");
                            InventoryUtility.riceList = manager.AddToInventory(InventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(InventoryUtility));
                            break;

                        case 2:
                            Console.WriteLine("ADDING THE WHEAT INVENTORY");
                            InventoryUtility.riceList = manager.AddToInventory(InventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(InventoryUtility));
                            break;

                        case 3:
                            Console.WriteLine("ADDING THE PULSE INVENTORY");
                            InventoryUtility.riceList = manager.AddToInventory(InventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(InventoryUtility));
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;

                    }
                    Console.WriteLine("Inventory is updated");
                    break;
                case 3:
                    //for updating 
                   switch(Inventory)
                    {
                        case 1:
                            InventoryUtility.riceList = manager.UpdateInventory(InventoryUtility.riceList);
                            InventoryUtility.riceList = manager.AddToInventory(InventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(InventoryUtility));
                            break;

                        case 2:
                            InventoryUtility.wheatList = manager.UpdateInventory(InventoryUtility.wheatList);
                            InventoryUtility.wheatList = manager.AddToInventory(InventoryUtility.wheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(InventoryUtility));
                            break;

                        case 3:
                            InventoryUtility.pulseList = manager.UpdateInventory(InventoryUtility.pulseList );
                            InventoryUtility.pulseList = manager.AddToInventory(InventoryUtility.pulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(InventoryUtility));
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                    Console.WriteLine("Inventory Updated");
                    break;

                case 4:
                    //for deleting
                    switch(Inventory)
                    {
                        case 1:
                            manager.RemoveInventory(InventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(InventoryUtility));
                            break;

                        case 2:
                            manager.RemoveInventory(InventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(InventoryUtility));
                            break;

                        case 3:
                            manager.RemoveInventory(InventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(InventoryUtility));
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;

                    }
                    Console.WriteLine("The Inventory is deleted");
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;

            }
        }
    }
    
}
