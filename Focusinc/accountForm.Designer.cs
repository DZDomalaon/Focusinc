namespace Focusinc
{
    partial class accountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.accountsBack_Btn = new System.Windows.Forms.Button();
            this.inactiveRbtn = new System.Windows.Forms.RadioButton();
            this.activeRbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.empList = new System.Windows.Forms.DataGridView();
            this.accountList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNameTxt = new System.Windows.Forms.TextBox();
            this.accountSearch = new System.Windows.Forms.TextBox();
            this.accountCreateBtn = new System.Windows.Forms.Button();
            this.removeEmployee = new System.Windows.Forms.Button();
            this.accountUpdateBtn = new System.Windows.Forms.Button();
            this.accountResetBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.accountsTimer = new System.Windows.Forms.Timer(this.components);
            this.addEmployee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchEmployeeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.accountsBack_Btn);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 42);
            this.panel1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(126, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "A C C O U N T S";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(932, 10);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(107, 22);
            this.dateLabel.TabIndex = 20;
            this.dateLabel.Text = "date today";
            // 
            // accountsBack_Btn
            // 
            this.accountsBack_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.accountsBack_Btn.FlatAppearance.BorderSize = 0;
            this.accountsBack_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountsBack_Btn.Image = global::Focusinc.Properties.Resources.left_arrow;
            this.accountsBack_Btn.Location = new System.Drawing.Point(3, 0);
            this.accountsBack_Btn.Name = "accountsBack_Btn";
            this.accountsBack_Btn.Size = new System.Drawing.Size(63, 42);
            this.accountsBack_Btn.TabIndex = 1;
            this.accountsBack_Btn.UseVisualStyleBackColor = false;
            this.accountsBack_Btn.Click += new System.EventHandler(this.accountsBack_Btn_Click);
            // 
            // inactiveRbtn
            // 
            this.inactiveRbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inactiveRbtn.AutoSize = true;
            this.inactiveRbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactiveRbtn.Location = new System.Drawing.Point(473, 586);
            this.inactiveRbtn.Name = "inactiveRbtn";
            this.inactiveRbtn.Size = new System.Drawing.Size(94, 25);
            this.inactiveRbtn.TabIndex = 8;
            this.inactiveRbtn.TabStop = true;
            this.inactiveRbtn.Text = "Inactive";
            this.inactiveRbtn.UseVisualStyleBackColor = true;
            // 
            // activeRbtn
            // 
            this.activeRbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.activeRbtn.AutoSize = true;
            this.activeRbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeRbtn.Location = new System.Drawing.Point(363, 586);
            this.activeRbtn.Name = "activeRbtn";
            this.activeRbtn.Size = new System.Drawing.Size(81, 25);
            this.activeRbtn.TabIndex = 7;
            this.activeRbtn.TabStop = true;
            this.activeRbtn.Text = "Active";
            this.activeRbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Account Status";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(674, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "M E M B E R S";
            // 
            // empList
            // 
            this.empList.AllowUserToAddRows = false;
            this.empList.AllowUserToDeleteRows = false;
            this.empList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empList.BackgroundColor = System.Drawing.Color.White;
            this.empList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empList.Location = new System.Drawing.Point(666, 3);
            this.empList.Name = "empList";
            this.empList.ReadOnly = true;
            this.empList.RowHeadersVisible = false;
            this.empList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empList.Size = new System.Drawing.Size(657, 425);
            this.empList.TabIndex = 20;
            this.empList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empList_CellClick);
            // 
            // accountList
            // 
            this.accountList.AllowUserToAddRows = false;
            this.accountList.AllowUserToDeleteRows = false;
            this.accountList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountList.BackgroundColor = System.Drawing.Color.White;
            this.accountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountList.Location = new System.Drawing.Point(3, 3);
            this.accountList.Name = "accountList";
            this.accountList.ReadOnly = true;
            this.accountList.RowHeadersVisible = false;
            this.accountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountList.Size = new System.Drawing.Size(657, 425);
            this.accountList.TabIndex = 18;
            this.accountList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountList_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "A C C O U N T S";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.accountList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.empList, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.09678F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 431);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Account Name";
            // 
            // accountNameTxt
            // 
            this.accountNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountNameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.accountNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameTxt.Location = new System.Drawing.Point(16, 583);
            this.accountNameTxt.Name = "accountNameTxt";
            this.accountNameTxt.Size = new System.Drawing.Size(306, 26);
            this.accountNameTxt.TabIndex = 23;
            // 
            // accountSearch
            // 
            this.accountSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.accountSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSearch.Location = new System.Drawing.Point(116, 81);
            this.accountSearch.Name = "accountSearch";
            this.accountSearch.Size = new System.Drawing.Size(306, 26);
            this.accountSearch.TabIndex = 24;
            this.accountSearch.TextChanged += new System.EventHandler(this.accountSearch_TextChanged);
            // 
            // accountCreateBtn
            // 
            this.accountCreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountCreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(182)))), ((int)(((byte)(71)))));
            this.accountCreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(182)))), ((int)(((byte)(71)))));
            this.accountCreateBtn.FlatAppearance.BorderSize = 2;
            this.accountCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountCreateBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountCreateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountCreateBtn.Location = new System.Drawing.Point(105, 629);
            this.accountCreateBtn.Name = "accountCreateBtn";
            this.accountCreateBtn.Size = new System.Drawing.Size(135, 35);
            this.accountCreateBtn.TabIndex = 49;
            this.accountCreateBtn.Text = "Create New";
            this.accountCreateBtn.UseVisualStyleBackColor = false;
            this.accountCreateBtn.Click += new System.EventHandler(this.accountCreateBtn_Click);
            // 
            // removeEmployee
            // 
            this.removeEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(61)))));
            this.removeEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(61)))));
            this.removeEmployee.FlatAppearance.BorderSize = 2;
            this.removeEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEmployee.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeEmployee.Location = new System.Drawing.Point(838, 629);
            this.removeEmployee.Name = "removeEmployee";
            this.removeEmployee.Size = new System.Drawing.Size(154, 35);
            this.removeEmployee.TabIndex = 50;
            this.removeEmployee.Text = "Remove Employee";
            this.removeEmployee.UseVisualStyleBackColor = false;
            this.removeEmployee.Click += new System.EventHandler(this.removeEmployee_Click);
            // 
            // accountUpdateBtn
            // 
            this.accountUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(127)))), ((int)(((byte)(35)))));
            this.accountUpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(127)))), ((int)(((byte)(35)))));
            this.accountUpdateBtn.FlatAppearance.BorderSize = 2;
            this.accountUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountUpdateBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountUpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountUpdateBtn.Location = new System.Drawing.Point(246, 629);
            this.accountUpdateBtn.Name = "accountUpdateBtn";
            this.accountUpdateBtn.Size = new System.Drawing.Size(135, 35);
            this.accountUpdateBtn.TabIndex = 50;
            this.accountUpdateBtn.Text = "Update Details";
            this.accountUpdateBtn.UseVisualStyleBackColor = false;
            this.accountUpdateBtn.Click += new System.EventHandler(this.accountUpdateBtn_Click);
            // 
            // accountResetBtn
            // 
            this.accountResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.accountResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.accountResetBtn.FlatAppearance.BorderSize = 2;
            this.accountResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountResetBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.accountResetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountResetBtn.Location = new System.Drawing.Point(387, 629);
            this.accountResetBtn.Name = "accountResetBtn";
            this.accountResetBtn.Size = new System.Drawing.Size(135, 35);
            this.accountResetBtn.TabIndex = 52;
            this.accountResetBtn.Text = "Reset";
            this.accountResetBtn.UseVisualStyleBackColor = false;
            this.accountResetBtn.Click += new System.EventHandler(this.employeeResetBtn_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(131, 561);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 53;
            this.label14.Text = "*";
            // 
            // accountsTimer
            // 
            this.accountsTimer.Tick += new System.EventHandler(this.accountsTimer_Tick);
            // 
            // addEmployee
            // 
            this.addEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(182)))), ((int)(((byte)(71)))));
            this.addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(182)))), ((int)(((byte)(71)))));
            this.addEmployee.FlatAppearance.BorderSize = 2;
            this.addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee.Location = new System.Drawing.Point(678, 629);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(154, 35);
            this.addEmployee.TabIndex = 49;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = false;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(674, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Account Name";
            // 
            // searchEmployeeTxt
            // 
            this.searchEmployeeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchEmployeeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.searchEmployeeTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeTxt.Location = new System.Drawing.Point(678, 587);
            this.searchEmployeeTxt.Name = "searchEmployeeTxt";
            this.searchEmployeeTxt.Size = new System.Drawing.Size(314, 27);
            this.searchEmployeeTxt.TabIndex = 55;            
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(157)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "SEARCH:";
            // 
            // empSearch
            // 
            this.empSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.empSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSearch.Location = new System.Drawing.Point(777, 82);
            this.empSearch.Name = "empSearch";
            this.empSearch.Size = new System.Drawing.Size(306, 26);
            this.empSearch.TabIndex = 24;
            this.empSearch.TextChanged += new System.EventHandler(this.empSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(157)))), ((int)(((byte)(212)))));
            this.label7.Location = new System.Drawing.Point(673, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "SEARCH:";
            // 
            // accountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchEmployeeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.accountResetBtn);
            this.Controls.Add(this.accountUpdateBtn);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.removeEmployee);
            this.Controls.Add(this.empSearch);
            this.Controls.Add(this.accountCreateBtn);
            this.Controls.Add(this.accountSearch);
            this.Controls.Add(this.accountNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inactiveRbtn);
            this.Controls.Add(this.activeRbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "accountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.accountForm_FormClosing);
            this.Load += new System.EventHandler(this.accountForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button accountsBack_Btn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.RadioButton inactiveRbtn;
        private System.Windows.Forms.RadioButton activeRbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView empList;
        private System.Windows.Forms.DataGridView accountList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountNameTxt;
        private System.Windows.Forms.TextBox accountSearch;
        private System.Windows.Forms.Button accountCreateBtn;
        private System.Windows.Forms.Button removeEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button accountUpdateBtn;
        private System.Windows.Forms.Button accountResetBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer accountsTimer;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchEmployeeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empSearch;
        private System.Windows.Forms.Label label7;
    }
}