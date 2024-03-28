using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForProject
{
    public class Tile
    {
        //this class will be used in a chess like table and one object of this class will be a square in the board


        /*
        //voi modifica
        private int TerrainType;    //this can be 1 = plain/2 = fores/3 = mountain  maybe more types if i have time
        private int SettlementType;  //i have not decided yet on the types 0= none
        private int SettlementLevel;  // will be from 1 to 10 and 0 if nothing exists 
        private int PlayerControl;      //value from 0 to 8 . 0 means nobody controls it 1 to 8 means player 1 ,player 2 ....
        */
        public int TerrainType { set; get; }    //this can be 1 = plain/2 = fores/3 = mountain  maybe more types if i have time
        public int SettlementType { set; get; }  //i have not decided yet on the types 0= none
        public int SettlementLevel { set; get; } // will be from 1 to 10 and 0 if nothing exists 
        public int PlayerControl { set; get; }   //value from 0 to 8 . 0 means nobody controls it 1 to 8 means player 1 ,player 2 ....


        //constructors
        public Tile()//no args constructor
        {

            TerrainType = 1;
            SettlementType = 0;
            SettlementLevel = 0;
            PlayerControl = 0;

        }
        public Tile(int TerrainType, int SettelmentType = 0, int SettelmentLevel = 0, int PlayerControl = 0)//all args constructor
        {
            this.TerrainType = TerrainType;
            this.SettlementType = SettelmentType;
            this.SettlementLevel = SettelmentLevel;
            this.PlayerControl = PlayerControl;
        }

        //property

        //setters

        //geters

        //methods
        public string TileInfo()
        {

            string info = string.Format("INFO : \n");
            //info = info + string.Format("");
            if (TerrainType == 1)
            {
                info = info + string.Format("Terrain Type :plain\n");
            }
            else if (TerrainType == 2) { info = info + string.Format("Terrain Type :forest\n"); }
            else if (TerrainType == 3) { info = info + string.Format("Terrain Type :mountain\n"); }

            if (SettlementType == 0)
            {
                info = info + string.Format("Settelment : none\n");
            }
            else if (SettlementType == 1)
            {
                info = info + string.Format("Settelment : city\n");
            }
            if (SettlementType != 0)
            {
                info = info + string.Format("Settelment level : {0}\n", SettlementLevel);
            }

            if (PlayerControl == 0)
            {
                info = info + string.Format("This tile belongs to no one\n");
            }
            else
            {
                info = info + string.Format("This tile belongs to Player {0}\n", PlayerControl);
            }
            return info;
        }
        public string PrintTile()
        {

            string tile = String.Format("{0} {1} {2} {3} |", TerrainType,SettlementType,SettlementLevel,PlayerControl);
            return tile;
        }
    }
}
