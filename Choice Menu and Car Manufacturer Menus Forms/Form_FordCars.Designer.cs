namespace CTF3001_Group_Project
{
    partial class Form_FordCars
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
            this.Panel_Skoda = new System.Windows.Forms.Panel();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Button_Mustang = new System.Windows.Forms.Button();
            this.Button_Focus = new System.Windows.Forms.Button();
            this.Button_CMax = new System.Windows.Forms.Button();
            this.Button_Fiesta = new System.Windows.Forms.Button();
            this.Label_FordCarsDescription = new System.Windows.Forms.Label();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Panel_Skoda.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Skoda
            // 
            this.Panel_Skoda.BackColor = System.Drawing.Color.White;
            this.Panel_Skoda.Controls.Add(this.Button_Return);
            this.Panel_Skoda.Controls.Add(this.Button_Mustang);
            this.Panel_Skoda.Controls.Add(this.Button_Focus);
            this.Panel_Skoda.Controls.Add(this.Button_CMax);
            this.Panel_Skoda.Controls.Add(this.Button_Fiesta);
            this.Panel_Skoda.Controls.Add(this.Label_FordCarsDescription);
            this.Panel_Skoda.Controls.Add(this.Label_Heading);
            this.Panel_Skoda.Location = new System.Drawing.Point(12, 12);
            this.Panel_Skoda.Name = "Panel_Skoda";
            this.Panel_Skoda.Size = new System.Drawing.Size(612, 381);
            this.Panel_Skoda.TabIndex = 12;
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
            // Button_Mustang
            // 
            this.Button_Mustang.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Mustang.Location = new System.Drawing.Point(247, 277);
            this.Button_Mustang.Name = "Button_Mustang";
            this.Button_Mustang.Size = new System.Drawing.Size(90, 35);
            this.Button_Mustang.TabIndex = 9;
            this.Button_Mustang.Text = "Mustang";
            this.Button_Mustang.UseVisualStyleBackColor = true;
            this.Button_Mustang.Click += new System.EventHandler(this.Button_Mustang_Click);
            // 
            // Button_Focus
            // 
            this.Button_Focus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Focus.Location = new System.Drawing.Point(247, 236);
            this.Button_Focus.Name = "Button_Focus";
            this.Button_Focus.Size = new System.Drawing.Size(90, 35);
            this.Button_Focus.TabIndex = 8;
            this.Button_Focus.Text = "Focus";
            this.Button_Focus.UseVisualStyleBackColor = true;
            this.Button_Focus.Click += new System.EventHandler(this.Button_Focus_Click);
            // 
            // Button_CMax
            // 
            this.Button_CMax.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CMax.Location = new System.Drawing.Point(247, 195);
            this.Button_CMax.Name = "Button_CMax";
            this.Button_CMax.Size = new System.Drawing.Size(90, 35);
            this.Button_CMax.TabIndex = 7;
            this.Button_CMax.Text = "C-Max";
            this.Button_CMax.UseVisualStyleBackColor = true;
            this.Button_CMax.Click += new System.EventHandler(this.Button_CMax_Click);
            // 
            // Button_Fiesta
            // 
            this.Button_Fiesta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Fiesta.Location = new System.Drawing.Point(247, 154);
            this.Button_Fiesta.Name = "Button_Fiesta";
            this.Button_Fiesta.Size = new System.Drawing.Size(90, 35);
            this.Button_Fiesta.TabIndex = 6;
            this.Button_Fiesta.Text = "Fiesta";
            this.Button_Fiesta.UseVisualStyleBackColor = true;
            this.Button_Fiesta.Click += new System.EventHandler(this.Button_Fiesta_Click);
            // 
            // Label_FordCarsDescription
            // 
            this.Label_FordCarsDescription.AutoSize = true;
            this.Label_FordCarsDescription.BackColor = System.Drawing.Color.White;
            this.Label_FordCarsDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FordCarsDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_FordCarsDescription.Location = new System.Drawing.Point(5, 35);
            this.Label_FordCarsDescription.Name = "Label_FordCarsDescription";
            this.Label_FordCarsDescription.Size = new System.Drawing.Size(598, 116);
            this.Label_FordCarsDescription.TabIndex = 5;
            this.Label_FordCarsDescription.Text = "Below is a list of cars by the manufacturer Ford.\r\nThe list decends from the chea" +
    "pest to the most expensive car.\r\n\r\nClick on a button to open the specification p" +
    "age for the selected car.\r\n";
            this.Label_FordCarsDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(207, 3);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(146, 32);
            this.Label_Heading.TabIndex = 3;
            this.Label_Heading.Text = "Ford Cars";
            // 
            // Form_FordCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(635, 402);
            this.Controls.Add(this.Panel_Skoda);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(651, 441);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(651, 441);
            this.Name = "Form_FordCars";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_Skoda.ResumeLayout(false);
            this.Panel_Skoda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Skoda;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.Button Button_Mustang;
        private System.Windows.Forms.Button Button_Focus;
        private System.Windows.Forms.Button Button_CMax;
        private System.Windows.Forms.Button Button_Fiesta;
        private System.Windows.Forms.Label Label_FordCarsDescription;
        private System.Windows.Forms.Label Label_Heading;
    }
}