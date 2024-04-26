using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsInterface
{
    public partial class NewGame : Form
    {
        protected static int PlayerNumber = 0;
        protected static int MapNumber = 0;
        protected static int Savefile = 0;
        private Label error;

        public static int GetPlayerNumber()
        {
            return PlayerNumber;
        }
        public static int GetMapNumber() { return MapNumber; }
        public static int GetSavefile() { return Savefile; }
        public NewGame()
        {
            InitializeComponent();
            this.Size = new Size(900, 450);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 150);
            this.Font = new Font("Arial", 13, FontStyle.Bold);
            this.ForeColor = Color.DarkCyan;
            this.Text = "NEW GAME";
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
            if(PlayerNumber != 0 && MapNumber != 0 && Savefile != 0)
            {
                this.Hide();
                var map = new Map();
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
                PlayerNumber = 2;
            }
            else if (selectedOption == "3 Players")
            {
                PlayerNumber = 3;
            }
            else if(selectedOption == "4 Players")
            {
                PlayerNumber= 4;
            }
            else if (selectedOption == "5 Players")
            {
                PlayerNumber = 5;
            }
            else if (selectedOption == "6 Players")
            {
                PlayerNumber = 6;
            }
            else if (selectedOption == "7 Players")
            {
                PlayerNumber = 7;
            }
            else if (selectedOption == "8 Players")
            {
                PlayerNumber = 8;
            }
        }

        

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = listBox2.SelectedItem.ToString();
            if (selectedOption == "Random Map")
            {
                MapNumber = 1;
            }
            else if (selectedOption == "The other ones are still in work")
            {
                MapNumber = 0;
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
                Savefile = 1;
            }
            else if (selectedOption == "Save_2")
            {
                Savefile = 2;
            }
            else if (selectedOption == "Save_3")
            {
                Savefile = 3;
            }
        }
    }
}
