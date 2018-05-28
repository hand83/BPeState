using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BPeState
{
    public partial class UCAddTransport : UserControl
    {
        // List of choices for public transport
        List<string> TransportList = new List<string> { "Bus", "Metro", "Tram", "Trolley", "Suburban rail"};

        tudbaseEntities2 context = new tudbaseEntities2();

        public UCAddTransport()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            CBTransport.DataSource = TransportList;

            context.Transports.Load();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Transport Tr = new Transport();
            Tr.Type = (string)CBTransport.SelectedItem;
            Tr.Number = (int)NTransport.Value;
            context.Transports.Add(Tr);
            context.SaveChanges();
        }
    }
}
