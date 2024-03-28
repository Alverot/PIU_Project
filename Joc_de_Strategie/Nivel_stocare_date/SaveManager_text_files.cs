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

        public SaveManager_text_files(string FileName)
        {
            this.FileName = FileName;
            Stream streamTextFile = File.Open(FileName,FileMode.OpenOrCreate);
            streamTextFile.Close();
        }
        public static void SaveGame(Player player,string FileName)
        {
            using (StreamWriter strwri = new StreamWriter(FileName, true))
            {
                strwri.WriteLine(player.PlayerInfo());
            }
        }
    }
}
