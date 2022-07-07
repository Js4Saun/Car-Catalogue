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
    public partial class Form_Citigo : Form
    {
        public Form_Citigo(String SkodaReturn)
        {
            InitializeComponent();
        }

        public static String SkodaReturn;

        private void Label_PriceRange1Description_Click(object sender, EventArgs e)
        {

        }

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

            Process.Start("https://www.autotrader.co.uk/cars/skoda/citigo");

        }

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£10,885";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€12,601.13";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$14,035.77";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$18,935.00";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$20,016.41";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.14,319.75";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;133,791.13";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$21,205.03";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥94,619.50";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥1,566,144.69";
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
                Label_Height.Text = "1478 mm";
                Label_Length.Text = "3563 mm";
                Label_Width.Text = "1910 mm";
                Label_Wheelbase.Text = "2420 mm";
                Label_Weight.Text = "1290 kg";
                Label_TankCapacity.Text = "35 Liters";
                Label_EnginePower.Text = "44 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "58.19 in";
                Label_Length.Text = "140.28 in";
                Label_Width.Text = "75.2 in";
                Label_Wheelbase.Text = "95.28 in";
                Label_Weight.Text = "203.14 stone";
                Label_TankCapacity.Text = "7.7 gal";
                Label_EnginePower.Text = "60 BHP";

            }

            else
            {
            }

        }
    }
}
