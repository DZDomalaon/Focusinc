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
    public partial class historyForm : Form
    {
        public historyForm()
        {
            InitializeComponent();
        }

        public static menuForm fromHistory { get; set; }

        private void historyForm_Load(object sender, EventArgs e)
        {

        }

        private void historyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fromHistory.Show();
        }
    }
}
