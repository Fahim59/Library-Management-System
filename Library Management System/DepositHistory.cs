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
    public partial class DepositHistory : Form
    {
        private bool isNew = true;
        public DepositHistory()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            isNew = true;

            sidtxt.Text = "";
            snametxt.Text = "";
            ddatetxt.Text = DateTime.Now.ToString();
            amttxt.Text = "";
            dhTable.ClearSelection();
        }
        private void DepositHistory_Load(object sender, EventArgs e)
        {
            LoadDepositHistory();
        }
        private void LoadDepositHistory()
        {
            string query = "SELECT * from [Deposit History]";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where [Deposit History].studentId like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            dhTable.AutoGenerateColumns = false;
            dhTable.DataSource = dt;
            dhTable.Refresh();
            dhTable.ClearSelection();

            this.Refresh();
        }

        private void LoadSingleList()
        {
            string query = "Select * from [Deposit History] Where studentId = '" + sidtxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            sidtxt.Text = dt.Rows[0]["studentId"].ToString();
            snametxt.Text = dt.Rows[0]["name"].ToString();
            ddatetxt.Text = dt.Rows[0]["date"].ToString();
            amttxt.Text = dt.Rows[0]["amount"].ToString();
        }

        private void newBtn_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadDepositHistory();
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            LoadDepositHistory();
        }

        private void dhTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dhTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                sidtxt.Text = id;
                this.LoadSingleList();
            }
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            this.Visible = false;
            ah.Visible = true;
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }
        private void DepositHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
