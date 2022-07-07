using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTF3001_Group_Project
{
    static class Program
    {
        /* CTF3001: Fundamentals of Programming
         * Group Project, Theme 4: Automobile Specifications
         * Group Names and Student IDs: Luke Hatchman 1808896 & Joseph Saunderson 0707476
           Programs Purpose: An application that will provide details relating to automotive specifications*/
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Welcome());
        }
    }
}
