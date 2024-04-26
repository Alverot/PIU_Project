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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
                this.Size = new Size(800, 400);
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(200, 150);
                this.Font = new Font("Arial", 15, FontStyle.Bold);
                this.ForeColor = Color.DarkCyan;
                this.Text = "INFO";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
