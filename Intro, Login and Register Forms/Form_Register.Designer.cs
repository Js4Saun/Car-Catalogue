namespace CTF3001_Group_Project
{
    partial class Form_Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Label_RegistrationDescription = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.TextBox_RegUsername = new System.Windows.Forms.TextBox();
            this.TextBox_RegPassword = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.CheckBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Button_Register = new System.Windows.Forms.Button();
            this.Panel_Registration = new System.Windows.Forms.Panel();
            this.Panel_Registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(117, 0);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(176, 32);
            this.Label_Heading.TabIndex = 1;
            this.Label_Heading.Text = "Registration";
            // 
            // Label_RegistrationDescription
            // 
            this.Label_RegistrationDescription.AutoSize = true;
            this.Label_RegistrationDescription.BackColor = System.Drawing.Color.White;
            this.Label_RegistrationDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RegistrationDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_RegistrationDescription.Location = new System.Drawing.Point(12, 32);
            this.Label_RegistrationDescription.Name = "Label_RegistrationDescription";
            this.Label_RegistrationDescription.Size = new System.Drawing.Size(399, 58);
            this.Label_RegistrationDescription.TabIndex = 3;
            this.Label_RegistrationDescription.Text = "The Automobile Specification App requires\r\nthe user to register to log into the a" +
    "pplication.\r\n";
            this.Label_RegistrationDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.Location = new System.Drawing.Point(4, 103);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(161, 29);
            this.Label_Username.TabIndex = 4;
            this.Label_Username.Text = "New Username:";
            // 
            // TextBox_RegUsername
            // 
            this.TextBox_RegUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_RegUsername.Location = new System.Drawing.Point(171, 107);
            this.TextBox_RegUsername.Name = "TextBox_RegUsername";
            this.TextBox_RegUsername.Size = new System.Drawing.Size(235, 26);
            this.TextBox_RegUsername.TabIndex = 5;
            this.TextBox_RegUsername.Text = "Input New Username";
            this.TextBox_RegUsername.Click += new System.EventHandler(this.TextBox_RegUsername_Click);
            // 
            // TextBox_RegPassword
            // 
            this.TextBox_RegPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_RegPassword.Location = new System.Drawing.Point(171, 139);
            this.TextBox_RegPassword.Name = "TextBox_RegPassword";
            this.TextBox_RegPassword.Size = new System.Drawing.Size(235, 26);
            this.TextBox_RegPassword.TabIndex = 7;
            this.TextBox_RegPassword.TabStop = false;
            this.TextBox_RegPassword.Text = "Input New Password";
            this.TextBox_RegPassword.Click += new System.EventHandler(this.TextBox_RegPassword_Click);
            this.TextBox_RegPassword.TextChanged += new System.EventHandler(this.TextBox_RegPassword_TextChanged);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.Location = new System.Drawing.Point(7, 136);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(158, 29);
            this.Label_Password.TabIndex = 6;
            this.Label_Password.Text = "New Password:";
            // 
            // CheckBox_ShowPassword
            // 
            this.CheckBox_ShowPassword.AutoSize = true;
            this.CheckBox_ShowPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_ShowPassword.Location = new System.Drawing.Point(289, 165);
            this.CheckBox_ShowPassword.Name = "CheckBox_ShowPassword";
            this.CheckBox_ShowPassword.Size = new System.Drawing.Size(124, 24);
            this.CheckBox_ShowPassword.TabIndex = 8;
            this.CheckBox_ShowPassword.Text = "Show Password";
            this.CheckBox_ShowPassword.UseVisualStyleBackColor = true;
            this.CheckBox_ShowPassword.CheckedChanged += new System.EventHandler(this.CheckBox_ShowPassword_CheckedChanged);
            // 
            // Button_Return
            // 
            this.Button_Return.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Return.Location = new System.Drawing.Point(325, 195);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(81, 29);
            this.Button_Return.TabIndex = 10;
            this.Button_Return.Text = "Return";
            this.Button_Return.UseVisualStyleBackColor = true;
            this.Button_Return.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Register
            // 
            this.Button_Register.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Register.Location = new System.Drawing.Point(171, 195);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(81, 29);
            this.Button_Register.TabIndex = 9;
            this.Button_Register.Text = "Register";
            this.Button_Register.UseVisualStyleBackColor = true;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // Panel_Registration
            // 
            this.Panel_Registration.BackColor = System.Drawing.Color.White;
            this.Panel_Registration.Controls.Add(this.Button_Return);
            this.Panel_Registration.Controls.Add(this.Button_Register);
            this.Panel_Registration.Controls.Add(this.CheckBox_ShowPassword);
            this.Panel_Registration.Controls.Add(this.TextBox_RegPassword);
            this.Panel_Registration.Controls.Add(this.Label_Password);
            this.Panel_Registration.Controls.Add(this.TextBox_RegUsername);
            this.Panel_Registration.Controls.Add(this.Label_Username);
            this.Panel_Registration.Controls.Add(this.Label_RegistrationDescription);
            this.Panel_Registration.Controls.Add(this.Label_Heading);
            this.Panel_Registration.Location = new System.Drawing.Point(8, 9);
            this.Panel_Registration.Name = "Panel_Registration";
            this.Panel_Registration.Size = new System.Drawing.Size(422, 231);
            this.Panel_Registration.TabIndex = 11;
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(439, 249);
            this.Controls.Add(this.Panel_Registration);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_Registration.ResumeLayout(false);
            this.Panel_Registration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Heading;
        private System.Windows.Forms.Label Label_RegistrationDescription;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.TextBox TextBox_RegUsername;
        private System.Windows.Forms.TextBox TextBox_RegPassword;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.CheckBox CheckBox_ShowPassword;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.Panel Panel_Registration;
    }
}