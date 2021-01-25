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
    public partial class AdminFrame : Form
    {
        private bool isNew = true;
        public AdminFrame()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            idtxt.Text = "";
            nametxt.Text = "";
            addresstxt.Text = "";
            emailtxt.Text = "";
            balancetxt.Text = "";
            finetxt.Text = "";
            balancetxt.Text = "";
            deptxt.Text = "";
            stTable.ClearSelection();
        }

        private void AdminFrame_Load(object sender, EventArgs e)
        {
            LoadAdminFrame();
        }

        private void LoadAdminFrame()
        {
            string query = "Select * from Student";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where Student.name like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            stTable.AutoGenerateColumns = false;
            stTable.DataSource = dt;
            stTable.Refresh();
            stTable.ClearSelection();

            this.Refresh();
        }

        private void stTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = stTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                idtxt.Text = id;
                this.LoadSingleStudent();
            }
        }

        private void LoadSingleStudent()
        {
            string query = "Select * from Student Where studentId = '" + idtxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            idtxt.Text = dt.Rows[0]["studentId"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            emailtxt.Text = dt.Rows[0]["email"].ToString();
            addresstxt.Text = dt.Rows[0]["address"].ToString();
            balancetxt.Text = dt.Rows[0]["balance"].ToString();
            finetxt.Text = dt.Rows[0]["fine"].ToString();
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

            string query1 = "Delete from Student Where studentId = '" + idtxt.Text + "'";
            string query2 = "Delete from [User] Where userId = '" + idtxt.Text + "'";

            if(DatabaseConnection.ExecuteQuery(query1) == true)
            {
                if (DatabaseConnection.ExecuteQuery(query2) == true)
                {
                    MessageBox.Show("Student data has been deleted");
                    this.LoadAdminFrame();
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("Cannot remove Student");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Cannot remove User");
                return;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadAdminFrame();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadAdminFrame();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int x = rd.Next(999) + 10000;

            string id = this.idtxt.Text;
            string name = this.nametxt.Text;
            string email = this.emailtxt.Text;
            string address = this.addresstxt.Text;
            string balance = Convert.ToString(this.balancetxt.Text);
            string fine = Convert.ToString(this.finetxt.Text);

            string userId = this.idtxt.Text;
            string password = (x + "");
            string status = "1";

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(balance) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Invalid/Insufficient Information");
                return;
            }

            string query = "";

            if (isNew == true)
            {
                query = "INSERT into Student(studentId,name,email,address,balance,fine) Values ('" + id + "', '" + name + "', '" + email + "', '" + address + "', " + balance + ", 0) ; INSERT into [User](userId,password,status) Values ('" + userId + "', '" + password + "', " + status + ")";
                MessageBox.Show("Student Added with Id: " + userId + " & Password: " + password);
            }
            else
            {
                query = "UPDATE Student SET Name = '" + name + "', Email = '" + email + "', Address = '" + address + "', Balance = " + balance + ", Fine = " + fine + " WHERE StudentId = '" + idtxt.Text + "'";
                MessageBox.Show("Student Updated");
            }

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                this.LoadAdminFrame();
                this.Refresh();
            }
        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            string sname = this.nametxt.Text;
            string sid = this.idtxt.Text;
            string date = DateTime.Now.ToString();
            string balance = this.deptxt.Text;

            if (string.IsNullOrEmpty(idtxt.Text) || string.IsNullOrEmpty(deptxt.Text))
            {
                MessageBox.Show("Cannot deposit, Insert Id and Balance");
                return;
            }

            string query = "";

            if (isNew != true)
            {
                if (Convert.ToInt32(deptxt.Text) < 50)
                {
                    MessageBox.Show("Minimum 50 Taka need to be deposited");
                    deptxt.Text = "";
                    deptxt.Focus();
                    return;
                }
                else
                {
                    query = "Update Student SET Balance = Balance + " + Convert.ToInt32(deptxt.Text) + " WHERE StudentId = '" + idtxt.Text + "'; Insert into [Deposit History] (studentId,[name],date,amount) values('" + sid + "','" + sname + "',GETDATE(),'" + balance + "')";
                }
                //query = "Update Student SET Balance = Balance + " + Convert.ToInt32(deptxt.Text) + " WHERE StudentId = '" + idtxt.Text + "'; Insert into [Deposit History] (studentId,[name],date,amount) values('" + sid + "','" + sname + "',GETDATE(),'" + balance + "')";
            }

            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Successfully Deposited...");
                this.LoadAdminFrame();
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

        private void AdminFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
