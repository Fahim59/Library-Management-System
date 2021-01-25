namespace Library_Management_System
{
    partial class SummaryFrame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tutxt = new System.Windows.Forms.Label();
            this.tbtxt = new System.Windows.Forms.Label();
            this.titxt = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Issued Books";
            // 
            // tutxt
            // 
            this.tutxt.AutoSize = true;
            this.tutxt.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutxt.Location = new System.Drawing.Point(119, 104);
            this.tutxt.Name = "tutxt";
            this.tutxt.Size = new System.Drawing.Size(34, 36);
            this.tutxt.TabIndex = 6;
            this.tutxt.Text = "=";
            // 
            // tbtxt
            // 
            this.tbtxt.AutoSize = true;
            this.tbtxt.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtxt.Location = new System.Drawing.Point(415, 104);
            this.tbtxt.Name = "tbtxt";
            this.tbtxt.Size = new System.Drawing.Size(34, 36);
            this.tbtxt.TabIndex = 7;
            this.tbtxt.Text = "=";
            // 
            // titxt
            // 
            this.titxt.AutoSize = true;
            this.titxt.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titxt.Location = new System.Drawing.Point(267, 252);
            this.titxt.Name = "titxt";
            this.titxt.Size = new System.Drawing.Size(34, 36);
            this.titxt.TabIndex = 8;
            this.titxt.Text = "=";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(500, 329);
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
            this.backBtn.Location = new System.Drawing.Point(419, 329);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 26);
            this.backBtn.TabIndex = 92;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SummaryFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(584, 363);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.titxt);
            this.Controls.Add(this.tbtxt);
            this.Controls.Add(this.tutxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SummaryFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Summary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SummaryFrame_FormClosed);
            this.Load += new System.EventHandler(this.SummaryFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tutxt;
        private System.Windows.Forms.Label tbtxt;
        private System.Windows.Forms.Label titxt;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
    }
}