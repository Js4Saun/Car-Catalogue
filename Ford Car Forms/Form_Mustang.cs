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

namespace CTF3001_Group_Project.Ford_Car_Forms
{
    public partial class Form_Mustang : Form
    {
        public Form_Mustang(String FordReturn)
        {
            InitializeComponent();
        }

        public static String FordReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£31,513";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€36,607.08";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$41,096.89";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$55,288.47";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$58,297.99";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.41,845.60";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;389,421.90";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$61,536.70";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥276,781.83";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥4,571,477.26";
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
                Label_Height.Text = "1382 mm";
                Label_Length.Text = "4789 mm";
                Label_Width.Text = "2097 mm";
                Label_Wheelbase.Text = "2791 mm";
                Label_Weight.Text = "1473 kg";
                Label_TankCapacity.Text = "58 Liters";
                Label_EnginePower.Text = "343 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "54.41 in";
                Label_Length.Text = "188.54 in";
                Label_Width.Text = "82.56 in";
                Label_Wheelbase.Text = "109.88 in";
                Label_Weight.Text = "231.96 stone";
                Label_TankCapacity.Text = "12.76 gal";
                Label_EnginePower.Text = "460 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.ford.co.uk/cars/mustang");
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
