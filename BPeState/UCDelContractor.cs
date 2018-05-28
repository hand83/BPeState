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
    public partial class UCDelContractor : UserControl
    {
        tudbaseEntities2 context = new tudbaseEntities2();

        public UCDelContractor()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            context.Contractors.Load();
            context.ICs.Load();
            CBContractor.DataSource = context.Contractors.Local.ToBindingList();
            CBContractor.DisplayMember = "Name";
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Contractor DelContr = (Contractor)CBContractor.SelectedItem;
            // Delete from connection tables first
            var DelIC = from S in context.ICs.Local
                        where S.Contractors_FK == DelContr.Contractors_SK
                        select S;
            context.ICs.RemoveRange(DelIC);
            // Delete from Contractor table
            context.Contractors.Remove(DelContr);
            context.SaveChanges();

        }
    }
}
