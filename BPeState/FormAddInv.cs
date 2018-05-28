using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPeState
{
    public partial class FormAddInv : Form
    {
        public FormAddInv()
        {
            InitializeComponent();
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void TBName_Validating(object sender, CancelEventArgs e)
        {
            TextBox TB = (TextBox)sender;
            if (!string.IsNullOrEmpty(TB.Text))
            {
                e.Cancel = false;
                TB.BackColor = Color.White;
            } else
            {
                e.Cancel = true;
                TB.BackColor = Color.LightSalmon;
            }
        }

        private void TBPrice_Validating(object sender, CancelEventArgs e)
        {
            TextBox TB = (TextBox)sender;
            Regex rex = new Regex(@"(^[0-9]+$)|(^[0-9]+[.][0-9]+$)");
            if (rex.IsMatch(TB.Text))
            {
                if(rex.IsMatch(TBMaxPrice.Text) && rex.IsMatch(TBMinPrice.Text) && double.Parse(TBMaxPrice.Text) < double.Parse(TBMinPrice.Text))
                {
                    e.Cancel = true;
                    TB.BackColor = Color.LightSalmon;
                    return;
                }
                e.Cancel = false;
                TB.BackColor = Color.White;
                return;
            } else
            {
                e.Cancel = true;
                TB.BackColor = Color.LightSalmon;
                return;
            }
        }

        private void TBArea_Validating(object sender, CancelEventArgs e)
        {
            TextBox TB = (TextBox)sender;
            Regex rex = new Regex(@"^[0-9]+$");
            if (rex.IsMatch(TB.Text))
            {
                if (rex.IsMatch(TBMinArea.Text) && rex.IsMatch(TBMaxArea.Text) && int.Parse(TBMaxArea.Text) < int.Parse(TBMinArea.Text))
                {
                    e.Cancel = true;
                    TB.BackColor = Color.LightSalmon;
                    return;
                }
                e.Cancel = false;
                TB.BackColor = Color.White;
                return;
            }
            else
            {
                e.Cancel = true;
                TB.BackColor = Color.LightSalmon;
                return;
            }
        }

        private void TBRooms_Validating(object sender, CancelEventArgs e)
        {
            TextBox TB = (TextBox)sender;
            Regex rex = new Regex(@"^[0-9]+$");
            if (rex.IsMatch(TB.Text))
            {
                if (rex.IsMatch(TBMinRooms.Text) && rex.IsMatch(TBMaxRooms.Text) && int.Parse(TBMaxRooms.Text) < int.Parse(TBMinRooms.Text))
                {
                    e.Cancel = true;
                    TB.BackColor = Color.LightSalmon;
                    return;
                }
                e.Cancel = false;
                TB.BackColor = Color.White;
                return;
            }
            else
            {
                e.Cancel = true;
                TB.BackColor = Color.LightSalmon;
                return;
            }
        }

        private void TBNHomes_Validating(object sender, CancelEventArgs e)
        {
            TextBox TB = (TextBox)sender;
            Regex rex = new Regex(@"^[0-9]+$");
            if (rex.IsMatch(TB.Text))
            {
                e.Cancel = false;
                TB.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                TB.BackColor = Color.LightSalmon;
            }
        }
    }
}
