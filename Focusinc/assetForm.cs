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
    public partial class assetForm : Form
    {
        public assetForm()
        {
            InitializeComponent();
        }
        public static menuForm fromAsset { get; set; }
        private void assetForm_Load(object sender, EventArgs e)
        {
            assetTimer.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            fromAsset.Show();
        }

        private void assetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fromAsset.Show();
        }

        private void assetTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();
            assetTimer.Start();
        }
    }
}
