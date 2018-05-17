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
using Microsoft.VisualBasic;


namespace Focusinc
{
    public partial class accountForm : Form
    {
        public static menuForm fromAccounts { get; set; }
        MySqlConnection conn;

        public accountForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=focusinc; uid = root; pwd = root");
        }       

        private void accountForm_Load(object sender, EventArgs e)
        {
            accountsTimer.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();            

            loadAccounts();
            empSearch2();
            accountUpdateBtn.Enabled = false;
        }

        private void accountsTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();
            accountsTimer.Start();
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

        public void loadAccounts()
        {
            String query = "SELECT * FROM ACCOUNTS";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            accountList.DataSource = dt;
            
            accountList.Columns["ACCOUNT_ID"].Visible = false;
            accountList.Columns["ACCOUNT_NAME"].HeaderText = "ACCOUNT";
            accountList.Columns["ACCOUNT_STATUS"].HeaderText = "STATUS";
        }

        public static int selected_account_id;
        public static string account_name;
        private void accountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            accountCreateBtn.Enabled = false;
            accountUpdateBtn.Enabled = true;
            if (e.RowIndex > -1)
            {
                selected_account_id = int.Parse(accountList.Rows[e.RowIndex].Cells["ACCOUNT_ID"].Value.ToString());
                accountNameTxt.Text = accountList.Rows[e.RowIndex].Cells["ACCOUNT_NAME"].Value.ToString();
                account_name = accountList.Rows[e.RowIndex].Cells["ACCOUNT_NAME"].Value.ToString();
                string stat = accountList.Rows[e.RowIndex].Cells["ACCOUNT_STATUS"].Value.ToString();
                if (stat == "ACTIVE")
                {
                    activeRbtn.Checked = true;
                    inactiveRbtn.Checked = false;
                }
                else
                {
                    activeRbtn.Checked = false;
                    inactiveRbtn.Checked = true;                    
                }

                employeeFromAccount();
            }
        }

        public void employeeFromAccount()
        {
            String query = "SELECT PERSON_ID, FIRSTNAME, LASTNAME, STATUS FROM PERSON WHERE PERSON_ACCOUNT_ID = '" + selected_account_id + "'";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            empList.DataSource = dt;

            empList.Columns["PERSON_ID"].Visible = false;
            empList.Columns["FIRSTNAME"].HeaderText = "FIRSTNAME";
            empList.Columns["LASTNAME"].HeaderText = "LASTNAME";
            empList.Columns["STATUS"].HeaderText = "Status";
        }

        private void employeeResetBtn_Click(object sender, EventArgs e)
        {
            accountCreateBtn.Enabled = true;
            accountUpdateBtn.Enabled = false;

            accountNameTxt.Clear();
            activeRbtn.Checked = false;
            inactiveRbtn.Checked = false;
        }

        private void accountCreateBtn_Click(object sender, EventArgs e)
        {
            if(accountNameTxt.Text == "")
            {
                MessageBox.Show("Please fill in all the required field/s");
            }
            else
            {
                if (MessageBox.Show("Do you want to add this account?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string stat = "";
                    if (activeRbtn.Checked)
                    {
                        stat = "ACTIVE";
                    }
                    else if (inactiveRbtn.Checked)
                    {
                        stat = "INACTIVE";
                    }
                    conn.Open();
                    string query = "INSERT INTO ACCOUNTS(ACCOUNT_NAME, ACCOUNT_STATUS) VALUES('" + accountNameTxt.Text + "', '" + stat + "')";

                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();

                    loadAccounts();

                    accountNameTxt.Clear();
                    activeRbtn.Checked = false;
                    inactiveRbtn.Checked = false;
                }
            }            
        }

        private void accountUpdateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this account?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string stat = "";
                if (activeRbtn.Checked)
                {
                    stat = "ACTIVE";
                }
                else if (inactiveRbtn.Checked)
                {
                    stat = "INACTIVE";
                }
                conn.Open();
                string query = "UPDATE ACCOUNTS SET ACCOUNT_NAME = '" + accountNameTxt.Text + "', ACCOUNT_STATUS  = '" + stat + "' WHERE ACCOUNT_ID = '" + selected_account_id + "'";

                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();

                loadAccounts();
            }
        }

        public static int selected_employee_id;    
        private void empList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_employee_id = int.Parse(empList.Rows[e.RowIndex].Cells["PERSON_ID"].Value.ToString());
        }

        private void removeEmployee_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE PERSON SET PERSON_ACCOUNT_ID = null WHERE PERSON_ID = '" + selected_employee_id + "'";

            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            employeeFromAccount();
        }        

        public void searchAccount()
        {
            string query = "SELECT * FROM ACCOUNTS WHERE ACCOUNT_NAME LIKE '%" + accountSearch.Text + "%'";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            accountList.DataSource = dt;

            accountList.Columns["ACCOUNT_ID"].Visible = false;
            accountList.Columns["ACCOUNT_NAME"].HeaderText = "Account";
            accountList.Columns["ACCOUNT_STATUS"].HeaderText = "Status";
        }

        private void accountSearch_TextChanged(object sender, EventArgs e)
        {
            searchAccount();
        }

        public void searchEmployee()
        {
            String query = "SELECT FIRSTNAME, LASTNAME, STATUS FROM PERSON WHERE PERSON_ACCOUNT_ID = '" + selected_account_id + "' AND (FIRSTNAME LIKE '%" + empSearch.Text + "%' OR LASTNAME LIKE '%" + empSearch.Text + "%')";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            empList.DataSource = dt;

            empList.Columns["FIRSTNAME"].HeaderText = "Firstname";
            empList.Columns["LASTNAME"].HeaderText = "Lastname";
            empList.Columns["STATUS"].HeaderText = "Status";
        }

        private void empSearch_TextChanged(object sender, EventArgs e)
        {
            searchEmployee();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            if(accountList.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select an account first.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(searchEmployeeTxt.Text == "")
                {
                    MessageBox.Show("Please input the name of the employee you add.", "Empty input field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int convertPerAccID = 0;
                    int PerAccID = 0;
                    MySqlCommand selectPerAccID = new MySqlCommand("SELECT COUNT(*) FROM PERSON WHERE PERSON_ACCOUNT_ID = '" + selected_account_id + "'", conn);
                    convertPerAccID = Convert.ToInt32(selectPerAccID.ExecuteScalar());
                    PerAccID = convertPerAccID;

                    if(PerAccID > 0)
                    {
                        MessageBox.Show(searchEmployeeTxt.Text + " is already a member of " + account_name, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "UPDATE PERSON SET PERSON_ACCOUNT_ID  = '" + selected_account_id + "' WHERE CONCAT(FIRSTNAME, ' ', LASTNAME) = '" + searchEmployeeTxt.Text + "'";

                        conn.Open();
                        MySqlCommand comm = new MySqlCommand(query, conn);
                        MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                        conn.Close();
                    }
                } 
            }
        }        

        public void empSearch2()
        {
            AutoCompleteStringCollection employeeCollection = new AutoCompleteStringCollection();

            conn.Open();

            String getEmployee = "SELECT FIRSTNAME, LASTNAME FROM PERSON";
            MySqlCommand comm = new MySqlCommand(getEmployee, conn);
            comm.CommandText = getEmployee;
            MySqlDataReader drd = comm.ExecuteReader();

            if (drd.HasRows == true)
            {
                while (drd.Read())
                    employeeCollection.Add(drd["FIRSTNAME"].ToString() + " " + drd["LASTNAME"].ToString());
            }

            drd.Close();
            conn.Close();

            searchEmployeeTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchEmployeeTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchEmployeeTxt.AutoCompleteCustomSource = employeeCollection;
        }             
    }
}
