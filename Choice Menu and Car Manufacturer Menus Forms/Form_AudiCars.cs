using CTF3001_Group_Project.Audi_Car_Forms;
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
    public partial class Form_AudiCars : Form
    {
        public Form_AudiCars(String AudiReturn)
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

        //Opens "Form_A3" and closes current form
        private void Button_A3_Click(object sender, EventArgs e)
        {
            Form_A3.AudiReturn = "1";

            Form_A3 A3 = new Form_A3("");
            A3.Show();

            this.Close();
        }

        //Opens "Form_Q5" and closes current form
        private void Button_Q5_Click(object sender, EventArgs e)
        {
            Form_Q5.AudiReturn = "1";

            Form_Q5 Q5 = new Form_Q5("");
            Q5.Show();

            this.Close();
        }

        //Opens "Form_S4" and closes current form
        private void Button_S4_Click(object sender, EventArgs e)
        {
            Form_S4.AudiReturn = "1";

            Form_S4 S4 = new Form_S4("");
            S4.Show();

            this.Close();
        }

        //Opens "Form_R8" and closes current form
        private void Button_R8_Click(object sender, EventArgs e)
        {
            Form_R8.AudiReturn = "1";

            Form_R8 R8 = new Form_R8("");
            R8.Show();

            this.Close();
        }
    }
}
