using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    class InventoryManager
    {
        // method for displaying the rice list 
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
            //to find the total investment iterate the rice utility 
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
            //to find the total investment iterate the rice utility 
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
