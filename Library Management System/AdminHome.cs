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
    public partial class AdminHome : Form
    {
        public static string x, y;
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            x = Form1.a;
            y = Form1.b;
        }
        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminFrame af = new AdminFrame();
            this.Visible = false;
            af.Visible = true;
        }

        private void manageBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookFrame bf = new BookFrame();
            this.Visible = false;
            bf.Visible = true;
        }

        private void issueBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoanListFrame llf = new LoanListFrame();
            this.Visible = false;
            llf.Visible = true;
        }

        private void loanHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryFrame hf = new HistoryFrame();
            this.Visible = false;
            hf.Visible = true;
        }

        private void depositHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositHistory dh = new DepositHistory();
            this.Visible = false;
            dh.Visible = true;
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceFrame If = new InvoiceFrame();
            this.Visible = false;
            If.Visible = true;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordFrame pf = new PasswordFrame();
            pf.Show(this);
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Visible = true;
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryFrame sf = new SummaryFrame();
            this.Visible = false;
            sf.Visible = true;
        }
        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Invoice_Report.PrintInvoice().Show();
        }

        private void sellBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellBookFrame sbf = new SellBookFrame();
            sbf.Show(this);
            this.Hide();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Email ef = new Email();
            ef.Show(this);
            this.Hide();

            ef.subjecttxt.Text = "";
            ef.subjecttxt.Enabled = true;
            ef.bodytxt.Text = "";
            ef.bodytxt.Enabled = true;

            ef.idtxt.Enabled = false;
            ef.loadBtn.Enabled = false;
        }
    }
}
