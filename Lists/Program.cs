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
            Drop("A");
            Drop("Healing Potion");
            PickUp("Healing Potion");
            PickUp("Healing Potion");
            Use("Healing Potion");
            PickUp("Apple");
            PickUp("Key");
            PickUp("Apple");
            PickUp("Healing Potion");
            PickUp("Key");
            PickUp("Key");
            PickUp("Apple");
            PickUp("Healing Potion");
            ClearInventory();
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
                Console.WriteLine(item + " Added");
            }
            else
            {
                Console.WriteLine("No room for the " + item);
            }
            ShowHud();
        }

        static void Drop(string item)
        {
            Console.WriteLine("Trying to drop " + item);
            if (Inventory.Contains(item))
            {
                Console.WriteLine("Dropped " + item);
                Inventory.Remove(item);
            }
            else
            {
                Console.WriteLine("You don't have any " + item + "s");
            }
            ShowHud();
        }

        static void Use(string item)
        {
            Console.WriteLine("Tryin to use " + item);
            if (Inventory.Contains(item))
            {
                Console.WriteLine("Used " + item);
                Inventory.Remove(item);
            }
            else
            {
                Console.WriteLine("You don't have any " + item + "s");
            }
            ShowHud();
        }

        static void ClearInventory()
        {
            Console.WriteLine("The player has died and lost all their stuff");
            Inventory.Clear();
            ShowHud();
        }

    }
}
