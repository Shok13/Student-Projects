using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Timetable
{
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            Button add_Button = new Button();

            add_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            add_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            add_Button.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            add_Button.ForeColor = System.Drawing.Color.Green;
            add_Button.Location = new System.Drawing.Point(271, 3);
            add_Button.Name = "add_Button";
            add_Button.Size = new System.Drawing.Size(100, 48);
            add_Button.Text = "Add";
            add_Button.UseVisualStyleBackColor = false;
            add_Button.Click += new System.EventHandler(this.add_button_Click);
            tableLayoutPanel3.Controls.Add(add_Button, 0, 0);
        }

        private void TimeTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            var addEventWindow = new AddEventForm(this.listView1);
            addEventWindow.ShowDialog();
        }

        private void find_Button_Click(object sender, EventArgs e)
        {
            var search = new SearchForm(listView1);
            search.ShowDialog();
        }

        private void filter_Button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Data.Sort();
            int cnt = 0;
            for (int i = 0; i < Data.Count(); i++)
            {
                if (Data.GetData(i, Data.TypeData.Time).EndsWith("00"))
                {
                    Data.Insert(i, cnt++);
                }
            }
            Data.FillList(listView1);
        }

        private void allEvents_switch_CheckedChanged(object sender, EventArgs e)
        {
            if (allEvents_switch.Checked)
            {
                listView1.Items.Clear();
                Data.FillList(listView1);
                comboBox1.SelectedIndex = -1;
            }
            
        }

        private void allByCategory_switch_CheckedChanged(object sender, EventArgs e)
        {
            if (allByCategory_switch.Checked)
            {
                comboBox1.SelectedIndex = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text != comboBox1.Text)
                    {
                        listView1.BeginUpdate();
                        listView1.Items[i].Remove();
                        i--;
                        listView1.EndUpdate();
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Data.FillList(listView1);
            if (allByCategory_switch.Checked)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text != comboBox1.Text)
                    {
                        listView1.BeginUpdate();
                        listView1.Items[i].Remove();
                        i--;
                        listView1.EndUpdate();
                    }
                }
            }
        }

        private void editRC_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem.Index != -1)
            {
                var addEventWindow = new AddEventForm(this.listView1, listView1.FocusedItem.Index);
                addEventWindow.ShowDialog();
            }
        }

        private void removeRC_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem.Index != -1)
            {
                var index = listView1.FocusedItem.Index;
                var caption = "Delete record?";
                var result = MessageBox.Show($"Are you sure you want to delete the record <{listView1.Items[index].SubItems[1].Text} / {listView1.Items[index].SubItems[2].Text} / {listView1.Items[index].SubItems[3].Text} >?", caption, MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    listView1.BeginUpdate();
                    listView1.Items[listView1.FocusedItem.Index].Remove();
                    listView1.EndUpdate();
                    Data.Refresh(listView1);
                }
            }
        }

        private void TimeTable_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                var saveDialog = new SaveFileDialog
                {
                    FileName = "Events",
                    DefaultExt = "txt",
                    AddExtension = true,
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };
                if(saveDialog.ShowDialog() == DialogResult.OK)
                {
                    Data.WriteInfo(saveDialog.FileName);
                }
            }
            if(e.Control && e.KeyCode == Keys.O)
            {
                var openDialog = new OpenFileDialog
                {
                    DefaultExt = "txt",
                    AddExtension = true,
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    Data.ReadInfo(openDialog.OpenFile());
                    listView1.Items.Clear();
                    Data.FillList(listView1);
                }
            }
            if(e.KeyCode == Keys.Delete)
            {
                listView1.BeginUpdate();
                try
                {
                    var index = listView1.FocusedItem.Index;
                    var caption = "Delete record?";
                    var result = MessageBox.Show($"Are you sure you want to delete the record <{listView1.Items[index].SubItems[1].Text} / {listView1.Items[index].SubItems[2].Text} / {listView1.Items[index].SubItems[3].Text} >?", caption, MessageBoxButtons.YesNo);
                    listView1.FocusedItem.Remove();
                }
                catch 
                {
                    MessageBox.Show("You did not select an event!"); 
                };
                Data.Refresh(listView1);
                listView1.Items.Clear();
                Data.FillList(listView1);
                listView1.EndUpdate();
            }
        }
    }
}
