using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop_Oppgave
{
    internal class PUBG : Game
    {
        public PUBG()
        {
            Id = 1;
            GameName = "PUBG";
            Price = 100;
            Digital = Physical = true;
        }
    }
}
