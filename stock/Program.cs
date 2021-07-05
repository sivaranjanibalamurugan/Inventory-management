using System;

namespace stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stock management");
            Inventory.ReadInput();
            Console.ReadLine();
        }
    }
}
