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
    public partial class Form_X3 : Form
    {
        public Form_X3(String BMWReturn)
        {
            InitializeComponent();
        }

        public static String BMWReturn;


        private void Form_X3_Load(object sender, EventArgs e)
        {

        }

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£52,540";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€61,100.60";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$68,515.58";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$91,918.10";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$97,231.14";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.69,844.78";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;650,597.57";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$102,627.96";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥461,516.61";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥7,629,682.63";
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
                Label_Height.Text = "1676 mm";
                Label_Length.Text = "4716 mm";
                Label_Width.Text = "2138 mm";
                Label_Wheelbase.Text = "2864 mm";
                Label_Weight.Text = "2500 kg";
                Label_TankCapacity.Text = "68 liters";
                Label_EnginePower.Text = "240 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "65.98 in";
                Label_Length.Text = "185.67 in";
                Label_Width.Text = "84.17 in";
                Label_Wheelbase.Text = "112.76 in";
                Label_Weight.Text = "393.68 stone";
                Label_TankCapacity.Text = "14.96 gal";
                Label_EnginePower.Text = "326 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bmw.co.uk/bmw-cars/x-models/2017-x3");
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
