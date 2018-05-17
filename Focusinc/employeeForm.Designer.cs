namespace Focusinc
{
    partial class employeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeBack_Btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeAddBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.benchRdn = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.ResignedRdn = new System.Windows.Forms.RadioButton();
            this.EmployedRdn = new System.Windows.Forms.RadioButton();
            this.employeeUpdateBtn = new System.Windows.Forms.Button();
            this.tempRdn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.accountTxt = new System.Windows.Forms.TextBox();
            this.skypeTxt = new System.Windows.Forms.TextBox();
            this.gmailTxt = new System.Windows.Forms.TextBox();
            this.positionTxt = new System.Windows.Forms.TextBox();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.employeeResetBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.employeeList = new System.Windows.Forms.DataGridView();
            this.searchEmployeeTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.employeeBack_Btn);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 42);
            this.panel1.TabIndex = 0;
            // 
            // employeeBack_Btn
            // 
            this.employeeBack_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.employeeBack_Btn.FlatAppearance.BorderSize = 0;
            this.employeeBack_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeBack_Btn.Image = global::Focusinc.Properties.Resources.left_arrow;
            this.employeeBack_Btn.Location = new System.Drawing.Point(5, 0);
            this.employeeBack_Btn.Name = "employeeBack_Btn";
            this.employeeBack_Btn.Size = new System.Drawing.Size(63, 42);
            this.employeeBack_Btn.TabIndex = 4;
            this.employeeBack_Btn.UseVisualStyleBackColor = false;
            this.employeeBack_Btn.Click += new System.EventHandler(this.employeeBack_Btn_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(96, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "E M P L O Y E E S";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(932, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(107, 22);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "date today";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2095, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Today";
            // 
            // employeeAddBtn
            // 
            this.employeeAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(182)))), ((int)(((byte)(71)))));
            this.employeeAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(182)))), ((int)(((byte)(71)))));
            this.employeeAddBtn.FlatAppearance.BorderSize = 2;
            this.employeeAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeAddBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeAddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeAddBtn.Location = new System.Drawing.Point(43, 617);
            this.employeeAddBtn.Name = "employeeAddBtn";
            this.employeeAddBtn.Size = new System.Drawing.Size(123, 35);
            this.employeeAddBtn.TabIndex = 11;
            this.employeeAddBtn.Text = "Add Employee";
            this.employeeAddBtn.UseVisualStyleBackColor = false;
            this.employeeAddBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 1314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 1314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gmail Account";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 1374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Skype Account";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(597, 1314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "First Name";
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Account Name";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Position";
            // 
            // benchRdn
            // 
            this.benchRdn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.benchRdn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.benchRdn.AutoSize = true;
            this.benchRdn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benchRdn.Location = new System.Drawing.Point(189, 258);
            this.benchRdn.Name = "benchRdn";
            this.benchRdn.Size = new System.Drawing.Size(74, 24);
            this.benchRdn.TabIndex = 5;
            this.benchRdn.TabStop = true;
            this.benchRdn.Text = "Bench";
            this.benchRdn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "Status";
            // 
            // ResignedRdn
            // 
            this.ResignedRdn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ResignedRdn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResignedRdn.AutoSize = true;
            this.ResignedRdn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResignedRdn.Location = new System.Drawing.Point(46, 288);
            this.ResignedRdn.Name = "ResignedRdn";
            this.ResignedRdn.Size = new System.Drawing.Size(94, 24);
            this.ResignedRdn.TabIndex = 4;
            this.ResignedRdn.TabStop = true;
            this.ResignedRdn.Text = "Resigned";
            this.ResignedRdn.UseVisualStyleBackColor = true;
            // 
            // EmployedRdn
            // 
            this.EmployedRdn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EmployedRdn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployedRdn.AutoSize = true;
            this.EmployedRdn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployedRdn.Location = new System.Drawing.Point(46, 258);
            this.EmployedRdn.Name = "EmployedRdn";
            this.EmployedRdn.Size = new System.Drawing.Size(99, 24);
            this.EmployedRdn.TabIndex = 3;
            this.EmployedRdn.TabStop = true;
            this.EmployedRdn.Text = "Employed";
            this.EmployedRdn.UseVisualStyleBackColor = true;
            // 
            // employeeUpdateBtn
            // 
            this.employeeUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(127)))), ((int)(((byte)(35)))));
            this.employeeUpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(127)))), ((int)(((byte)(35)))));
            this.employeeUpdateBtn.FlatAppearance.BorderSize = 2;
            this.employeeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeUpdateBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeUpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeUpdateBtn.Location = new System.Drawing.Point(179, 617);
            this.employeeUpdateBtn.Name = "employeeUpdateBtn";
            this.employeeUpdateBtn.Size = new System.Drawing.Size(123, 35);
            this.employeeUpdateBtn.TabIndex = 12;
            this.employeeUpdateBtn.Text = "Update Details";
            this.employeeUpdateBtn.UseVisualStyleBackColor = false;
            this.employeeUpdateBtn.Click += new System.EventHandler(this.employeeUpdateBtn_Click);
            // 
            // tempRdn
            // 
            this.tempRdn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tempRdn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tempRdn.AutoSize = true;
            this.tempRdn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempRdn.Location = new System.Drawing.Point(189, 288);
            this.tempRdn.Name = "tempRdn";
            this.tempRdn.Size = new System.Drawing.Size(103, 24);
            this.tempRdn.TabIndex = 6;
            this.tempRdn.TabStop = true;
            this.tempRdn.Text = "Temporary";
            this.tempRdn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Skype ID";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Gmail ";
            // 
            // accountTxt
            // 
            this.accountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.accountTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTxt.Location = new System.Drawing.Point(43, 420);
            this.accountTxt.Name = "accountTxt";
            this.accountTxt.Size = new System.Drawing.Size(259, 27);
            this.accountTxt.TabIndex = 8;
            // 
            // skypeTxt
            // 
            this.skypeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skypeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.skypeTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skypeTxt.Location = new System.Drawing.Point(43, 485);
            this.skypeTxt.Name = "skypeTxt";
            this.skypeTxt.Size = new System.Drawing.Size(259, 27);
            this.skypeTxt.TabIndex = 9;
            // 
            // gmailTxt
            // 
            this.gmailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gmailTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.gmailTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmailTxt.Location = new System.Drawing.Point(43, 547);
            this.gmailTxt.Name = "gmailTxt";
            this.gmailTxt.Size = new System.Drawing.Size(259, 27);
            this.gmailTxt.TabIndex = 10;
            // 
            // positionTxt
            // 
            this.positionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.positionTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.positionTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionTxt.Location = new System.Drawing.Point(43, 358);
            this.positionTxt.Name = "positionTxt";
            this.positionTxt.Size = new System.Drawing.Size(259, 27);
            this.positionTxt.TabIndex = 7;
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastnameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lastnameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxt.Location = new System.Drawing.Point(43, 194);
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(259, 27);
            this.lastnameTxt.TabIndex = 2;
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.firstnameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.firstnameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxt.Location = new System.Drawing.Point(43, 135);
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(259, 27);
            this.firstnameTxt.TabIndex = 1;
            // 
            // employeeResetBtn
            // 
            this.employeeResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.employeeResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.employeeResetBtn.FlatAppearance.BorderSize = 2;
            this.employeeResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeResetBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeResetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeResetBtn.Location = new System.Drawing.Point(110, 665);
            this.employeeResetBtn.Name = "employeeResetBtn";
            this.employeeResetBtn.Size = new System.Drawing.Size(123, 35);
            this.employeeResetBtn.TabIndex = 13;
            this.employeeResetBtn.Text = "Reset";
            this.employeeResetBtn.UseVisualStyleBackColor = false;
            this.employeeResetBtn.Click += new System.EventHandler(this.employeeResetBtn_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(118, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(119, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = "*";
            // 
            // employeeList
            // 
            this.employeeList.AllowUserToAddRows = false;
            this.employeeList.AllowUserToDeleteRows = false;
            this.employeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeList.BackgroundColor = System.Drawing.Color.White;
            this.employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeList.Location = new System.Drawing.Point(360, 114);
            this.employeeList.Name = "employeeList";
            this.employeeList.ReadOnly = true;
            this.employeeList.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeList.Size = new System.Drawing.Size(943, 586);
            this.employeeList.TabIndex = 22;
            this.employeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeList_CellClick);
            // 
            // searchEmployeeTxt
            // 
            this.searchEmployeeTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchEmployeeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.searchEmployeeTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeTxt.Location = new System.Drawing.Point(453, 65);
            this.searchEmployeeTxt.Name = "searchEmployeeTxt";
            this.searchEmployeeTxt.Size = new System.Drawing.Size(363, 27);
            this.searchEmployeeTxt.TabIndex = 43;
            this.searchEmployeeTxt.TextChanged += new System.EventHandler(this.searchEmployeeTxt_TextChanged);
            // 
            // label16
            // 
            this.label16.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(157)))), ((int)(((byte)(212)))));
            this.label16.Location = new System.Drawing.Point(355, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 25);
            this.label16.TabIndex = 18;
            this.label16.Text = "SEARCH:";
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.searchEmployeeTxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.firstnameTxt);
            this.Controls.Add(this.lastnameTxt);
            this.Controls.Add(this.positionTxt);
            this.Controls.Add(this.gmailTxt);
            this.Controls.Add(this.skypeTxt);
            this.Controls.Add(this.accountTxt);
            this.Controls.Add(this.tempRdn);
            this.Controls.Add(this.benchRdn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ResignedRdn);
            this.Controls.Add(this.EmployedRdn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeResetBtn);
            this.Controls.Add(this.employeeUpdateBtn);
            this.Controls.Add(this.employeeAddBtn);
            this.Controls.Add(this.panel1);
            this.Name = "employeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.employeeForm_FormClosing);
            this.Load += new System.EventHandler(this.employeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button employeeAddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button employeeBack_Btn;
        private System.Windows.Forms.RadioButton benchRdn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton ResignedRdn;
        private System.Windows.Forms.RadioButton EmployedRdn;
        private System.Windows.Forms.Button employeeUpdateBtn;
        private System.Windows.Forms.RadioButton tempRdn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox accountTxt;
        private System.Windows.Forms.TextBox skypeTxt;
        private System.Windows.Forms.TextBox gmailTxt;
        private System.Windows.Forms.TextBox positionTxt;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.TextBox firstnameTxt;
        private System.Windows.Forms.Button employeeResetBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView employeeList;
        private System.Windows.Forms.TextBox searchEmployeeTxt;
        private System.Windows.Forms.Label label16;
    }
}