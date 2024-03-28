using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForProject
{
    public class Player
    {
        public int Food { get; set; }
        public int Wood { get; set; }
        public int Stone { get; set; }
        public int Gold { get; set; }


        //constructors
        public Player()//no arg constructor
        {
            Food = 200;
            Wood = 200;
            Stone = 200;
            Gold = 200;
        }
        public Player(int food, int wood, int stone, int gold)//all arg constructor
        {
            this.Food = food;
            this.Wood = wood;
            this.Stone = stone;
            this.Gold = gold;
        }

        //property
        /*
        
        */
        //public int food { set; get; };

        //setters

        //geters

        //methods

        public string PlayerInfo()
        {
            string info = string.Format("Player resourses : \n" +
                "food  : {0} \n" +
                "wood  : {1} \n" +
                "stone  : {2} \n" +
                "gold  : {3} \n", Food, Wood , Stone, Gold);
            return info;
        }
        public string ConvetPlayerForSave(int playerNB)
        {
            string info = string.Format("{0}|{1}|{2}|{3}|{4}", playerNB,Food, Wood, Stone, Gold);
            return info;
        }


    }
}
