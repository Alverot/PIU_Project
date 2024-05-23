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
using static WindowsFormsInterface.NewGame;
using Joc_de_Strategie;

namespace WindowsFormsInterface
{
    public partial class GameScreen : Form
    {

        private PictureBox[,] pictureBoxes = new PictureBox[10, 10];
        private PictureBox[,] pictureBoxesback = new PictureBox[10, 10];
        protected static int PlayerNumber = 0;// GetPlayerNumberNG();
        protected static int MapNumber = 1;// GetMapNumberNG();
        protected static int SavefileNG = 1;// GetSavefileNG();

        protected static int SelectedTileX = 0;// GetSavefileNG();
        protected static int SelectedTileY = 0;// GetSavefileNG();

        protected static int LoadOrNew = 0;//0 new game 1 load game from SaveFile
        protected static bool initiation = false;

        public static void SetLoadOrNew(int loadOrNew)
        {
            LoadOrNew = loadOrNew;
        }

        //GameManager gameManager;
        protected static GameManager gameManager = new GameManager(PlayerNumber, MapNumber, SavefileNG);
        public static void InitiateGameManager()
        {
            if(LoadOrNew == 0)
            {
                PlayerNumber = GetPlayerNumberNG();
                MapNumber = GetMapNumberNG();
                SavefileNG = GetSavefileNG();
                gameManager = new GameManager(PlayerNumber, MapNumber, SavefileNG);
                gameManager.GameManagerInitiation();//makes all the preparations for the game for the settings that have been introduced
            }
            else
            {
                SavefileNG = LoadGame.GetSavefileLG();
                gameManager.ReadAndLoadSave(SavefileNG);
                PlayerNumber = gameManager.GetPlayerNumber();
            }
        }

        
        public GameScreen()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(200, 100);
            this.Text = "GameScreen";

            if(initiation == false)
            {
                InitiateGameManager();
                initiation = true;
            }
            
            
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

                    if (GameManager.MAPP.MAP[i,j].TerrainType == 1)
                    {
                        pictureBoxes[i, j].Image = Image.FromFile("../Resourses/Tiles/plain.png");

                    }
                    else if (GameManager.MAPP.MAP[i, j].TerrainType == 2)
                    {
                        pictureBoxes[i, j].Image = Image.FromFile("../Resourses/Tiles/hill.png");

                    }
                    else if (GameManager.MAPP.MAP[i, j].TerrainType == 3)
                    {
                        pictureBoxes[i, j].Image = Image.FromFile("../Resourses/Tiles/forest.png");
                    }
                    else if (GameManager.MAPP.MAP[i, j].TerrainType == 4)
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

                    if (GameManager.MAPP.MAP[i, j].PlayerControl == 1 )
                            pictureBoxesback[i, j].Image = Image.FromFile("../Resourses/Players_colors/Blue.png");
                    if (GameManager.MAPP.MAP[i, j].PlayerControl == 2)
                            pictureBoxesback[i, j].Image = Image.FromFile("../Resourses/Players_colors/Red.png");

                    pictureBoxesback[i, j].SendToBack();
                    Controls.Add(pictureBoxesback[i, j]);
                    k++;
                }
            }
            FoodLable.Text = GameManager.players.playersss[0].Food.ToString();
            WoodLable.Text = GameManager.players.playersss[0].Wood.ToString();
            StoneLable.Text = GameManager.players.playersss[0].Stone.ToString();
            GoldLable.Text = GameManager.players.playersss[0].Gold.ToString();
            TurnLable.Text = String.Format("Turn : {0}", gameManager.GetTurn());

        }
        private void RefreshScreen()
        {
            

            int k = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (GameManager.MAPP.MAP[i, j].PlayerControl == 0)
                        pictureBoxesback[i, j].Image = Image.FromFile("../Resourses/Players_colors/Empty.png");
                    if (GameManager.MAPP.MAP[i, j].PlayerControl == 1)
                        pictureBoxesback[i, j].Image = Image.FromFile("../Resourses/Players_colors/Blue.png");
                    if (GameManager.MAPP.MAP[i, j].PlayerControl == 2)
                        pictureBoxesback[i, j].Image = Image.FromFile("../Resourses/Players_colors/Red.png");

                    pictureBoxesback[i, j].SendToBack();
                    Controls.Add(pictureBoxesback[i, j]);
                    k++;
                }
            }
            FoodLable.Text = GameManager.players.playersss[0].Food.ToString();
            WoodLable.Text = GameManager.players.playersss[0].Wood.ToString();
            StoneLable.Text = GameManager.players.playersss[0].Stone.ToString();
            GoldLable.Text = GameManager.players.playersss[0].Gold.ToString();
            TurnLable.Text = String.Format("Turn : {0}", gameManager.GetTurn());
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameManager.Save();
            LoadOrNew = 0;
            initiation = false;
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void MapPictureBox_Click(object sender, EventArgs e)
        {

            RefreshScreen();
            PictureBox pictureBox = ((PictureBox)sender);
            string[] XY;  
            XY = pictureBox.Name.Split('_');
            XTextBox.Text = XY[0];
            YTextBox.Text = XY[1];
            SelectedTileX = int.Parse(XY[0]);
            SelectedTileY = int.Parse(XY[1]);
            TileInfoBox.Items.Clear();
            string[] InfoTil =GameManager.MAPP.MAP[SelectedTileX, SelectedTileY].TileInfo().Split('\n');
            for (int i = 0; i< InfoTil.Length ; i++)
                TileInfoBox.Items.Add(InfoTil[i]);
            pictureBoxesback[SelectedTileX, SelectedTileY].Image = Image.FromFile("../Resourses/Players_colors/Black.png");
            
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
        private void SelectTileButon_Click(object sender, EventArgs e)
        {

            RefreshScreen();

            int x, y;
            bool X, Y;
            X = int.TryParse(XTextBox.Text,out x);
            Y = int.TryParse(YTextBox.Text,out y);
            if (X  == false) { x =0; }
            if (Y == false) { y = 0; }
            if (x >=0 && x<=9 && y >=0 && y<=9)
            {
                ErorOutOfMap.Text = "";
                ErorOutOfMap.ForeColor = Color.Red;
                SelectedTileX = x;
                SelectedTileY = y;
                pictureBoxesback[SelectedTileX, SelectedTileY].Image = Image.FromFile("../Resourses/Players_colors/Black.png");
                TileInfoBox.Items.Clear();
                string[] InfoTil = GameManager.MAPP.MAP[SelectedTileX, SelectedTileY].TileInfo().Split('\n');
                for (int i = 0; i < InfoTil.Length; i++)
                    TileInfoBox.Items.Add(InfoTil[i]);
                pictureBoxesback[SelectedTileX, SelectedTileY].Image = Image.FromFile("../Resourses/Players_colors/Black.png");

            }
            else
            {
                ErorOutOfMap.Text = "Coordonate in afara Harti!!";
                ErorOutOfMap.ForeColor = Color.Red;
            }

        }
    }
}
