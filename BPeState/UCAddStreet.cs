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
    public partial class UCAddStreet : UserControl
    {
        // All possible choices for districts
        List<int> DistrictList = Enumerable.Range(1, 23).ToList();
        tudbaseEntities2 context = new tudbaseEntities2();

        public UCAddStreet()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            CBDistrict.DataSource = DistrictList;

            context.Streets.Load();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Save new record if not empty
            if (!string.IsNullOrEmpty(TBStreet.Text))
            {
                Street Str = new Street();
                Str.District = byte.Parse(CBDistrict.SelectedValue.ToString());
                Str.Name = TBStreet.Text;
                context.Streets.Add(Str);
                context.SaveChanges();
                TBStreet.Text = "";
                
            }
        }
    }
}
