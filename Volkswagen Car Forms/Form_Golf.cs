using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTF3001_Group_Project.Volkswagen_Car_Forms
{
    public partial class Form_Golf : Form
    {
        public Form_Golf(String VolkswagenReturn)
        {
            InitializeComponent();
        }

        public static String VolkswagenReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£24,830";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€28,892.47";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$32,378.32";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$43,456.85";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$45,956.49";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.33,018.60";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;307,659.44";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$48,522.15";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥218,061.51";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥3,606,103.25";
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
                Label_Height.Text = "1492 mm";
                Label_Length.Text = "4258 mm";
                Label_Width.Text = "1790 mm";
                Label_Wheelbase.Text = "2620 mm";
                Label_Weight.Text = "1800 kg";
                Label_TankCapacity.Text = "50 liters";
                Label_EnginePower.Text = "90 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "58.74 in";
                Label_Length.Text = "167.64 in";
                Label_Width.Text = "70.47 in";
                Label_Wheelbase.Text = "103.15 in";
                Label_Weight.Text = "283.45 stone";
                Label_TankCapacity.Text = "11 gal";
                Label_EnginePower.Text = "128 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.volkswagen.co.uk/new/golf");
        }

        /*Checks the public variable for the form the user came from, closes the current 
         * form and re-opens the form the user was previsouly on*/
        private void Button_Return_Click(object sender, EventArgs e)
        {
            if (VolkswagenReturn == "1")
            {

                Form_VolkswagenCars VolkswagenCars = new Form_VolkswagenCars("");
                VolkswagenCars.Show();

                this.Close();

            }

            else if (VolkswagenReturn == "2")
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
