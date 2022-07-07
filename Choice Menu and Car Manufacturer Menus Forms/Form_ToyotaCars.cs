using CTF3001_Group_Project.Choice_Menu_and_Car_Manufacturer_Menus_Forms;
using CTF3001_Group_Project.Toyota_Car_Forms;
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
    public partial class Form_ToyotaCars : Form
    {
        public Form_ToyotaCars(String ToyotaReturn)
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

        //Opens "Form_Aygo" and closes current form
        private void Button_Aygo_Click(object sender, EventArgs e)
        {

            Form_Aygo.ToyotaReturn = "1";

            Form_Aygo Aygo = new Form_Aygo("");
            Aygo.Show();

            this.Close();

        }

        //Opens "Form_Prius" and closes current form
        private void Button_Prius_Click(object sender, EventArgs e)
        {
            Form_Prius.ToyotaReturn = "1";

            Form_Prius Prius = new Form_Prius("");
            Prius.Show();

            this.Close();
        }

        //Opens "Form_Corolla" and closes current form
        private void Button_Corolla_Click(object sender, EventArgs e)
        {
            Form_Corolla.ToyotaReturn = "1";

            Form_Corolla Corolla = new Form_Corolla("");
            Corolla.Show();

            this.Close();
        }

        //Opens "Form_Yaris" and closes current form
        private void Button_Yaris_Click(object sender, EventArgs e)
        {
            Form_Yaris.ToyotaReturn = "1";

            Form_Yaris Yaris = new Form_Yaris("");
            Yaris.Show();

            this.Close();
        }
    }
}
