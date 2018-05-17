using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Focusinc
{
    public partial class assetForm : Form
    {
        MySqlConnection conn;
        public static menuForm fromAsset { get; set; }

        public assetForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=focusinc; uid = root; pwd = root");
        }
        
        private void assetForm_Load(object sender, EventArgs e)
        {
            assetTimer.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();

            loadEmployee();
        }

        private void assetTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();
            assetTimer.Start();
        }

        private void assetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fromAsset.Show();
        }

        private void assetBack_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            fromAsset.Show();
        }

        public void loadEmployee()
        {
            AutoCompleteStringCollection accountsCollection = new AutoCompleteStringCollection();

            conn.Open();

            String getAccount = "SELECT FIRSTNAME, LASTNAME FROM PERSON WHERE (FIRSTNAME LIKE '%" + empName.Text + "%' OR LASTNAME LIKE '%" + empName.Text + "%')";
            MySqlCommand comm = new MySqlCommand(getAccount, conn);
            comm.CommandText = getAccount;
            MySqlDataReader drd = comm.ExecuteReader();

            if (drd.HasRows == true)
            {
                while (drd.Read())
                    accountsCollection.Add(drd["FIRSTNAME"].ToString() + " " + drd["LASTNAME"].ToString());
            }

            drd.Close();
            conn.Close();

            empName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            empName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            empName.AutoCompleteCustomSource = accountsCollection;
        }

        private void searchEmployeeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
