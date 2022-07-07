namespace CTF3001_Group_Project
{
    partial class Form_AudiCars
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
            this.Panel_Audi = new System.Windows.Forms.Panel();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Button_R8 = new System.Windows.Forms.Button();
            this.Button_S4 = new System.Windows.Forms.Button();
            this.Button_Q5 = new System.Windows.Forms.Button();
            this.Button_A3 = new System.Windows.Forms.Button();
            this.Label_AudiCarsDescription = new System.Windows.Forms.Label();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Panel_Audi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Audi
            // 
            this.Panel_Audi.BackColor = System.Drawing.Color.White;
            this.Panel_Audi.Controls.Add(this.Button_Return);
            this.Panel_Audi.Controls.Add(this.Button_R8);
            this.Panel_Audi.Controls.Add(this.Button_S4);
            this.Panel_Audi.Controls.Add(this.Button_Q5);
            this.Panel_Audi.Controls.Add(this.Button_A3);
            this.Panel_Audi.Controls.Add(this.Label_AudiCarsDescription);
            this.Panel_Audi.Controls.Add(this.Label_Heading);
            this.Panel_Audi.Location = new System.Drawing.Point(12, 12);
            this.Panel_Audi.Name = "Panel_Audi";
            this.Panel_Audi.Size = new System.Drawing.Size(612, 381);
            this.Panel_Audi.TabIndex = 14;
            // 
            // Button_Return
            // 
            this.Button_Return.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Return.Location = new System.Drawing.Point(247, 338);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(90, 35);
            this.Button_Return.TabIndex = 10;
            this.Button_Return.Text = "Return";
            this.Button_Return.UseVisualStyleBackColor = true;
            this.Button_Return.Click += new System.EventHandler(this.Button_Return_Click);
            // 
            // Button_R8
            // 
            this.Button_R8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_R8.Location = new System.Drawing.Point(247, 277);
            this.Button_R8.Name = "Button_R8";
            this.Button_R8.Size = new System.Drawing.Size(90, 35);
            this.Button_R8.TabIndex = 9;
            this.Button_R8.Text = "R8";
            this.Button_R8.UseVisualStyleBackColor = true;
            this.Button_R8.Click += new System.EventHandler(this.Button_R8_Click);
            // 
            // Button_S4
            // 
            this.Button_S4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_S4.Location = new System.Drawing.Point(247, 236);
            this.Button_S4.Name = "Button_S4";
            this.Button_S4.Size = new System.Drawing.Size(90, 35);
            this.Button_S4.TabIndex = 8;
            this.Button_S4.Text = "S4";
            this.Button_S4.UseVisualStyleBackColor = true;
            this.Button_S4.Click += new System.EventHandler(this.Button_S4_Click);
            // 
            // Button_Q5
            // 
            this.Button_Q5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Q5.Location = new System.Drawing.Point(247, 195);
            this.Button_Q5.Name = "Button_Q5";
            this.Button_Q5.Size = new System.Drawing.Size(90, 35);
            this.Button_Q5.TabIndex = 7;
            this.Button_Q5.Text = "Q5";
            this.Button_Q5.UseVisualStyleBackColor = true;
            this.Button_Q5.Click += new System.EventHandler(this.Button_Q5_Click);
            // 
            // Button_A3
            // 
            this.Button_A3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_A3.Location = new System.Drawing.Point(247, 154);
            this.Button_A3.Name = "Button_A3";
            this.Button_A3.Size = new System.Drawing.Size(90, 35);
            this.Button_A3.TabIndex = 6;
            this.Button_A3.Text = "A3";
            this.Button_A3.UseVisualStyleBackColor = true;
            this.Button_A3.Click += new System.EventHandler(this.Button_A3_Click);
            // 
            // Label_AudiCarsDescription
            // 
            this.Label_AudiCarsDescription.AutoSize = true;
            this.Label_AudiCarsDescription.BackColor = System.Drawing.Color.White;
            this.Label_AudiCarsDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AudiCarsDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_AudiCarsDescription.Location = new System.Drawing.Point(5, 35);
            this.Label_AudiCarsDescription.Name = "Label_AudiCarsDescription";
            this.Label_AudiCarsDescription.Size = new System.Drawing.Size(598, 116);
            this.Label_AudiCarsDescription.TabIndex = 5;
            this.Label_AudiCarsDescription.Text = "Below is a list of cars by the manufacturer Audi.\r\nThe list decends from the chea" +
    "pest to the most expensive car.\r\n\r\nClick on a button to open the specification p" +
    "age for the selected car.\r\n";
            this.Label_AudiCarsDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(207, 3);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(145, 32);
            this.Label_Heading.TabIndex = 3;
            this.Label_Heading.Text = "Audi Cars";
            // 
            // Form_AudiCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(635, 403);
            this.Controls.Add(this.Panel_Audi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(651, 442);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(651, 442);
            this.Name = "Form_AudiCars";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_Audi.ResumeLayout(false);
            this.Panel_Audi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Audi;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.Button Button_R8;
        private System.Windows.Forms.Button Button_S4;
        private System.Windows.Forms.Button Button_Q5;
        private System.Windows.Forms.Button Button_A3;
        private System.Windows.Forms.Label Label_AudiCarsDescription;
        private System.Windows.Forms.Label Label_Heading;
    }
}