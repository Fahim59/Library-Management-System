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
    public partial class LoanListFrame : Form
    {
        private bool isNew = true;
        public LoanListFrame()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            isNew = true;

            lidtxt.Text = "";
            bnametxt.Text = "";
            sidtxt.Text = "";
            idatetxt.Text = DateTime.Now.ToString();
            ddatetxt.Text = DateTime.Now.ToString();
            rdatetxt.Text = "";
            finetxt.Text = "";
            statustxt.Text = "";
            llTable.ClearSelection();
        }

        private void LoanListFrame_Load(object sender, EventArgs e)
        {
            LoadLoanListFrame();
            LoadBook();
            bnametxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            bnametxt.AutoCompleteSource = AutoCompleteSource.ListItems;
            bnametxt.Text = "";
        }

        private void LoadLoanListFrame()
        {
            //string query = "SELECT * from IssueBook";
            string query = "SELECT IssueBook.*,Book.name from IssueBook, Book where IssueBook.bookName = Book.name";

            if (string.IsNullOrEmpty(searchtxt.Text) == false)
            {
                query = query + " Where IssueBook.studentId like '%" + searchtxt.Text + "%'";
            }

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            llTable.AutoGenerateColumns = false;
            llTable.DataSource = dt;
            llTable.Refresh();
            llTable.ClearSelection();

            this.Refresh();
        }
        private void LoadBook()
        {
            string query = "Select * from Book";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            bnametxt.DataSource = dt;
            bnametxt.DisplayMember = "name";
        }

        private void LoadSingleList()
        {
            string query = "Select * from IssueBook Where loanId = '" + lidtxt.Text + "'";

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt == null)
                return;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            isNew = false;

            lidtxt.Text = dt.Rows[0]["loanId"].ToString();
            bnametxt.Text = dt.Rows[0]["bookName"].ToString();
            sidtxt.Text = dt.Rows[0]["studentId"].ToString();
            idatetxt.Text = dt.Rows[0]["issueDate"].ToString();
            ddatetxt.Text = dt.Rows[0]["dueDate"].ToString();
            rdatetxt.Text = dt.Rows[0]["returnDate"].ToString();
            statustxt.Text = dt.Rows[0]["status"].ToString();
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

            if(statustxt.Text == "Returned")
            {
                string query1 = "Delete from IssueBook Where loanId = '" + lidtxt.Text + "'";

                if (DatabaseConnection.ExecuteQuery(query1) == true)
                {
                    MessageBox.Show("Deleted");
                    this.LoadLoanListFrame();
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                string query2 = "UPDATE Book SET Quantity =  Quantity + 1  WHERE Name = '" + bnametxt.Text + "' ; Delete from IssueBook Where loanId = '" + lidtxt.Text + "'";

                if (DatabaseConnection.ExecuteQuery(query2) == true)
                {
                    MessageBox.Show("Deleted & Updated");
                    this.LoadLoanListFrame();
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchtxt.Text = "";
            this.LoadLoanListFrame();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.LoadLoanListFrame();
        }

        private bool checkBook() //It is checking if the book is available or not
        {
            string query = ("Select * from Book where name = '" + bnametxt.Text + "' AND Book.quantity > 0");
            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkBalance() //If a student's balance is less than 0 he/she cannot borrow a book
        {
            string query = ("Select * from Student where studentId = '" + sidtxt.Text + "' AND Student.balance >= 0");
            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkStudent()  //It will allow a student to borrow 2 books highest. When a book is returned he/she can borrow another book.
        {
            string query = ("SELECT * FROM IssueBook Where studentId = '" + sidtxt.Text + "' AND status = 'Issued'");
            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt.Rows.Count <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkDuplicate()  //It will not allow a student to borrow same book at a time. When a book is returned he/she can borrow the book again.
        {
            string query = ("Select bookName, COUNT(bookName) from IssueBook Where studentId = '" + sidtxt.Text + "' AND status = 'Issued' Group By bookName");
            DatabaseConnection.ExecuteQuery(query);

            DataTable dt = DatabaseConnection.GetData(query);

            if (dt.Rows.Count != 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string loanId = this.lidtxt.Text;
            string bookName = this.bnametxt.Text;
            string sid = this.sidtxt.Text;
            //string issueDate = this.idatetxt.Text;
            //string dueDate = this.ddatetxt.Text;
            //string returnDate = this.rdatetxt.Text;
            string status = this.statustxt.Text;
            string fine = Convert.ToString(0);

            string x = this.rdatetxt.Text;
            DateTime returnDate = DateTime.Parse(x);
            string p = returnDate.ToShortDateString();

            string y = this.idatetxt.Text;
            DateTime issueDate = DateTime.Parse(y);
            string q = issueDate.ToShortDateString();

            string z = this.ddatetxt.Text;
            DateTime dueDate = DateTime.Parse(z);
            string r = dueDate.ToShortDateString();

            if (string.IsNullOrEmpty(loanId) || string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(sid) || string.IsNullOrEmpty(y) || string.IsNullOrEmpty(z))
            {
                MessageBox.Show("Invalid Information");
                return;
            }

            if (isNew == true)
            {
                if (checkBook())
                {
                    if(checkBalance())
                    {
                        if(checkStudent())
                        {
                            if(checkDuplicate())
                            {
                                string query1 = "INSERT into IssueBook(loanId,bookName,studentId,issueDate,dueDate,status,returnDate,fine) Values('" + loanId + "', '" + bookName + "', '" + sid + "', '" + q + "','" + r + "', 'Issued', NULL, 0) ; UPDATE Book SET Quantity =  Quantity - 1  WHERE Name = '" + bnametxt.Text + "'";

                                if (DatabaseConnection.ExecuteQuery(query1) != true)
                                {
                                    MessageBox.Show("Cannot Issue Book, Invalid Information");
                                    return;
                                }

                                string query2 = "INSERT into History(fine,loanId,bookName,studentId,dueDate,returnDate) Values (" + fine + ", '" + loanId + "', '" + bookName + "', '" + sid + "','" + r + "', NULL)";
                                DatabaseConnection.ExecuteQuery(query2);

                                MessageBox.Show("Book Issued Successfully");

                                this.LoadLoanListFrame();
                                this.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("Same Book cannot be Issued at a time");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Maximum 2 Books!!!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot Issue Book, Either Invalid information or Clear the fine at first");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Book is not Available");
                    return;
                }
            }
            else
            {
                string query3 = "UPDATE IssueBook SET BookName = '" + bookName + "', StudentId = '" + sid + "', IssueDate = '" + q + "', DueDate = '" + r + "', ReturnDate = '" + p + "', Status = '" + status + "', Fine = '" + fine + "' WHERE LoanId = '" + lidtxt.Text + "'";
                DatabaseConnection.ExecuteQuery(query3);

                MessageBox.Show("IssueBook Updated Successfully");

                this.LoadLoanListFrame();
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

        private void llTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = llTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                lidtxt.Text = id;
                this.LoadSingleList();
            }
        }

        private void LoanListFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            Email ef = new Email();
            ef.Show(this);
            this.Hide();
        }
    }
}
