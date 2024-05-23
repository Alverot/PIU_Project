using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForProject;

namespace Nivel_stocare_date
{
    public class SaveManager_text_files
    {
        private string FileName;
        private const char SEPARATOR_LINII_FISIER = '\n';
        private const char SEPARATOR_PRINCIPAL_FISIER = '|';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        public SaveManager_text_files(string FileName)
        {
            this.FileName = FileName;
            Stream streamTextFile = File.Open(FileName, FileMode.OpenOrCreate);
            streamTextFile.Close();
        }
        public static void SaveGame(PlayersManager players, string FileName, MapGenerator map, int turn)
        {

            File.WriteAllText(FileName, players.ConvertPlayersForSave());
            using (StreamWriter strwri = new StreamWriter(FileName, true))
            {

                //strwri.WriteLine(player.ConvetPlayerForSave(nr));//va trebui modificat formatul pentru a putea salva resursele la mai multi playeri
                strwri.WriteLine(map.ConvertMAPForSave());
                strwri.WriteLine(turn.ToString());
            }
            //File.AppendAllText(FileName, turn.ToString());

        }

        public static string LoadGameTEXT(string FileName)
        {
            return File.ReadAllText(FileName);
        }

        public static int CheckForSave(string FileName)         //returns the number of the turn if the game exists                                         
        {                                                       //else returns -1 if there is no game saved in the file
            
            FileInfo fileInfo = new FileInfo(FileName);
            if(fileInfo.Length == 0)
            {
                return -1;
            }
            else
            {
                string FullStringOfSav = File.ReadAllText(FileName);
                string[] lines = FullStringOfSav.Split(SEPARATOR_LINII_FISIER);
                //load la playeri
                int PlayerNumber;
                Int32.TryParse(lines[0], out PlayerNumber);

                int Turn = Int32.Parse(lines[PlayerNumber + 3 + 10]);
                return Turn;
            }
            
        }
    }
}
