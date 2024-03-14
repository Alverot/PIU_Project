using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_de_Strategie
{
    internal class Tile
    {
        //this class will be used in a chess like table and one object of this class will be a square in the board
        int TerrainType;   //this can be 1 = plain/2 = fores/3 = mountain  maybe more types if i have time
        int SettelmentType;   //i have not decided yet on the types 0= none
        int SettelmentLevel;  // will be from 1 to 10 and 0 if nothing exists
        int PlayerControl;     //value from 0 to 8 . 0 means nobody controls it 1 to 8 means player 1 ,player 2 ....

        //constructors
        public Tile()//no args constructor
        {
            
            TerrainType = 1;
            SettelmentType = 0;
            SettelmentLevel = 0;
            PlayerControl = 0;

        }
        public Tile(int TerrainType, int SettelmentType, int SettelmentLevel, int PlayerControl)//all args constructor
        {
            this.TerrainType = TerrainType; 
            this.SettelmentType = SettelmentType;
            this.SettelmentLevel = SettelmentLevel;
            this.PlayerControl = PlayerControl;
        }
        //setters

        //geters

        //methods
        public void TileInfo()
        {
            if (TerrainType == 1) { Console.WriteLine("Terrain Type :plain\n"); }
            else if (TerrainType == 2) { Console.WriteLine("Terrain Type :forest\n"); }
            else if (TerrainType == 3) { Console.WriteLine("Terrain Type :mountain\n"); }

            if (SettelmentType == 0)
            { 
                Console.WriteLine("Settelment : none\n");
            } 
            else if(SettelmentType == 1)
            {
                Console.WriteLine("Settelment : city\n"); 
            }
            if (SettelmentType != 0)
            {
                Console.WriteLine($"Settelment level : {SettelmentLevel} \n" );
            }

            if (PlayerControl == 0)
            {
                Console.WriteLine("This tile belongs to no one\n");
            }
            else 
            {
                Console.WriteLine($"This tile belongs to Player {PlayerControl}");
            }

        }
    }
}
