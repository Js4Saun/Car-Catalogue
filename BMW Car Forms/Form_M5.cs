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

namespace CTF3001_Group_Project.BMW_Car_Forms
{
    public partial class Form_M5 : Form
    {
        public Form_M5(String BMWReturn)
        {
            InitializeComponent();
        }

        public static String BMWReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£89,610";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€104,211.50";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$116,869.36";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$156,780.83";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$165,830.47";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.119,118.57";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;1,109,602.78";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$175,055.74";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥786,910.73";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥13,012,863.73";
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
                Label_Height.Text = "1473 mm";
                Label_Length.Text = "4966 mm";
                Label_Width.Text = "2126 mm";
                Label_Wheelbase.Text = "2982 mm";
                Label_Weight.Text = "1955 kg";
                Label_TankCapacity.Text = "68 liters";
                Label_EnginePower.Text = "441 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "57.99 in";
                Label_Length.Text = "195.51 in";
                Label_Width.Text = "83.7 in";
                Label_Wheelbase.Text = "117.40 in";
                Label_Weight.Text = "307.86 stone";
                Label_TankCapacity.Text = "14.96 gal";
                Label_EnginePower.Text = "600 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bmw.co.uk/bmw-cars/bmw-m/2017-m5-saloon");
        }

        /*Checks the public variable for the form the user came from, closes the current 
         * form and re-opens the form the user was previsouly on*/
        private void Button_Return_Click(object sender, EventArgs e)
        {
            if (BMWReturn == "1")
            {

                Form_BMWCars BMWCars = new Form_BMWCars("");
                BMWCars.Show();

                this.Close();

            }

            else if (BMWReturn == "2")
            {

                Form_PriceRange4 PriceRange4 = new Form_PriceRange4("", "");
                PriceRange4.Show();

                this.Close();

            }

            else
            {
            }
        }
    }
}
