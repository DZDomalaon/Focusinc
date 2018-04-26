using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Focusinc
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settings.Visible = true;
            settings.Location = new Point(414, 146);
            settings.Size = new Size(1130, 624);
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            accountForm af = new accountForm();
            af.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm back = new Focusinc.loginForm();
            back.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            settings.Location = new Point(450, 620);
            settings.Size = new Size(210, 150);
            settings.Visible = false;
        }

        private void settings_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
