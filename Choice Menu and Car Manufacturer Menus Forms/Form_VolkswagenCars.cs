using CTF3001_Group_Project.Choice_Menu_and_Car_Manufacturer_Menus_Forms;
using CTF3001_Group_Project.Volkswagen_Car_Forms;
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
    public partial class Form_VolkswagenCars : Form
    {
        public Form_VolkswagenCars(String VolkswagenReturn)
        {
            InitializeComponent();
        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
            Form_ChoiceMenu ChoiceMenu = new Form_ChoiceMenu("");
            ChoiceMenu.Show();

            this.Close();
        }

        //Opens "Form_Polo" and closes current form
        private void Button_Polo_Click(object sender, EventArgs e)
        {
            Form_Polo.VolkswagenReturn = "1";

            Form_Polo Polo = new Form_Polo("");
            Polo.Show();

            this.Close();
        }

        //Opens "Form_Scirocco" and closes current form
        private void Button_Scirocco_Click(object sender, EventArgs e)
        {
            Form_Scirocco.VolkswagenReturn = "1";

            Form_Scirocco Scirocco = new Form_Scirocco("");
            Scirocco.Show();

            this.Close();
        }

        //Opens "Form_Golf" and closes current form
        private void Button_Golf_Click(object sender, EventArgs e)
        {
            Form_Golf.VolkswagenReturn = "1";

            Form_Golf Golf = new Form_Golf("");
            Golf.Show();

            this.Close();
        }

        //Opens "Form_Passat" and closes current form
        private void Button_Passat_Click(object sender, EventArgs e)
        {
            Form_Passat.VolkswagenReturn = "1";

            Form_Passat Passat = new Form_Passat("");
            Passat.Show();

            this.Close();
        }
    }
}
