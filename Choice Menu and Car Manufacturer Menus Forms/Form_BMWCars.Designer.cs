namespace CTF3001_Group_Project
{
    partial class Form_BMWCars
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
            this.Panel_BMW = new System.Windows.Forms.Panel();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Button_M5 = new System.Windows.Forms.Button();
            this.Button_X3 = new System.Windows.Forms.Button();
            this.Button_2Series = new System.Windows.Forms.Button();
            this.Button_1Series = new System.Windows.Forms.Button();
            this.Label_BMWCarsDescription = new System.Windows.Forms.Label();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Panel_BMW.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_BMW
            // 
            this.Panel_BMW.BackColor = System.Drawing.Color.White;
            this.Panel_BMW.Controls.Add(this.Button_Return);
            this.Panel_BMW.Controls.Add(this.Button_M5);
            this.Panel_BMW.Controls.Add(this.Button_X3);
            this.Panel_BMW.Controls.Add(this.Button_2Series);
            this.Panel_BMW.Controls.Add(this.Button_1Series);
            this.Panel_BMW.Controls.Add(this.Label_BMWCarsDescription);
            this.Panel_BMW.Controls.Add(this.Label_Heading);
            this.Panel_BMW.Location = new System.Drawing.Point(12, 12);
            this.Panel_BMW.Name = "Panel_BMW";
            this.Panel_BMW.Size = new System.Drawing.Size(612, 381);
            this.Panel_BMW.TabIndex = 16;
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
            // Button_M5
            // 
            this.Button_M5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_M5.Location = new System.Drawing.Point(247, 277);
            this.Button_M5.Name = "Button_M5";
            this.Button_M5.Size = new System.Drawing.Size(90, 35);
            this.Button_M5.TabIndex = 9;
            this.Button_M5.Text = "M5";
            this.Button_M5.UseVisualStyleBackColor = true;
            this.Button_M5.Click += new System.EventHandler(this.Button_M5_Click);
            // 
            // Button_X3
            // 
            this.Button_X3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_X3.Location = new System.Drawing.Point(247, 236);
            this.Button_X3.Name = "Button_X3";
            this.Button_X3.Size = new System.Drawing.Size(90, 35);
            this.Button_X3.TabIndex = 8;
            this.Button_X3.Text = "X3";
            this.Button_X3.UseVisualStyleBackColor = true;
            this.Button_X3.Click += new System.EventHandler(this.Button_X3_Click);
            // 
            // Button_2Series
            // 
            this.Button_2Series.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_2Series.Location = new System.Drawing.Point(247, 195);
            this.Button_2Series.Name = "Button_2Series";
            this.Button_2Series.Size = new System.Drawing.Size(90, 35);
            this.Button_2Series.TabIndex = 7;
            this.Button_2Series.Text = "2 Series";
            this.Button_2Series.UseVisualStyleBackColor = true;
            this.Button_2Series.Click += new System.EventHandler(this.Button_2Series_Click);
            // 
            // Button_1Series
            // 
            this.Button_1Series.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_1Series.Location = new System.Drawing.Point(247, 154);
            this.Button_1Series.Name = "Button_1Series";
            this.Button_1Series.Size = new System.Drawing.Size(90, 35);
            this.Button_1Series.TabIndex = 6;
            this.Button_1Series.Text = "1 Series";
            this.Button_1Series.UseVisualStyleBackColor = true;
            this.Button_1Series.Click += new System.EventHandler(this.Button_1Series_Click);
            // 
            // Label_BMWCarsDescription
            // 
            this.Label_BMWCarsDescription.AutoSize = true;
            this.Label_BMWCarsDescription.BackColor = System.Drawing.Color.White;
            this.Label_BMWCarsDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BMWCarsDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_BMWCarsDescription.Location = new System.Drawing.Point(5, 35);
            this.Label_BMWCarsDescription.Name = "Label_BMWCarsDescription";
            this.Label_BMWCarsDescription.Size = new System.Drawing.Size(598, 116);
            this.Label_BMWCarsDescription.TabIndex = 5;
            this.Label_BMWCarsDescription.Text = "Below is a list of cars by the manufacturer BMW.\r\nThe list decends from the cheap" +
    "est to the most expensive car.\r\n\r\nClick on a button to open the specification pa" +
    "ge for the selected car.\r\n";
            this.Label_BMWCarsDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(212, 3);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(150, 32);
            this.Label_Heading.TabIndex = 3;
            this.Label_Heading.Text = "BMW Cars";
            // 
            // Form_BMWCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(636, 400);
            this.Controls.Add(this.Panel_BMW);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(652, 439);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 439);
            this.Name = "Form_BMWCars";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_BMW.ResumeLayout(false);
            this.Panel_BMW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_BMW;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.Button Button_M5;
        private System.Windows.Forms.Button Button_X3;
        private System.Windows.Forms.Button Button_2Series;
        private System.Windows.Forms.Button Button_1Series;
        private System.Windows.Forms.Label Label_BMWCarsDescription;
        private System.Windows.Forms.Label Label_Heading;
    }
}