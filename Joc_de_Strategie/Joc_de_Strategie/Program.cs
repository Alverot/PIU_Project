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


            //cod pentru teste
            Tile tile = new Tile();
            string info = tile.TileInfo();
            Console.WriteLine(info);
            Tile test = new Tile(2,1,7,1);
            Console.WriteLine(test.TileInfo());

            
            Player player = new Player();
            Console.WriteLine(player.PlayerInfo());
            Player player1 = new Player(99,2343,32,0);
            Console.WriteLine(player1.PlayerInfo());
            Console.ReadKey();

            


        }
    }
}
