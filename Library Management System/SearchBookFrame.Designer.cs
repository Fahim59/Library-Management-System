namespace Library_Management_System
{
    partial class SearchBookFrame
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
            this.cbox = new System.Windows.Forms.ComboBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sbTable = new System.Windows.Forms.DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvauthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvlocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.lbox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.catbox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qntxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbTable)).BeginInit();
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
            this.panel1.Controls.Add(this.cbox);
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
            // cbox
            // 
            this.cbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox.FormattingEnabled = true;
            this.cbox.Items.AddRange(new object[] {
            "Action and Adventure",
            "Art & Music",
            "Biographies",
            "Classics",
            "Com. Science",
            "Comics",
            "Cookbooks",
            "Detective and Mystery",
            "Entertainment",
            "Essays",
            "Fantasy",
            "Fictions",
            "Health",
            "History",
            "Horror",
            "Literary Fiction",
            "Poetry",
            "Religion",
            "Romance",
            "Science & Math",
            "Self-Help",
            "Short Stories",
            "Soc. Sience",
            "Suspense and Thrillers",
            "Travel",
            "True Crime",
            "Womens Fiction"});
            this.cbox.Location = new System.Drawing.Point(91, 9);
            this.cbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(122, 27);
            this.cbox.Sorted = true;
            this.cbox.TabIndex = 57;
            this.cbox.TabStop = false;
            this.cbox.Text = "Category";
            this.cbox.SelectedIndexChanged += new System.EventHandler(this.cbox_SelectedIndexChanged);
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(300, 9);
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
            this.refreshBtn.Location = new System.Drawing.Point(219, 8);
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
            this.newBtn.Location = new System.Drawing.Point(7, 8);
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
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(617, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 44);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "<< Book Details >> ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sbTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 445);
            this.panel3.TabIndex = 2;
            // 
            // sbTable
            // 
            this.sbTable.AllowUserToAddRows = false;
            this.sbTable.AllowUserToDeleteRows = false;
            this.sbTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sbTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvname,
            this.dgvauthor,
            this.dgvcategory,
            this.dgvlocation});
            this.sbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbTable.Location = new System.Drawing.Point(0, 0);
            this.sbTable.Name = "sbTable";
            this.sbTable.ReadOnly = true;
            this.sbTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sbTable.Size = new System.Drawing.Size(608, 445);
            this.sbTable.TabIndex = 0;
            this.sbTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sbTable_CellClick);
            // 
            // dgvid
            // 
            this.dgvid.DataPropertyName = "bookId";
            this.dgvid.HeaderText = "ID";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Width = 50;
            // 
            // dgvname
            // 
            this.dgvname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvname.DataPropertyName = "name";
            this.dgvname.HeaderText = "Book Name";
            this.dgvname.Name = "dgvname";
            this.dgvname.ReadOnly = true;
            // 
            // dgvauthor
            // 
            this.dgvauthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvauthor.DataPropertyName = "author";
            this.dgvauthor.HeaderText = "Author";
            this.dgvauthor.Name = "dgvauthor";
            this.dgvauthor.ReadOnly = true;
            // 
            // dgvcategory
            // 
            this.dgvcategory.DataPropertyName = "category";
            this.dgvcategory.HeaderText = "Category";
            this.dgvcategory.Name = "dgvcategory";
            this.dgvcategory.ReadOnly = true;
            // 
            // dgvlocation
            // 
            this.dgvlocation.DataPropertyName = "location";
            this.dgvlocation.HeaderText = "Location";
            this.dgvlocation.Name = "dgvlocation";
            this.dgvlocation.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.logoutBtn);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Controls.Add(this.lbox);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.catbox);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.qntxt);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.authortxt);
            this.panel4.Controls.Add(this.nametxt);
            this.panel4.Controls.Add(this.idtxt);
            this.panel4.Controls.Add(this.pricetxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(617, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 445);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.giphy__1_;
            this.pictureBox1.Location = new System.Drawing.Point(5, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(212, 413);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 26);
            this.logoutBtn.TabIndex = 91;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(119, 413);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 26);
            this.backBtn.TabIndex = 90;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lbox
            // 
            this.lbox.Enabled = false;
            this.lbox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox.FormattingEnabled = true;
            this.lbox.Items.AddRange(new object[] {
            "Row 1, Column 1",
            "Row 1, Column 2",
            "Row 1, Column 3",
            "Row 2, Column 1",
            "Row 2, Column 2",
            "Row 2, Column 3",
            "Row 3, Column 1",
            "Row 3, Column 2",
            "Row 3, Column 3",
            "Row 4, Column 1",
            "Row 4, Column 2",
            "Row 4, Column 3",
            "Row 5, Column 1",
            "Row 5, Column 2",
            "Row 5, Column 3",
            "Row 6, Column 1",
            "Row 6, Column 2",
            "Row 6, Column 3",
            "Row 7, Column 1",
            "Row 7, Column 2",
            "Row 7, Column 3",
            "Row 8, Column 1",
            "Row 8, Column 2",
            "Row 8, Column 3",
            "Row 9, Column 1",
            "Row 9, Column 2",
            "Row 9, Column 3",
            "Row 10, Column 1",
            "Row 10, Column 2",
            "Row 10, Column 3"});
            this.lbox.Location = new System.Drawing.Point(94, 187);
            this.lbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(191, 25);
            this.lbox.TabIndex = 89;
            this.lbox.TabStop = false;
            this.lbox.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "Location:";
            // 
            // catbox
            // 
            this.catbox.Enabled = false;
            this.catbox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catbox.FormattingEnabled = true;
            this.catbox.Items.AddRange(new object[] {
            "Action and Adventure",
            "Art & Music",
            "Biographies",
            "Classics",
            "Com. Science",
            "Comics",
            "Cookbooks",
            "Detective and Mystery",
            "Entertainment",
            "Essays",
            "Fantasy",
            "Fictions",
            "Health",
            "History",
            "Horror",
            "Literary Fiction",
            "Poetry",
            "Religion",
            "Romance",
            "Science & Math",
            "Self-Help",
            "Short Stories",
            "Soc. Sience",
            "Suspense and Thrillers",
            "Travel",
            "True Crime",
            "Womens Fiction"});
            this.catbox.Location = new System.Drawing.Point(93, 157);
            this.catbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.catbox.Name = "catbox";
            this.catbox.Size = new System.Drawing.Size(192, 25);
            this.catbox.Sorted = true;
            this.catbox.TabIndex = 87;
            this.catbox.TabStop = false;
            this.catbox.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 86;
            this.label7.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 85;
            this.label4.Text = "Price:";
            // 
            // qntxt
            // 
            this.qntxt.CausesValidation = false;
            this.qntxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qntxt.Location = new System.Drawing.Point(93, 96);
            this.qntxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.qntxt.Name = "qntxt";
            this.qntxt.ReadOnly = true;
            this.qntxt.Size = new System.Drawing.Size(192, 25);
            this.qntxt.TabIndex = 84;
            this.qntxt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "ID:";
            // 
            // authortxt
            // 
            this.authortxt.CausesValidation = false;
            this.authortxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authortxt.Location = new System.Drawing.Point(93, 66);
            this.authortxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.authortxt.Name = "authortxt";
            this.authortxt.ReadOnly = true;
            this.authortxt.Size = new System.Drawing.Size(192, 25);
            this.authortxt.TabIndex = 79;
            this.authortxt.TabStop = false;
            // 
            // nametxt
            // 
            this.nametxt.CausesValidation = false;
            this.nametxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(93, 35);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nametxt.Name = "nametxt";
            this.nametxt.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(192, 25);
            this.nametxt.TabIndex = 78;
            this.nametxt.TabStop = false;
            // 
            // idtxt
            // 
            this.idtxt.CausesValidation = false;
            this.idtxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(93, 5);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(192, 25);
            this.idtxt.TabIndex = 77;
            this.idtxt.TabStop = false;
            // 
            // pricetxt
            // 
            this.pricetxt.CausesValidation = false;
            this.pricetxt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(93, 127);
            this.pricetxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.ReadOnly = true;
            this.pricetxt.Size = new System.Drawing.Size(192, 25);
            this.pricetxt.TabIndex = 76;
            this.pricetxt.TabStop = false;
            // 
            // SearchBookFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(914, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchBookFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBookFrame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchBookFrame_FormClosed);
            this.Load += new System.EventHandler(this.SearchBookFrame_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sbTable)).EndInit();
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
        private System.Windows.Forms.DataGridView sbTable;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox lbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox catbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qntxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvlocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbox;
    }
}