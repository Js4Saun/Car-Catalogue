using CTF3001_Group_Project.Choice_Menu_and_Car_Manufacturer_Menus_Forms;
using CTF3001_Group_Project.Toyota_Car_Forms;
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
    public partial class Form_PriceRange2 : Form
    {
        public Form_PriceRange2(String SkodaReturn, String FordReturn, String ToyotaReturn, String VolkswagenReturn)
        {
            InitializeComponent();
        }

        //Changes the currency displayed and translates the amount.
        private void ComboBox_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Currency.SelectedIndex == 0)
            {
                Label_Price1.Text = "£20,695";
                Label_Price2.Text = "£21,000";
                Label_Price3.Text = "£21,266";
                Label_Price4.Text = "£23,115";
                Label_Price5.Text = "£23,190";
                Label_Price6.Text = "£24,830";
                Label_Price7.Text = "£25,740";
                Label_Price8.Text = "£25,830";
                Label_Price9.Text = "£27,840";
                Label_Price10.Text = "£27,990";

            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_Price1.Text = "€24,031.65";
                Label_Price2.Text = "€24,392.24";
                Label_Price3.Text = "€24,727.79";
                Label_Price4.Text = "€26,875.50";
                Label_Price5.Text = "€26,857.45";
                Label_Price6.Text = "€28,892.47";
                Label_Price7.Text = "€29,927.55";
                Label_Price8.Text = "€30,056.08";
                Label_Price9.Text = "€32,297.30";
                Label_Price10.Text = "€36,491.96";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_Price1.Text = "$26,976.14";
                Label_Price2.Text = "$27,380.11";
                Label_Price3.Text = "$27,705.77";
                Label_Price4.Text = "$30,116.65";
                Label_Price5.Text = "$30,110.94";
                Label_Price6.Text = "$32,378.32";
                Label_Price7.Text = "$33,536.77";
                Label_Price8.Text = "$33,681.93";
                Label_Price9.Text = "$36,217.89 ";
                Label_Price10.Text = "$36,491.96";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_Price1.Text = "C$36,308.53";
                Label_Price2.Text = "C$36,839.67";
                Label_Price3.Text = "C$37,244.27";
                Label_Price4.Text = "C$40,462.77";
                Label_Price5.Text = "C$40,479.77";
                Label_Price6.Text = "C$43,456.85";
                Label_Price7.Text = "C$45,053.14";
                Label_Price8.Text = "C$45,198.63";
                Label_Price9.Text = "C$48,670.17";
                Label_Price10.Text = "C$49,099.57";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_Price1.Text = "A$38,275.82";
                Label_Price2.Text = "A$38,829.66";
                Label_Price3.Text = "A$39,374.08";
                Label_Price4.Text = "A$42,793.46";
                Label_Price5.Text = "A$42,662.82";
                Label_Price6.Text = "A$45,956.49";
                Label_Price7.Text = "A$47,671.77";
                Label_Price8.Text = "A$47,807.84";
                Label_Price9.Text = "A$51,308.01";
                Label_Price10.Text = "A$51,763.45";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_Price1.Text = "Fr.27,498.13";
                Label_Price2.Text = "Fr.27,887.33";
                Label_Price3.Text = "Fr.28,260.43";
                Label_Price4.Text = "Fr.30,713.13";
                Label_Price5.Text = "Fr.30,667.15";
                Label_Price6.Text = "Fr.33,018.60";
                Label_Price7.Text = "Fr.34,218.07";
                Label_Price8.Text = "Fr.34,342.53";
                Label_Price9.Text = "Fr.36,905.48";
                Label_Price10.Text = "Fr.37,157.98";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_Price1.Text = "Kr;255,662.93";
                Label_Price2.Text = "Kr;259,360.88";
                Label_Price3.Text = "Kr;263,368.33";
                Label_Price4.Text = "Kr;286,164.86";
                Label_Price5.Text = "Kr;285,565.83";
                Label_Price6.Text = "Kr;307,659.44";
                Label_Price7.Text = "Kr;318,856.95";
                Label_Price8.Text = "Kr;319,991.54";
                Label_Price9.Text = "Kr;343,311.74";
                Label_Price10.Text = "Kr;345,882.27";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_Price1.Text = "NZ$40,418.47";
                Label_Price2.Text = "NZ$40,998.30";
                Label_Price3.Text = "NZ$41,557.27";
                Label_Price4.Text = "NZ$45,167.63";
                Label_Price5.Text = "NZ$45,108.49";
                Label_Price6.Text = "NZ$48,522.15";
                Label_Price7.Text = "NZ$50,337.46";
                Label_Price8.Text = "NZ$50,468.87";
                Label_Price9.Text = "NZ$54,223.55";
                Label_Price10.Text = "NZ$54,659.21";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_Price1.Text = "元/¥181,728.05";
                Label_Price2.Text = "元/¥184,447.20";
                Label_Price3.Text = "元/¥186,634.67";
                Label_Price4.Text = "元/¥202,828.83";
                Label_Price5.Text = "元/¥202,859.16";
                Label_Price6.Text = "元/¥218,061.51";
                Label_Price7.Text = "元/¥226,016.02";
                Label_Price8.Text = "元/¥226,848.04";
                Label_Price9.Text = "元/¥243,825.50";
                Label_Price10.Text = "元/¥245,796.47";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_Price1.Text = "¥3,002,896.41";
                Label_Price2.Text = "¥3.047.152.67";
                Label_Price3.Text = "¥3,086,536.61";
                Label_Price4.Text = "¥3,354,394.56";
                Label_Price5.Text = "¥3,354,780.02";
                Label_Price6.Text = "¥3,606,103.25";
                Label_Price7.Text = "¥3,737,932.75";
                Label_Price8.Text = "¥3,751,810.82";
                Label_Price9.Text = "¥4,029,241.44";
                Label_Price10.Text = "¥4,060,408.35";
            }

            else
            {
            }
        }

        //Opens "Form_Superb" and closes current form
        private void Button_Superb_Click(object sender, EventArgs e)
        {
            Form_Superb.SkodaReturn = "2";

            Form_Superb Superb = new Form_Superb("");
            Superb.Show();

            this.Close();
        }

        //Opens "Form_Octavia" and closes current form
        private void Button_Octavia_Click(object sender, EventArgs e)
        {
            Form_Octavia.SkodaReturn = "2";

            Form_Octavia Octavia = new Form_Octavia("");
            Octavia.Show();

            this.Close();
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
            Form_Fiesta.FordReturn = "2";

            Form_Fiesta Fiesta = new Form_Fiesta("");
            Fiesta.Show();

            this.Close();
        }

        //Opens "Form_CMax" and closes current form
        private void Button_CMax_Click(object sender, EventArgs e)
        {
            Form_CMax.FordReturn = "2";

            Form_CMax CMax = new Form_CMax("");
            CMax.Show();

            this.Close();
        }

        //Opens "Form_Focus" and closes current form
        private void Button_Focus_Click(object sender, EventArgs e)
        {
            Form_Focus.FordReturn = "2";

            Form_Focus Focus = new Form_Focus("");
            Focus.Show();

            this.Close();
        }

        //Opens "Form_CMax" and closes current form
        private void Button_CMax_Click_1(object sender, EventArgs e)
        {
            Form_CMax.FordReturn = "2";

            Form_CMax CMax = new Form_CMax("");
            CMax.Show();

            this.Close();
        }

        //Opens "Form_Prius" and closes current form
        private void Button_Prius_Click(object sender, EventArgs e)
        {
            Form_Prius.ToyotaReturn = "2";

            Form_Prius Prius = new Form_Prius("");
            Prius.Show();

            this.Close();
        }

        //Opens "Form_Corolla" and closes current form
        private void Button_Corolla_Click(object sender, EventArgs e)
        {
            Form_Corolla.ToyotaReturn = "2";

            Form_Corolla Corolla = new Form_Corolla("");
            Corolla.Show();

            this.Close();
        }

        //Opens "Form_Yaris" and closes current form
        private void Button_Yaris_Click(object sender, EventArgs e)
        {
            Form_Yaris.ToyotaReturn = "2";

            Form_Yaris Yaris = new Form_Yaris("");
            Yaris.Show();

            this.Close();
        }

        //Opens "Form_Golf" and closes current form
        private void Button_Golf_Click(object sender, EventArgs e)
        {
            Form_Golf.VolkswagenReturn = "2";

            Form_Golf Golf = new Form_Golf("");
            Golf.Show();

            this.Close();
        }

        //Opens "Form_Passat" and closes current form
        private void Button_Passat_Click(object sender, EventArgs e)
        {
            Form_Passat.VolkswagenReturn = "2";

            Form_Passat Passat = new Form_Passat("");
            Passat.Show();

            this.Close();
        }
    }
}
