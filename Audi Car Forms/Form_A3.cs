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
    public partial class Form_A3 : Form
    {
        public Form_A3(String AudiReturn)
        {
            InitializeComponent();
        }

        public static String AudiReturn;

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£37,095";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€43,157.06";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$48,347.95";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$64,958.13";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$68,690.36";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.49,295.33";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;459,523.13";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$72,516.13";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥325,664.42";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥5,386,892.60";
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
                Label_Height.Text = "1404 mm";
                Label_Length.Text = "4322 mm";
                Label_Width.Text = "1966 mm";
                Label_Wheelbase.Text = "2631 mm";
                Label_Weight.Text = "1465 kg";
                Label_TankCapacity.Text = "55 Liters";
                Label_EnginePower.Text = "228 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "55.28 in";
                Label_Length.Text = "170.16 in";
                Label_Width.Text = "77.40 in";
                Label_Wheelbase.Text = "103.58 in";
                Label_Weight.Text = "230.7 stone";
                Label_TankCapacity.Text = "12.1 gal";
                Label_EnginePower.Text = "310 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.audi.co.uk/models/a3/a3-sportback.html");
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
