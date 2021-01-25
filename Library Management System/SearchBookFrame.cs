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
    public partial class SearchBookFrame : Form
    {
        private bool isNew = true;
        public SearchBookFrame()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";
            authortxt.Text = "";
            qntxt.Text = "";
            pricetxt.Text = "";
            catbox.Text = "";
            lbox.Text = "";
            sbTable.ClearSelection();
        }

        private void LoadSearchBookFrame()
        {
            string query = "Select * from Book";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Book.name like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            sbTable.AutoGenerateColumns = false;
            sbTable.DataSource = dt;
            sbTable.Refresh();
            sbTable.ClearSelection();

            this.Refresh();
        }

        private void LoadSingleBook()
        {
            string query = "Select * from Book Where bookId = '" + idtxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            idtxt.Text = dt.Rows[0]["bookId"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            authortxt.Text = dt.Rows[0]["author"].ToString();
            qntxt.Text = dt.Rows[0]["quantity"].ToString();
            pricetxt.Text = dt.Rows[0]["price"].ToString();
            catbox.Text = dt.Rows[0]["category"].ToString();
            lbox.Text = dt.Rows[0]["location"].ToString();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadSearchBookFrame();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.LoadSearchBookFrame();
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

        private void SearchBookFrame_Load(object sender, EventArgs e)
        {
            LoadSearchBookFrame();
        }

        private void sbTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = sbTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = id;
                this.LoadSingleBook();
            }
        }

        private void SearchBookFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Book WHERE Category = '" + cbox.SelectedItem + "'";

            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            sbTable.AutoGenerateColumns = false;
            sbTable.DataSource = dt;
            sbTable.Refresh();
            sbTable.ClearSelection();

            this.Refresh();
        }
    }
}
