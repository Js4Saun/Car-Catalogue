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
    public partial class Form_Passat : Form
    {
        public Form_Passat(String VolkswagenReturn)
        {
            InitializeComponent();
        }

        public static String VolkswagenReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£25,830 ";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€30,056.08";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$33,681.93";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$45,198.63";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$47,807.84";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.34,342.53";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;319,991.54";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$50,468.87";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥226,848.04";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥3,751,810.82";
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
                Label_Height.Text = "1476 mm";
                Label_Length.Text = "4767 mm";
                Label_Width.Text = "2083 mm";
                Label_Wheelbase.Text = "2786 mm";
                Label_Weight.Text = "2020 kg";
                Label_TankCapacity.Text = "66 liters";
                Label_EnginePower.Text = "110 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "58.11 in";
                Label_Length.Text = "187.68 in";
                Label_Width.Text = "82.01 in";
                Label_Wheelbase.Text = "109.69 in";
                Label_Weight.Text = "318.1 stone";
                Label_TankCapacity.Text = "14.52 gal";
                Label_EnginePower.Text = "150 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.volkswagen.co.uk/new-passat");
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
