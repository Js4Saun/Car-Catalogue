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
    public partial class Form_Login : Form
    {
        public Form_Login(String RegUsername, String RegPassword)
        {
            InitializeComponent();
        }

        //Declare Username and Password Variable
        String Username, Password;

        //Opens "Form_Register", closes current form
        private void Button_Return_Click(object sender, EventArgs e)
        {
            Form_Register Register = new Form_Register("", "");
            Register.Show();

            this.Close();
        }

        //If TextBox_RegUsername.Text == "Input Username", clears text for user input
        private void TextBox_Username_Click(object sender, EventArgs e)
        {

            if (TextBox_Username.Text == "Input Username")
            {

                TextBox_Username.Text = "";

            }

            else
            {
            }

        }

        //If TextBox_Password.Text == "Input Password", clears text for user input
        private void TextBox_Password_Click(object sender, EventArgs e)
        {

            if (TextBox_Password.Text == "Input Password")
            {

                TextBox_Password.Text = "";

                TextBox_Password.UseSystemPasswordChar = true;

            }

            else
            {
            }

        }

        //Setting the text inside of the "Password" text box, to password characters
        private void CheckBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox_ShowPassword.Checked == true)
            {

                TextBox_Password.UseSystemPasswordChar = false;

            }

            else if (CheckBox_ShowPassword.Checked != true)
            {

                TextBox_Password.UseSystemPasswordChar = true;

            }

            else
            {

                TextBox_Password.UseSystemPasswordChar = true;

            }

        }

        /*Sets variables "Username" and "Password" to the test inside the forms text boxes, then checks if these variables are the 
         as the variables set in the registration form "RegUsername" and "RegPassword". Also displaying different message boxes for each of the conditions
         within the if statments*/
        private void Button_Login_Click(object sender, EventArgs e)
        {

            Username = TextBox_Username.Text;

            Password = TextBox_Password.Text;

            if (Username == Form_Register.RegUsername && Password == Form_Register.RegPassword)
            {

                Form_ChoiceMenu ChoiceMenu = new Form_ChoiceMenu("");
                ChoiceMenu.Show();

                this.Close();

            }

            else if (Username != Form_Register.RegUsername || Password != Form_Register.RegPassword)
            {

                MessageBox.Show("Error\nUsername or Password was incorrect\nPlease re-try submission\nor return to Registration and submit new details");

            }

            else
            {

                MessageBox.Show("Error\nLogin details was not submitted\nPlease re-try submission");

            }
        }
    }
}
