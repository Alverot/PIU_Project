using ClassLibraryForProject;
using Joc_de_Strategie;
using Nivel_stocare_date;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Joc_de_Strategie.GameManager;

namespace WindowsFormsInterface
{
    public partial class NewGame : Form
    {
        protected static int PlayerNumberNG = 0;
        protected static int MapNumberNG = 0;
        protected static int SavefileNG = 0;
        private Label error;
        

        public static int GetPlayerNumberNG(){ return PlayerNumberNG; }
        public static int GetMapNumberNG() { return MapNumberNG; }
        public static int GetSavefileNG() { return SavefileNG; }
        public NewGame()
        {
            InitializeComponent();
            this.Size = new Size(900, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(200, 150);
            this.Font = new Font("Arial", 13, FontStyle.Bold);
            this.ForeColor = Color.DarkCyan;
            this.Text = "NEW GAME";
            int TurnNbSave1 = SaveManager_text_files.CheckForSave(ConfigurationManager.AppSettings["NumeFisier1"]);
            if (TurnNbSave1 < 0)
            {
                this.InfoSave1.Text = "Save is Empty";
            }
            else
            {
                string tmporal = String.Format("Save is at turn {0}!!", TurnNbSave1);
                this.InfoSave1.Text = tmporal;
                this.InfoSave1.ForeColor = Color.Red;
            }

            int TurnNbSave2 = SaveManager_text_files.CheckForSave(ConfigurationManager.AppSettings["NumeFisier2"]);
            if (TurnNbSave2 < 0)
            {
                this.InfoSave2.Text = "Save is Empty";
            }
            else
            {
                string tmporal = String.Format("Save is at turn {0}!!", TurnNbSave2);
                this.InfoSave2.Text = tmporal;
                this.InfoSave2.ForeColor = Color.Red;
            }

            int TurnNbSave3 = SaveManager_text_files.CheckForSave(ConfigurationManager.AppSettings["NumeFisier3"]);
            if (TurnNbSave3 < 0)
            {
                this.InfoSave3.Text = "Save is Empty";
            }
            else
            {
                string tmporal = String.Format("Save is at turn {0}!!", TurnNbSave3);
                this.InfoSave3.Text = tmporal;
                this.InfoSave3.ForeColor = Color.Red;
            }
        }

        private void NewGame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PlayerNumberNG != 0 && MapNumberNG != 0 && SavefileNG != 0)
            {
                GameScreen.SetLoadOrNew(0);// 0 = new game , 1 = load game;
                this.Hide();
                var map = new GameScreen();
                map.Closed += (s, args) => this.Close();
                map.Show();
            }
            else
            {
                error = new Label();
                error.Location = new System.Drawing.Point(1000, 500);
                error.Size = new System.Drawing.Size(400, 33);
                error.Text = "!!Please select one of all options!! ";
                error.ForeColor = Color.Red;
                this.Controls.Add(error);
            }
            
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = listBox1.SelectedItem.ToString();
            if (selectedOption == "2 Players")
            {
                PlayerNumberNG = 2;
            }
            else if (selectedOption == "3 Players")
            {
                PlayerNumberNG = 3;
            }
            else if(selectedOption == "4 Players")
            {
                PlayerNumberNG = 4;
            }
            else if (selectedOption == "5 Players")
            {
                PlayerNumberNG = 5;
            }
            else if (selectedOption == "6 Players")
            {
                PlayerNumberNG = 6;
            }
            else if (selectedOption == "7 Players")
            {
                PlayerNumberNG = 7;
            }
            else if (selectedOption == "8 Players")
            {
                PlayerNumberNG = 8;
            }
        }

        

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = listBox2.SelectedItem.ToString();
            if (selectedOption == "Random Map")
            {
                MapNumberNG = 1;
            }
            else if (selectedOption == "The other ones are still in work")
            {
                MapNumberNG = 0;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = listBox3.SelectedItem.ToString();
            if (selectedOption == "Save_1")
            {
                SavefileNG = 1;
            }
            else if (selectedOption == "Save_2")
            {
                SavefileNG = 2;
            }
            else if (selectedOption == "Save_3")
            {
                SavefileNG = 3;
            }
        }
    }
}
