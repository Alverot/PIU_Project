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
        private Player[] players;

        public PlayersManager(int playerNumber) 
        {
            this.playerNumber = playerNumber;
            players = new Player[playerNumber];
            for(int i = 0; i < players.Length; i++)
            {
                players[i] = new Player();
            }
        }

        public string ConvertPlayersForSave()
        {
            string st = String.Format("{0}\n", playerNumber);
            for(int i =0; i < playerNumber; i++)
            {
                st = st + players[i].ConvetPlayerForSave(i+1);
            }
            return st;
        }


    }
}
