namespace CTF3001_Group_Project
{
    partial class Form_SkodaCars
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
            this.Label_SkodaCarsDescription = new System.Windows.Forms.Label();
            this.Button_Citigo = new System.Windows.Forms.Button();
            this.Button_Fabia = new System.Windows.Forms.Button();
            this.Button_Superb = new System.Windows.Forms.Button();
            this.Button_Octavia = new System.Windows.Forms.Button();
            this.Button_Return = new System.Windows.Forms.Button();
            this.Panel_Skoda = new System.Windows.Forms.Panel();
            this.Panel_Skoda.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(207, 3);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(166, 32);
            this.Label_Heading.TabIndex = 3;
            this.Label_Heading.Text = "Skoda Cars";
            // 
            // Label_SkodaCarsDescription
            // 
            this.Label_SkodaCarsDescription.AutoSize = true;
            this.Label_SkodaCarsDescription.BackColor = System.Drawing.Color.White;
            this.Label_SkodaCarsDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SkodaCarsDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_SkodaCarsDescription.Location = new System.Drawing.Point(5, 35);
            this.Label_SkodaCarsDescription.Name = "Label_SkodaCarsDescription";
            this.Label_SkodaCarsDescription.Size = new System.Drawing.Size(598, 116);
            this.Label_SkodaCarsDescription.TabIndex = 5;
            this.Label_SkodaCarsDescription.Text = "Below is a list of cars by the manufacturer Skoda.\r\nThe list decends from the che" +
    "apest to the most expensive car.\r\n\r\nClick on a button to open the specification " +
    "page for the selected car.\r\n";
            this.Label_SkodaCarsDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Citigo
            // 
            this.Button_Citigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Citigo.Location = new System.Drawing.Point(247, 154);
            this.Button_Citigo.Name = "Button_Citigo";
            this.Button_Citigo.Size = new System.Drawing.Size(90, 35);
            this.Button_Citigo.TabIndex = 6;
            this.Button_Citigo.Text = "Citigo";
            this.Button_Citigo.UseVisualStyleBackColor = true;
            this.Button_Citigo.Click += new System.EventHandler(this.Button_Citigo_Click);
            // 
            // Button_Fabia
            // 
            this.Button_Fabia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Fabia.Location = new System.Drawing.Point(247, 195);
            this.Button_Fabia.Name = "Button_Fabia";
            this.Button_Fabia.Size = new System.Drawing.Size(90, 35);
            this.Button_Fabia.TabIndex = 7;
            this.Button_Fabia.Text = "Fabia";
            this.Button_Fabia.UseVisualStyleBackColor = true;
            this.Button_Fabia.Click += new System.EventHandler(this.Button_Fabia_Click);
            // 
            // Button_Superb
            // 
            this.Button_Superb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Superb.Location = new System.Drawing.Point(247, 236);
            this.Button_Superb.Name = "Button_Superb";
            this.Button_Superb.Size = new System.Drawing.Size(90, 35);
            this.Button_Superb.TabIndex = 8;
            this.Button_Superb.Text = "Superb";
            this.Button_Superb.UseVisualStyleBackColor = true;
            this.Button_Superb.Click += new System.EventHandler(this.Button_Superb_Click);
            // 
            // Button_Octavia
            // 
            this.Button_Octavia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Octavia.Location = new System.Drawing.Point(247, 277);
            this.Button_Octavia.Name = "Button_Octavia";
            this.Button_Octavia.Size = new System.Drawing.Size(90, 35);
            this.Button_Octavia.TabIndex = 9;
            this.Button_Octavia.Text = "Octavia";
            this.Button_Octavia.UseVisualStyleBackColor = true;
            this.Button_Octavia.Click += new System.EventHandler(this.Button_Octavia_Click);
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
            // Panel_Skoda
            // 
            this.Panel_Skoda.BackColor = System.Drawing.Color.White;
            this.Panel_Skoda.Controls.Add(this.Button_Return);
            this.Panel_Skoda.Controls.Add(this.Button_Octavia);
            this.Panel_Skoda.Controls.Add(this.Button_Superb);
            this.Panel_Skoda.Controls.Add(this.Button_Fabia);
            this.Panel_Skoda.Controls.Add(this.Button_Citigo);
            this.Panel_Skoda.Controls.Add(this.Label_SkodaCarsDescription);
            this.Panel_Skoda.Controls.Add(this.Label_Heading);
            this.Panel_Skoda.Location = new System.Drawing.Point(7, 6);
            this.Panel_Skoda.MaximumSize = new System.Drawing.Size(612, 381);
            this.Panel_Skoda.MinimumSize = new System.Drawing.Size(612, 381);
            this.Panel_Skoda.Name = "Panel_Skoda";
            this.Panel_Skoda.Size = new System.Drawing.Size(612, 381);
            this.Panel_Skoda.TabIndex = 11;
            // 
            // Form_SkodaCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(625, 393);
            this.Controls.Add(this.Panel_Skoda);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 432);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 432);
            this.Name = "Form_SkodaCars";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_Skoda.ResumeLayout(false);
            this.Panel_Skoda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Heading;
        private System.Windows.Forms.Label Label_SkodaCarsDescription;
        private System.Windows.Forms.Button Button_Citigo;
        private System.Windows.Forms.Button Button_Fabia;
        private System.Windows.Forms.Button Button_Superb;
        private System.Windows.Forms.Button Button_Octavia;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.Panel Panel_Skoda;
    }
}