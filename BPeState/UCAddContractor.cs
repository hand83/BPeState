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
    public partial class UCAddContractor : UserControl
    {
        tudbaseEntities2 context = new tudbaseEntities2();

        public UCAddContractor()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            context.Contractors.Load();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Save new record if not empty
            if (!string.IsNullOrEmpty(TBContractor.Text))
            {
                Contractor Con = new Contractor();
                Con.Name = TBContractor.Text;
                context.Contractors.Add(Con);
                context.SaveChanges();
                TBContractor.Text = "";
            }
        }
    }
}
