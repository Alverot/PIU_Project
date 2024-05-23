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

namespace WindowsFormsInterface
{
    public partial class LoadGame : Form
    {
        protected static int SavefileLG = 0;
        protected static bool Valid = false;

        public static int GetSavefileLG() { return SavefileLG; }
        public LoadGame()
        {
            InitializeComponent();
            this.Size = new Size(900, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(200, 150);
            this.Font = new Font("Arial", 13, FontStyle.Bold);
            this.ForeColor = Color.DarkCyan;

            int TurnNbSave1 = SaveManager_text_files.CheckForSave(ConfigurationManager.AppSettings["NumeFisier1"]);
            if(TurnNbSave1 < 0)
            {
                this.InfoSave1.Text = "Save is Empty";
            }
            else
            {
                string tmporal = String.Format("Save is at turn {0}", TurnNbSave1);
                this.InfoSave1.Text = tmporal;
            }

            int TurnNbSave2 = SaveManager_text_files.CheckForSave(ConfigurationManager.AppSettings["NumeFisier2"]);
            if (TurnNbSave2 < 0)
            {
                this.InfoSave2.Text = "Save is Empty";
            }
            else
            {
                string tmporal = String.Format("Save is at turn {0}", TurnNbSave2);
                this.InfoSave2.Text = tmporal;
            }

            int TurnNbSave3 = SaveManager_text_files.CheckForSave(ConfigurationManager.AppSettings["NumeFisier3"]);
            if (TurnNbSave3 < 0)
            {
                this.InfoSave3.Text = "Save is Empty";
            }
            else
            {
                string tmporal = String.Format("Save is at turn {0}", TurnNbSave3);
                this.InfoSave3.Text = tmporal;
            }
        }

        private void LoadGame_Load(object sender, EventArgs e)
        {
            if (Valid == true )
            {
                GameScreen.SetLoadOrNew(1);// 0 = new game , 1 = load game;
                this.Hide();
                var map = new GameScreen();
                map.Closed += (s, args) => this.Close();
                map.Show();
            }
            
        }
        private void BackButton(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void save1_Click(object sender, EventArgs e)
        {
            SavefileLG = 1;
            SelectedSave.Text = "Selected save : 1";
            if(SaveManager_text_files.CheckForSave(ConfigurationManager.AppSettings["NumeFisier1"]) < 0)
            {
                ErorLable.Text = "The save is empty";
                ErorLable.ForeColor = Color.Red;
                Valid = false;
            }
            else
            {
                ErorLable.Text = "";
                ErorLable.ForeColor = Color.Red;
                Valid = true;
            }
        }
        private void save2_Click(object sender, EventArgs e)
        {
            SavefileLG = 2;
            SelectedSave.Text = "Selected save : 2";
            if (SaveManager_text_files.CheckForSave(ConfigurationManager.AppSettings["NumeFisier2"]) < 0)
            {
                ErorLable.Text = "The save is empty";
                ErorLable.ForeColor = Color.Red;
                Valid = false;
            }
            else
            {
                ErorLable.Text = "";
                ErorLable.ForeColor = Color.Red;
                Valid = true;
            }
        }
        private void save3_Click(object sender, EventArgs e)
        {
            SavefileLG = 3;
            SelectedSave.Text = "Selected save : 3";
            if (SaveManager_text_files.CheckForSave(ConfigurationManager.AppSettings["NumeFisier3"]) < 0)
            {
                ErorLable.Text = "The save is empty";
                ErorLable.ForeColor = Color.Red;
                Valid = false;
            }
            else
            {
                ErorLable.Text = "";
                ErorLable.ForeColor = Color.Red;
                Valid = true;
            }
        }
    }
}
