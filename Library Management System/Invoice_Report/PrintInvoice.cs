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
using Microsoft.Reporting.WinForms;

namespace Library_Management_System.Invoice_Report
{
    public partial class PrintInvoice : Form
    {
        string invoiceId;
        public PrintInvoice()
        {
            InitializeComponent();
        }
        public PrintInvoice(string id)
        {
            invoiceId = id;
            InitializeComponent();
            this.printBtn.Visible = false;
            this.idtxt.Visible = false;
            this.inlabel.Text = "Invoice Slip";
            this.inlabel.Location = new Point(210, 7);
            this.inlabel.Font = new Font("Cambria", 14, FontStyle.Bold);
        }
        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MUSTAFIZ\FAHIMSQL;Initial Catalog=library;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter("Select * from View_Bill where dId = '" + invoiceId + "'", con);

            DataSet1 ds = new DataSet1();
            sda.Fill(ds, "InvoiceTable"); //Dataset Tablename

            ReportDataSource rds = new ReportDataSource("DataSet_InvoiceReport", ds.Tables[0]);  //Reportdata Dataset name

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"F:\C# Code\Library Management System\Library Management System\Invoice_Report\Invoice.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MUSTAFIZ\FAHIMSQL;Initial Catalog=library;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter("Select * from View_Bill where dId = '" + idtxt.Text + "'", con);

            DataSet1 ds = new DataSet1();
            sda.Fill(ds, "InvoiceTable");

            ReportDataSource rds = new ReportDataSource("DataSet_InvoiceReport", ds.Tables[0]);

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"F:\C# Code\Library Management System\Library Management System\Invoice_Report\Invoice.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
