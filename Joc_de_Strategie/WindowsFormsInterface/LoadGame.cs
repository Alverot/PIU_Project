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
    public partial class LoadGame : Form
    {
        public LoadGame()
        {
            InitializeComponent();
            this.Size = new Size(900, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(200, 150);
            this.Font = new Font("Arial", 13, FontStyle.Bold);
            this.ForeColor = Color.DarkCyan;
        }

        private void LoadGame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void BackButton(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
