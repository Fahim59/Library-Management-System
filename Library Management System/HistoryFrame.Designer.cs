namespace Library_Management_System
{
    partial class HistoryFrame
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
            this.delBtn = new System.Windows.Forms.Button();
            this.emailBtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hsTable = new System.Windows.Forms.DataGridView();
            this.dgvloanid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstudentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvduedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvreturndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.rdatetxt = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.ddatetxt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.finetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sidtxt = new System.Windows.Forms.TextBox();
            this.bnametxt = new System.Windows.Forms.TextBox();
            this.lidtxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hsTable)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.emailBtn);
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
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(171, 8);
            this.delBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 27);
            this.delBtn.TabIndex = 13;
            this.delBtn.TabStop = false;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // emailBtn
            // 
            this.emailBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBtn.Location = new System.Drawing.Point(525, 8);
            this.emailBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(75, 27);
            this.emailBtn.TabIndex = 12;
            this.emailBtn.TabStop = false;
            this.emailBtn.Text = "Email";
            this.emailBtn.UseVisualStyleBackColor = true;
            this.emailBtn.Click += new System.EventHandler(this.emailBtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(252, 8);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(186, 26);
            this.searchtxt.TabIndex = 11;
            this.searchtxt.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(444, 8);
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
            this.refreshBtn.Location = new System.Drawing.Point(89, 8);
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
            this.newBtn.Location = new System.Drawing.Point(6, 8);
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
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(617, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 44);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "<< Issued Book History >> ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.hsTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 445);
            this.panel3.TabIndex = 2;
            // 
            // hsTable
            // 
            this.hsTable.AllowUserToAddRows = false;
            this.hsTable.AllowUserToDeleteRows = false;
            this.hsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvloanid,
            this.dgvbookname,
            this.dgvstudentid,
            this.dgvduedate,
            this.dgvreturndate});
            this.hsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hsTable.Location = new System.Drawing.Point(0, 0);
            this.hsTable.Name = "hsTable";
            this.hsTable.ReadOnly = true;
            this.hsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hsTable.Size = new System.Drawing.Size(606, 443);
            this.hsTable.TabIndex = 0;
            this.hsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hsTable_CellClick);
            // 
            // dgvloanid
            // 
            this.dgvloanid.DataPropertyName = "loanId";
            this.dgvloanid.HeaderText = "Loan ID";
            this.dgvloanid.Name = "dgvloanid";
            this.dgvloanid.ReadOnly = true;
            this.dgvloanid.Width = 90;
            // 
            // dgvbookname
            // 
            this.dgvbookname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvbookname.DataPropertyName = "bookName";
            this.dgvbookname.HeaderText = "Book Name";
            this.dgvbookname.Name = "dgvbookname";
            this.dgvbookname.ReadOnly = true;
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
            this.dgvduedate.DataPropertyName = "dueDate";
            this.dgvduedate.HeaderText = "Due Date";
            this.dgvduedate.Name = "dgvduedate";
            this.dgvduedate.ReadOnly = true;
            // 
            // dgvreturndate
            // 
            this.dgvreturndate.DataPropertyName = "returnDate";
            this.dgvreturndate.HeaderText = "Return Date";
            this.dgvreturndate.Name = "dgvreturndate";
            this.dgvreturndate.ReadOnly = true;
            this.dgvreturndate.Width = 120;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.exportBtn);
            this.panel4.Controls.Add(this.rdatetxt);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.logoutBtn);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Controls.Add(this.ddatetxt);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.finetxt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.sidtxt);
            this.panel4.Controls.Add(this.bnametxt);
            this.panel4.Controls.Add(this.lidtxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(617, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 445);
            this.panel4.TabIndex = 3;
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.Location = new System.Drawing.Point(20, 409);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 26);
            this.exportBtn.TabIndex = 124;
            this.exportBtn.TabStop = false;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // rdatetxt
            // 
            this.rdatetxt.CalendarFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdatetxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdatetxt.Location = new System.Drawing.Point(113, 148);
            this.rdatetxt.Name = "rdatetxt";
            this.rdatetxt.Size = new System.Drawing.Size(171, 26);
            this.rdatetxt.TabIndex = 123;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.ezgif_com_gif_maker__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(206, 409);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 26);
            this.logoutBtn.TabIndex = 93;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(113, 409);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 26);
            this.backBtn.TabIndex = 92;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ddatetxt
            // 
            this.ddatetxt.CalendarFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddatetxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddatetxt.Location = new System.Drawing.Point(113, 114);
            this.ddatetxt.Name = "ddatetxt";
            this.ddatetxt.Size = new System.Drawing.Size(171, 26);
            this.ddatetxt.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 86;
            this.label6.Text = "Fine:";
            // 
            // finetxt
            // 
            this.finetxt.CausesValidation = false;
            this.finetxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finetxt.Location = new System.Drawing.Point(113, 180);
            this.finetxt.Name = "finetxt";
            this.finetxt.Size = new System.Drawing.Size(171, 26);
            this.finetxt.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 84;
            this.label4.Text = "Return Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 83;
            this.label1.Text = "Due Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 82;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "Book Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 80;
            this.label5.Text = "Loan ID:";
            // 
            // sidtxt
            // 
            this.sidtxt.CausesValidation = false;
            this.sidtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidtxt.Location = new System.Drawing.Point(113, 80);
            this.sidtxt.Name = "sidtxt";
            this.sidtxt.Size = new System.Drawing.Size(171, 26);
            this.sidtxt.TabIndex = 79;
            // 
            // bnametxt
            // 
            this.bnametxt.CausesValidation = false;
            this.bnametxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnametxt.Location = new System.Drawing.Point(113, 46);
            this.bnametxt.Name = "bnametxt";
            this.bnametxt.Size = new System.Drawing.Size(171, 26);
            this.bnametxt.TabIndex = 78;
            // 
            // lidtxt
            // 
            this.lidtxt.CausesValidation = false;
            this.lidtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lidtxt.Location = new System.Drawing.Point(113, 12);
            this.lidtxt.Name = "lidtxt";
            this.lidtxt.Size = new System.Drawing.Size(171, 26);
            this.lidtxt.TabIndex = 77;
            // 
            // HistoryFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(914, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HistoryFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryFrame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HistoryFrame_FormClosed);
            this.Load += new System.EventHandler(this.HistoryFrame_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hsTable)).EndInit();
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
        private System.Windows.Forms.DataGridView hsTable;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.DateTimePicker ddatetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox finetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sidtxt;
        private System.Windows.Forms.TextBox bnametxt;
        private System.Windows.Forms.TextBox lidtxt;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker rdatetxt;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvloanid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvbookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstudentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvduedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvreturndate;
        private System.Windows.Forms.Button emailBtn;
        private System.Windows.Forms.Button delBtn;
    }
}