namespace CTF3001_Group_Project
{
    partial class Form_Welcome
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
            this.Label_GroupName = new System.Windows.Forms.Label();
            this.Label_ProgramDescription = new System.Windows.Forms.Label();
            this.Panel_WelcomeText = new System.Windows.Forms.Panel();
            this.Button_Continue = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Panel_WelcomeText.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(42, 3);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(618, 32);
            this.Label_Heading.TabIndex = 0;
            this.Label_Heading.Text = "Welcome to the Automobile Specification App";
            // 
            // Label_GroupName
            // 
            this.Label_GroupName.AutoSize = true;
            this.Label_GroupName.BackColor = System.Drawing.Color.White;
            this.Label_GroupName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GroupName.Location = new System.Drawing.Point(12, 45);
            this.Label_GroupName.Name = "Label_GroupName";
            this.Label_GroupName.Size = new System.Drawing.Size(683, 27);
            this.Label_GroupName.TabIndex = 1;
            this.Label_GroupName.Text = "By Luke Hatchman 1808896 and Joseph Saunderson 0707476";
            // 
            // Label_ProgramDescription
            // 
            this.Label_ProgramDescription.AutoSize = true;
            this.Label_ProgramDescription.BackColor = System.Drawing.Color.White;
            this.Label_ProgramDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ProgramDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_ProgramDescription.Location = new System.Drawing.Point(54, 81);
            this.Label_ProgramDescription.Name = "Label_ProgramDescription";
            this.Label_ProgramDescription.Size = new System.Drawing.Size(592, 87);
            this.Label_ProgramDescription.TabIndex = 2;
            this.Label_ProgramDescription.Text = "The Automobile Specification App is an application that will provide \r\ndetails re" +
    "lating to automotive specifications, providing information\r\nof cars from 6 diffe" +
    "rent brands.\r\n";
            this.Label_ProgramDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_ProgramDescription.Click += new System.EventHandler(this.Label_ProgramDescription_Click);
            // 
            // Panel_WelcomeText
            // 
            this.Panel_WelcomeText.BackColor = System.Drawing.Color.White;
            this.Panel_WelcomeText.Controls.Add(this.Label_Heading);
            this.Panel_WelcomeText.Controls.Add(this.Label_ProgramDescription);
            this.Panel_WelcomeText.Location = new System.Drawing.Point(8, 5);
            this.Panel_WelcomeText.Name = "Panel_WelcomeText";
            this.Panel_WelcomeText.Size = new System.Drawing.Size(699, 168);
            this.Panel_WelcomeText.TabIndex = 3;
            // 
            // Button_Continue
            // 
            this.Button_Continue.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Continue.Location = new System.Drawing.Point(205, 189);
            this.Button_Continue.Name = "Button_Continue";
            this.Button_Continue.Size = new System.Drawing.Size(111, 39);
            this.Button_Continue.TabIndex = 4;
            this.Button_Continue.Text = "Continue";
            this.Button_Continue.UseVisualStyleBackColor = true;
            this.Button_Continue.Click += new System.EventHandler(this.Button_Continue_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(359, 189);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(111, 39);
            this.Button_Exit.TabIndex = 5;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(714, 240);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Continue);
            this.Controls.Add(this.Label_GroupName);
            this.Controls.Add(this.Panel_WelcomeText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 279);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 279);
            this.Name = "Form_Welcome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_WelcomeText.ResumeLayout(false);
            this.Panel_WelcomeText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Heading;
        private System.Windows.Forms.Label Label_GroupName;
        private System.Windows.Forms.Label Label_ProgramDescription;
        private System.Windows.Forms.Panel Panel_WelcomeText;
        private System.Windows.Forms.Button Button_Continue;
        private System.Windows.Forms.Button Button_Exit;
    }
}

