using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CTF3001_Group_Project
{
    public partial class Form_Superb : Form
    {
        public Form_Superb(String SkodaReturn)
        {
            InitializeComponent();
        }

        public static String SkodaReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£23,190";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€26,857.45";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$30,110.94";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$40,479.77";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$42,662.82";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.30,667.15";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;285,565.83";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$45,108.49";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥202,859.16";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥3,354,780.02";
            }

            else
            {
            }
        }

        //Changes the type of Measurment System used on the form (Metric or Imperial)
        private void ComboBox_MeasurementSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_MeasurementSystem.SelectedIndex == 0)
            {
                Label_Height.Text = "1477 mm";
                Label_Length.Text = "4856 mm";
                Label_Width.Text = "2031 mm";
                Label_Wheelbase.Text = "2841 mm";
                Label_Weight.Text = "2073 kg";
                Label_TankCapacity.Text = "66 Liters";
                Label_EnginePower.Text = "110 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "58.15 in";
                Label_Length.Text = "191.18 in";
                Label_Width.Text = "79.96 in";
                Label_Wheelbase.Text = "111.85 in";
                Label_Weight.Text = "326.44 stone";
                Label_TankCapacity.Text = "17.44 gal";
                Label_EnginePower.Text = "150 BHP";

            }

            else
            {
            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.topgear.com/car-reviews/skoda/superb-estate/15-tsi-s-5dr/spec");
        }

        /*Checks the public variable for the form the user came from, closes the current 
         * form and re-opens the form the user was previsouly on*/
        private void Button_Return_Click(object sender, EventArgs e)
        {
            if (SkodaReturn == "1")
            {

                Form_SkodaCars SkodaCars = new Form_SkodaCars("");
                SkodaCars.Show();

                this.Close();

            }

            else if (SkodaReturn == "2")
            {

                Form_PriceRange2 PriceRange2 = new Form_PriceRange2("", "", "", "");
                PriceRange2.Show();

                this.Close();

            }

            else
            {
            }
        }
    }
}
