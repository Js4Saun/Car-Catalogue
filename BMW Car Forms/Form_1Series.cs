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
    public partial class Form_1Series : Form
    {
        public Form_1Series(String BMWReturn)
        {
            InitializeComponent();
        }

        public static String BMWReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£35,430";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€41,219.08";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$46,208.34";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$62,006.74";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$65,565.01";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.47,100.39";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;438,990.10";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$69,210.39";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥311,273.81";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥5,146,751.85";
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
                Label_Height.Text = "1411 mm";
                Label_Length.Text = "4324 mm";
                Label_Width.Text = "1984 mm";
                Label_Wheelbase.Text = "2690 mm";
                Label_Weight.Text = "1470 kg";
                Label_TankCapacity.Text = "52 liters";
                Label_EnginePower.Text = "250 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "55.55 in";
                Label_Length.Text = "170.24 in";
                Label_Width.Text = "78.11 in";
                Label_Wheelbase.Text = "105.91 in";
                Label_Weight.Text = "231.49 stone";
                Label_TankCapacity.Text = "11.44 gal";
                Label_EnginePower.Text = "340 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bmw.co.uk/bmw-cars/1-series");
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

                Form_PriceRange3 PriceRange3 = new Form_PriceRange3("", "", "");
                PriceRange3.Show();

                this.Close();

            }

            else
            {
            }
        }
    }
}
