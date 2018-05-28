using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPeState
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            TaskPanel.Controls.Clear();
            UCSearch SearchPanel = new UCSearch();
            TaskPanel.Controls.Add(SearchPanel);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            TaskPanel.Controls.Clear();
            UCAdd AddPanel = new UCAdd();
            TaskPanel.Controls.Add(AddPanel);
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            TaskPanel.Controls.Clear();
            UCDel DelPanel = new UCDel();
            TaskPanel.Controls.Add(DelPanel);
        }
    }
}
