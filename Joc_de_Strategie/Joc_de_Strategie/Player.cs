using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_de_Strategie
{
    internal class Player
    {
        int food;
        int wood;
        int stone;
        int gold;

        //constructors
        public Player()//no arg constructor
        {
            food = 200;
            wood = 200;
            stone = 200;
            gold = 200;
        }
        public Player(int food, int wood, int stone, int gold)//all arg constructor
        {
            this.food = food;
            this.wood = wood;
            this.stone = stone;
            this.gold = gold;
        }

        //setters

        //geters

        //methods

        public void PlayerInfo()
        {
            Console.WriteLine("Player resoureces:\n");
            Console.WriteLine($"food  : {food}");
            Console.WriteLine($"wood  : {wood}");
            Console.WriteLine($"stone : {stone}");
            Console.WriteLine($"gold  : {gold}");
        }


    }
}
