using ClassLibraryForProject;
using Nivel_stocare_date;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;





//this class will be responsibale for ussing all the clases and get all the parameters needed for runnig the match


namespace Joc_de_Strategie
{
    public class GameManager
    {
        private const char SEPARATOR_LINII_FISIER = '\n';
        private const char SEPARATOR_PRINCIPAL_FISIER = '|';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        protected static int PlayerNumber = 8;
        protected static int MapNumber = 0;
        protected static string Savefile = ConfigurationManager.AppSettings["NumeFisier0"];
        public static PlayersManager players = new PlayersManager(PlayerNumber);
        public static MapGenerator MAPP = new MapGenerator();
        protected static int Turn = 0;


        public int GetPlayerNumber() { return PlayerNumber; }
        public int GetTurn() { return Turn; }

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


        public void Save()
        {
            SaveManager_text_files.SaveGame(players, Savefile, MAPP, Turn);
        }

        public void ReadAndLoadSave(int SvNr)   //convert the text from a savefile to object for the program
        {
            switch (SvNr)
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
            string FullStringOfSav = SaveManager_text_files.LoadGameTEXT(Savefile);
            string[] lines = FullStringOfSav.Split(SEPARATOR_LINII_FISIER);
            //load la playeri
            Int32.TryParse(lines[0], out PlayerNumber);
            players = new PlayersManager(PlayerNumber);
            for(int i = 0 ; i < PlayerNumber; i++)
            {
                string[] line = lines[i+1].Split(SEPARATOR_PRINCIPAL_FISIER);
                players.playersss[i] = new Player(Int32.Parse(line[1]), Int32.Parse(line[2]), Int32.Parse(line[3]), Int32.Parse(line[4]));
            }

            //load la harta
            
            for(int i = 0 ;i < 10; i++)
            {
                string[] line = lines[PlayerNumber + 2+i].Split(SEPARATOR_PRINCIPAL_FISIER);
                for(int j = 0;j < 10; j++)
                {
                    string[] square = line[j].Split(SEPARATOR_SECUNDAR_FISIER);
                    MAPP.MAP[i, j] = new Tile(Int32.Parse(square[1]), Int32.Parse(square[0]), Int32.Parse(square[2]), Int32.Parse(square[3]),Int32.Parse(square[4]), Int32.Parse(square[5]), Int32.Parse(square[6]));
                }
                
            }
            Turn = Int32.Parse(lines[PlayerNumber + 3 + 10]);
        }


        public void NEXTTURN()
        {
            for(int i = 0 ; i < 10; i++)
            {
                for(int j=0 ; j < 10; j++)
                {
                    if(MAPP.MAP[i, j].PlayerControl != 0)
                    {
                        int playerNB = MAPP.MAP[i, j].PlayerControl - 1 ;
                        if(MAPP.MAP[i, j].SettlementType != 0)
                        {
                            int settelType = MAPP.MAP[i, j].SettlementType;
                            switch(settelType)
                            {
                                case 1:
                                    players.playersss[playerNB].Gold = players.playersss[playerNB].Gold + 10 *  MAPP.MAP[i, j].SettlementLevel;
                                    break;
                                case 2:
                                    players.playersss[playerNB].Gold = players.playersss[playerNB].Gold + 100 * MAPP.MAP[i, j].SettlementLevel;
                                    break;
                                case 3:
                                    players.playersss[playerNB].Food = players.playersss[playerNB].Food + 10 * MAPP.MAP[i, j].SettlementLevel;
                                    break;
                                case 4:
                                    players.playersss[playerNB].Wood = players.playersss[playerNB].Wood + 10 * MAPP.MAP[i, j].SettlementLevel;
                                    break;
                                case 5:
                                    players.playersss[playerNB].Stone = players.playersss[playerNB].Stone + 10 * MAPP.MAP[i, j].SettlementLevel;
                                    break;
                            }
                        }
                    }
                }
            }
            Turn++;
        }


}
}
