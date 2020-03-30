using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recruitment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void passport_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passport_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void experience_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ok_Button_Click_1(object sender, EventArgs e)
        {
            bool teachExp;
            if (teachingExp.Checked)
            {
                teachExp = true;
            }
            else if (nonTeachingExp.Checked)
            {
                teachExp = false;
            }
            else
            {
                teachExp = false;
            }
            var Solution_Window = new Solution(fullName.Text, experience.SelectedItem.ToString(), teachExp, passport.Text, textBox1.Text);
            Solution_Window.StartPosition = FormStartPosition.CenterScreen;
            Solution_Window.Show();
        }
    }
}
