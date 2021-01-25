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
    public partial class StudentFrame : Form
    {
        public static string x;
        public StudentFrame()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            nametxt.Text = "";
            addresstxt.Text = "";
            emailtxt.Text = "";
            balancetxt.Text = "";
            finetxt.Text = "";
            balancetxt.Text = "";
        }
        public void LoadStudent()
        {
            string query = "Select * from Student Where studentId = '" + x + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid ID! Enter your ID...");
                return;
            }

            idtxt.Text = dt.Rows[0]["studentId"].ToString();
            nametxt.Text = dt.Rows[0]["name"].ToString();
            emailtxt.Text = dt.Rows[0]["email"].ToString();
            addresstxt.Text = dt.Rows[0]["address"].ToString();
            balancetxt.Text = dt.Rows[0]["balance"].ToString();
            finetxt.Text = dt.Rows[0]["fine"].ToString();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtxt.Text) || string.IsNullOrEmpty(nametxt.Text) || string.IsNullOrEmpty(addresstxt.Text) || string.IsNullOrEmpty(balancetxt.Text) || string.IsNullOrEmpty(finetxt.Text))
            {
                MessageBox.Show("Load data first");
                return;
            }

            string id = this.idtxt.Text;
            string name = this.nametxt.Text;
            string email = this.emailtxt.Text;
            string address = this.addresstxt.Text;
            string balance = Convert.ToString(this.balancetxt.Text);
            string fine = Convert.ToString(this.finetxt.Text);

            string query = "UPDATE Student SET Name = '" + name + "', Email = '" + email + "', Address = '" + address + "' WHERE StudentId = '" + idtxt.Text + "'";


            if (DatabaseConnection.ExecuteQuery(query) == true)
            {
                MessageBox.Show("Student data Updated Successfully");
                this.Refresh();
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

        private void StudentFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void StudentFrame_Load(object sender, EventArgs e)
        {
            x = Form1.a;
            LoadStudent();
        }
    }
}
