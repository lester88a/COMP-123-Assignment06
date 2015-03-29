namespace COMP123_Sharp_Mail_Order
{
    partial class SalesBonusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonusForm));
            this.SalesPictureBox = new System.Windows.Forms.PictureBox();
            this.LanguagesGroupBox = new System.Windows.Forms.GroupBox();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalSalsesTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalsesLabel = new System.Windows.Forms.Label();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPictureBox)).BeginInit();
            this.LanguagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesPictureBox
            // 
            this.SalesPictureBox.Image = global::COMP123_Sharp_Mail_Order.Properties.Resources.graphIcon;
            this.SalesPictureBox.Location = new System.Drawing.Point(20, 20);
            this.SalesPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesPictureBox.Name = "SalesPictureBox";
            this.SalesPictureBox.Size = new System.Drawing.Size(195, 205);
            this.SalesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalesPictureBox.TabIndex = 0;
            this.SalesPictureBox.TabStop = false;
            // 
            // LanguagesGroupBox
            // 
            this.LanguagesGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguagesGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguagesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguagesGroupBox.Location = new System.Drawing.Point(258, 20);
            this.LanguagesGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LanguagesGroupBox.Name = "LanguagesGroupBox";
            this.LanguagesGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LanguagesGroupBox.Size = new System.Drawing.Size(300, 154);
            this.LanguagesGroupBox.TabIndex = 1;
            this.LanguagesGroupBox.TabStop = false;
            this.LanguagesGroupBox.Text = "Languages";
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrenchRadioButton.Location = new System.Drawing.Point(54, 98);
            this.FrenchRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(130, 33);
            this.FrenchRadioButton.TabIndex = 2;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishRadioButton.Location = new System.Drawing.Point(54, 52);
            this.EnglishRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(118, 33);
            this.EnglishRadioButton.TabIndex = 1;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLabel.Location = new System.Drawing.Point(20, 280);
            this.EmployeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(199, 29);
            this.EmployeeNameLabel.TabIndex = 1;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(258, 277);
            this.EmployeeNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(300, 35);
            this.EmployeeNameTextBox.TabIndex = 3;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(258, 327);
            this.EmployeeIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(184, 35);
            this.EmployeeIDTextBox.TabIndex = 4;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(20, 330);
            this.EmployeeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(157, 29);
            this.EmployeeIDLabel.TabIndex = 4;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(258, 402);
            this.HoursWorkedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(184, 35);
            this.HoursWorkedTextBox.TabIndex = 5;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedLabel.Location = new System.Drawing.Point(20, 406);
            this.HoursWorkedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(173, 29);
            this.HoursWorkedLabel.TabIndex = 6;
            this.HoursWorkedLabel.Text = "Hours Worked:";
            // 
            // TotalSalsesTextBox
            // 
            this.TotalSalsesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalsesTextBox.Location = new System.Drawing.Point(258, 451);
            this.TotalSalsesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TotalSalsesTextBox.Name = "TotalSalsesTextBox";
            this.TotalSalsesTextBox.Size = new System.Drawing.Size(184, 35);
            this.TotalSalsesTextBox.TabIndex = 6;
            // 
            // TotalSalsesLabel
            // 
            this.TotalSalsesLabel.AutoSize = true;
            this.TotalSalsesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalsesLabel.Location = new System.Drawing.Point(20, 454);
            this.TotalSalsesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalSalsesLabel.Name = "TotalSalsesLabel";
            this.TotalSalsesLabel.Size = new System.Drawing.Size(153, 29);
            this.TotalSalsesLabel.TabIndex = 8;
            this.TotalSalsesLabel.Text = "Total Salses:";
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalesBonusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusTextBox.Location = new System.Drawing.Point(258, 501);
            this.SalesBonusTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(185, 35);
            this.SalesBonusTextBox.TabIndex = 7;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusLabel.Location = new System.Drawing.Point(20, 503);
            this.SalesBonusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(154, 29);
            this.SalesBonusLabel.TabIndex = 10;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(18, 569);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(134, 46);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(218, 569);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(134, 46);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(424, 569);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 46);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SalesBonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 634);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalsesTextBox);
            this.Controls.Add(this.TotalSalsesLabel);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.LanguagesGroupBox);
            this.Controls.Add(this.SalesPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalesBonusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.SalesPictureBox)).EndInit();
            this.LanguagesGroupBox.ResumeLayout(false);
            this.LanguagesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SalesPictureBox;
        private System.Windows.Forms.GroupBox LanguagesGroupBox;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.TextBox TotalSalsesTextBox;
        private System.Windows.Forms.Label TotalSalsesLabel;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

