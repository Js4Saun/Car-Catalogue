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
    public partial class Form_SkodaCars : Form
    {
        public Form_SkodaCars(String SkodaReturn)
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

        //Opens "Form_Citigo" and closes current form
        private void Button_Citigo_Click(object sender, EventArgs e)
        {

            Form_Citigo.SkodaReturn = "1";

            Form_Citigo Citigo = new Form_Citigo("");
            Citigo.Show();

            this.Close();
        }

        //Opens "Form_Fabia" and closes current form
        private void Button_Fabia_Click(object sender, EventArgs e)
        {
            Form_Fabia.SkodaReturn = "1";

            Form_Fabia Fabia = new Form_Fabia("");
            Fabia.Show();

            this.Close();
        }

        //Opens "Form_Superb" and closes current form
        private void Button_Superb_Click(object sender, EventArgs e)
        {

            Form_Superb.SkodaReturn = "1";

            Form_Superb Superb = new Form_Superb("");
            Superb.Show();

            this.Close();

        }

        //Opens "Form_Octavia" and closes current form
        private void Button_Octavia_Click(object sender, EventArgs e)
        {
            Form_Octavia.SkodaReturn = "1";

            Form_Octavia Octavia = new Form_Octavia("");
            Octavia.Show();

            this.Close();
        }
    }
}
