
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForProject;
using System.Configuration;
using Nivel_stocare_date;
using System.Runtime.InteropServices;

namespace Joc_de_Strategie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string CurrentSave = ConfigurationManager.AppSettings["NumeFisier0"];
            //SaveManager_text_files file = new SaveManager_text_files(CurrentSave);

            //temporaty
            MapGenerator MAPPP = new MapGenerator();//temporaty
            int plNumber = 7;
            PlayersManager players = new PlayersManager(plNumber);
            //temporaty

            string opt;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("N-New game");
                Console.WriteLine("L-Load game");
                Console.WriteLine("I-Info");

                //Sectiune temporara pentru teste
                Console.WriteLine("P-generate and printmap and save(temporaty)");
                Console.WriteLine("S-search and print all player tiles(temporaty)");
                //Sectiune temporara pentru teste

                Console.WriteLine("X-EXIT");

                opt = Console.ReadLine();

                switch(opt.ToUpper())
                {
                    case "N":
                        Console.WriteLine("test 1 scriere in fisier");
                        NewGame(ref CurrentSave);
                        Console.WriteLine(CurrentSave);
                        Console.ReadKey();
                        break;
                    case "L":
                        Console.WriteLine("(Temporat) salveaza niste date in fisierul text selectat");
                        SaveManager_text_files.SaveGame(players, CurrentSave, MAPPP,0);
                        Console.ReadKey();
                        break;
                    case "I":
                        INFO();
                        Console.ReadKey();
                        break;



                    case "P":
                        MapGenerator MAPP = new MapGenerator();
                       
                        Console.WriteLine(MAPP.PrintMAP());
                        Console.WriteLine("(Temporat) salveaza niste date in fisierul text selectat");
                        //SaveManager_text_files.SaveGame(player1, 1, CurrentSave, MAPPP);
                        Console.ReadKey();
                        break;
                    case "S":
                        Console.WriteLine(MAPPP.SearchAndReturn(1));
                        Console.ReadKey();
                        break;



                    case "X":
                        break;
                    default:
                        Console.WriteLine("Not an option");
                        Console.ReadKey();
                        break;
                }


            } while (opt.ToUpper() != "X");


        }


        //functions

        public static void NewGame(ref string CurrentSave)
        {
            int ok = 0;
            Console.Clear();
            Console.WriteLine("New game");
            Console.Write("Select the save file for your game (1,2,3,4) : ");
            do
            {
                
                string SaveNumber = Console.ReadLine();
                int svnr;
                
                if(int.TryParse(SaveNumber, out svnr))
                {
                    if (svnr == 1 || svnr == 2 || svnr == 3 || svnr == 4)
                    {
                        switch(svnr)
                        {
                            case 1:
                                CurrentSave = ConfigurationManager.AppSettings["NumeFisier0"];
                                //SaveManager_text_files file1 = new SaveManager_text_files(CurrentSave);
                                break;
                            case 2:
                                CurrentSave = ConfigurationManager.AppSettings["NumeFisier1"];
                                //SaveManager_text_files file2 = new SaveManager_text_files(CurrentSave);
                                break;
                            case 3:
                                CurrentSave = ConfigurationManager.AppSettings["NumeFisier2"];
                                //SaveManager_text_files file3 = new SaveManager_text_files(CurrentSave);
                                break;
                            case 4:
                                CurrentSave = ConfigurationManager.AppSettings["NumeFisier3"];
                                //SaveManager_text_files file4 = new SaveManager_text_files(CurrentSave);
                                break;
                        }
                        ok = 1;
                    }
                    else
                    {
                        Console.Write("Please enter a number from(1,2,3,4) : ");
                    }
                }
                else
                {
                    Console.Write("Please enter a number from(1,2,3,4) : ");
                }

            } while (ok == 0);
            //return CurrentSave;
        }

        public static void INFO()
        {
            Console.WriteLine("Aici se vor gasi toate instructiunile legat de cum se joaca jocul" +
                " si multe alte informatii utile legate de program" +
                "\n Proiect realizat de Melinte Alexandru");
        }

    }
}
