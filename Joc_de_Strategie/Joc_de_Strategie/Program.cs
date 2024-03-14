using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_de_Strategie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tile tile = new Tile();
            tile.TileInfo();
            Console.WriteLine("\n\n");
            Tile test = new Tile(2,1,7,1);
            test.TileInfo();
            Console.WriteLine("\n\n");
            Player player = new Player();
            player.PlayerInfo();
            Console.WriteLine("\n\n");
            Player player1 = new Player(99,2343,32,0);
            player1.PlayerInfo();
            Console.ReadKey();
        }
    }
}
