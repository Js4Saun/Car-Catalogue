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
    public partial class Form_Polo : Form
    {
        public Form_Polo(String VolkswagenReturn)
        {
            InitializeComponent();
        }

        public static String VolkswagenReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£15,735";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€18,226.09";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$20,293.43";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$27,374.21";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$28,940.46";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.20,705.39";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;193,429.26";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$30,651.23";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥136,848.87";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥2,263,967.54";
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
                Label_Height.Text = "1990 mm";
                Label_Length.Text = "4067 mm";
                Label_Width.Text = "1964 mm";
                Label_Wheelbase.Text = "2549 mm";
                Label_Weight.Text = "641 kg";
                Label_TankCapacity.Text = "40 Liters";
                Label_EnginePower.Text = "70 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "78.35 in";
                Label_Length.Text = "160.12 in";
                Label_Width.Text = "77.32 in";
                Label_Wheelbase.Text = "100.35 in";
                Label_Weight.Text = "100.94 stone";
                Label_TankCapacity.Text = "8.8 gal";
                Label_EnginePower.Text = "93 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.volkswagen.co.uk/new/polo");
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

                Form_PriceRange1 PriceRange1 = new Form_PriceRange1("", "", "");
                PriceRange1.Show();

                this.Close();

            }

            else
            {
            }
        }
    }
}
