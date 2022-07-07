using CTF3001_Group_Project.Choice_Menu_and_Car_Manufacturer_Menus_Forms;
using CTF3001_Group_Project.Ford_Car_Forms;
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
    public partial class Form_FordCars : Form
    {
        public Form_FordCars(String FordReturn)
        {
            InitializeComponent();
        }

        //Closes current Form and opens "Form_ChoiceMenu"
        private void Button_Return_Click(object sender, EventArgs e)
        {
            Form_ChoiceMenu ChoiceMenu = new Form_ChoiceMenu("");
            ChoiceMenu.Show();

            this.Close();
        }

        //Opens "Form_Fiesta" and closes current form
        private void Button_Fiesta_Click(object sender, EventArgs e)
        {
            Form_Fiesta.FordReturn = "1";

            Form_Fiesta Fiesta = new Form_Fiesta("");
            Fiesta.Show();

            this.Close();
        }

        //Opens "Form_CMax" and closes current form
        private void Button_CMax_Click(object sender, EventArgs e)
        {
            Form_CMax.FordReturn = "1";

            Form_CMax CMax = new Form_CMax("");
            CMax.Show();

            this.Close();
        }

        //Opens "Form_Focus" and closes current form
        private void Button_Focus_Click(object sender, EventArgs e)
        {
            Form_Focus.FordReturn = "1";

            Form_Focus Focus = new Form_Focus("");
            Focus.Show();

            this.Close();
        }

        //Opens "Form_Mustang" and closes current form
        private void Button_Mustang_Click(object sender, EventArgs e)
        {
            Form_Mustang.FordReturn = "1";

            Form_Mustang Mustang = new Form_Mustang("");
            Mustang.Show();

            this.Close();
        }
    }
}
