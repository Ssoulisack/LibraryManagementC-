using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementFinal
{
    public partial class ReturnBook : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F01AA5A\\SQLEXPRESS;Initial Catalog=LibrarySystem;Persist Security Info=True;User ID=soulisack;Password=77477686");
        SqlCommand cmd;
        public ReturnBook()
        {
            InitializeComponent();

            displayReturnIssuedBooksData();
        }
        //refresh Data Method
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayReturnIssuedBooksData();
        }
        //Method Dispay
        public void displayReturnIssuedBooksData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.ReturnIssueBooksData();

            dataGridView1.DataSource = listData;
        }
        //Method ClearFields
        public void clearFields()
        {
            returnBooks_issueID.Text = "";
            returnBooks_name.Text = "";
            returnBooks_contact.Text = "";
            returnBooks_email.Text = "";
            returnBooks_bookTitle.Text = "";
            returnBooks_author.Text = "";
        }
        /*-------------------------------------------->Button Zone<------------------------------------------*/
        //ReturnBooks
        private void returnBooks_returnBtn_Click(object sender, EventArgs e)
        {
            if (returnBooks_issueID.Text == ""
               || returnBooks_name.Text == ""
               || returnBooks_contact.Text == ""
               || returnBooks_email.Text == ""
               || returnBooks_bookTitle.Text == ""
               || returnBooks_author.Text == ""
               || bookIssue_issueDate.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    DialogResult check = MessageBox.Show("Are you sure that Issue ID: "
                        + returnBooks_issueID.Text.Trim()
                        + "is return already?", "Confirmation Message", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            DateTime today = DateTime.Today;
                            conn.Open();

                            string updateData = "UPDATE issues SET status = @status, date_update = @dateUpdate " +
                            "WHERE issue_id = @issueID";

                            cmd = new SqlCommand(updateData, conn);
                                cmd.Parameters.AddWithValue("@status", "Return");
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", returnBooks_issueID.Text);

                                cmd.ExecuteNonQuery();

                                displayReturnIssuedBooksData();

                                MessageBox.Show("Returned successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }

                }
            }
        }
        //clearFields
        private void returnBooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        //DataGridvView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                returnBooks_issueID.Text = row.Cells[1].Value.ToString();
                returnBooks_name.Text = row.Cells[2].Value.ToString();
                returnBooks_contact.Text = row.Cells[3].Value.ToString();
                returnBooks_email.Text = row.Cells[4].Value.ToString();
                returnBooks_bookTitle.Text = row.Cells[5].Value.ToString();
                returnBooks_author.Text = row.Cells[6].Value.ToString();
                bookIssue_issueDate.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
