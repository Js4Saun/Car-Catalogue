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
    public partial class Form_Fiesta : Form
    {
        public Form_Fiesta(String FordReturn)
        {
            InitializeComponent();
        }

        public static String FordReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£20,695";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€24,031.65";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$26,976.14";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$36,308.53";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$38,275.82";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.27,498.13";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;255,662.93";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$40,418.47";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥181,728.05";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥3,002,896.41";
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
                Label_Height.Text = "1452.88 mm";
                Label_Length.Text = "4064 mm";
                Label_Width.Text = "1722.12 mm";
                Label_Wheelbase.Text = "2489.2 mm";
                Label_Weight.Text = "1233 kg";
                Label_TankCapacity.Text = "56 Liters";
                Label_EnginePower.Text = "146 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "57.2  in";
                Label_Length.Text = "160 in";
                Label_Width.Text = "67.8  in";
                Label_Wheelbase.Text = "98 in";
                Label_Weight.Text = "194.16 stone";
                Label_TankCapacity.Text = "12.32 gal";
                Label_EnginePower.Text = "197 BHP";

            }

            else
            {
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
            Process.Start("https://www.topgear.com/car-reviews/ford/fiesta-st");
        }
    }
}
