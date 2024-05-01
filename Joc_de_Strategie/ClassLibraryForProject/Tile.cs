using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibraryForProject.Tile;

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
        public enum Terrain_Type
        {
            plain = 1,
            hill = 2,
            forest = 3,
            mountain = 4
        };
        public enum Settlement_Type
        {
            Empty = 0,
            Village = 1,
            City =2,
            Metropolis =3,
            Stone_mine =4,
            Farm =5,
            Wood_cutting_camp=6
        };
        
        public int TileNumber { get; set; }  //the number of the tyle in the map
        public int TerrainType { set; get; }    //this can be 1 = plain/ 2 = hill /3 = fores/4 = mountain  maybe more types if i have time
        public int SettlementType { set; get; }  //i have not decided yet on the types 0= none
        public int SettlementLevel { set; get; } // will be from 1 to 10 and 0 if nothing exists 
        public int PlayerControl { set; get; }   //value from 0 to 8 . 0 means nobody controls it 1 to 8 means player 1 ,player 2 ....
        public int ArmyNumber { set; get; }    // the number of the army from the army array(each element of that aray will be an army)
        public int ArmyOwner { set; get; }    //the player that owns the army



        //constructors
        public Tile()//no args constructor
        {

            TileNumber = 0;
            TerrainType = 1;
            SettlementType = 0;
            SettlementLevel = 0;
            PlayerControl = 0;
            ArmyNumber = 0;
            ArmyOwner = 0;



        }
        public Tile(int TerrainType,int TileNumber , int SettelmentType = 0, int SettelmentLevel = 0, int PlayerControl = 0, int ArmyNumber = 0, int ArmyOwner = 0 )//all args constructor
        {
            this.TileNumber = TileNumber;
            this.TerrainType = TerrainType;
            this.SettlementType = SettelmentType;
            this.SettlementLevel = SettelmentLevel;
            this.PlayerControl = PlayerControl;
            this.ArmyNumber = ArmyNumber;
            this.ArmyOwner = ArmyOwner;
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
                info = info + string.Format($"Terrain Type :{Terrain_Type.plain.ToString()}\n");
            }
            else if (TerrainType == 2) { info = info + string.Format($"Terrain Type :{Terrain_Type.hill.ToString()}\n"); }
            else if (TerrainType == 3) { info = info + string.Format($"Terrain Type :{Terrain_Type.forest.ToString()}\n"); }
            else if (TerrainType == 4) { info = info + string.Format($"Terrain Type :{Terrain_Type.mountain.ToString()}\n"); }

            if (SettlementType == 0)
            {   info = info + string.Format("Settlement : none\n");}
            else if (SettlementType == 1) { info = info + string.Format($"Settlement Type :{Settlement_Type.Village.ToString()}\n"); }
            else if (SettlementType == 2) { info = info + string.Format($"Settlement Type :{Settlement_Type.City.ToString()}\n"); }
            else if (SettlementType == 3) { info = info + string.Format($"Settlement Type :{Settlement_Type.Metropolis.ToString()}\n"); }
            else if (SettlementType == 4) { info = info + string.Format($"Settlement Type :{Settlement_Type.Stone_mine.ToString()}\n"); }
            else if (SettlementType == 5) { info = info + string.Format($"Settlement Type :{Settlement_Type.Farm.ToString()}\n"); }
            else if (SettlementType == 6) { info = info + string.Format($"Settlement Type :{Settlement_Type.Wood_cutting_camp.ToString()}\n"); }


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

            string tile = String.Format("{0} {1} {2} {3} {4} {5} {6}|",TileNumber, TerrainType,SettlementType,SettlementLevel,PlayerControl,ArmyNumber,ArmyOwner);
            return tile;
        }
    }
}
