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
    public partial class StudentHome : Form
    {
        public static string x, y;
        public StudentHome()
        {
            InitializeComponent();
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            x = Form1.a;
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBookFrame sbf = new SearchBookFrame();
            this.Visible = false;
            sbf.Visible = true;
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyBookFrame mb = new MyBookFrame();
            this.Visible = false;
            mb.Visible = true;
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentFrame sf = new StudentFrame();
            this.Visible = false;
            sf.Visible = true;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordFrame pf = new PasswordFrame();
            pf.Show(this);
            this.Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }
        private void StudentHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buyBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellBookFrame sbf = new SellBookFrame();
            sbf.Show(this);
            this.Hide();
        }
    }
}
