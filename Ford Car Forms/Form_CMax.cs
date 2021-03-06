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
    public partial class Form_CMax : Form
    {
        public Form_CMax(String FordReturn)
        {
            InitializeComponent();
        }

        public static String FordReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£21,000";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€24,392.24";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$27,380.11";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$36,839.67";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$38,829.66";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.27,887.33";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;259,360.88";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$40,998.30";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥184,447.20";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥3.047.152.67";
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
                Label_Height.Text = "1601 mm";
                Label_Length.Text = "4379 mm";
                Label_Width.Text = "2067 mm";
                Label_Wheelbase.Text = "2680 mm";
                Label_Weight.Text = "1473 kg";
                Label_TankCapacity.Text = "55 Liters";
                Label_EnginePower.Text = "74 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "63.03 in";
                Label_Length.Text = "172.40 in";
                Label_Width.Text = "81.38 in";
                Label_Wheelbase.Text = "98 in";
                Label_Weight.Text = "231.96 stone";
                Label_TankCapacity.Text = "12.1 gal";
                Label_EnginePower.Text = "100 BHP";

            }
        }

        /*Checks the public variable for the form the user came from, closes the current 
         * form and re-opens the form the user was previsouly on*/
        private void Button_Return_Click(object sender, EventArgs e)
        {
            if (FordReturn == "1")
            {

                Form_FordCars FordCars = new Form_FordCars("");
                FordCars.Show();

                this.Close();

            }

            else if (FordReturn == "2")
            {

                Form_PriceRange2 PriceRange2 = new Form_PriceRange2("", "", "", "");
                PriceRange2.Show();

                this.Close();

            }

            else
            {
            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ford.co.uk/cars/c-max");
        }
    }
}
