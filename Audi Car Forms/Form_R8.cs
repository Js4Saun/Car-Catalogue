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
    public partial class Form_R8 : Form
    {
        public Form_R8(String AudiReturn)
        {
            InitializeComponent();
        }

        public static String AudiReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£147,765";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€171,915.71";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$192,627.19";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$258,520.04 ";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$273,478.73";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.196,490.12";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;1,831,225.82";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$288,736.21";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥1,297,760.89";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥21,460,162.98";
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
                Label_Height.Text = "1244 mm ";
                Label_Length.Text = "4426 mm";
                Label_Width.Text = "2037 mm";
                Label_Wheelbase.Text = "2650 mm";
                Label_Weight.Text = "1695 kg";
                Label_TankCapacity.Text = "80 Liters";
                Label_EnginePower.Text = "449 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "48.97 in";
                Label_Length.Text = "174.25 in";
                Label_Width.Text = "80.2 in";
                Label_Wheelbase.Text = "104.33 in";
                Label_Weight.Text = "266.92 stone";
                Label_TankCapacity.Text = "17.6 gal";
                Label_EnginePower.Text = "610 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.audi.co.uk/models/r8/r8-coupe.html");
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
