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
    public partial class SellBookFrame : Form
    {
        private bool isNew = true;
        public SellBookFrame()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            nametxt.Text = "";
            authortxt.Text = "";
            cnametxt.Text = "";
            pricetxt.Text = "";
            catbox.Text = "";
            addresstxt.Text = "";
            qttxt.Text = "";
            totaltxt.Text = "";
            subtxt.Text = "0";
            distxt.Text = "0";
            paidtxt.Text = "0";
            nettxt.Text = "";
            baltxt.Text = "";
            mobiletxt.Text = "";
            
            sbTable.ClearSelection();
        }

        private void SellBookFrame_Load(object sender, EventArgs e)
        {
            LoadSellBookFrame();
        }
        private void LoadSellBookFrame()
        {
            string query = "Select name from Book";

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
            string query = "Select name, author, category, price from Book Where name = '" + nametxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            nametxt.Text = dt.Rows[0]["name"].ToString();
            authortxt.Text = dt.Rows[0]["author"].ToString();
            pricetxt.Text = dt.Rows[0]["price"].ToString();
            catbox.Text = dt.Rows[0]["category"].ToString();

            totaltxt.Text = "";
            qttxt.Text = "";
        }

        private void sbTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string name = sbTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                nametxt.Text = name;
                this.LoadSingleBook();
            }
        }
        private void newBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
            orderView.Items.Clear();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadSellBookFrame();
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.LoadSellBookFrame();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void SellBookFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void orderBtn_Click(object sender, EventArgs e)
        {
            if(orderView.Items.Count > 0)
            {
                string subTotal = this.subtxt.Text;
                string discount = this.distxt.Text;
                string netAmount = this.nettxt.Text;
                string paidAmount = this.paidtxt.Text;
                string cName = this.cnametxt.Text;
                string mobile = this.mobiletxt.Text;
                string address = this.addresstxt.Text;


                if (string.IsNullOrEmpty(subTotal) || string.IsNullOrEmpty(discount) || string.IsNullOrEmpty(netAmount) || string.IsNullOrEmpty(paidAmount) || string.IsNullOrEmpty(cName) || string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Invalid/Insufficient information");
                    return;
                }
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=MUSTAFIZ\FAHIMSQL;Initial Catalog=library;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "INSERT into Print_Invoice(date,subTotal,discount,netAmount,paidAmount) Values" + "(getdate()," + subTotal + ", " + discount + ", " + netAmount + ", " + paidAmount + ") select SCOPE_IDENTITY()";

                    string invoiceId = cmd.ExecuteScalar().ToString();

                    foreach (ListViewItem ListItem in orderView.Items)
                    {
                        cmd.CommandText = "INSERT into Details_Invoice(dId,itemName,price,quantity,totalItem,cName,mobile,address) Values ('" + invoiceId + "','" + ListItem.SubItems[0].Text + "', '" + ListItem.SubItems[1].Text + "', '" + ListItem.SubItems[2].Text + "', '" + ListItem.SubItems[3].Text + "', '" + cName + "', '" + mobile + "', '" + address + "')";
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                    MessageBox.Show("Invoice Successfully Inserted with InvoiceID: " +invoiceId);

                    new Invoice_Report.PrintInvoice(invoiceId).Show();

                    this.LoadSellBookFrame();
                    this.Refresh();
                    orderView.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Atleast 1 item must be added in the cart");
            } 
        }
        private void cartBtn_Click(object sender, EventArgs e)
        {
            if(qttxt.Text == "")
            {
                MessageBox.Show("Enter Quantity");
                qttxt.Focus();
                return;
            }
            else if(isNew == true)
            {
                MessageBox.Show("Choose any Book");
                return;
            }

            string[] ar = new string[4];
            ar[0] = nametxt.Text;
            ar[1] = pricetxt.Text;
            ar[2] = qttxt.Text;
            ar[3] = totaltxt.Text;

            ListViewItem lvi = new ListViewItem(ar);

            for (int i = orderView.Items.Count - 1; i >= 0; i--)
            {
                if (orderView.Items[i].ToString().ToLower().Contains(nametxt.Text.ToLower()))
                {
                    orderView.Items[i].SubItems[2].Text = (Convert.ToInt32(orderView.Items[i].SubItems[2].Text) + Convert.ToInt32(qttxt.Text)).ToString();
                    orderView.Items[i].SubItems[3].Text = (Convert.ToInt32(orderView.Items[i].SubItems[2].Text) * Convert.ToInt32(pricetxt.Text)).ToString();
                    Refresh();
                    return;
                }
            }
            orderView.Items.Add(lvi);
            Refresh();
        }
        private void Check()
        {
            for (int i = orderView.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = orderView.Items[i];

                if (item.SubItems[2].Text == "0")
                {
                    item.Remove();
                }
            }
        }
        private void increaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderView.SelectedItems != null)
                {
                    ListViewItem item = orderView.SelectedItems[0];
                    item.SubItems[2].Text = (Convert.ToInt32(item.SubItems[2].Text) + Convert.ToInt32(1)).ToString();
                    item.SubItems[3].Text = (Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[2].Text)).ToString();

                    orderView.SelectedItems.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void decreaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderView.SelectedItems != null)
                {
                    ListViewItem item = orderView.SelectedItems[0];

                    if(item.SubItems[2].Text == "0")
                    {
                        item.SubItems[2].Text = "0";
                        return;
                    }
                    item.SubItems[2].Text = (Convert.ToInt32(item.SubItems[2].Text) - Convert.ToInt32(1)).ToString();
                    item.SubItems[3].Text = (Convert.ToInt32(item.SubItems[1].Text) * Convert.ToInt32(item.SubItems[2].Text)).ToString();

                    orderView.SelectedItems.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select an Item");
            }
        }
        private void qttxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (qttxt.Text.Length > 0)
                {
                    totaltxt.Text = (Convert.ToInt32(pricetxt.Text) * Convert.ToInt32(qttxt.Text)).ToString();
                    sbTable.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Integer Only!");
                qttxt.Text = "";
                qttxt.Focus();
            }
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            qttxt.Text = "";
            qttxt.Focus();
        }

        private void distxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (distxt.Text.Length > 0)
                {
                    nettxt.Text = (Convert.ToInt32(subtxt.Text) - Convert.ToInt32(distxt.Text)).ToString();
                    sbTable.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Integer Only!");
            }
        }
        private void paidtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (paidtxt.Text.Length > 0)
                {
                    baltxt.Text = (Convert.ToInt32(nettxt.Text) - Convert.ToInt32(paidtxt.Text)).ToString();
                    sbTable.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Integer Only!");
            }
        }
        private void remBtn_Click(object sender, EventArgs e)
        {
            if(orderView.SelectedItems.Count > 0)
            {
                for(int i = 0; i < orderView.Items.Count; i++)
                {
                    if(orderView.Items[i].Selected)
                    {
                        subtxt.Text = (Convert.ToInt32(subtxt.Text) - Convert.ToInt32(orderView.Items[i].SubItems[3].Text)).ToString();
                        orderView.Items[i].Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            Check();

            double valorSum = 0;
            foreach (ListViewItem lstItem in orderView.Items)
            {
                valorSum += double.Parse(lstItem.SubItems[3].Text);
                subtxt.Text = valorSum.ToString();
            }
        }
    }
}
