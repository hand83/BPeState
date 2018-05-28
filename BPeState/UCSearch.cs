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
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace BPeState
{
    public partial class UCSearch : UserControl
    {

        tudbaseEntities2 context = new tudbaseEntities2();
        // Default filter values
        double defPriceMin = 0;
        double defPriceMax;
        int defAreaMin = 0;
        int defAreaMax;
        int defRoomMin = 0;
        int defRoomMax;
        int defNDistrict = 0;
        // Actual filter values
        double priceMin, priceMax;
        int areaMin, areaMax, roomMin, roomMax, nDistrict;

        public UCSearch()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            // Loading tables
            context.Investments.Load();
            context.ISs.Load();
            context.Streets.Load();

            // Set datasource for District ComboBox
            // option to select all added
            List<string> DSelectList = new List<string>() { "all" };
            var DistrictList = from s in context.Streets.Local
                               orderby s.District
                               group s by s.District into g
                               select g.FirstOrDefault().District.ToString();
            DSelectList.AddRange(DistrictList.ToList());
            CBDistrict.DataSource = DSelectList;         

            // Set default maximum filter values
            defPriceMax = (double)context.Investments.Local.Max(x => x.Price_max);
            defAreaMax = context.Investments.Local.Max(x => x.Area_max);
            defRoomMax = context.Investments.Local.Max(x => x.Rooms_max);

            // Set initial filter values
            priceMax = defPriceMax;
            priceMin = defPriceMin;
            areaMin = defAreaMin;
            areaMax = defAreaMax;
            roomMin = defRoomMin;
            roomMax = defRoomMax;
            nDistrict = defNDistrict;

            // Set DataGridView to show all records
            UpdateTable();
        }
  
        private void UpdateTable()
        {
            // SET DGVInv DATAGRIDVIEW TO SHOW ALL RECORDS
            // Setting bounded datasources
            //iSBindingSource.DataSource = context.ISs.Local;
            investmentBindingSource.DataSource = context.Investments.Local;
            streetBindingSource.DataSource = context.Streets.Local;
            // Obtaining initial table and setting as datasource
            var IniTable =
                from s in context.ISs.Local
                where
                    (double)s.Investment.Price_max >= priceMin &&
                    (double)s.Investment.Price_min <= priceMax &&
                    s.Investment.Area_max >= areaMin &&
                    s.Investment.Area_min <= areaMax &&
                    s.Investment.Rooms_max >= roomMin &&
                    s.Investment.Rooms_min <= roomMax &&
                    (nDistrict == defNDistrict || nDistrict == s.Street.District)
                orderby s.Investment.Price_min / s.Investment.Area_min
                group s by s.Investments_FK into g
                select new
                {
                    g.FirstOrDefault().Investments_FK,
                    g.FirstOrDefault().Streets_FK
                };
            iSBindingSource.DataSource = IniTable.ToList();

        }

        private void UpdateFilter()
        {
            // SET DGVInv DATAGRIDVIEW TO SHOW FILTERED RECORDS
            // min price
            if (TBPriceMin.Text == "")
            {
                priceMin = defPriceMin;
            }
            else if (TBPriceMin.BackColor == Color.White)
            {
                priceMin = double.Parse(TBPriceMin.Text);
            }
            // max price
            if (TBPriceMax.Text == "")
            {
                priceMax = defPriceMax;
            }
            else if (TBPriceMax.BackColor == Color.White)
            {
                priceMax = double.Parse(TBPriceMax.Text);
            }
            // min area
            if (TBAreaMin.Text == "")
            {
                areaMin = defAreaMin;
            }
            else if (TBAreaMin.BackColor == Color.White)
            {
                areaMin = int.Parse(TBAreaMin.Text);
            }
            // max area
            if (TBAreaMax.Text == "")
            {
                areaMax = defAreaMax;
            }
            else if (TBAreaMax.BackColor == Color.White)
            {
                areaMax = int.Parse(TBAreaMax.Text);
            }
            // min room
            if (TBRoomsMin.Text == "")
            {
                roomMin = defRoomMin;
            }
            else if (TBRoomsMin.BackColor == Color.White)
            {
                roomMin = int.Parse(TBRoomsMin.Text);
            }
            // max room
            if (TBRoomsMax.Text == "")
            {
                roomMax = defRoomMax;
            }
            else if (TBRoomsMin.BackColor == Color.White)
            {
                roomMax = int.Parse(TBRoomsMax.Text);
            }
            // district
            if (CBDistrict.SelectedValue.ToString() == "all")
            {
                nDistrict = defNDistrict;
            } else
            {
                nDistrict = int.Parse(CBDistrict.SelectedValue.ToString());
            }

            UpdateTable();

        }

        private void TBFloatValidate(object sender, EventArgs e)
        {
            Regex rex = new Regex(@"(^$)|(^[0-9]+$)|(^[0-9]+[.][0-9]+$)");
            TextBox TB = (TextBox)sender;
            if (!rex.IsMatch(TB.Text))
            {
                TB.BackColor = Color.LightSalmon;
            } else
            {
                TB.BackColor = Color.White;
                UpdateFilter();
            }

        }

        private void TBIntValidate(object sender, EventArgs e)
        {
            Regex rex = new Regex(@"(^$)|(^[0-9]+$)");
            TextBox TB = (TextBox)sender;
            if (!rex.IsMatch(TB.Text))
            {
                TB.BackColor = Color.LightSalmon;
            }
            else
            {
                TB.BackColor = Color.White;
                UpdateFilter();
            }
        }

        private void CBDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }
    }
}
