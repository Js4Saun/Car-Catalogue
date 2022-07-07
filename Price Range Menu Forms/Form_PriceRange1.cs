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
    public partial class Form_PriceRange1 : Form
    {
        public Form_PriceRange1(String SkodaReturn, String ToyotaReturn, String VolkswagenReturn)
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
                Label_TextBoxAygo.Text = "£9,515";
                Label_TextBoxCitigo.Text = "£10,885";
                Label_TextBoxPolo.Text = "£15,735";
                Label_TextBoxFabia.Text = "£16,425";
                Label_TextBoxScirocco.Text = "£19,780";
            }

            else if (ComboBox_Currency.SelectedIndex == 1)
            {
                Label_TextBoxAygo.Text = "€11,022.47";
                Label_TextBoxCitigo.Text = "€12,601.13";
                Label_TextBoxPolo.Text = "€18,226.09";
                Label_TextBoxFabia.Text = "€19,025.32";
                Label_TextBoxScirocco.Text = "€22,907.74";
            }

            else if (ComboBox_Currency.SelectedIndex == 2)
            {
                Label_TextBoxAygo.Text = "$12,273.07";
                Label_TextBoxCitigo.Text = "$14,035.77";
                Label_TextBoxPolo.Text = "$20,293.43";
                Label_TextBoxFabia.Text = "$21,182.83";
                Label_TextBoxScirocco.Text = "$25,504.33";
            }

            else if (ComboBox_Currency.SelectedIndex == 3)
            {
                Label_TextBoxAygo.Text = "C$16,555.87";
                Label_TextBoxCitigo.Text = "C$18,935.00";
                Label_TextBoxPolo.Text = "C$27,374.21";
                Label_TextBoxFabia.Text = "C$28,573.62";
                Label_TextBoxScirocco.Text = "C$34,402.46";
            }

            else if (ComboBox_Currency.SelectedIndex == 4)
            {
                Label_TextBoxAygo.Text = "A$17,504.94";
                Label_TextBoxCitigo.Text = "A$20,016.41";
                Label_TextBoxPolo.Text = "A$28,940.46";
                Label_TextBoxFabia.Text = "A$30,208.20";
                Label_TextBoxScirocco.Text = "A$36,373.94";
            }

            else if (ComboBox_Currency.SelectedIndex == 5)
            {
                Label_TextBoxAygo.Text = "Fr.12,522.36";
                Label_TextBoxCitigo.Text = "Fr.14,319.75";
                Label_TextBoxPolo.Text = "Fr.20,705.39";
                Label_TextBoxFabia.Text = "Fr.21,614.85";
                Label_TextBoxScirocco.Text = "Fr.26,028.50";
            }

            else if (ComboBox_Currency.SelectedIndex == 6)
            {
                Label_TextBoxAygo.Text = "kr;116,995.00";
                Label_TextBoxCitigo.Text = "kr;133,791.13";
                Label_TextBoxPolo.Text = "kr;193,429.26";
                Label_TextBoxFabia.Text = "kr;201,906.78";
                Label_TextBoxScirocco.Text = "kr;243,135.76";
            }

            else if (ComboBox_Currency.SelectedIndex == 7)
            {
                Label_TextBoxAygo.Text = "NZ$18,542.69";
                Label_TextBoxCitigo.Text = "NZ$21,205.03";
                Label_TextBoxPolo.Text = "NZ$30,651.23";
                Label_TextBoxFabia.Text = "NZ$31,992.04";
                Label_TextBoxScirocco.Text = "NZ$38,523.33";
            }

            else if (ComboBox_Currency.SelectedIndex == 8)
            {
                Label_TextBoxAygo.Text = "元/¥82,749.10";
                Label_TextBoxCitigo.Text = "元/¥94,619.50";
                Label_TextBoxPolo.Text = "元/¥136,848.87";
                Label_TextBoxFabia.Text = "元/¥142,873.68";
                Label_TextBoxScirocco.Text = "元/¥172,013.61";
            }

            else if (ComboBox_Currency.SelectedIndex == 9)
            {
                Label_TextBoxAygo.Text = "¥1,369,969.70";
                Label_TextBoxCitigo.Text = "¥1,566,144.69";
                Label_TextBoxPolo.Text = "¥2,263,967.54";
                Label_TextBoxFabia.Text = "¥2,364,411.60";
                Label_TextBoxScirocco.Text = "¥2,847,370.56";
            }

            else
            {
            }
        }

        //Opens "Form_Citigo" and closes current form
        private void Button_Citigo_Click(object sender, EventArgs e)
        {

            Form_Citigo.SkodaReturn = "2";

            Form_Citigo Citigo = new Form_Citigo("");
            Citigo.Show();

            this.Close();
        }

        //Opens "Form_Aygo" and closes current form
        private void Button_Aygo_Click(object sender, EventArgs e)
        {

            Form_Aygo.ToyotaReturn = "2";

            Form_Aygo Aygo = new Form_Aygo("");
            Aygo.Show();

            this.Close();

        }

        //Opens "Form_Fabia" and closes current form
        private void Button_Fabia_Click(object sender, EventArgs e)
        {
            Form_Fabia.SkodaReturn = "2";

            Form_Fabia Fabia = new Form_Fabia("");
            Fabia.Show();

            this.Close();
        }

        //Opens "Form_Polo" and closes current form
        private void Button_Polo_Click(object sender, EventArgs e)
        {
            Form_Polo.VolkswagenReturn = "2";

            Form_Polo Polo = new Form_Polo("");
            Polo.Show();

            this.Close();
        }

        //Opens "Form_Scirocco" and closes current form
        private void Button_Scirocco_Click(object sender, EventArgs e)
        {
            Form_Scirocco.VolkswagenReturn = "2";

            Form_Scirocco Scirocco = new Form_Scirocco("");
            Scirocco.Show();

            this.Close();
        }
    }
}
