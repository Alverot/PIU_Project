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
    public partial class Menu : Form
    {

        //private PictureBox pictureBox1;
        //private OpenFileDialog openFileDialog1;
        public Menu()
        {
            InitializeComponent();
            this.Size = new Size(800, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(200, 150);
            this.Font = new Font("Arial", 15, FontStyle.Bold);
            this.ForeColor = Color.DarkCyan;
            this.Text = "MENU";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var ngame = new NewGame();
            ngame.Closed += (s, args) => this.Close();
            ngame.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LG = new LoadGame();
            LG.Closed += (s, args) => this.Close();
            LG.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var info = new Info();
            info.Closed += (s, args) => this.Close();
            info.Show();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
