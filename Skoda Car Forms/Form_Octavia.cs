using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CTF3001_Group_Project
{
    public partial class Form_Octavia : Form
    {
        public Form_Octavia(String SkodaReturn)
        {
            InitializeComponent();
        }

        public static String SkodaReturn;

        /*Checks the public variable for the form the user came from, closes the current 
        * form and re-opens the form the user was previsouly on*/
        private void Button_Return_Click(object sender, EventArgs e)
        {
            if (SkodaReturn == "1")
            {

                Form_SkodaCars SkodaCars = new Form_SkodaCars("");
                SkodaCars.Show();

                this.Close();

            }

            else if (SkodaReturn == "2")
            {

                Form_PriceRange1 PriceRange1 = new Form_PriceRange1("", "", "");
                PriceRange1.Show();

                this.Close();

            }

            else
            {
            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.topgear.com/car-reviews/skoda/octavia/20-tsi-245-vrs-5dr/spec");
        }

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£27,840";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€32,297.30";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$36,217.89";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$48670.17";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$51,308.01";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.36,905.48";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;343,311.74";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$54,223.55";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥243,825.50";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥4,029,241.44";
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
                Label_Height.Text = "1448 mm";
                Label_Length.Text = "4670 mm";
                Label_Width.Text = "2017 mm";
                Label_Wheelbase.Text = "2680 mm";
                Label_Weight.Text = "1912 kg";
                Label_TankCapacity.Text = "50 Liters";
                Label_EnginePower.Text = "180 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "57.01 in";
                Label_Length.Text = "183.86 in";
                Label_Width.Text = "79.41 in";
                Label_Wheelbase.Text = "101.57 in";
                Label_Weight.Text = "301.09 stone";
                Label_TankCapacity.Text = "11 gal";
                Label_EnginePower.Text = "245 BHP";

            }

            else
            {
            }
        }
    }
}
