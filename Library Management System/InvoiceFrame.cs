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
    public partial class InvoiceFrame : Form
    {
        public InvoiceFrame()
        {
            InitializeComponent();
        }

        private void InvoiceFrame_Load(object sender, EventArgs e)
        {
            LoadInvoiceFrame();
        }

        private void LoadInvoiceFrame()
        {
            string query = "Select * from Details_Invoice";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            sbTable.AutoGenerateColumns = false;
            sbTable.DataSource = dt;
            sbTable.Refresh();
            sbTable.ClearSelection();
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
        private void InvoiceFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            sbTable.ClearSelection();
        }
    }
}
