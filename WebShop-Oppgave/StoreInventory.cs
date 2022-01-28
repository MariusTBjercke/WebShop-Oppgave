using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop_Oppgave
{
    internal class StoreInventory
    {
        public List<Game> InventoryList = new();

        public StoreInventory()
        {
            InventoryList = new List<Game>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEvee());
            InventoryList.Add(new CyberPunk());
            InventoryList.Add(new BattleField());
        }

        public List<Game> ListPhysicalItems()
        {
            return InventoryList.FindAll(x => x.Physical);
        }

        public List<Game> ListDownloadable()
        {
            return InventoryList.FindAll(x => x.Digital);
        }

        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDownloadable());
            }
        }

        public static void Print(List<Game> list)
        {
            list.ForEach(x => x.PrintGameNameAndPrice());
        }

    }
}
