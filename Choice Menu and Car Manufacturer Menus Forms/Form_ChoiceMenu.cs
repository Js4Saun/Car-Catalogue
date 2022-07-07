using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTF3001_Group_Project
{
    public partial class Form_ChoiceMenu : Form
    {
        public Form_ChoiceMenu(String Return)
        {
            InitializeComponent();
        }

        private void Panel_ChoiceMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        //Checks the text inside of the ComboBox and Opens Form depending on the option chose.
        private void Button_SearchBrand_Click(object sender, EventArgs e)
        {

            //Opens Skoda Cars Form
            if (ComboBox_CarManufacturer.Text == "Skoda")
            {

                Form_SkodaCars SkodaCars = new Form_SkodaCars("");
                SkodaCars.Show();

                this.Close();

            }

            //Opens Ford Cars Form
            else if (ComboBox_CarManufacturer.Text == "Ford")
            {

                Form_FordCars FordCars = new Form_FordCars("");
                FordCars.Show();

                this.Close();

            }

            //Opens Toyota Cars Form
            else if (ComboBox_CarManufacturer.Text == "Toyota")
            {

                Form_ToyotaCars ToyotaCars = new Form_ToyotaCars("");
                ToyotaCars.Show();

                this.Close();

            }

            //Opens Audi Cars Form
            else if (ComboBox_CarManufacturer.Text == "Audi")
            {

                Form_AudiCars AudiCars = new Form_AudiCars("");
                AudiCars.Show();

                this.Close();

            }

            //Opens Volkswagen Cars Form
            else if (ComboBox_CarManufacturer.Text == "Volkswagen")
            {

                Form_VolkswagenCars VolkswagenCars = new Form_VolkswagenCars("");
                VolkswagenCars.Show();

                this.Close();

            }

            //Opens BMW Cars Form
            else if (ComboBox_CarManufacturer.Text == "BMW")
            {

                Form_BMWCars BMWCars = new Form_BMWCars("");
                BMWCars.Show();

                this.Close();

            }

            else
            {

                MessageBox.Show("Error\nAn option from the drop down menu was not selected\nPlease select an option and press search again");

            }

        }

        //Checks the text inside of the ComboBox and Opens Form depending on the option chose.
        private void Button_SearchPriceRange_Click(object sender, EventArgs e)
        {

            if (ComboBox_PriceRange.Text == "0 - 20,000 (5 cars)")
            {

                Form_PriceRange1 PriceRange1 = new Form_PriceRange1("", "", "");
                PriceRange1.Show();

                this.Close();

            }

            else if (ComboBox_PriceRange.Text == "20,000 - 30,000 (10 cars)")
            {

                Form_PriceRange2 PriceRange2 = new Form_PriceRange2("", "", "", "");
                PriceRange2.Show();

                this.Close();

            }

            else if (ComboBox_PriceRange.Text == "30,000 - 40,000 (4 cars)")
            {

                Form_PriceRange3 PriceRange3 = new Form_PriceRange3("", "", "");
                PriceRange3.Show();

                this.Close();

            }

            else if (ComboBox_PriceRange.Text == "40,000 - 150,000 (5 cars)")
            {

                Form_PriceRange4 PriceRange4 = new Form_PriceRange4("", "");
                PriceRange4.Show();

                this.Close();

            }

            else
            {

                MessageBox.Show("Error\nAn option from the drop down menu was not selected\nPlease select an option and press search again");

            }
        }

        //Closes the program
        private void Button_Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void ComboBox_PriceRange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
