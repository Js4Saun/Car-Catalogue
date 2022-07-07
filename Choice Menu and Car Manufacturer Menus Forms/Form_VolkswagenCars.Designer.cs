namespace CTF3001_Group_Project
{
    partial class Form_VolkswagenCars
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
            this.Panel_Volkswagen = new System.Windows.Forms.Panel();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Button_Passat = new System.Windows.Forms.Button();
            this.Button_Golf = new System.Windows.Forms.Button();
            this.Button_Scirocco = new System.Windows.Forms.Button();
            this.Button_Polo = new System.Windows.Forms.Button();
            this.Label_VolkswagenCarsDescription = new System.Windows.Forms.Label();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Panel_Volkswagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Volkswagen
            // 
            this.Panel_Volkswagen.BackColor = System.Drawing.Color.White;
            this.Panel_Volkswagen.Controls.Add(this.Button_Return);
            this.Panel_Volkswagen.Controls.Add(this.Button_Passat);
            this.Panel_Volkswagen.Controls.Add(this.Button_Golf);
            this.Panel_Volkswagen.Controls.Add(this.Button_Scirocco);
            this.Panel_Volkswagen.Controls.Add(this.Button_Polo);
            this.Panel_Volkswagen.Controls.Add(this.Label_VolkswagenCarsDescription);
            this.Panel_Volkswagen.Controls.Add(this.Label_Heading);
            this.Panel_Volkswagen.Location = new System.Drawing.Point(12, 12);
            this.Panel_Volkswagen.Name = "Panel_Volkswagen";
            this.Panel_Volkswagen.Size = new System.Drawing.Size(612, 381);
            this.Panel_Volkswagen.TabIndex = 15;
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
            // Button_Passat
            // 
            this.Button_Passat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Passat.Location = new System.Drawing.Point(247, 277);
            this.Button_Passat.Name = "Button_Passat";
            this.Button_Passat.Size = new System.Drawing.Size(90, 35);
            this.Button_Passat.TabIndex = 9;
            this.Button_Passat.Text = "Passat";
            this.Button_Passat.UseVisualStyleBackColor = true;
            this.Button_Passat.Click += new System.EventHandler(this.Button_Passat_Click);
            // 
            // Button_Golf
            // 
            this.Button_Golf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Golf.Location = new System.Drawing.Point(247, 236);
            this.Button_Golf.Name = "Button_Golf";
            this.Button_Golf.Size = new System.Drawing.Size(90, 35);
            this.Button_Golf.TabIndex = 8;
            this.Button_Golf.Text = "Golf";
            this.Button_Golf.UseVisualStyleBackColor = true;
            this.Button_Golf.Click += new System.EventHandler(this.Button_Golf_Click);
            // 
            // Button_Scirocco
            // 
            this.Button_Scirocco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Scirocco.Location = new System.Drawing.Point(247, 195);
            this.Button_Scirocco.Name = "Button_Scirocco";
            this.Button_Scirocco.Size = new System.Drawing.Size(90, 35);
            this.Button_Scirocco.TabIndex = 7;
            this.Button_Scirocco.Text = "Scirocco";
            this.Button_Scirocco.UseVisualStyleBackColor = true;
            this.Button_Scirocco.Click += new System.EventHandler(this.Button_Scirocco_Click);
            // 
            // Button_Polo
            // 
            this.Button_Polo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Polo.Location = new System.Drawing.Point(247, 154);
            this.Button_Polo.Name = "Button_Polo";
            this.Button_Polo.Size = new System.Drawing.Size(90, 35);
            this.Button_Polo.TabIndex = 6;
            this.Button_Polo.Text = "Polo";
            this.Button_Polo.UseVisualStyleBackColor = true;
            this.Button_Polo.Click += new System.EventHandler(this.Button_Polo_Click);
            // 
            // Label_VolkswagenCarsDescription
            // 
            this.Label_VolkswagenCarsDescription.AutoSize = true;
            this.Label_VolkswagenCarsDescription.BackColor = System.Drawing.Color.White;
            this.Label_VolkswagenCarsDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VolkswagenCarsDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_VolkswagenCarsDescription.Location = new System.Drawing.Point(5, 35);
            this.Label_VolkswagenCarsDescription.Name = "Label_VolkswagenCarsDescription";
            this.Label_VolkswagenCarsDescription.Size = new System.Drawing.Size(598, 116);
            this.Label_VolkswagenCarsDescription.TabIndex = 5;
            this.Label_VolkswagenCarsDescription.Text = "Below is a list of cars by the manufacturer Volkswagen.\r\nThe list decends from th" +
    "e cheapest to the most expensive car.\r\n\r\nClick on a button to open the specifica" +
    "tion page for the selected car.\r\n";
            this.Label_VolkswagenCarsDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(175, 3);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(240, 32);
            this.Label_Heading.TabIndex = 3;
            this.Label_Heading.Text = "Volkswagen Cars";
            // 
            // Form_VolkswagenCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(636, 403);
            this.Controls.Add(this.Panel_Volkswagen);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(652, 442);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 442);
            this.Name = "Form_VolkswagenCars";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_Volkswagen.ResumeLayout(false);
            this.Panel_Volkswagen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Volkswagen;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.Button Button_Passat;
        private System.Windows.Forms.Button Button_Golf;
        private System.Windows.Forms.Button Button_Scirocco;
        private System.Windows.Forms.Button Button_Polo;
        private System.Windows.Forms.Label Label_VolkswagenCarsDescription;
        private System.Windows.Forms.Label Label_Heading;
    }
}