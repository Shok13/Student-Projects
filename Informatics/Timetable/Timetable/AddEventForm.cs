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
    public partial class AddEventForm : Form
    {
        public AddEventForm(ListView list)
        {
            ListInfo = list;
            InitializeComponent();
        }
        public AddEventForm(ListView list, int item)
        {
            SelectedIndex = item;
            ListInfo = list;
            InitializeComponent();
        }
        private ListView ListInfo;
        private int SelectedIndex = -1;
        private void AddEventForm_Load(object sender, EventArgs e)
        {
            if (SelectedIndex != -1)
            {
                switch (ListInfo.Items[SelectedIndex].SubItems[0].Text)
                {
                    case "Meeting":
                        type_Select.SelectedIndex = 0;
                        break;
                    case "Memo":
                        type_Select.SelectedIndex = 1;
                        break;
                    case "Task":
                        type_Select.SelectedIndex = 2;
                        break;
                }
                textBox1.Text = ListInfo.Items[SelectedIndex].SubItems[3].Text;
                monthCalendar1.SelectionStart = DateTime.Parse(ListInfo.Items[SelectedIndex].SubItems[1].Text + " 23:59:59");
                dateTimePicker1.Value = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + ListInfo.Items[SelectedIndex].SubItems[2].Text + ":00");
            }
            else 
            {
                dateTimePicker1.Value = DateTime.Now;
                type_Select.SelectedIndex = 0;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar1.SelectionStart.Subtract(DateTime.Now.Date)<TimeSpan.Zero)
            { 
                MessageBox.Show("You have selected an invalid date!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionStart.Date == DateTime.Now.Date && dateTimePicker1.Value.TimeOfDay.Subtract(DateTime.Now.TimeOfDay) < TimeSpan.FromSeconds(-10f))
            {
                MessageBox.Show("You have selected an invalid date!");
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(SelectedIndex != -1)
            {
                ListInfo.BeginUpdate();
                ListInfo.Items[SelectedIndex].SubItems[0].Text = this.type_Select.SelectedItem.ToString();
                ListInfo.Items[SelectedIndex].SubItems[1].Text = this.monthCalendar1.SelectionStart.Date.ToShortDateString(); ;
                ListInfo.Items[SelectedIndex].SubItems[2].Text = this.dateTimePicker1.Value.ToShortTimeString();
                ListInfo.Items[SelectedIndex].SubItems[3].Text = this.textBox1.Text;
                ListInfo.EndUpdate();
            }
            else
            {
                var _event = new ListViewItem(this.type_Select.SelectedItem.ToString());
                _event.SubItems.Add(this.monthCalendar1.SelectionStart.Date.ToShortDateString());
                _event.SubItems.Add(this.dateTimePicker1.Value.ToShortTimeString());
                _event.SubItems.Add(this.textBox1.Text);
                ListInfo.Items.Add(_event);
            }
            Data.Refresh(ListInfo);
            this.Close();
        }

    }
}
