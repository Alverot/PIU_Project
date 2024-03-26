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

        public string PlayerInfo()
        {
            string info = string.Format("Player resourses : \n" +
                "food  : {0} \n" +
                "wood  : {0} \n" +
                "stone  : {0} \n" +
                "gold  : {0} \n", food, wood , stone, gold);
            return info;
        }


    }
}
