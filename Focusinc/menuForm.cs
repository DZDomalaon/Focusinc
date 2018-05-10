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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            employeeForm employee = new employeeForm();
            employee.Show();
            employeeForm.fromEmployee = this;
            this.Hide();
        }

        private void accountsBtn_Click(object sender, EventArgs e)
        {
            accountForm account = new accountForm();
            account.Show();
            accountForm.fromAccounts = this;
            this.Hide();
        }

        private void assetsBtn_Click(object sender, EventArgs e)
        {
            assetForm asset = new assetForm();
            asset.Show();
            assetForm.fromAsset = this;
            this.Hide();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            historyForm history = new historyForm();
            history.Show();
            historyForm.fromHistory = this;
            this.Hide();
        }

        private void workstationBtn_Click(object sender, EventArgs e)
        {
            workStationForm workstation = new workStationForm();
            workstation.Show();
            workStationForm.fromWorkstation = this;
            this.Hide();
        }
    }
}
