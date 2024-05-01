using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryForProject;
using Nivel_stocare_date;
using static WindowsFormsInterface.NewGame;


namespace WindowsFormsInterface
{
    public partial class GameScreen : Form
    {

        private PictureBox[,] pictureBoxes = new PictureBox[10, 10];
        private PictureBox[,] pictureBoxesback = new PictureBox[10, 10];
        protected static int PlayerNumber = GetPlayerNumberNG();
        protected static int MapNumber = GetMapNumberNG();
        protected static int Savefile = GetSavefileNG();

        //GameManager gameManager;

        

    MapGenerator MAP = new MapGenerator();
        PlayersManager players = new PlayersManager(PlayerNumber);

        protected static String CurrentSave = ConfigurationManager.AppSettings["NumeFisier0"];



        public GameScreen()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 100);
            this.Text = "GameScreen";

            switch (MapNumber)
            {
                case 1:
                    MapGenerator MAP = new MapGenerator();
                    break;
                case 2:
                    //MapGenerator MAP = new MapGenerator();
                    break;
                case 3:
                    //MapGenerator MAP = new MapGenerator();
                    break;

            }

            //setting upt the map and savefiles
            switch (Savefile)
            {
                case 1:
                    CurrentSave = ConfigurationManager.AppSettings["NumeFisier1"];
                    break;
                case 2:
                    CurrentSave = ConfigurationManager.AppSettings["NumeFisier2"];
                    break;
                case 3:
                    CurrentSave = ConfigurationManager.AppSettings["NumeFisier3"];
                    break;
            }

            SaveManager_text_files.SaveGame(players, CurrentSave, MAP);
            int[] rndm = new int[100];

            rndm = RandomGeneratorForMultipleUses.RandomArrayGenerator(100);
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    pictureBoxes[i, j] = new PictureBox();
                    pictureBoxes[i, j].Location = new System.Drawing.Point(100 + 60 * j, 100 + 60 * i);
                    pictureBoxes[i, j].Size = new System.Drawing.Size(50, 50);
                    pictureBoxes[i, j].TabIndex = 1 + k;
                    pictureBoxes[i, j].TabStop = false;
                    pictureBoxes[i, j].BringToFront();
                    pictureBoxes[i, j].Name = $"{i}_{j}";

                    // de modificat adresele

                    if (rndm[k] == 1)
                    {
                        pictureBoxes[i, j].Image = Image.FromFile("../Resourses/Tiles/plain.png");

                    }
                    else if (rndm[k] == 2)
                    {
                        pictureBoxes[i, j].Image = Image.FromFile("../Resourses/Tiles/hill.png");

                    }
                    else if (rndm[k] == 3)
                    {
                        pictureBoxes[i, j].Image = Image.FromFile("../Resourses/Tiles/forest.png");


                    }
                    else if (rndm[k] == 4)
                    {
                        pictureBoxes[i, j].Image = Image.FromFile("../Resourses/Tiles/mountain.png");


                    }

                    Controls.Add(pictureBoxes[i, j]);
                    pictureBoxes[i, j].Click += MapPictureBox_Click;
                    k++;
                }
            }

            k = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    pictureBoxesback[i, j] = new PictureBox();
                    pictureBoxesback[i, j].Location = new System.Drawing.Point(95 + 60 * j, 95 + 60 * i);
                    pictureBoxesback[i, j].Size = new System.Drawing.Size(60, 60);
                    pictureBoxesback[i, j].TabIndex = 2;
                    pictureBoxesback[i, j].TabStop = false;


                    if (PlayerNumber == 2)
                    {
                        if (k == 0)
                            pictureBoxesback[i, j].Image = Image.FromFile("../Resourses/Players_colors/Blue.png");
                        if (k == 99)
                            pictureBoxesback[i, j].Image = Image.FromFile("../Resourses/Players_colors/Orange.png");

                    }

                    pictureBoxesback[i, j].SendToBack();
                    Controls.Add(pictureBoxesback[i, j]);
                    k++;
                }
            }


        }


        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void MapPictureBox_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = ((PictureBox)sender);
            int x, y;
            string[] XY;  
            XY = pictureBox.Name.Split('_');
            x = int.Parse(XY[0]);
            y = int.Parse(XY[1]);

            pictureBoxesback[x,y].Image = Image.FromFile("../Resourses/Players_colors/Blue.png");

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void NextTurn_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
