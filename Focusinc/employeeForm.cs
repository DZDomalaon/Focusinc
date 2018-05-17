using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Focusinc
{
    public partial class employeeForm : Form
    {
        public static menuForm fromEmployee { get; set; }
        MySqlConnection conn;

        public employeeForm()
        {
            conn = new MySqlConnection("SERVER=localhost; DATABASE=focusinc; uid = root; pwd = root");
            InitializeComponent();
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();

            loadAccounts();
            loadEmployee();

            employeeUpdateBtn.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString() + "      " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void employeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fromEmployee.Show();
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            int getAccount = 0;
            int accountID = 0;

            if (firstnameTxt.Text == "" || lastnameTxt.Text == "")
            {
                MessageBox.Show("Please fill in all the required field/s");
            }
            else
            {
                if (MessageBox.Show("Do you want to add this employee?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string status = " ";

                    if (EmployedRdn.Checked == true)
                    {
                        status = "Employed";
                    }
                    else if (ResignedRdn.Checked == true)
                    {
                        status = "Resigned";
                    }
                    else if (benchRdn.Checked == true)
                    {
                        status = "Bench";
                    }
                    else if (tempRdn.Checked == true)
                    {
                        status = "Temporary";
                    }

                    conn.Open();
                    MySqlCommand getAccountID = new MySqlCommand("SELECT ACCOUNT_ID FROM ACCOUNTS WHERE ACCOUNT_NAME = '" + accountTxt.Text + "'", conn);
                    getAccount = Convert.ToInt32(getAccountID.ExecuteScalar());
                    accountID = getAccount;

                    string query = "INSERT INTO PERSON(FIRSTNAME, LASTNAME, POSITION, STATUS, SKYPE_ACC, GMAIL_ACC, PERSON_ACCOUNT_ID)" +
                                   "VALUES ('" + firstnameTxt.Text + "','" + lastnameTxt.Text + "','" + positionTxt.Text + "','" + status + "','" + skypeTxt.Text + "','" + gmailTxt.Text + "', '" + accountID + "')";
                    
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();

                    loadEmployee();

                    firstnameTxt.Text = "";
                    lastnameTxt.Text = "";
                    EmployedRdn.Checked = false;
                    ResignedRdn.Checked = false;
                    benchRdn.Checked = false;
                    tempRdn.Checked = false;
                    positionTxt.Text = "";
                    accountTxt.Text = "";
                    skypeTxt.Text = "";
                    gmailTxt.Text = "";
                }
            }
        }
        private void employeeUpdateBtn_Click(object sender, EventArgs e)
        {
            string status = " ";

            if (EmployedRdn.Checked == true)
            {
                status = "Employed";
            }
            else if (ResignedRdn.Checked == true)
            {
                status = "Resigned";
            }
            else if (benchRdn.Checked == true)
            {
                status = "Bench";
            }
            else if (tempRdn.Checked == true)
            {
                status = "Temporary";
            }

            if (MessageBox.Show("Do you want to update the data?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();

                String updateEmployee = "UPDATE PERSON, ACCOUNTS SET FIRSTNAME = '" + firstnameTxt.Text + "', LASTNAME = '" + lastnameTxt.Text + "', POSITION = '" + positionTxt.Text + "', STATUS = '" + status + "', ACCOUNT_NAME ='" + accountTxt.Text + "', SKYPE_ACC = '" + skypeTxt.Text + "', GMAIL_ACC = '" + gmailTxt.Text + "' WHERE PERSON_ID = '" + selected_emp_id +"' AND ACCOUNT_ID = PERSON_ACCOUNT_ID";
                MySqlCommand comm = new MySqlCommand(updateEmployee, conn);
                comm.ExecuteNonQuery();

                conn.Close();
            }
            MessageBox.Show("Customer data has been updated successfully", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadEmployee();
        }

        private void employeeBack_Btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            fromEmployee.Show();
        }

        public void loadAccounts()
        {
            AutoCompleteStringCollection accountsCollection = new AutoCompleteStringCollection();

            conn.Open();

            String getAccount = "SELECT ACCOUNT_NAME FROM ACCOUNTS";
            MySqlCommand comm = new MySqlCommand(getAccount, conn);
            comm.CommandText = getAccount;
            MySqlDataReader drd = comm.ExecuteReader();

            if (drd.HasRows == true)
            {
                while (drd.Read())
                    accountsCollection.Add(drd["ACCOUNT_NAME"].ToString());
            }

            drd.Close();
            conn.Close();

            accountTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            accountTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            accountTxt.AutoCompleteCustomSource = accountsCollection;
        }

        public void searchEmployee()
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
        
        //try
        public void loadSearch()
        {
            String query = "SELECT PERSON_ID, FIRSTNAME, LASTNAME, STATUS, POSITION, ACCOUNT_NAME, SKYPE_ACC, GMAIL_ACC FROM PERSON, ACCOUNTS WHERE ACCOUNT_ID = PERSON_ACCOUNT_ID and (FIRSTNAME LIKE '%"+searchEmployeeTxt.Text+ "%' OR LASTNAME LIKE '%" + searchEmployeeTxt.Text + "%')";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            employeeList.DataSource = dt;

            employeeList.Columns["PERSON_ID"].Visible = false;
            employeeList.Columns["FIRSTNAME"].HeaderText = "Firstname";
            employeeList.Columns["LASTNAME"].HeaderText = "Lastname";
            employeeList.Columns["STATUS"].HeaderText = "Status";
            employeeList.Columns["POSITION"].HeaderText = "Position";
            employeeList.Columns["ACCOUNT_NAME"].HeaderText = "Account";
            employeeList.Columns["SKYPE_ACC"].HeaderText = "Skype ID";
            employeeList.Columns["GMAIL_ACC"].HeaderText = "Gmail";
        }

        //try

        public void loadEmployee()
        {
            String query = "SELECT PERSON_ID, FIRSTNAME, LASTNAME, STATUS, POSITION, ACCOUNT_NAME, SKYPE_ACC, GMAIL_ACC FROM PERSON, ACCOUNTS WHERE ACCOUNT_ID = PERSON_ACCOUNT_ID";
           
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            employeeList.DataSource = dt;

            employeeList.Columns["PERSON_ID"].Visible = false;
            employeeList.Columns["FIRSTNAME"].HeaderText = "Firstname";
            employeeList.Columns["LASTNAME"].HeaderText = "Lastname";
            employeeList.Columns["STATUS"].HeaderText = "Status";
            employeeList.Columns["POSITION"].HeaderText = "Position";
            employeeList.Columns["ACCOUNT_NAME"].HeaderText = "Account";
            employeeList.Columns["SKYPE_ACC"].HeaderText = "Skype ID";
            employeeList.Columns["GMAIL_ACC"].HeaderText = "Gmail";
        }

        public int selected_emp_id;
        private void employeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeAddBtn.Enabled = false;
            employeeUpdateBtn.Enabled = true;
            if (e.RowIndex > -1)
            {
                selected_emp_id = int.Parse(employeeList.Rows[e.RowIndex].Cells["PERSON_ID"].Value.ToString());
                firstnameTxt.Text = employeeList.Rows[e.RowIndex].Cells["FIRSTNAME"].Value.ToString();
                lastnameTxt.Text = employeeList.Rows[e.RowIndex].Cells["LASTNAME"].Value.ToString();
                positionTxt.Text = employeeList.Rows[e.RowIndex].Cells["POSITION"].Value.ToString();
                accountTxt.Text = employeeList.Rows[e.RowIndex].Cells["ACCOUNT_NAME"].Value.ToString();
                skypeTxt.Text = employeeList.Rows[e.RowIndex].Cells["SKYPE_ACC"].Value.ToString();
                gmailTxt.Text = employeeList.Rows[e.RowIndex].Cells["GMAIL_ACC"].Value.ToString();
                string stat = employeeList.Rows[e.RowIndex].Cells["STATUS"].Value.ToString();
                if (stat == "Employed")
                {
                    EmployedRdn.Checked = true;                    
                }
                else if (stat == "Resigned")
                {
                    ResignedRdn.Checked = true;                    
                }
                else if (stat == "Bench")
                {
                    benchRdn.Checked = true;                    
                }
                else if (stat == "Temporary")
                {
                    tempRdn.Checked = true;                    
                }
            }
        }

        private void searchEmployeeTxt_TextChanged(object sender, EventArgs e)
        {
            loadSearch();
        }

        private void employeeResetBtn_Click(object sender, EventArgs e)
        {
            employeeAddBtn.Enabled = true;
            employeeUpdateBtn.Enabled = false;

            firstnameTxt.Clear();
            lastnameTxt.Clear();
            EmployedRdn.Checked = false;
            benchRdn.Checked = false;
            ResignedRdn.Checked = false;
            tempRdn.Checked = false;
            accountTxt.Clear();            
            positionTxt.Clear();
            skypeTxt.Clear();
            gmailTxt.Clear();
        }
    }
}
