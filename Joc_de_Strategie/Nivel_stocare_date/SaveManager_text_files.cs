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

        //needs to be done
        public static void LoadGame(Player player, string FileName)
        {
            using (StreamWriter strwri = new StreamWriter(FileName, true))
            {
                strwri.WriteLine(player.PlayerInfo());
            }
        }

        /* model pt citire din fisier :
        public Student[] GetStudenti(out int nrStudenti)
        {
            Student[] studenti = new Student[NR_MAX_STUDENTI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrStudenti = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    studenti[nrStudenti++] = new Student(linieFisier);
                }
            }

            return studenti;
        }
         */

    }
}
