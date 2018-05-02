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
    public partial class accountForm : Form
    {
        public accountForm()
        {
            InitializeComponent();
        }

        public static menuForm fromAccounts { get; set; }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accountForm_Load(object sender, EventArgs e)
        {

        }

        private void accountsBack_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            fromAccounts.Show();
        }

        private void accountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fromAccounts.Show();
        }
    }
}
