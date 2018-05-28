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
    public partial class UCDel : UserControl
    {
        // Possible choices for table selection
        List<string> TableList = new List<string> { "Investments", "Contractors", "Streets", "Transport" };
        
        public UCDel()
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
                UCDelInvestment InvPanel = new UCDelInvestment();
                SubPanel.Controls.Add(InvPanel);

            } else if (STable == TableList[1])
            {
                SubPanel.Controls.Clear();
                UCDelContractor ConPanel = new UCDelContractor();
                SubPanel.Controls.Add(ConPanel);

            } else if (STable == TableList[2])
            {
                SubPanel.Controls.Clear();
                UCDelStreet StrPanel = new UCDelStreet();
                SubPanel.Controls.Add(StrPanel);

            } else if (STable == TableList[3])
            {
                SubPanel.Controls.Clear();
                UCDelTransport TrPanel = new UCDelTransport();
                SubPanel.Controls.Add(TrPanel);

            }
        }
    }
}
