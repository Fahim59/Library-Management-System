using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library_Management_System
{
    public partial class HistoryFrame : Form
    {
        private bool isNew = true;
        public HistoryFrame()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            isNew = true;

            lidtxt.Text = "";
            bnametxt.Text = "";
            sidtxt.Text = "";
            ddatetxt.Text = DateTime.Now.ToString();
            rdatetxt.Text = "";
            finetxt.Text = "";
            hsTable.ClearSelection();
        }
        private void HistoryFrame_Load(object sender, EventArgs e)
        {
            LoadHistoryFrame();
        }
        private void LoadHistoryFrame()
        {
            string query = "SELECT * from History";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where History.studentId like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            hsTable.AutoGenerateColumns = false;
            hsTable.DataSource = dt;
            hsTable.Refresh();
            hsTable.ClearSelection();

            this.Refresh();
        }
        private void LoadSingleList()
        {
            string query = "Select * from History Where loanId = '" + lidtxt.Text + "'";

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
            this.LoadHistoryFrame();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.LoadHistoryFrame();
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

        private void hsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = hsTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                lidtxt.Text = id;
                this.LoadSingleList();
            }
        }

        private void HistoryFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if(isNew != true)
            {
                try
                {
                    TextWriter writer = new StreamWriter(@"F:\C# Code\Library Management System\History.txt");

                    writer.WriteLine("    Library Management System \t");
                    writer.WriteLine("\t Borrow History \t");
                    writer.WriteLine("    ------------------------- \t");
                    writer.WriteLine("Loan ID:     " + lidtxt.Text);
                    writer.WriteLine("Book Name:   " + bnametxt.Text);
                    writer.WriteLine("Student ID:  " + sidtxt.Text);
                    writer.WriteLine("Due Date:    " + ddatetxt.Text);
                    writer.WriteLine("Return Date: " + rdatetxt.Text);
                    writer.WriteLine("Fine:        " + finetxt.Text);

                    writer.Close();
                    MessageBox.Show("Data Exported Successfully");
                    this.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Load Existing Data...");
            }
        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            Email ef = new Email();
            ef.Show(this);
            this.Hide();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                MessageBox.Show("Please load existing data first");
                return;
            }

            string query = "Delete from History Where loanId = '" + lidtxt.Text + "'";

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("History Deleted");
                this.LoadHistoryFrame();
                this.Refresh();
            }
        }
    }
}
