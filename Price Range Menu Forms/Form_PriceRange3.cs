using CTF3001_Group_Project.Audi_Car_Forms;
using CTF3001_Group_Project.BMW_Car_Forms;
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
    public partial class Form_PriceRange3 : Form
    {
        public Form_PriceRange3(String FordReturn, String AudiReturn, String BMWReturn)
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

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price1.Text = "£31,513";
                Label_Price2.Text = "£35,430";
                Label_Price3.Text = "£37,095";
                Label_Price4.Text = "£38,855";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price1.Text = "€36,607.08";
                Label_Price2.Text = "€41,219.08";
                Label_Price3.Text = "€43,157.06";
                Label_Price4.Text = "€45,185.84";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price1.Text = "$41,096.89";
                Label_Price2.Text = "$46,208.34";
                Label_Price3.Text = "$48,347.95";
                Label_Price4.Text = "$50,668.28";

            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price1.Text = "C$55,288.47";
                Label_Price2.Text = "C$62,006.74";
                Label_Price3.Text = "C$64,958.13";
                Label_Price4.Text = "C$67,972.26";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price1.Text = "A$58,297.99";
                Label_Price2.Text = "A$65,565.01";
                Label_Price3.Text = "A$68,690.36";
                Label_Price4.Text = "A$71,915.75";

            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price1.Text = "Fr.41,845.60";
                Label_Price2.Text = "Fr.47,100.39";
                Label_Price3.Text = "Fr.49,295.33";
                Label_Price4.Text = "Fr.51,658.50";

            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price1.Text = "Kr;389,421.90";
                Label_Price2.Text = "Kr;438,990.10";
                Label_Price3.Text = "Kr;459,523.13";
                Label_Price4.Text = "Kr;481,423.16";

            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price1.Text = "NZ$61,536.70";
                Label_Price2.Text = "NZ$69,210.39";
                Label_Price3.Text = "NZ$72,516.13";
                Label_Price4.Text = "NZ$75,916.84";

            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price1.Text = "元/¥276,781.83";
                Label_Price2.Text = "元/¥311,273.81";
                Label_Price3.Text = "元/¥325,664.42";
                Label_Price4.Text = "元/¥341,395.57";

            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price1.Text = "¥4,571,477.26";
                Label_Price2.Text = "¥5,146,751.85";
                Label_Price3.Text = "¥5,386,892.60";
                Label_Price4.Text = "¥5,644,285.72";

            }

            else
            {
            }
        }

        //Opens "Form_Mustang" and closes current form
        private void Button_Mustang_Click(object sender, EventArgs e)
        {
            Form_Mustang.FordReturn = "2";

            Form_Mustang Mustang = new Form_Mustang("");
            Mustang.Show();

            this.Close();
        }

        //Opens "Form_A3" and closes current form
        private void Button_A3_Click(object sender, EventArgs e)
        {
            Form_A3.AudiReturn = "2";

            Form_A3 A3 = new Form_A3("");
            A3.Show();

            this.Close();
        }

        //Opens "Form_1Series" and closes current form
        private void Button_1Series_Click(object sender, EventArgs e)
        {
            Form_1Series.BMWReturn = "2";

            Form_1Series Series1 = new Form_1Series("");
            Series1.Show();

            this.Close();
        }

        //Opens "Form_2Series" and closes current form
        private void Button_2Series_Click(object sender, EventArgs e)
        {
            Form_2Series.BMWReturn = "2";

            Form_2Series Series2 = new Form_2Series("");
            Series2.Show();

            this.Close();
        }
    }
}
