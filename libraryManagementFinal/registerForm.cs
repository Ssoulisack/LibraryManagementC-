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
    public partial class registerForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F01AA5A\\SQLEXPRESS;Initial Catalog=LibrarySystem;Persist Security Info=True;User ID=soulisack;Password=77477686");
        SqlCommand cmd;
        public registerForm()
        {
            InitializeComponent();
        }
        //Login Form
        private void lbRLogin_Click(object sender, EventArgs e)
        {
            loginForm lForm = new loginForm();
            lForm.Show();
            this.Hide();
        }
        //Exit Button
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Check Pass
        private void R_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtRPass.PasswordChar = R_showPass.Checked ? '\0' : '*';
            txtRCpass.PasswordChar = R_showPass.Checked ? '\0' : '*';
        }
        //Register Button
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (txtRuser.Text == "" || txtRemail.Text == "" || txtRPass.Text == "")
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
                        String checkExistingUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email";
                        cmd = new SqlCommand(checkExistingUserQuery, conn);
                        cmd.Parameters.AddWithValue("@Username", txtRuser.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtRemail.Text.Trim());
                        int count = (int)cmd.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show(count == 1 ? "Username or Email is already taken" : "Both user and email are already taken",
                                "ERROR Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clears();
                        }
                        else
                        {
                            // Check if passwords match
                            if (txtRPass.Text.Trim() != txtRCpass.Text.Trim())
                            {
                                MessageBox.Show("Passwords do not match", "ERROR Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clears();
                            }
                            else
                            {

                                // TO GET THE DATE TODAY
                                DateTime day = DateTime.Today;

                                String insertData = "INSERT INTO Users (Username, Email, Password, date_register) " +
                                    "VALUES(@username, @email, @password, @date)";
                                SqlCommand insertCMD = new SqlCommand(insertData, conn);
                                insertCMD.Parameters.AddWithValue("@username", txtRuser.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@email", txtRemail.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@password", txtRPass.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@date", day.ToString());

                                insertCMD.ExecuteNonQuery();

                                MessageBox.Show("Register successfully!", "Information Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                loginForm lForm = new loginForm();
                                lForm.Show();
                                this.Hide();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtRuser.Text = "";
            txtRemail.Text = "";
            txtRPass.Text = "";
            txtRCpass.Text = "";
        }
    }
}
