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
    public partial class Form_S4 : Form
    {
        public Form_S4(String AudiReturn)
        {
            InitializeComponent();
        }

        public static String AudiReturn;

        private void Form_S4_Load(object sender, EventArgs e)
        {

        }

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price.Text = "£46.595";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price.Text = "€54,210.49";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price.Text = "$60,741.47";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price.Text = "C$81,513.54";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price.Text = "A$86,222.52";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price.Text = "Fr.61,952.36";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price.Text = "kr;577,316.44";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price.Text = "NZ$91,043.57";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price.Text = "元/¥409,146.04";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price.Text = "¥6,764,637.39";
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
                Label_Height.Text = "1411 mm";
                Label_Length.Text = "4745 mm";
                Label_Width.Text = "2022 mm";
                Label_Wheelbase.Text = "2825 mm";
                Label_Weight.Text = "1675 kg";
                Label_TankCapacity.Text = "58 Liters";
                Label_EnginePower.Text = "260 KW";

            }

            else if (ComboBox_MeasurementSystem.SelectedIndex == 1)
            {
                Label_Height.Text = "55.55 in";
                Label_Length.Text = "186.81 in";
                Label_Width.Text = "79.61 in";
                Label_Wheelbase.Text = "111.22 in";
                Label_Weight.Text = "263.77 stone";
                Label_TankCapacity.Text = "12.76 gal";
                Label_EnginePower.Text = "354 BHP";

            }
        }

        //Hyperlinks the user to the website used to find car specifications for further information
        private void Button_MoreInformation_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.audiusa.com/models/audi-s4");
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
