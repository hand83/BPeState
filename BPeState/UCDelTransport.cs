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
    public partial class UCDelTransport : UserControl
    {
        tudbaseEntities2 context = new tudbaseEntities2();

        public UCDelTransport()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            context.Transports.Load();
            context.IT.Load();

            // Transport modes to display
            var TransportModes = from S in context.Transports.Local
                                 group S by S.Type into g
                                 select new
                                 {
                                     g.FirstOrDefault().Type
                                 };
            CBTransport.DisplayMember = "Type";
            CBTransport.ValueMember = "Type";
            CBTransport.SelectedValueChanged += CBTransport_SelectedValueChanged;
            CBTransport.DataSource = TransportModes.ToList();

        }

        private void CBTransport_SelectedValueChanged(object sender, EventArgs e)
        {
            // Public transport numbers to display
            ComboBox CB = (ComboBox)sender;
            var Nlist = from S in context.Transports.Local
                        where S.Type == (string)CB.SelectedValue
                        orderby S.Number
                        select S;
            CBNumber.DataSource = Nlist.ToList();
            CBNumber.DisplayMember = "Number";
            CBNumber.ValueMember = "Number";
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            dynamic SelType = CBTransport.SelectedValue;
            dynamic SelNumber = CBNumber.SelectedValue;
            if(SelNumber != null)
            {
                var DelTr = from S in context.Transports.Local
                            where S.Type == SelType && S.Number == SelNumber
                            select S;
                // Delete from connected tables first
                var DelIT = from S in context.IT.Local
                            where S.Transport_FK == DelTr.FirstOrDefault().Transport_SK
                            select S;
                context.IT.RemoveRange(DelIT);
                // Delete from Transport table
                context.Transports.Remove(DelTr.FirstOrDefault());
                context.SaveChanges();
                // Update public transport type list
                var TransportModes = from S in context.Transports.Local
                                     group S by S.Type into g
                                     select new
                                     {
                                         g.FirstOrDefault().Type
                                     };
                CBTransport.DataSource = TransportModes.ToList();


            }
        }
    }
}
