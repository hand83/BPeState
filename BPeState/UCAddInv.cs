using System;
using System.Collections;
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
    public partial class UCAddInv : UserControl
    {
        tudbaseEntities2 context = new tudbaseEntities2();

        // selected item bindingsources
        BindingSource SelContr = new BindingSource();
        BindingSource SelStr = new BindingSource();
        BindingSource SelTr = new BindingSource();
        // selected Investment item
        Investment NewInv = new Investment();

        public UCAddInv()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            context.Investments.Load();
            context.Contractors.Load();
            context.Streets.Load();
            context.Transports.Load();
            context.ICs.Load();
            context.ISs.Load();
            context.IT.Load();

            // All contractors datasource
            // Data binding has to be done before event assignment
            CBAllContr.DataSource = context.Contractors.Local.ToList();
            CBAllContr.DisplayMember = "Name";
            CBAllContr.ValueMember = "Contractors_SK";
            CBAllContr.SelectedIndexChanged += new EventHandler(CBAllContr_SelectedIndexChanged);


            // All streets datasource
            // Data binding has to be done before event assignment
            var AllStreets = from S in context.Streets.Local
                             select new {
                                 ComboName = S.District.ToString() + " - " + S.Name,
                                 S.Streets_SK
                             };
            CBAllStr.DataSource = AllStreets.ToList();
            CBAllStr.DisplayMember = "ComboName";
            CBAllStr.ValueMember = "Streets_SK";
            CBAllStr.SelectedIndexChanged += new EventHandler(CBAllStr_SelectedIndexChanged);

            // All transport datasource
            // Data binding has to be done before event assignment
            var AllTrans = from T in context.Transports.Local
                           select new
                           {
                               ComboName = T.Type + " " + T.Number.ToString(),
                               T.Transport_SK
                           };
            CBAllTr.DataSource = AllTrans.ToList();
            CBAllTr.DisplayMember = "ComboName";
            CBAllTr.ValueMember = "Transport_SK";
            CBAllTr.SelectedIndexChanged += new EventHandler(CBAllTr_SelectedIndexChanged);

            // Selected contractor datasource
            LBSelectedContr.DataSource = SelContr;
            // Selected street datasource
            LBSelectedStr.DataSource = SelStr;
            // Selected transport datasource
            LBSelectedTr.DataSource = SelTr;

        }

        private void ButtonData_Click(object sender, EventArgs e)
        {
            // Get user input data for new Investment record
            FormAddInv AddInv = new FormAddInv();
            if (AddInv.ShowDialog() != DialogResult.OK) return;
            NewInv.Name = AddInv.TBName.Text;
            NewInv.Price_min = (decimal)double.Parse(AddInv.TBMinPrice.Text);
            NewInv.Price_max = (decimal)double.Parse(AddInv.TBMaxPrice.Text);
            NewInv.Area_min = int.Parse(AddInv.TBMinArea.Text);
            NewInv.Area_max = int.Parse(AddInv.TBMaxArea.Text);
            NewInv.Rooms_min = byte.Parse(AddInv.TBMinRooms.Text);
            NewInv.Rooms_max = byte.Parse(AddInv.TBMaxRooms.Text);
            NewInv.No_of_homes = int.Parse(AddInv.TBNHomes.Text);
            NewInv.Date_of_finish = AddInv.DatePicker.Value.Date;
            BindingSource BS = new BindingSource();
            BS.Add(NewInv);
            DGVAdd.DataSource = BS;
            DGVAdd.Columns["Investments_SK"].Visible = false;
            DGVAdd.Columns["ICs"].Visible = false;
            DGVAdd.Columns["ISs"].Visible = false;
            DGVAdd.Columns["IT"].Visible = false;

        }

        private void CBAllContr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Put item from all Contractors list to selected Contractors list
            ComboBox CB = (ComboBox)sender;
            if(!SelContr.Contains(CB.SelectedItem)){
                SelContr.Add(CB.SelectedItem);
            }
            LBSelectedContr.DisplayMember = "Name";
            LBSelectedContr.ValueMember = "Contractors_SK";
        }

        private void CBAllStr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Put item from all Streets list to selected Streets list
            ComboBox CB = (ComboBox)sender;
            if (!SelStr.Contains(CB.SelectedItem))
            {
                SelStr.Add(CB.SelectedItem);
            }
            LBSelectedStr.DisplayMember = "ComboName";
            LBSelectedStr.ValueMember = "Streets_SK";
        }

        private void CBAllTr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Put item from all Transport list to selected Transport list
            ComboBox CB = (ComboBox)sender;
            if (!SelTr.Contains(CB.SelectedItem))
            {
                SelTr.Add(CB.SelectedItem);
            }
            LBSelectedTr.DisplayMember = "ComboName";
            LBSelectedTr.ValueMember = "Transport_SK";
        }

        private void ButtonRemoveContr_Click(object sender, EventArgs e)
        {
            // Remove item from selected Contractor list
            if (SelContr.Count > 0)
            {
                SelContr.RemoveAt(LBSelectedContr.SelectedIndex);
            }
        }

        private void ButtonRemoveStr_Click(object sender, EventArgs e)
        {
            // Remove item from selected Streets list
            if (SelStr.Count > 0)
            {
                SelStr.RemoveAt(LBSelectedStr.SelectedIndex);
            }
        }

        private void ButtonRemoveTr_Click(object sender, EventArgs e)
        {
            // Remove item from selected Transport list
            if (SelTr.Count > 0)
            {
                SelTr.RemoveAt(LBSelectedTr.SelectedIndex);
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(NewInv.Name) && SelStr.Count > 0)
            {
                // Street record cannot be null
                context.Investments.Add(NewInv);
                context.SaveChanges();
                
                // Add to IS
                for (int ndx = 0; ndx < SelStr.Count; ndx++)
                {
                    dynamic d = SelStr[ndx];
                    IS InvStr = new IS();
                    InvStr.Investments_FK = NewInv.Investments_SK;
                    InvStr.Streets_FK = d.Streets_SK;
                    context.ISs.Add(InvStr);
                }
                // Add to IC
                for (int ndx = 0; ndx < SelContr.Count; ndx++)
                {
                    dynamic d = SelContr[ndx];
                    IC InvContr = new IC();
                    InvContr.Investments_FK = NewInv.Investments_SK;
                    InvContr.Contractors_FK = d.Contractors_SK;
                    context.ICs.Add(InvContr);
                }
                // Add to IT
                for (int ndx = 0; ndx < SelTr.Count; ndx++)
                {
                    dynamic d = SelTr[ndx];
                    IT InvTr = new IT();
                    InvTr.Investments_FK = NewInv.Investments_SK;
                    InvTr.Transport_FK = d.Transport_SK;
                    context.IT.Add(InvTr);
                }
                context.SaveChanges();

                // Reset settings
                BindingSource BS = new BindingSource();
                DGVAdd.DataSource = BS;
                SelContr.Clear();
                SelStr.Clear();
                SelTr.Clear();
            }
            
            
        }
    }
}
