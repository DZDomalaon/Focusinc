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
    public partial class employeeForm : Form
    {
        public employeeForm()
        {
            InitializeComponent();
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      "+ DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
