using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    class InventoryUtility
    {
        //creating list for rice inventory 
        public List<Rice> riceList { get;  set; }

        //creating list for wheat inventory 
        public List<Wheat> wheatList { get; set; }

        //creating List for pulse inventory
        public List<Pulse> pulseList { get; set; }
         
        //creating methods in class for name , weight , price and type 
        public class Rice
        {
            //creating the name method
            public String Name { get; set; }
            
            //creating the weight method
            public int weight { get; set; }

            //creating the price method
            public int price { get; set; }

            //creating the type method
            public String type { get; set; }
        }


        //creting methods in class wheat for name , weight , type and price
        public class Wheat
        {
            //creating the name method
            public String Name { get; set; }

            //creating the weight method
            public int weight { get; set; }

            //creating the price method
            public int price { get; set; }

            //creating the type method
            public String type { get; set; }
        }

        //creting methods in class wheat for name , weight , type and price
        public class Pulse
        {
            //creating the name method
            public String Name { get; set; }

            //creating the weight method
            public int weight { get; set; }

            //creating the price method
            public int price { get; set; }

            //creating the type method
            public String type { get; set; }
        }

    }
}
