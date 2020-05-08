using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }


        private void showPass_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass_Check.Checked)
            {
                this.passwordField.PasswordChar = (char)0;
            }
            else
            {
                this.passwordField.PasswordChar = '*';
            }
        }


        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.wrongPassOrLog.Visible = false;
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (this.loginField.Text.Length > 5 && this.passwordField.Text.Length > 5)
            {
                this.Hide();
                var TimeTableWindow = new TimeTable();
                TimeTableWindow.Show();
               
            }
            else
            {
                this.wrongPassOrLog.Visible = true;
            }
        }

    }
    
}
