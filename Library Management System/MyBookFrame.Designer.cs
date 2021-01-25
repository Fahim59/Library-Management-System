namespace Library_Management_System
{
    partial class MyBookFrame
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mbTable = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdatetxt = new System.Windows.Forms.DateTimePicker();
            this.finetxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ddatetxt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.idatetxt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.sidtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lidtxt = new System.Windows.Forms.TextBox();
            this.bnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvloanid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstudentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvduedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvreturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mbTable)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.newBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 44);
            this.panel1.TabIndex = 0;
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(294, 8);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(215, 26);
            this.searchtxt.TabIndex = 11;
            this.searchtxt.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(522, 8);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 27);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.TabStop = false;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(180, 8);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 27);
            this.refreshBtn.TabIndex = 9;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(69, 8);
            this.newBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 27);
            this.newBtn.TabIndex = 7;
            this.newBtn.TabStop = false;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.returnBtn);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(617, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 44);
            this.panel2.TabIndex = 1;
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(13, 9);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(75, 26);
            this.returnBtn.TabIndex = 7;
            this.returnBtn.TabStop = false;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(109, 9);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 26);
            this.backBtn.TabIndex = 116;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(205, 9);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 26);
            this.logoutBtn.TabIndex = 117;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.mbTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 455);
            this.panel3.TabIndex = 2;
            // 
            // mbTable
            // 
            this.mbTable.AllowUserToAddRows = false;
            this.mbTable.AllowUserToDeleteRows = false;
            this.mbTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mbTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvloanid,
            this.dgvstudentid,
            this.dgvduedate,
            this.dgvreturnDate});
            this.mbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbTable.Location = new System.Drawing.Point(0, 0);
            this.mbTable.Name = "mbTable";
            this.mbTable.ReadOnly = true;
            this.mbTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mbTable.Size = new System.Drawing.Size(606, 453);
            this.mbTable.TabIndex = 0;
            this.mbTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mbTable_CellClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.rdatetxt);
            this.panel4.Controls.Add(this.finetxt);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.ddatetxt);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.idatetxt);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.sidtxt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lidtxt);
            this.panel4.Controls.Add(this.bnametxt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(617, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 455);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.Return_Books;
            this.pictureBox1.Location = new System.Drawing.Point(52, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // rdatetxt
            // 
            this.rdatetxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdatetxt.Location = new System.Drawing.Point(104, 150);
            this.rdatetxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdatetxt.Name = "rdatetxt";
            this.rdatetxt.Size = new System.Drawing.Size(181, 25);
            this.rdatetxt.TabIndex = 118;
            // 
            // finetxt
            // 
            this.finetxt.Enabled = false;
            this.finetxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finetxt.Location = new System.Drawing.Point(104, 179);
            this.finetxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.finetxt.Name = "finetxt";
            this.finetxt.Size = new System.Drawing.Size(181, 25);
            this.finetxt.TabIndex = 115;
            this.finetxt.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 114;
            this.label9.Text = "Fine:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 112;
            this.label8.Text = "Return Date:";
            // 
            // ddatetxt
            // 
            this.ddatetxt.Enabled = false;
            this.ddatetxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddatetxt.Location = new System.Drawing.Point(104, 121);
            this.ddatetxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ddatetxt.Name = "ddatetxt";
            this.ddatetxt.Size = new System.Drawing.Size(181, 25);
            this.ddatetxt.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 108;
            this.label6.Text = "Due Date:";
            // 
            // idatetxt
            // 
            this.idatetxt.Enabled = false;
            this.idatetxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.idatetxt.Location = new System.Drawing.Point(104, 92);
            this.idatetxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idatetxt.Name = "idatetxt";
            this.idatetxt.Size = new System.Drawing.Size(181, 25);
            this.idatetxt.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "Issue Date:";
            // 
            // sidtxt
            // 
            this.sidtxt.Enabled = false;
            this.sidtxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidtxt.Location = new System.Drawing.Point(104, 63);
            this.sidtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sidtxt.Name = "sidtxt";
            this.sidtxt.Size = new System.Drawing.Size(181, 25);
            this.sidtxt.TabIndex = 105;
            this.sidtxt.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 104;
            this.label4.Text = "Student ID:";
            // 
            // lidtxt
            // 
            this.lidtxt.Enabled = false;
            this.lidtxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lidtxt.Location = new System.Drawing.Point(104, 5);
            this.lidtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lidtxt.Name = "lidtxt";
            this.lidtxt.Size = new System.Drawing.Size(181, 25);
            this.lidtxt.TabIndex = 103;
            this.lidtxt.TabStop = false;
            // 
            // bnametxt
            // 
            this.bnametxt.Enabled = false;
            this.bnametxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnametxt.Location = new System.Drawing.Point(104, 34);
            this.bnametxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bnametxt.Name = "bnametxt";
            this.bnametxt.Size = new System.Drawing.Size(181, 25);
            this.bnametxt.TabIndex = 101;
            this.bnametxt.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 100;
            this.label2.Text = "Book Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Loan ID:";
            // 
            // dgvloanid
            // 
            this.dgvloanid.DataPropertyName = "loanId";
            this.dgvloanid.HeaderText = "Loan ID";
            this.dgvloanid.Name = "dgvloanid";
            this.dgvloanid.ReadOnly = true;
            this.dgvloanid.Width = 90;
            // 
            // dgvstudentid
            // 
            this.dgvstudentid.DataPropertyName = "studentId";
            this.dgvstudentid.HeaderText = "Student ID";
            this.dgvstudentid.Name = "dgvstudentid";
            this.dgvstudentid.ReadOnly = true;
            this.dgvstudentid.Width = 110;
            // 
            // dgvduedate
            // 
            this.dgvduedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvduedate.DataPropertyName = "dueDate";
            this.dgvduedate.HeaderText = "Due Date";
            this.dgvduedate.Name = "dgvduedate";
            this.dgvduedate.ReadOnly = true;
            // 
            // dgvreturnDate
            // 
            this.dgvreturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvreturnDate.DataPropertyName = "returnDate";
            this.dgvreturnDate.HeaderText = "Return Date";
            this.dgvreturnDate.Name = "dgvreturnDate";
            this.dgvreturnDate.ReadOnly = true;
            // 
            // MyBookFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(914, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyBookFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBookFrame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyBookFrame_FormClosed);
            this.Load += new System.EventHandler(this.MyBookFrame_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mbTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView mbTable;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox finetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ddatetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker idatetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sidtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lidtxt;
        private System.Windows.Forms.TextBox bnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker rdatetxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvloanid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstudentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvduedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvreturnDate;
    }
}