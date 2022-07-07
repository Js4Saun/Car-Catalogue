namespace CTF3001_Group_Project
{
    partial class Form_ChoiceMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChoiceMenu));
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Label_ChoiceMenuDescription = new System.Windows.Forms.Label();
            this.ComboBox_PriceRange = new System.Windows.Forms.ComboBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Panel_ChoiceMenu = new System.Windows.Forms.Panel();
            this.Button_SearchPriceRange = new System.Windows.Forms.Button();
            this.Button_SearchBrand = new System.Windows.Forms.Button();
            this.ComboBox_CarManufacturer = new System.Windows.Forms.ComboBox();
            this.Panel_ChoiceMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.Location = new System.Drawing.Point(158, 1);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(185, 32);
            this.Label_Heading.TabIndex = 2;
            this.Label_Heading.Text = "Choice Menu";
            // 
            // Label_ChoiceMenuDescription
            // 
            this.Label_ChoiceMenuDescription.AutoSize = true;
            this.Label_ChoiceMenuDescription.BackColor = System.Drawing.Color.White;
            this.Label_ChoiceMenuDescription.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ChoiceMenuDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_ChoiceMenuDescription.Location = new System.Drawing.Point(1, 31);
            this.Label_ChoiceMenuDescription.Name = "Label_ChoiceMenuDescription";
            this.Label_ChoiceMenuDescription.Size = new System.Drawing.Size(530, 174);
            this.Label_ChoiceMenuDescription.TabIndex = 4;
            this.Label_ChoiceMenuDescription.Text = resources.GetString("Label_ChoiceMenuDescription.Text");
            this.Label_ChoiceMenuDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_PriceRange
            // 
            this.ComboBox_PriceRange.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_PriceRange.FormattingEnabled = true;
            this.ComboBox_PriceRange.Items.AddRange(new object[] {
            "0 - 20,000 (5 cars)",
            "20,000 - 30,000 (10 cars)",
            "30,000 - 40,000 (4 cars)",
            "40,000 - 150,000 (5 cars)"});
            this.ComboBox_PriceRange.Location = new System.Drawing.Point(83, 266);
            this.ComboBox_PriceRange.Name = "ComboBox_PriceRange";
            this.ComboBox_PriceRange.Size = new System.Drawing.Size(206, 31);
            this.ComboBox_PriceRange.TabIndex = 6;
            this.ComboBox_PriceRange.Text = "Choose Price Range";
            this.ComboBox_PriceRange.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PriceRange_SelectedIndexChanged);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(197, 313);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(111, 39);
            this.Button_Exit.TabIndex = 7;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Panel_ChoiceMenu
            // 
            this.Panel_ChoiceMenu.BackColor = System.Drawing.Color.White;
            this.Panel_ChoiceMenu.Controls.Add(this.Button_SearchPriceRange);
            this.Panel_ChoiceMenu.Controls.Add(this.Button_SearchBrand);
            this.Panel_ChoiceMenu.Controls.Add(this.ComboBox_CarManufacturer);
            this.Panel_ChoiceMenu.Controls.Add(this.Label_ChoiceMenuDescription);
            this.Panel_ChoiceMenu.Controls.Add(this.Button_Exit);
            this.Panel_ChoiceMenu.Controls.Add(this.ComboBox_PriceRange);
            this.Panel_ChoiceMenu.Controls.Add(this.Label_Heading);
            this.Panel_ChoiceMenu.Location = new System.Drawing.Point(8, 8);
            this.Panel_ChoiceMenu.Name = "Panel_ChoiceMenu";
            this.Panel_ChoiceMenu.Size = new System.Drawing.Size(529, 363);
            this.Panel_ChoiceMenu.TabIndex = 8;
            this.Panel_ChoiceMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_ChoiceMenu_Paint);
            // 
            // Button_SearchPriceRange
            // 
            this.Button_SearchPriceRange.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SearchPriceRange.Location = new System.Drawing.Point(295, 266);
            this.Button_SearchPriceRange.Name = "Button_SearchPriceRange";
            this.Button_SearchPriceRange.Size = new System.Drawing.Size(84, 31);
            this.Button_SearchPriceRange.TabIndex = 14;
            this.Button_SearchPriceRange.Text = "Search";
            this.Button_SearchPriceRange.UseVisualStyleBackColor = true;
            this.Button_SearchPriceRange.Click += new System.EventHandler(this.Button_SearchPriceRange_Click);
            // 
            // Button_SearchBrand
            // 
            this.Button_SearchBrand.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SearchBrand.Location = new System.Drawing.Point(295, 218);
            this.Button_SearchBrand.Name = "Button_SearchBrand";
            this.Button_SearchBrand.Size = new System.Drawing.Size(84, 31);
            this.Button_SearchBrand.TabIndex = 13;
            this.Button_SearchBrand.Text = "Search";
            this.Button_SearchBrand.UseVisualStyleBackColor = true;
            this.Button_SearchBrand.Click += new System.EventHandler(this.Button_SearchBrand_Click);
            // 
            // ComboBox_CarManufacturer
            // 
            this.ComboBox_CarManufacturer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_CarManufacturer.FormattingEnabled = true;
            this.ComboBox_CarManufacturer.Items.AddRange(new object[] {
            "Skoda",
            "Ford",
            "Toyota",
            "Audi",
            "Volkswagen",
            "BMW"});
            this.ComboBox_CarManufacturer.Location = new System.Drawing.Point(83, 218);
            this.ComboBox_CarManufacturer.Name = "ComboBox_CarManufacturer";
            this.ComboBox_CarManufacturer.Size = new System.Drawing.Size(206, 31);
            this.ComboBox_CarManufacturer.TabIndex = 11;
            this.ComboBox_CarManufacturer.Text = "Choose Brand";
            // 
            // Form_ChoiceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(545, 377);
            this.Controls.Add(this.Panel_ChoiceMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(561, 416);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(561, 416);
            this.Name = "Form_ChoiceMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Specification App";
            this.Panel_ChoiceMenu.ResumeLayout(false);
            this.Panel_ChoiceMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Heading;
        private System.Windows.Forms.Label Label_ChoiceMenuDescription;
        private System.Windows.Forms.ComboBox ComboBox_PriceRange;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Panel Panel_ChoiceMenu;
        private System.Windows.Forms.ComboBox ComboBox_CarManufacturer;
        private System.Windows.Forms.Button Button_SearchBrand;
        private System.Windows.Forms.Button Button_SearchPriceRange;
    }
}