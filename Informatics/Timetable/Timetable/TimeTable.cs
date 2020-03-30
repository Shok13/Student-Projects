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
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
            this.ControlAdded += add_button;
        }

        private void add_button(object sender, ControlEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
