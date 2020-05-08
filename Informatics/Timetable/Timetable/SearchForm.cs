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
    public partial class SearchForm : Form
    {
        public SearchForm(ListView list)
        {
            ListInfo = list;
            InitializeComponent();
        }
        public ListView ListInfo;
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                for (int i = 0; i < ListInfo.Items.Count; i++)
                {
                    if (!ListInfo.Items[i].SubItems[3].Text.Contains(this.textBox1.Text))
                    {
                        ListInfo.Items[i].Remove();
                        i--;
                    }
                }
            }
            else
            {
                ListInfo.Items.Clear();
                Data.FillList(ListInfo);
            }
            this.Close();
        }
    }
}
