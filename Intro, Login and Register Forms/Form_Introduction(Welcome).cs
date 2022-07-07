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
    public partial class Form_Welcome : Form
    {
        public Form_Welcome()
        {
            InitializeComponent();
        }

        private void Label_ProgramDescription_Click(object sender, EventArgs e)
        {

        }

        //Hides current form and opens a new instance of "Form_Register"
        private void Button_Continue_Click(object sender, EventArgs e)
        {

            Form_Register Register = new Form_Register("", "");
            Register.Show();

            this.Hide();

        }

        //Closes the Application
        private void Button_Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
