﻿using System;
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
    public partial class workStationForm : Form
    {
        public workStationForm()
        {
            InitializeComponent();
        }

        public static menuForm fromWorkstation { get; set; }

        private void workStationForm_Load(object sender, EventArgs e)
        {
            wsTimer.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();            
        }

        private void workStationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fromWorkstation.Show();
        }

        private void workstationBack_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            fromWorkstation.Show();
        }

        private void wsTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();
            wsTimer.Start();
        }
    }
}
