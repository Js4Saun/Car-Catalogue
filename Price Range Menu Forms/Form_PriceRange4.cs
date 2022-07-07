using CTF3001_Group_Project.Audi_Car_Forms;
using CTF3001_Group_Project.BMW_Car_Forms;
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
    public partial class Form_PriceRange4 : Form
    {
        public Form_PriceRange4(String AudiReturn, String BMWReturn)
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

        private void Panel_PriceRange4_Paint(object sender, PaintEventArgs e)
        {

        }

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price1.Text = "£40,370";
                Label_Price2.Text = "£46,595";
                Label_Price3.Text = "£52,540";
                Label_Price4.Text = "£89,610";
                Label_Price5.Text = "£147,765";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price1.Text = "€46,967.27";
                Label_Price2.Text = "€54,210.49";
                Label_Price3.Text = "€61,100.60";
                Label_Price4.Text = "€104,211.50";
                Label_Price5.Text = "€171,915.71";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price1.Text = "$52,615.84";
                Label_Price2.Text = "$60,741.47 ";
                Label_Price3.Text = "$68,515.58";
                Label_Price4.Text = "$116,869.36";
                Label_Price5.Text = "$192,627.19";

            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price1.Text = "C$70,602.08";
                Label_Price2.Text = "C$81,513.54";
                Label_Price3.Text = "C$91,918.10";
                Label_Price4.Text = "C$156,780.83";
                Label_Price5.Text = "C$258,520.04";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price1.Text = "A$74,703.07 ";
                Label_Price2.Text = "A$86,222.52";
                Label_Price3.Text = "A$97,231.14";
                Label_Price4.Text = "A$165,830.47";
                Label_Price5.Text = "A$273,478.73";

            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price1.Text = "Fr.53,672.72";
                Label_Price2.Text = "Fr.61,952.36";
                Label_Price3.Text = "Fr.69,844.78";
                Label_Price4.Text = "Fr.119,118.57";
                Label_Price5.Text = "Fr.196,490.12";

            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price1.Text = "Kr;500,119.50";
                Label_Price2.Text = "Kr;577,316.44";
                Label_Price3.Text = "Kr;650,597.57";
                Label_Price4.Text = "Kr;1,109,602.78";
                Label_Price5.Text = "Kr;1,831,225.82";

            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price1.Text = "NZ$78,868.63";
                Label_Price2.Text = "NZ$91,043.57";
                Label_Price3.Text = "NZ$102,627.96";
                Label_Price4.Text = "NZ$175,055.74";
                Label_Price5.Text = "NZ$288,736.21";

            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price1.Text = "元/¥354,388.40";
                Label_Price2.Text = "元/¥409,146.04";
                Label_Price3.Text = "元/¥461,516.61";
                Label_Price4.Text = "元/¥786,910.73";
                Label_Price5.Text = "元/¥1,297,760.89";

            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price1.Text = "¥5,860,895.19";
                Label_Price2.Text = "¥6,764,637.39";
                Label_Price3.Text = "¥7,629,682.63";
                Label_Price4.Text = "¥13,012,863.73";
                Label_Price5.Text = "¥21,460,162.98";

            }

            else
            {
            }
        }

        //Opens "Form_Q5" and closes current form
        private void Button_Q5_Click(object sender, EventArgs e)
        {
            Form_Q5.AudiReturn = "2";

            Form_Q5 Q5 = new Form_Q5("");
            Q5.Show();

            this.Close();
        }

        //Opens "Form_S4" and closes current form
        private void Button_S4_Click(object sender, EventArgs e)
        {
            Form_S4.AudiReturn = "2";

            Form_S4 S4 = new Form_S4("");
            S4.Show();

            this.Close();
        }

        //Opens "Form_R8" and closes current form
        private void Button_R8_Click(object sender, EventArgs e)
        {
            Form_R8.AudiReturn = "2";

            Form_R8 R8 = new Form_R8("");
            R8.Show();

            this.Close();
        }

        //Opens "Form_X3" and closes current form
        private void Button_X3_Click(object sender, EventArgs e)
        {
            Form_X3.BMWReturn = "2";

            Form_X3 X3 = new Form_X3("");
            X3.Show();

            this.Close();
        }

        //Opens "Form_M5" and closes current form
        private void Button_M5_Click(object sender, EventArgs e)
        {
            Form_M5.BMWReturn = "2";

            Form_M5 M5 = new Form_M5("");
            M5.Show();

            this.Close();
        }
    }
}
