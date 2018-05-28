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
    public partial class UCDelInvestment : UserControl
    {
        tudbaseEntities2 context = new tudbaseEntities2();
        Investment DelInv = new Investment();

        public UCDelInvestment()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            context.Investments.Load();
            context.ISs.Load();
            context.ICs.Load();
            context.IT.Load();
            CBInvName.DataSource = context.Investments.Local.ToBindingList();
            CBInvName.DisplayMember = "Name";
            CBInvName.SelectedIndexChanged += CBInvName_SelectedIndexChanged;
        }

        private void CBInvName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DelInv = (Investment)CBInvName.SelectedItem;
            BindingSource BS = new BindingSource();
            BS.Add(DelInv);
            DGVPreview.DataSource = BS;
            DGVPreview.Columns["Investments_SK"].Visible = false;
            DGVPreview.Columns["ICs"].Visible = false;
            DGVPreview.Columns["ISs"].Visible = false;
            DGVPreview.Columns["IT"].Visible = false;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DelInv.Name))
            {
                // Delete from connection tables first
                // IS
                var DelIS = from S in context.ISs.Local
                            where S.Investments_FK == DelInv.Investments_SK
                            select S;
                context.ISs.RemoveRange(DelIS);
                // IC
                var DelIC = from S in context.ICs.Local
                            where S.Investments_FK == DelInv.Investments_SK
                            select S;
                context.ICs.RemoveRange(DelIC);
                // IT
                var DelIT = from S in context.IT.Local
                            where S.Investments_FK == DelInv.Investments_SK
                            select S;
                context.IT.RemoveRange(DelIT);
                // Delete from Investment table
                context.Investments.Remove(DelInv);
                context.SaveChanges();
                BindingSource BS = new BindingSource();
                DGVPreview.DataSource = BS;




            }
        }
    }
}
