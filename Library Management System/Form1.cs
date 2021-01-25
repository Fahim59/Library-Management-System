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
    public partial class Form1 : Form
    {
        public static string a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            a = usertxt.Text;
            b = passtxt.Text;

            string query = "SELECT * from [User] WHERE userId = '" + usertxt.Text + "' AND password = '" + passtxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            try
            {
                string status = dt.Rows[0]["status"].ToString();

                if (dt == null)
                {
                    return;
                }

                if (dt.Rows.Count != 1)
                {
                    MessageBox.Show("Invaild Id or Password");
                    return;
                }

                if (status == "0")
                {
                    AdminHome ah = new AdminHome();
                    ah.Visible = true;
                    this.Visible = false;
                }
                else if (status == "1")
                {
                    StudentHome sh = new StudentHome();
                    sh.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invaild Id or Password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invaild Id or Password");
            }
        }

        private void guestBtn_Click(object sender, EventArgs e)
        {
            SellBookFrame sbf = new SellBookFrame();
            sbf.Show(this);
            this.Hide();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            RegistrationFrame rf = new RegistrationFrame();
            rf.Visible = true;
            this.Visible = false;
        }

        private void showBtn_MouseHover(object sender, EventArgs e)
        {
            passtxt.PasswordChar = '\0';
        }

        private void showBtn_MouseLeave(object sender, EventArgs e)
        {
            passtxt.PasswordChar = '*';
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
