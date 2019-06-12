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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.datumPicker = new System.Windows.Forms.DateTimePicker();
            this.VlakCheckbox = new System.Windows.Forms.CheckBox();
            this.BusCheckbox = new System.Windows.Forms.CheckBox();
            this.MHDCheckbox = new System.Windows.Forms.CheckBox();
            this.HladajButton = new System.Windows.Forms.Button();
            this.ZTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DoTextBox = new System.Windows.Forms.TextBox();
            this.MainBrowser = new System.Windows.Forms.WebBrowser();
            this.labelTest = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datumPicker
            // 
            resources.ApplyResources(this.datumPicker, "datumPicker");
            this.datumPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumPicker.Name = "datumPicker";
            this.datumPicker.Value = new System.DateTime(2019, 6, 12, 0, 0, 0, 0);
            // 
            // VlakCheckbox
            // 
            resources.ApplyResources(this.VlakCheckbox, "VlakCheckbox");
            this.VlakCheckbox.Checked = true;
            this.VlakCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VlakCheckbox.Name = "VlakCheckbox";
            this.VlakCheckbox.UseVisualStyleBackColor = true;
            // 
            // BusCheckbox
            // 
            resources.ApplyResources(this.BusCheckbox, "BusCheckbox");
            this.BusCheckbox.Name = "BusCheckbox";
            this.BusCheckbox.UseVisualStyleBackColor = true;
            // 
            // MHDCheckbox
            // 
            resources.ApplyResources(this.MHDCheckbox, "MHDCheckbox");
            this.MHDCheckbox.Name = "MHDCheckbox";
            this.MHDCheckbox.UseVisualStyleBackColor = true;
            // 
            // HladajButton
            // 
            resources.ApplyResources(this.HladajButton, "HladajButton");
            this.HladajButton.Name = "HladajButton";
            this.HladajButton.UseVisualStyleBackColor = true;
            this.HladajButton.Click += new System.EventHandler(this.HladajButton_Click);
            // 
            // ZTextBox
            // 
            resources.ApplyResources(this.ZTextBox, "ZTextBox");
            this.ZTextBox.Name = "ZTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DoTextBox
            // 
            resources.ApplyResources(this.DoTextBox, "DoTextBox");
            this.DoTextBox.Name = "DoTextBox";
            // 
            // MainBrowser
            // 
            resources.ApplyResources(this.MainBrowser, "MainBrowser");
            this.MainBrowser.Name = "MainBrowser";
            this.MainBrowser.ScriptErrorsSuppressed = true;
            // 
            // labelTest
            // 
            resources.ApplyResources(this.labelTest, "labelTest");
            this.labelTest.Name = "labelTest";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.MainBrowser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZTextBox);
            this.Controls.Add(this.HladajButton);
            this.Controls.Add(this.MHDCheckbox);
            this.Controls.Add(this.BusCheckbox);
            this.Controls.Add(this.VlakCheckbox);
            this.Controls.Add(this.datumPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.WebBrowser MainBrowser;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

