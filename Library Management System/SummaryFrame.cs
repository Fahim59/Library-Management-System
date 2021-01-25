using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class SummaryFrame : Form
    {
        public SummaryFrame()
        {
            InitializeComponent();
        }

        private void SummaryFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SummaryFrame_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT COUNT(userId) FROM [User]";
            string query2 = "SELECT COUNT(bookId) FROM Book";
            string query3 = "SELECT COUNT(loanId) FROM IssueBook Where status = 'Issued'";

            DataTable dt1 = DatabaseConnection.GetData(query1);
            DataTable dt2 = DatabaseConnection.GetData(query2);
            DataTable dt3 = DatabaseConnection.GetData(query3);

            tutxt.Text = dt1.Rows[0][0].ToString();
            tbtxt.Text = dt2.Rows[0][0].ToString();
            titxt.Text = dt3.Rows[0][0].ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            this.Visible = false;
            ah.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }
    }
}
