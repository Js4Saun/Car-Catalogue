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
    public partial class Form_Corolla : Form
    {
        public Form_Corolla(String ToyotaReturn)
        {
            InitializeComponent();
        }

        public static String ToyotaReturn;

        private void Label_Reference_Click(object sender, EventArgs e)
        {

        }

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£23,115";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€26,875.50";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$30,116.65";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$40,462.77";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$42,793.46";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.30,713.13";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;286,164.86";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$45,167.63";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥202,828.83";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥3,354,394.56";
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
                Label_Height.Text = "1435 mm";
                Label_Length.Text = "4370 mm";
                Label_Width.Text = "1660 mm";
                Label_Wheelbase.Text = "2640 mm";
                Label_Weight.Text = "1240 kg";
                Label_TankCapacity.Text = "50 Liters";
                Label_EnginePower.Text = "85 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "56.5 in";
                Label_Length.Text = "172.05 in";
                Label_Width.Text = "65.35 in";
                Label_Wheelbase.Text = "92.13 in";
                Label_Weight.Text = "195.27 stone";
                Label_TankCapacity.Text = "11 gal";
                Label_EnginePower.Text = "116 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.toyota.co.uk/new-cars/corolla-hatchback/");
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
