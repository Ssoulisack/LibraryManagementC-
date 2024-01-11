using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementFinal
{
    public partial class AddBooks : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F01AA5A\\SQLEXPRESS;Initial Catalog=LibrarySystem;Persist Security Info=True;User ID=soulisack;Password=77477686");
        SqlCommand cmd;
        SqlDataReader dr;
        public AddBooks()
        {
            InitializeComponent();
            displayBooks();
        }
        //refresh Data Method
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBooks();
        }
        //Method Clear Fields
        public void clearFields()
        {
            addBooks_bookTitle.Text = "";
            addBooks_author.Text = "";
            txt_search.Text = "";
            txtSearch.Text = "";
            addBooks_picture.Image = null;
            addBooks_status.SelectedIndex = -1;
            cbcolumn.SelectedIndex = -1;
        }
        //Method Display
        public void displayBooks()
        {
            DataAddbooks dab = new DataAddbooks();
            List<DataAddbooks> listData = dab.addBooksData();

            dataGridView1.DataSource = listData;

        }
        //Import Images
        private String imagePath;
        private void addBooks_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addBooks_picture.ImageLocation = imagePath;
                }
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DataGridView
        private int bookID = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= -1 )
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    bookID = (int)row.Cells[0].Value;
                    addBooks_bookTitle.Text = row.Cells[1].Value.ToString();
                    addBooks_author.Text = row.Cells[2].Value.ToString();
                    addBooks_published.Text = row.Cells[3].Value.ToString();
                    string imagePath = row.Cells[4].Value as string; // Ensure imagePath is a string

                    addBooks_status.Text = row.Cells[5].Value.ToString();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*-------------------------------------->Button zone<--------------------------------------------------*/
        //Button AddBooks
        private void addBooks_addBtn_Click(object sender, EventArgs e)
        {
            if (addBooks_picture.Image == null
                || addBooks_bookTitle.Text == ""
                || addBooks_author.Text == ""
                || addBooks_published.Value == null
                || addBooks_status.Text == ""
                || addBooks_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //Add Data Books
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        conn.Open();
                        string insertData = "INSERT INTO books " +
                            "(book_title, author, published_date, status, image, date_insert) " +
                            "VALUES(@bookTitle, @author, @published_date, @status, @image, @dateInsert)";

                        string path = Path.Combine(@"C:\c#\C#FinalProject\libraryManagementFinal\books\" +
                            addBooks_bookTitle.Text + addBooks_author.Text.Trim() + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        File.Copy(addBooks_picture.ImageLocation, path, true);

                        cmd = new SqlCommand(insertData, conn);
                            cmd.Parameters.AddWithValue("@bookTitle", addBooks_bookTitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", addBooks_author.Text.Trim());
                            cmd.Parameters.AddWithValue("@published_date", addBooks_published.Value);
                            cmd.Parameters.AddWithValue("@status", addBooks_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBooks();

                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        //Button Update Book
        private void addBooks_updateBtn_Click(object sender, EventArgs e)
        {
            if (addBooks_bookTitle.Text == ""
                || addBooks_author.Text == ""
                || addBooks_published.Value == null
                || addBooks_status.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {       //Update Data
                if (conn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Book ID:"
                        + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET book_title = @bookTitle" +
                                ", author = @author, published_date = @published" +
                                ", status = @status, date_update = @dateUpdate WHERE bID = @id";

                            cmd = new SqlCommand(updateData, conn);
                                cmd.Parameters.AddWithValue("@bookTitle", addBooks_bookTitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", addBooks_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@published", addBooks_published.Value);
                                cmd.Parameters.AddWithValue("@status", addBooks_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
        //Button Delete
        private void addBooks_deleteBtn_Click(object sender, EventArgs e)
        {   
            if (addBooks_bookTitle.Text == ""
                || addBooks_author.Text == ""
                || addBooks_published.Value == null
                || addBooks_status.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //Delete Data Books
                if (conn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Book ID:"
                        + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET date_delete = @dateDelete WHERE bID = @id";

                            cmd = new SqlCommand(updateData, conn);
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
        //Button  Clear 
        private void addBooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        //Search Button
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                displayBooks();
            }
            else
            {
                try
                { 
                    string sql = "SELECT * FROM books WHERE bID = '"+txt_search.Text+"'";
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    { 
                        addBooks_bookTitle.Text = dr["book_title"].ToString();
                        addBooks_author.Text = dr["author"].ToString();
                        addBooks_published.Text = dr["published_date"].ToString();
                        string imagePath = dr["image"].ToString();
                        if (imagePath != null)
                        {
                            addBooks_picture.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            addBooks_picture.Image = null;
                        }
                        addBooks_status.Text = dr["status"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Record found");
                    }
                    /*DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;*/
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                
                    conn.Close() ;
                }
            }
        }
        //Text Search For bookID, bookTitle, author 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string src = txtSearch.Text;

                string query = "SELECT * FROM books";
                if (cbcolumn.SelectedIndex == 0)
                {
                    query += " WHERE book_title LIKE '%" + src + "%' OR author LIKE '%" + src + "%' ";
                    if (int.TryParse(src, out _))
                    {
                        query += " OR bID = " + src;
                    }

                }
                else
                {
                    if (cbcolumn.SelectedIndex == 1 && src.Length > 0)
                    {
                        // Check if the input is a valid integer for ID
                        if (!int.TryParse(src, out _))
                        {
                            MessageBox.Show("Please enter a valid intege for ID.");
                            conn.Close();
                            return;
                        }

                        // Continue with the query for ID
                        query += " WHERE bID = " + src;
                    }
                    else if (cbcolumn.SelectedIndex == 2)
                    {
                        query += " WHERE book_title LIKE '%" + src + "%' ";
                    }
                    else if (cbcolumn.SelectedIndex == 3)
                    {
                        query += " WHERE author LIKE '%" + src + "%' ";
                    }

                }

                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
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