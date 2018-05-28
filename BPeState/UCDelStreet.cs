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
    public partial class UCDelStreet : UserControl
    {
        tudbaseEntities2 context = new tudbaseEntities2();
        
        public UCDelStreet()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            context.Streets.Load();
            context.ISs.Load();

            // Districts to display
            var DistrictList = from S in context.Streets.Local
                               orderby S.District
                               group S by S.District into g
                               select new
                               {
                                   g.FirstOrDefault().District
                               };
            CBDistrict.DisplayMember = "District";
            CBDistrict.ValueMember = "District";
            CBDistrict.SelectedValueChanged += CBDistrict_SelectedValueChanged;
            CBDistrict.DataSource = DistrictList.ToList();
        }

        private void CBDistrict_SelectedValueChanged(object sender, EventArgs e)
        {
            // Streets to display
            ComboBox CB = (ComboBox)sender;
            var StrList = from S in context.Streets.Local
                          where S.District == (byte)CB.SelectedValue
                          orderby S.Name
                          select S;
            CBStreet.DataSource = StrList.ToList();
            CBStreet.DisplayMember = "Name";
            CBStreet.ValueMember = "Name";
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            dynamic SelDistrict = CBDistrict.SelectedValue;
            dynamic SelStreet = CBStreet.SelectedValue;
            if (SelStreet != null)
            {
                var DelStreet = from S in context.Streets.Local
                                where S.Name == SelStreet && S.District == SelDistrict
                                select S;

                // Delete from connected tables first
                var DelIS = from S in context.ISs.Local
                            where S.Streets_FK == DelStreet.FirstOrDefault().Streets_SK
                            select S;
                context.ISs.RemoveRange(DelIS);
                // Delete from Streets table
                context.Streets.Remove(DelStreet.FirstOrDefault());
                context.SaveChanges();
                // Update District List
                var DistrictList = from S in context.Streets.Local
                                   orderby S.District
                                   group S by S.District into g
                                   select new
                                   {
                                       g.FirstOrDefault().District
                                   };
                CBDistrict.DataSource = DistrictList.ToList();

            }



        }
    }
}
