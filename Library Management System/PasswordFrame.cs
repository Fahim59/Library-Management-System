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
    public partial class PasswordFrame : Form
    {
        public static string x, y;
        public PasswordFrame()
        {
            InitializeComponent();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (!oldpasstxt.Text.Equals("") && !oldpasstxt.Text.Equals(null))
            {
                try
                {
                    if (oldpasstxt.Text.Equals(y))
                    {
                        if (!newpasstxt.Text.Equals("") && !newpasstxt.Text.Equals(null))
                        {
                            string query = "Update [User] SET Password = '" + newpasstxt.Text + "' WHERE UserId = '" + x + "'";
                            if (DatabaseConnection.ExecuteQuery(query) == true)
                            {
                                MessageBox.Show("Password changed successfully!!");

                                y = this.newpasstxt.Text;

                                this.oldpasstxt.Text = "";
                                this.newpasstxt.Text = "";

                                Form1 f = new Form1();
                                this.Visible = false;
                                f.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Password changed failed");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please insert new password!!");
                            newpasstxt.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old password doesnot match!!");
                        this.oldpasstxt.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Please insert old password!!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void PasswordFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PasswordFrame_Load(object sender, EventArgs e)
        {
            x = Form1.a;
            y = Form1.b;
        }
    }
}
