using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagementFinal
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        /*-------------------------------------->Button zone<--------------------------------------------------*/

        //Logout Button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                loginForm lForm = new loginForm();
                lForm.Show();
                this.Hide();
            }
        }
        //Exit Button
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Dashboard 
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addBooks1.Visible = false;
            returnBook1.Visible = false;
            issuseBooks1.Visible = false;
            dashboard Dform = dashboard1 as dashboard;
            if(Dform != null)
            {
                Dform.refreshData();
            }
        }
        //addBooks
        private void addBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = true;
            returnBook1.Visible = false;
            issuseBooks1.Visible = false;

            AddBooks aForm = addBooks1 as AddBooks;
            if (aForm != null)
            {
                aForm.refreshData();
            }
        }
        //IssuesBooks
        private void issueBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            issuseBooks1.Visible = true;
            returnBook1.Visible = false;
            IssuseBooks Iform = issuseBooks1 as IssuseBooks;
            if(Iform != null)
            {
                Iform.refreshData();
            }
            
        }
        //ReturnBooks
        private void returnBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            issuseBooks1.Visible = false;
            returnBook1.Visible = true;
            ReturnBook rform = returnBook1 as ReturnBook;
            if(rform != null)
            {
                rform.refreshData();
            }
        }
    }
}
