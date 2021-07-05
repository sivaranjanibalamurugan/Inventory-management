using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    class InventoryManager
    {
        // method for adding item for inventory 
        public List<InventoryUtility.Rice> AddToInventory(List<InventoryUtility.Rice> riceList)
        {
            //create the new object for rice class 
            InventoryUtility.Rice rice = new InventoryUtility.Rice();
            Console.WriteLine("Enter the name of rice:");
            rice.Name = Console.ReadLine();
            Console.WriteLine("Enter the weight of rice in kg:");
            rice.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of the rice:");
            rice.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of rice:");
            rice.type = Console.ReadLine();
            //add the updated object to the list
            riceList.Add(rice);
            return riceList;
        }
        public List<InventoryUtility.Wheat> AddToInventory(List<InventoryUtility.Wheat> wheatList)
        {
            //create the new object for  class 
            InventoryUtility.Wheat wheat = new InventoryUtility.Wheat();
            Console.WriteLine("Enter the name of wheat:");
            wheat.Name = Console.ReadLine();
            Console.WriteLine("Enter the weight of wheat in kg:");
            wheat.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of the wheat:");
            wheat.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of wheat:");
            wheat.type = Console.ReadLine();
            //append the updated object to the list
            wheatList.Add(wheat);
            return wheatList;
        }
        public List<InventoryUtility.Pulse> AddToInventory(List<InventoryUtility.Pulse> pulseList)
        {
            //create the new object for rice class 
            InventoryUtility.Pulse pulse = new InventoryUtility.Pulse();
            Console.WriteLine("Enter the name of pulse:");
            pulse.Name = Console.ReadLine();
            Console.WriteLine("Enter the weight of pulse in kg:");
            pulse.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of the pulse:");
            pulse.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of pulse:");
            pulse.type = Console.ReadLine();
            //append the updated object to the list
            pulseList.Add(pulse);
            return pulseList;
        }
        //method to update the rice inventory
        public List<InventoryUtility.Rice> UpdateInventory(List<InventoryUtility.Rice> riceList)
        {
            Console.WriteLine("Enter the name of rice to be updated:");
            string Name = Console.ReadLine();
            riceList.Remove(riceList.Find(utl => utl.Name.Equals(Name)));
            return (riceList);
        }
        //method to update the Wheat inventory
        public List<InventoryUtility.Wheat> UpdateInventory(List<InventoryUtility.Wheat> wheatList)
        {
            Console.WriteLine("Enter the name of wheat to be updated:");
            string Name = Console.ReadLine();
            wheatList.Remove(wheatList.Find(utl => utl.Name.Equals(Name)));
            return (wheatList);
        }

        //method to update the pulse inventory
        public List<InventoryUtility.Pulse> UpdateInventory(List<InventoryUtility.Pulse> pulseList)
        {
            Console.WriteLine("Enter the name of pulse to be updated:");
            string Name = Console.ReadLine();
            pulseList.Remove(pulseList.Find(utl => utl.Name.Equals(Name)));
            return (pulseList);
        }
        //method to delete the rice inventory
        public List<InventoryUtility.Rice> RemoveInventory(List<InventoryUtility.Rice> riceList)
        {
            Console.WriteLine("Enter the name of rice to be Removed:");
            string Name = Console.ReadLine();
            riceList.Remove(riceList.Find(utl => utl.Name.Equals(Name)));
            return (riceList);
        }
        //method to delete the wheat inventory
        public List<InventoryUtility.Wheat> RemoveInventory(List<InventoryUtility.Wheat> wheatList)
        {
            Console.WriteLine("Enter the name of wheat to be Removed:");
            string Name = Console.ReadLine();
            wheatList.Remove(wheatList.Find(utl => utl.Name.Equals(Name)));
            return (wheatList);
        }
        //method to delete the Pulse inventory
        public List<InventoryUtility.Pulse> RemoveInventory(List<InventoryUtility.Pulse> pulseList)
        {
            Console.WriteLine("Enter the name of Pulse to be Removed:");
            string Name = Console.ReadLine();
            pulseList.Remove(pulseList.Find(utl => utl.Name.Equals(Name)));
            return (pulseList);
        }
        public void DisplayInventory(List<InventoryUtility.Rice> rice)
        {
            string item = string.Empty;
            int totalinvestment = 0;
            //to find the total investment iterate the rice utility 
            foreach (InventoryUtility.Rice i in rice)
            {
                item = "name:" + i.Name + "\nWeight:" + i.weight + "\nPrice:" + i.price + "\nType:" + i.type;
                Console.WriteLine(item);
                totalinvestment = totalinvestment + Calculatetotalinverstment(i.weight, i.price);
            }
            Console.WriteLine("total investment of Rice is:" + totalinvestment);
        }

        // method for displaying the Wheat list 
        public void DisplayInventory(List<InventoryUtility.Wheat> wheat)
        {
            string item = string.Empty;
            int totalinvestment = 0;
            //to find the total investment iterate the wheat utility 
            foreach (InventoryUtility.Wheat i in wheat)
            {
                item = "name:" + i.Name + "\nWeight:" + i.weight + "\nPrice:" + i.price + "\nType:" + i.type;
                Console.WriteLine(item);
                totalinvestment = totalinvestment + Calculatetotalinverstment(i.weight, i.price);
            }
            Console.WriteLine("total investment of  Wheat is:" + totalinvestment);
        }
       

        // method for displaying the pulse list 
        public void DisplayInventory(List<InventoryUtility.Pulse> pulse)
        {
            string item = string.Empty;
            int totalinvestment = 0;
            //to find the total investment iterate the pulse utility 
            foreach (InventoryUtility.Pulse i in pulse)
            {
                item = "name:" + i.Name + "\nWeight:" + i.weight + "\nPrice:" + i.price + "\nType:" + i.type;
                Console.WriteLine(item);
                totalinvestment = totalinvestment + Calculatetotalinverstment(i.weight, i.price);
            }
            Console.WriteLine("total investment of Pulse is:" + totalinvestment);
        }

        //creating method for calculating the totalinvestment
        public int Calculatetotalinverstment(int weight , int price)
        {
            return (weight * price);
        }
    }
}
