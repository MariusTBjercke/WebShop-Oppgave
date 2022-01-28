using System;

namespace WebShop_Oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new StoreInventory();
            inventory.PrintInventory("1");
        }
    }
}
