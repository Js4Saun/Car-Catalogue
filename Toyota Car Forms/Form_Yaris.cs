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

namespace CTF3001_Group_Project.Toyota_Car_Forms
{
    public partial class Form_Yaris : Form
    {
        public Form_Yaris(String ToyotaReturn)
        {
            InitializeComponent();
        }

        public static String ToyotaReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£25,740";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€29,927.55";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$33,536.77";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$45,053.14";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$47,671.77";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.34,218.07";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;318,856.95";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$50,337.46";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥226,016.02";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥3,737,932.75";
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
                Label_Height.Text = "1510 mm";
                Label_Length.Text = "3945 mm";
                Label_Width.Text = "1760 mm";
                Label_Wheelbase.Text = "2510 mm";
                Label_Weight.Text = "1545 kg";
                Label_TankCapacity.Text = "42 Liters";
                Label_EnginePower.Text = "156 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "59.45 in";
                Label_Length.Text = "155.32 in";
                Label_Width.Text = "69.29 in";
                Label_Wheelbase.Text = "98.82 in";
                Label_Weight.Text = "243.3 stone";
                Label_TankCapacity.Text = "9.2 gal";
                Label_EnginePower.Text = "212 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.toyota.co.uk/new-cars/yaris/");
        }

        /*Checks the public variable for the form the user came from, closes the current 
         * form and re-opens the form the user was previsouly on*/
        private void Button_Return_Click(object sender, EventArgs e)
        {
            if (ToyotaReturn == "1")
            {

                Form_ToyotaCars ToyotaCars = new Form_ToyotaCars("");
                ToyotaCars.Show();

                this.Close();

            }

            else if (ToyotaReturn == "2")
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
