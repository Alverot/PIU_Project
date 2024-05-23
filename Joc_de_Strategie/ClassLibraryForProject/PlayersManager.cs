using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryForProject
{
    public class PlayersManager
    {
        private int playerNumber=2;
        public Player[] playersss;

        public PlayersManager(int playerNumber) 
        {
            this.playerNumber = playerNumber;
            playersss = new Player[playerNumber];
            for(int i = 0; i < playersss.Length; i++)
            {
                playersss[i] = new Player();
            }
        }
        public int GetPlayerNumber() 
        {
            return playerNumber;
        }
        public void SetPlayerNumber(int playerNumber)
        {
            this.playerNumber=playerNumber;
        }

        public string ConvertPlayersForSave()
        {
            string st = String.Format("{0}\n", playerNumber);
            for(int i =0; i < playerNumber; i++)
            {
                st = st + playersss[i].ConvetPlayerForSave(i+1);
            }
            return st;
        }


    }
}
