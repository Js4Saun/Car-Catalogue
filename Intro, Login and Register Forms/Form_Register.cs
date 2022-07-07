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
    public partial class Form_Register : Form
    {
        public Form_Register(String RegUsername, String RegPassword)
        {
            InitializeComponent();
        }

        //Declaring public static Variables
        public static String RegUsername, RegPassword;

        //Sets variables to text inside of respective text boxes, opens the Login Form and closes the current form
        private void Button_Register_Click(object sender, EventArgs e)
        {

            RegUsername = TextBox_RegUsername.Text;

            RegPassword = TextBox_RegPassword.Text;

            Form_Login Login = new Form_Login("", "");
            Login.Show();

            this.Close();

        }

        //Shows "Form_Welcome", closes current form
        private void Button_Exit_Click(object sender, EventArgs e)
        {

            Form_Welcome Welcome  = new Form_Welcome(); 
            Welcome.Show();

            this.Close();

        }

        //If TextBox_RegUsername.Text == "Input New Username", clears text for user input
        private void TextBox_RegUsername_Click(object sender, EventArgs e)
        {

            if (TextBox_RegUsername.Text == "Input New Username")
            {

                TextBox_RegUsername.Text = "";

            }

            else
            {
            }

        }

        private void TextBox_RegPassword_TextChanged(object sender, EventArgs e)
        {

        }

        //Setting the text inside of the "RegPassword" text box, to password characters
        private void CheckBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox_ShowPassword.Checked == true)
            {

                TextBox_RegPassword.UseSystemPasswordChar = false;

            }

            else if (CheckBox_ShowPassword.Checked != true)
            {

                TextBox_RegPassword.UseSystemPasswordChar = true;

            }

            else
            {

                TextBox_RegPassword.UseSystemPasswordChar = true;

            }

        }

        //If TextBox_RegPassword.Text == "Input New Password", clears text for user input
        private void TextBox_RegPassword_Click(object sender, EventArgs e)
        {

            if (TextBox_RegPassword.Text == "Input New Password")
            {

                TextBox_RegPassword.Text = "";

                TextBox_RegPassword.UseSystemPasswordChar = true;

            }

            else
            {
            }

        }
    }
}
