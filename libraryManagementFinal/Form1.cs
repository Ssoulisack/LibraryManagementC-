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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;
            if(panel2.Width >= 600)
            {
                timer1.Stop();
                loginForm loginForm= new loginForm();
                loginForm.Show();
                this.Hide();

            }
        }
    }
}
