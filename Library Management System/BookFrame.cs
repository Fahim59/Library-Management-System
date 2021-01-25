using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class BookFrame : Form
    {
        private bool isNew = true;
        public BookFrame()
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
            cbox.Text = "";
            bkTable.ClearSelection();
        }

        private void BookFrame_Load(object sender, EventArgs e)
        {
            LoadBookFrame();
        }

        private void LoadBookFrame()
        {
            string query = "Select * from Book";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Book.name like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            bkTable.AutoGenerateColumns = false;
            bkTable.DataSource = dt;
            bkTable.Refresh();
            bkTable.ClearSelection();

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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                MessageBox.Show("Please load existing data first");
                return;
            }

            string query = "Delete from Book Where bookId = '" + idtxt.Text + "'";

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Book Deleted");
                this.LoadBookFrame();
                this.Refresh();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadBookFrame();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.LoadBookFrame();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string id = this.idtxt.Text;
            string name = this.nametxt.Text;
            string author = this.authortxt.Text;
            string quantity = Convert.ToString(this.qntxt.Text);
            string price = Convert.ToString(this.pricetxt.Text);
            string category = this.catbox.Text;
            string location = this.lbox.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Invalid/Insufficient information");
                return;
            }

            string query = "";

            if (isNew == true)
            {
                query = "INSERT into Book(bookId,name,author,quantity,price,category,location) Values ('" + id + "', '" + name + "', '" + author + "', " + quantity + ", " + price + ", '" + category + "', '" + location + "')";
                MessageBox.Show("Book Successfully Inserted");
            }
            else
            {
                query = "UPDATE Book SET Name = '" + name + "', Author = '" + author + "', Price = " + price + ", Quantity = " + quantity + ", Category = '" + category + "', Location = '" + location + "' WHERE BookId = '" + idtxt.Text + "'";
                MessageBox.Show("Book Successfully Updated");
            }

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                this.LoadBookFrame();
                this.Refresh();
            }
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

        private void BookFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bkTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = bkTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = id;
                this.LoadSingleBook();
            }
        }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Book WHERE Category = '" + cbox.SelectedItem + "'";

            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            bkTable.AutoGenerateColumns = false;
            bkTable.DataSource = dt;
            bkTable.Refresh();
            bkTable.ClearSelection();

            this.Refresh();
        }
    }
}
