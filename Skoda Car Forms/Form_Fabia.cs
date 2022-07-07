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
    public partial class Form_Fabia : Form
    {
        public Form_Fabia(String SkodaReturn)
        {
            InitializeComponent();
        }

        public static String SkodaReturn;

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

                Form_PriceRange1 PriceRange1 = new Form_PriceRange1("", "", "");
                PriceRange1.Show();

                this.Close();

            }

            else
            {
            }
        }      


        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£16,425";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€19,025.32";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$21,182.83";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$28,573.62";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$30,208.20";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.21,614.85";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;201,906.78";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$31,992.04";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥142,873.68";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥2,364,411.60";
            }

            else
            {
            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.topgear.com/car-reviews/skoda/fabia/12-tsi-monte-carlo-5dr/spec-0");
        }

        //Changes the type of Measurment System used on the form (Metric or Imperial)
        private void ComboBox_MeasurementSystem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ComboBox_MeasurementSystem.SelectedIndex == 0)
            {
                Label_Height.Text = "1475 mm";
                Label_Length.Text = "4028 mm";
                Label_Width.Text = "1810 mm";
                Label_Wheelbase.Text = "2470 mm";
                Label_Weight.Text = "1584 kg";
                Label_TankCapacity.Text = "45 Liters";
                Label_EnginePower.Text = "81 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "58.07 in";
                Label_Length.Text = "158.58 in";
                Label_Width.Text = "71.26 in";
                Label_Wheelbase.Text = "97.24 in";
                Label_Weight.Text = "249.44 stone";
                Label_TankCapacity.Text = "11.89 gal";
                Label_EnginePower.Text = "108.62 BHP";

            }

            else
            {
            }
        }

        private void Label_Price_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Fabia_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
