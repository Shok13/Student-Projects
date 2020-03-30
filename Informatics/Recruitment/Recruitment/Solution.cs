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
    public partial class Solution : Form
    {
        public Solution()
        {
            InitializeComponent();
        }

        public Solution(string name, string exp, bool haveTeachExp, string passportNumber, string passportInfo)
        {
            InitializeComponent();
           
            greeting.Text = "Здравствуйте, " + name;
            label1.Text = "Ваш опыт работы " + exp;
            if (haveTeachExp)
            {
                label2.Text = "Поздравляем, вы приняты на работу!";
                this.BackColor = Color.LightGreen;
            }
            else
            {
                label2.Text = "К сожалению, мы вынуждены вам отказать...";
                this.BackColor = Color.LightCoral;
            }
            label3.Text = "Ваши паспортные данные:" + passportNumber + " " + passportInfo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            MainForm.ActiveForm.Close(); 
        }
    }
}
