namespace CTF3001_Group_Project
{
    partial class Form_ToyotaCars
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
            this.Panel_Toyota = new System.Windows.Forms.Panel();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Button_Yaris = new System.Windows.Forms.Button();
            this.Button_Corolla = new System.Windows.Forms.Button();
            this.Button_Prius = new System.Windows.Forms.Button();
            this.Button_Aygo = new System.Windows.Forms.Button();
            this.Label_ToyotaCarsDescription = new System.Windows.Forms.Label();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Panel_Toyota.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Toyota
            // 
            this.Panel_Toyota.BackColor = System.Drawing.Color.White;
            this.Panel_Toyota.Controls.Add(this.Button_Return);
            this.Panel_Toyota.Controls.Add(this.Button_Yaris);
            this.Panel_Toyota.Controls.Add(this.Button_Corolla);
            this.Panel_Toyota.Controls.Add(this.Button_Prius);
            this.Panel_Toyota.Controls.Add(this.Button_Aygo);
            this.Panel_Toyota.Controls.Add(this.Label_ToyotaCarsDescription);
            this.Panel_Toyota.Controls.Add(this.Label_Heading);
            this.Panel_Toyota.Location = new System.Drawing.Point(12, 12);
            this.Panel_Toyota.Name = "Panel_Toyota";
            this.Panel_Toyota.Size = new System.Drawing.Size(612, 381);
            this.Panel_Toyota.TabIndex = 13;
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
            // Button_Yaris
            // 
            this.Button_Yaris.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Yaris.Location = new System.Drawing.Point(247, 277);
            this.Button_Yaris.Name = "Button_Yaris";
            this.Button_Yaris.Size = new System.Drawing.Size(90, 35);
            this.Button_Yaris.TabIndex = 9;
            this.Button_Yaris.Text = "Yaris";
            this.Button_Yaris.UseVisualStyleBackColor = true;
            this.Button_Yaris.Click += new System.EventHandler(this.Button_Yaris_Click);
            // 
            // Button_Corolla
            // 
            this.Button_Corolla.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Corolla.Location = new System.Drawing.Point(247, 236);
            this.Button_Corolla.Name = "Button_Corolla";
            this.Button_Corolla.Size = new System.Drawing.Size(90, 35);
            this.Button_Corolla.TabIndex = 8;
            this.Button_Corolla.Text = "Corolla";
            this.Button_Corolla.UseVisualStyleBackColor = true;
            this.Button_Corolla.Click += new System.EventHandler(this.Button_Corolla_Click);
            // 
            // Button_Prius
            // 
            this.Button_Prius.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Prius.Location = new System.Drawing.Point(247, 195);
            this.Button_Prius.Name = "Button_Prius";
            this.Button_Prius.Size = new System.Drawing.Size(90, 35);
            this.Button_Prius.TabIndex = 7;
            this.Button_Prius.Text = "Prius";
            this.Button_Prius.UseVisualStyleBackColor = true;
            this.Button_Prius.Click += new System.EventHandler(this.Button_Prius_Click);
            // 
            // Button_Aygo
            // 
            this.Button_Aygo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Aygo.Location = new System.Drawing.Point(247, 154);
            this.Button_Aygo.Name = "Button_Aygo";
            this.Button_Aygo.Size = new System.Drawing.Size(90, 35);
            this.Button_Aygo.TabIndex = 6;
            this.Button_Aygo.Text = "Aygo";
            this.Button_Aygo.UseVisualStyleBackColor = true;
            this.Button_Aygo.Click += new System.EventHandler(this.Button_Aygo_Click);
            // 
            // Label_ToyotaCarsDescription
            // 
            this.Label_ToyotaCarsDescription.AutoSize = true;
            this.Label_ToyotaCarsDescription.BackColor = System.Drawing.Color.White;
            this.Label_ToyotaCarsDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ToyotaCarsDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_ToyotaCarsDescription.Location = new System.Drawing.Point(5, 35);
            this.Label_ToyotaCarsDescription.Name = "Label_ToyotaCarsDescription";
            this.Label_ToyotaCarsDescription.Size = new System.Drawing.Size(598, 116);
            this.Label_ToyotaCarsDescription.TabIndex = 5;
            this.Label_ToyotaCarsDescription.Text = "Below is a list of cars by the manufacturer Toyota.\r\nThe list decends from the ch" +
    "eapest to the most expensive car.\r\n\r\nClick on a button to open the specification" +
    " page for the selected car.\r\n";
            this.Label_ToyotaCarsDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(207, 3);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(173, 32);
            this.Label_Heading.TabIndex = 3;
            this.Label_Heading.Text = "Toyota Cars";
            // 
            // Form_ToyotaCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(637, 402);
            this.Controls.Add(this.Panel_Toyota);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(653, 441);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(653, 441);
            this.Name = "Form_ToyotaCars";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_Toyota.ResumeLayout(false);
            this.Panel_Toyota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Toyota;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.Button Button_Yaris;
        private System.Windows.Forms.Button Button_Corolla;
        private System.Windows.Forms.Button Button_Prius;
        private System.Windows.Forms.Button Button_Aygo;
        private System.Windows.Forms.Label Label_ToyotaCarsDescription;
        private System.Windows.Forms.Label Label_Heading;
    }
}