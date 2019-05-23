namespace CPScraper
{
    partial class Form1
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
            this.datumPicker = new System.Windows.Forms.DateTimePicker();
            this.VlakCheckbox = new System.Windows.Forms.CheckBox();
            this.BusCheckbox = new System.Windows.Forms.CheckBox();
            this.MHDCheckbox = new System.Windows.Forms.CheckBox();
            this.HladajButton = new System.Windows.Forms.Button();
            this.ZTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DoTextBox = new System.Windows.Forms.TextBox();
            this.TempBrowser = new System.Windows.Forms.WebBrowser();
            this.labelTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datumPicker
            // 
            this.datumPicker.CustomFormat = "";
            this.datumPicker.Location = new System.Drawing.Point(12, 89);
            this.datumPicker.Name = "datumPicker";
            this.datumPicker.Size = new System.Drawing.Size(175, 20);
            this.datumPicker.TabIndex = 0;
            this.datumPicker.Value = new System.DateTime(2019, 2, 16, 0, 0, 0, 0);
            // 
            // VlakCheckbox
            // 
            this.VlakCheckbox.AutoSize = true;
            this.VlakCheckbox.Location = new System.Drawing.Point(12, 12);
            this.VlakCheckbox.Name = "VlakCheckbox";
            this.VlakCheckbox.Size = new System.Drawing.Size(47, 17);
            this.VlakCheckbox.TabIndex = 1;
            this.VlakCheckbox.Text = "Vlak";
            this.VlakCheckbox.UseVisualStyleBackColor = true;
            // 
            // BusCheckbox
            // 
            this.BusCheckbox.AutoSize = true;
            this.BusCheckbox.Location = new System.Drawing.Point(65, 12);
            this.BusCheckbox.Name = "BusCheckbox";
            this.BusCheckbox.Size = new System.Drawing.Size(44, 17);
            this.BusCheckbox.TabIndex = 2;
            this.BusCheckbox.Text = "Bus";
            this.BusCheckbox.UseVisualStyleBackColor = true;
            // 
            // MHDCheckbox
            // 
            this.MHDCheckbox.AutoSize = true;
            this.MHDCheckbox.Location = new System.Drawing.Point(115, 12);
            this.MHDCheckbox.Name = "MHDCheckbox";
            this.MHDCheckbox.Size = new System.Drawing.Size(51, 17);
            this.MHDCheckbox.TabIndex = 3;
            this.MHDCheckbox.Text = "MHD";
            this.MHDCheckbox.UseVisualStyleBackColor = true;
            // 
            // HladajButton
            // 
            this.HladajButton.Location = new System.Drawing.Point(12, 115);
            this.HladajButton.Name = "HladajButton";
            this.HladajButton.Size = new System.Drawing.Size(175, 69);
            this.HladajButton.TabIndex = 4;
            this.HladajButton.Text = "Hľadaj";
            this.HladajButton.UseVisualStyleBackColor = true;
            this.HladajButton.Click += new System.EventHandler(this.HladajButton_Click);
            // 
            // ZTextBox
            // 
            this.ZTextBox.Location = new System.Drawing.Point(46, 35);
            this.ZTextBox.Name = "ZTextBox";
            this.ZTextBox.Size = new System.Drawing.Size(141, 20);
            this.ZTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Do:";
            // 
            // DoTextBox
            // 
            this.DoTextBox.Location = new System.Drawing.Point(46, 58);
            this.DoTextBox.Name = "DoTextBox";
            this.DoTextBox.Size = new System.Drawing.Size(141, 20);
            this.DoTextBox.TabIndex = 9;
            // 
            // TempBrowser
            // 
            this.TempBrowser.Location = new System.Drawing.Point(193, 12);
            this.TempBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TempBrowser.Name = "TempBrowser";
            this.TempBrowser.ScriptErrorsSuppressed = true;
            this.TempBrowser.Size = new System.Drawing.Size(774, 550);
            this.TempBrowser.TabIndex = 11;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(24, 224);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 13);
            this.labelTest.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 574);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.TempBrowser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZTextBox);
            this.Controls.Add(this.HladajButton);
            this.Controls.Add(this.MHDCheckbox);
            this.Controls.Add(this.BusCheckbox);
            this.Controls.Add(this.VlakCheckbox);
            this.Controls.Add(this.datumPicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumPicker;
        private System.Windows.Forms.CheckBox VlakCheckbox;
        private System.Windows.Forms.CheckBox BusCheckbox;
        private System.Windows.Forms.CheckBox MHDCheckbox;
        private System.Windows.Forms.Button HladajButton;
        private System.Windows.Forms.TextBox ZTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DoTextBox;
        private System.Windows.Forms.WebBrowser TempBrowser;
        private System.Windows.Forms.Label labelTest;
    }
}

