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

namespace CTF3001_Group_Project.Audi_Car_Forms
{
    public partial class Form_Q5 : Form
    {
        public Form_Q5(String AudiReturn)
        {
            InitializeComponent();
        }

        public static String AudiReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£40,370";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€46,967.27";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$52,615.84";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$70,602.08";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$74,703.07";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.53,672.72";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;500,119.50";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$78,868.63";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥354,388.40";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥5,860,895.19";
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
                Label_Height.Text = "1659 mm";
                Label_Length.Text = "4663 mm";
                Label_Width.Text = "2140 mm";
                Label_Wheelbase.Text = "2819 mm";
                Label_Weight.Text = "1645 kg";
                Label_TankCapacity.Text = "70 Liters";
                Label_EnginePower.Text = "185 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "65.31 in";
                Label_Length.Text = "183.58 in";
                Label_Width.Text = "84.25 in";
                Label_Wheelbase.Text = "103.58 in";
                Label_Weight.Text = "259.04 stone";
                Label_TankCapacity.Text = "15.4 gal";
                Label_EnginePower.Text = "252 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.uk.audi.com/uk/web/en/models/q5/q5.html");
        }

        /*Checks the public variable for the form the user came from, closes the current 
         * form and re-opens the form the user was previsouly on*/
        private void Button_Return_Click(object sender, EventArgs e)
        {
            if (AudiReturn == "1")
            {

                Form_AudiCars AudiCars = new Form_AudiCars("");
                AudiCars.Show();

                this.Close();

            }

            else if (AudiReturn == "2")
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
