namespace CTF3001_Group_Project
{
    partial class Form_Login
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
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Button_Login = new System.Windows.Forms.Button();
            this.CheckBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_LoginDescription = new System.Windows.Forms.Label();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Panel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Login
            // 
            this.Panel_Login.BackColor = System.Drawing.Color.White;
            this.Panel_Login.Controls.Add(this.Button_Return);
            this.Panel_Login.Controls.Add(this.Button_Login);
            this.Panel_Login.Controls.Add(this.CheckBox_ShowPassword);
            this.Panel_Login.Controls.Add(this.TextBox_Password);
            this.Panel_Login.Controls.Add(this.Label_Password);
            this.Panel_Login.Controls.Add(this.TextBox_Username);
            this.Panel_Login.Controls.Add(this.Label_Username);
            this.Panel_Login.Controls.Add(this.Label_LoginDescription);
            this.Panel_Login.Controls.Add(this.Label_Heading);
            this.Panel_Login.Location = new System.Drawing.Point(12, 12);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(369, 231);
            this.Panel_Login.TabIndex = 12;
            // 
            // Button_Return
            // 
            this.Button_Return.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Return.Location = new System.Drawing.Point(272, 198);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(81, 29);
            this.Button_Return.TabIndex = 10;
            this.Button_Return.Text = "Return";
            this.Button_Return.UseVisualStyleBackColor = true;
            this.Button_Return.Click += new System.EventHandler(this.Button_Return_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.Location = new System.Drawing.Point(118, 198);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(81, 29);
            this.Button_Login.TabIndex = 9;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // CheckBox_ShowPassword
            // 
            this.CheckBox_ShowPassword.AutoSize = true;
            this.CheckBox_ShowPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_ShowPassword.Location = new System.Drawing.Point(236, 168);
            this.CheckBox_ShowPassword.Name = "CheckBox_ShowPassword";
            this.CheckBox_ShowPassword.Size = new System.Drawing.Size(124, 24);
            this.CheckBox_ShowPassword.TabIndex = 8;
            this.CheckBox_ShowPassword.Text = "Show Password";
            this.CheckBox_ShowPassword.UseVisualStyleBackColor = true;
            this.CheckBox_ShowPassword.CheckedChanged += new System.EventHandler(this.CheckBox_ShowPassword_CheckedChanged);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.Location = new System.Drawing.Point(125, 136);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(235, 26);
            this.TextBox_Password.TabIndex = 7;
            this.TextBox_Password.TabStop = false;
            this.TextBox_Password.Text = "Input Password";
            this.TextBox_Password.Click += new System.EventHandler(this.TextBox_Password_Click);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.Location = new System.Drawing.Point(6, 133);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(113, 29);
            this.Label_Password.TabIndex = 6;
            this.Label_Password.Text = "Password:";
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Username.Location = new System.Drawing.Point(125, 105);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(235, 26);
            this.TextBox_Username.TabIndex = 5;
            this.TextBox_Username.Text = "Input Username";
            this.TextBox_Username.Click += new System.EventHandler(this.TextBox_Username_Click);
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.Location = new System.Drawing.Point(3, 101);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(116, 29);
            this.Label_Username.TabIndex = 4;
            this.Label_Username.Text = "Username:";
            // 
            // Label_LoginDescription
            // 
            this.Label_LoginDescription.AutoSize = true;
            this.Label_LoginDescription.BackColor = System.Drawing.Color.White;
            this.Label_LoginDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LoginDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_LoginDescription.Location = new System.Drawing.Point(6, 32);
            this.Label_LoginDescription.Name = "Label_LoginDescription";
            this.Label_LoginDescription.Size = new System.Drawing.Size(359, 58);
            this.Label_LoginDescription.TabIndex = 3;
            this.Label_LoginDescription.Text = "Please input the details submitted in the \r\nregistration form\r\n";
            this.Label_LoginDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(130, 0);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(99, 32);
            this.Label_Heading.TabIndex = 1;
            this.Label_Heading.Text = "Log in";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(396, 251);
            this.Controls.Add(this.Panel_Login);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 290);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(412, 290);
            this.Name = "Form_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.CheckBox CheckBox_ShowPassword;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label Label_LoginDescription;
        private System.Windows.Forms.Label Label_Heading;
    }
}