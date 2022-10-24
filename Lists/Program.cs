using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static List<string> Inventory = new List<string>();
        static int maxInventory = 8;

        static void Main(string[] args)
        {
            ShowHud();
            PickUp("Healing Potion");
            ShowHud();
        }

        static void ShowHud()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inventory");
            Console.WriteLine(Inventory.Count + " items");
            foreach (string item in Inventory)
            {
                Console.WriteLine("|" + item + "|");
            }
            Console.ResetColor();
            Console.ReadKey(true);
        }

        static void PickUp(string item)
        {
            Console.WriteLine("Trying to add " + item);
            if(Inventory.Count < maxInventory)
            {
                Inventory.Add(item);
                Console.WriteLine("Item Added");
            }
            else
            {
                Console.WriteLine("No room for the " + item);
            }
        }

        

    }
}
