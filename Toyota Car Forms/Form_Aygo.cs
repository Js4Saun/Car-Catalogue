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
    public partial class Form_Aygo : Form
    {
        public Form_Aygo(String ToyotaReturn)
        {
            InitializeComponent();
        }

        public static String ToyotaReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£9,515";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€11,022.47";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$12273.07";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$16,555.87";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$17,504.94";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.12522.36";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;116,995.00";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$18,542.69";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥82,749.10";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥1,369,969.70";
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
                Label_Height.Text = "1460 mm ";
                Label_Length.Text = "3460 mm";
                Label_Width.Text = "1670 mm";
                Label_Wheelbase.Text = "2340 mm";
                Label_Weight.Text = "1240 kg";
                Label_TankCapacity.Text = "35 Liters";
                Label_EnginePower.Text = "53 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "57.48 in";
                Label_Length.Text = "136.22 in";
                Label_Width.Text = "65.75 in";
                Label_Wheelbase.Text = "92.13 in";
                Label_Weight.Text = "195.27 stone";
                Label_TankCapacity.Text = "7.7 gal";
                Label_EnginePower.Text = "71 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.toyota.co.uk/new-cars/aygo/");
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

                Form_PriceRange1 PriceRange1 = new Form_PriceRange1("", "", "");
                PriceRange1.Show();

                this.Close();

            }

            else
            {
            }
        }
    }
}
