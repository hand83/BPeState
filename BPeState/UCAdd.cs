using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPeState
{
    public partial class UCAdd : UserControl
    {
        // Possible choices for table selection
        List<string> TableList = new List<string> { "Investments", "Contractors", "Streets", "Transport" };
        
        public UCAdd()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            
            // Set values for the ComboBox table selector
            CBTable.DataSource = TableList;
        }

        private void CBTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            string STable = CB.SelectedValue.ToString();
            if (STable == TableList[0])
            {
                SubPanel.Controls.Clear();
                UCAddInv InvPanel = new UCAddInv();
                SubPanel.Controls.Add(InvPanel);

            } else if (STable == TableList[1])
            {
                SubPanel.Controls.Clear();
                UCAddContractor ConPanel = new UCAddContractor();
                SubPanel.Controls.Add(ConPanel);

            } else if (STable == TableList[2])
            {
                SubPanel.Controls.Clear();
                UCAddStreet StrPanel = new UCAddStreet();
                SubPanel.Controls.Add(StrPanel);

            } else if (STable == TableList[3])
            {
                SubPanel.Controls.Clear();
                UCAddTransport TrPanel = new UCAddTransport();
                SubPanel.Controls.Add(TrPanel);

            }
        }
    }
}
