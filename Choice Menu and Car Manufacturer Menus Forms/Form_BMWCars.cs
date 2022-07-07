using CTF3001_Group_Project.BMW_Car_Forms;
using CTF3001_Group_Project.Choice_Menu_and_Car_Manufacturer_Menus_Forms;
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
    public partial class Form_BMWCars : Form
    {
        public Form_BMWCars(String BMWReturn)
        {
            InitializeComponent();
        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
            Form_ChoiceMenu ChoiceMenu = new Form_ChoiceMenu("");
            ChoiceMenu.Show();

            this.Close();
        }

        //Opens "Form_1Series" and closes current form
        private void Button_1Series_Click(object sender, EventArgs e)
        {
            Form_1Series.BMWReturn = "1";

            Form_1Series Series1 = new Form_1Series("");
            Series1.Show();

            this.Close();
        }

        //Opens "Form_2Series" and closes current form
        private void Button_2Series_Click(object sender, EventArgs e)
        {
            Form_2Series.BMWReturn = "1";

            Form_2Series Series2 = new Form_2Series("");
            Series2.Show();

            this.Close();
        }

        //Opens "Form_X3" and closes current form
        private void Button_X3_Click(object sender, EventArgs e)
        {
            Form_X3.BMWReturn = "1";

            Form_X3 X3 = new Form_X3("");
            X3.Show();

            this.Close();
        }

        //Opens "Form_M5" and closes current form
        private void Button_M5_Click(object sender, EventArgs e)
        {
            Form_M5.BMWReturn = "1";

            Form_M5 M5 = new Form_M5("");
            M5.Show();

            this.Close();
        }
    }
}
