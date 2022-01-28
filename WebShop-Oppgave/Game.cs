using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop_Oppgave
{
    internal class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
        public bool Digital { get; set; }
        public bool Physical { get; set; }

        public virtual void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {GameName} Price: {Price} ID: {Id}");
        }
    }
}
