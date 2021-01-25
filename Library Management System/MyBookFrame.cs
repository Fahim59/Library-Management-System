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
    public partial class MyBookFrame : Form
    {
        private bool isNew = true;
        public static string x;
        public MyBookFrame()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            lidtxt.Text = "";
            bnametxt.Text = "";
            sidtxt.Text = "";
            idatetxt.Text = "";
            ddatetxt.Text = "";
            rdatetxt.Text = "";
            finetxt.Text = "";
            mbTable.ClearSelection();
        }

        private void LoadMyBookFrame()
        {
            string query = "SELECT * from IssueBook where status = 'Issued' AND StudentId = '" + x + "'";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " AND IssueBook.bookName like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            mbTable.AutoGenerateColumns = false;
            mbTable.DataSource = dt;
            mbTable.Refresh();
            mbTable.ClearSelection();

            this.Refresh();
        }

        private void LoadSingleList()
        {
            string query = "Select * from IssueBook Where loanId = '" + lidtxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            lidtxt.Text = dt.Rows[0]["loanId"].ToString();
            bnametxt.Text = dt.Rows[0]["bookName"].ToString();
            sidtxt.Text = dt.Rows[0]["studentId"].ToString();
            idatetxt.Text = dt.Rows[0]["issueDate"].ToString();
            ddatetxt.Text = dt.Rows[0]["dueDate"].ToString();
            rdatetxt.Text = dt.Rows[0]["returnDate"].ToString();
            finetxt.Text = dt.Rows[0]["fine"].ToString();
        }
        private void newBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadMyBookFrame();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.LoadMyBookFrame();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            string loanId = this.lidtxt.Text;
            string bookName = this.bnametxt.Text;
            string sid = this.sidtxt.Text;
            string fine = Convert.ToString(this.finetxt.Text);
            //string issueDate = this.idatetxt.Text;
            //string returnDate = this.rdatetxt.Text;
            //string dueDate = this.ddatetxt.Text;

            string x = this.rdatetxt.Text;
            DateTime returnDate = DateTime.Parse(x);
            string p = returnDate.ToShortDateString();

            string y = this.idatetxt.Text;
            DateTime issueDate = DateTime.Parse(y);
            string q = issueDate.ToShortDateString();

            string z = this.ddatetxt.Text;
            DateTime dueDate = DateTime.Parse(z);
            string r = dueDate.ToShortDateString();

            if (returnDate < issueDate)
            {
                MessageBox.Show("Invalid Return Date");
                return;
            }

            DateTime c = Convert.ToDateTime(ddatetxt.Text);
            DateTime d = Convert.ToDateTime(rdatetxt.Text);

            int X = Convert.ToInt32(d.Subtract(c).Days.ToString());

            if (isNew == true)
            {
                MessageBox.Show("Please load existing data first");
                return;
            }

            string query = "UPDATE IssueBook SET BookName = '" + bookName + "', StudentId = '" + sid + "', IssueDate = '" + q + "', DueDate = '" + r + "', ReturnDate = '" + p + "', Status = 'Returned', Fine = " + fine + " WHERE LoanId = '" + lidtxt.Text + "' ; UPDATE Book SET Quantity =  Quantity + 1  WHERE Name = '" + bnametxt.Text + "' ; UPDATE History SET ReturnDate = '" + p + "' WHERE LoanId = '" + lidtxt.Text + "' ; UPDATE IssueBook SET fine = CASE when DATEDIFF(d,duedate,returndate)>0 then (DATEDIFF(d,duedate,returndate)) *10 else 0 end WHERE LoanId = '" + lidtxt.Text + "' ; UPDATE History SET fine = CASE when DATEDIFF(d,duedate,returndate)>0 then (DATEDIFF(d,duedate,returndate)) *10 else 0 end WHERE LoanId = '" + lidtxt.Text + "' ; UPDATE Student set Student.fine = IssueBook.fine from Student, IssueBook where Student.studentId = '" + sidtxt.Text + "' ; UPDATE Student set balance = balance - fine, fine = 0 Where StudentId = '" + sidtxt.Text + "'";

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                if (X > 0)
                {
                    X = X * 10;
                    MessageBox.Show("Book Returned With Fine " + X + " taka");
                }
                else
                {
                    MessageBox.Show("Book Returned Successfully");
                }
                //MessageBox.Show("Book Returned Successfully");
                this.LoadMyBookFrame();
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Book Returned Failed");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentHome sh = new StudentHome();
            this.Visible = false;
            sh.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void MyBookFrame_Load(object sender, EventArgs e)
        {
            x = Form1.a;
            LoadMyBookFrame();
        }

        private void MyBookFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mbTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = mbTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                lidtxt.Text = id;
                this.LoadSingleList();
            }
        }
    }
}
