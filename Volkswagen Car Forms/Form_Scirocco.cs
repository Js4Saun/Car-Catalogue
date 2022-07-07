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

namespace CTF3001_Group_Project.Choice_Menu_and_Car_Manufacturer_Menus_Forms
{
    public partial class Form_Scirocco : Form
    {
        public Form_Scirocco(String VolkswagenReturn)
        {
            InitializeComponent();
        }

        public static String VolkswagenReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£19,780";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€22,907.74";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$25,504.33";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$34,402.46";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$36,373.94";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.26,028.50";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;243,135.76";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$38,523.33";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥172,013.61";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥2,847,370.56";
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
                Label_Height.Text = "1404 mm";
                Label_Length.Text = "4256 mm";
                Label_Width.Text = "1910 mm";
                Label_Wheelbase.Text = "2649 mm";
                Label_Weight.Text = "1244 kg";
                Label_TankCapacity.Text = "46 Liters";
                Label_EnginePower.Text = "90 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "55.28 in";
                Label_Length.Text = "167.56 in";
                Label_Width.Text = "75.2 in";
                Label_Wheelbase.Text = "104.29 in";
                Label_Weight.Text = "195.9 stone";
                Label_TankCapacity.Text = "10.12 gal";
                Label_EnginePower.Text = "122 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.topgear.com/car-reviews/volkswagen/scirocco");
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
