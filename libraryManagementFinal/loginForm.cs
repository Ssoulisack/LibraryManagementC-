using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementFinal
{
    public partial class loginForm : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F01AA5A\\SQLEXPRESS;Initial Catalog=LibrarySystem;Persist Security Info=True;User ID=soulisack;Password=77477686");
        SqlCommand cmd;
        SqlDataAdapter da;
        public loginForm()
        {
            InitializeComponent();
        }
        //register button
        private void regBtn_Click(object sender, EventArgs e)
        {
            registerForm registerForm= new registerForm();
            registerForm.Show();
            this.Hide();
        }
        //exit
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //checkPass
        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
        //Login button
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        string sql = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@username", txtLogin.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());

                        da = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        da.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login Successfully!", "Information Message"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                            mainForm mForm = new mainForm();
                            mForm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clears();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message"
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        //method clear
        void clears()
        {
            txtLogin.Text = "";
            txtPass.Text = "";
        }
    }
}
