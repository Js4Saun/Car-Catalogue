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
    public partial class Form_Focus : Form
    {
        public Form_Focus(String FordReturn)
        {
            InitializeComponent();
        }

        public static String FordReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£27.990";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€32,511.36";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$36,491.96";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$49,099.57";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$51,763.45";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.37,157.98";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;345,882.27";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$54,659.21";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥245,796.47";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥4,060,408.35";
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
                Label_Height.Text = "1473.2 mm";
                Label_Length.Text = "4343.4 mm";
                Label_Width.Text = "1803.4 mm";
                Label_Wheelbase.Text = "2641.6 mm";
                Label_Weight.Text = "1560 kg";
                Label_TankCapacity.Text = "54 Liters";
                Label_EnginePower.Text = "184 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "58 in";
                Label_Length.Text = "171 in";
                Label_Width.Text = "71 in";
                Label_Wheelbase.Text = "104 in";
                Label_Weight.Text = "245.66 stone";
                Label_TankCapacity.Text = "11.88 gal";
                Label_EnginePower.Text = "247 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.topgear.com/car-reviews/ford/focus");
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
    }
}
