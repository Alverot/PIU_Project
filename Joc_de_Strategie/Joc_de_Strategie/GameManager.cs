using ClassLibraryForProject;
using Nivel_stocare_date;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





//this class will be responsibale for ussing all the clases and get all the parameters needed for runnig the match


namespace Joc_de_Strategie
{
    public class GameManager
    {

        protected static int PlayerNumber = 0;
        protected static int MapNumber = 0;
        protected static string Savefile = ConfigurationManager.AppSettings["NumeFisier0"];
        protected static PlayersManager players = new PlayersManager(PlayerNumber);
        protected static MapGenerator MAPP = new MapGenerator();
        protected static int LoadOrNew = 0;//0 new game 1 load game from SaveFile
        protected static int Turn = 0;
        public static void SetLoadOrNew(int loadOrNew)
        {
            LoadOrNew = loadOrNew;
        }
        public GameManager(int PN, int MN, int SF)
        {
            PlayerNumber = PN;
            players = new PlayersManager(PlayerNumber);
            MapNumber = MN;
            switch (SF)
            {
                case 1:
                    Savefile = ConfigurationManager.AppSettings["NumeFisier1"];
                    break;
                case 2:
                    Savefile = ConfigurationManager.AppSettings["NumeFisier2"];
                    break;
                case 3:
                    Savefile = ConfigurationManager.AppSettings["NumeFisier3"];
                    break;
            }
        }

        public void GameManagerInitiation()
        {
            switch (MapNumber)
            {
                case 1:
                    GameManager.MAPP = new MapGenerator();
                    break;
                case 2:
                    //MapGenerator MAP = new MapGenerator();
                    break;
                case 3:
                    //MapGenerator MAP = new MapGenerator();
                    break;
            }
            //initial save
            SaveManager_text_files.SaveGame(players, Savefile, MAPP, Turn);
        }



}
}
