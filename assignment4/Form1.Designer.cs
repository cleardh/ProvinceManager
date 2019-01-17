namespace assignment4
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.provinceCodeListBox = new System.Windows.Forms.ListBox();
            this.labelProvinceCode = new System.Windows.Forms.Label();
            this.provinceCodeTextBox = new System.Windows.Forms.TextBox();
            this.provinceNameTextBox = new System.Windows.Forms.TextBox();
            this.labelProvinceName = new System.Windows.Forms.Label();
            this.countryCodeTextBox = new System.Windows.Forms.TextBox();
            this.labelCountryCode = new System.Windows.Forms.Label();
            this.taxCodeTextBox = new System.Windows.Forms.TextBox();
            this.labelTaxCode = new System.Windows.Forms.Label();
            this.taxRateTextBox = new System.Windows.Forms.TextBox();
            this.labelTaxRate = new System.Windows.Forms.Label();
            this.includesFederalTaxCheckBox = new System.Windows.Forms.CheckBox();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(258, 37);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(458, 49);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Province Maintenance";
            // 
            // provinceCodeListBox
            // 
            this.provinceCodeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceCodeListBox.FormattingEnabled = true;
            this.provinceCodeListBox.ItemHeight = 29;
            this.provinceCodeListBox.Location = new System.Drawing.Point(81, 143);
            this.provinceCodeListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.provinceCodeListBox.Name = "provinceCodeListBox";
            this.provinceCodeListBox.Size = new System.Drawing.Size(224, 468);
            this.provinceCodeListBox.TabIndex = 1;
            this.provinceCodeListBox.SelectedIndexChanged += new System.EventHandler(this.provinceCodeListBox_SelectedIndexChanged);
            // 
            // labelProvinceCode
            // 
            this.labelProvinceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvinceCode.Location = new System.Drawing.Point(375, 152);
            this.labelProvinceCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProvinceCode.Name = "labelProvinceCode";
            this.labelProvinceCode.Size = new System.Drawing.Size(207, 29);
            this.labelProvinceCode.TabIndex = 2;
            this.labelProvinceCode.Text = "Province Code";
            this.labelProvinceCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // provinceCodeTextBox
            // 
            this.provinceCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceCodeTextBox.Location = new System.Drawing.Point(591, 146);
            this.provinceCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.provinceCodeTextBox.Name = "provinceCodeTextBox";
            this.provinceCodeTextBox.Size = new System.Drawing.Size(96, 35);
            this.provinceCodeTextBox.TabIndex = 3;
            // 
            // provinceNameTextBox
            // 
            this.provinceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceNameTextBox.Location = new System.Drawing.Point(591, 215);
            this.provinceNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.provinceNameTextBox.Name = "provinceNameTextBox";
            this.provinceNameTextBox.Size = new System.Drawing.Size(308, 35);
            this.provinceNameTextBox.TabIndex = 5;
            // 
            // labelProvinceName
            // 
            this.labelProvinceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvinceName.Location = new System.Drawing.Point(375, 222);
            this.labelProvinceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProvinceName.Name = "labelProvinceName";
            this.labelProvinceName.Size = new System.Drawing.Size(207, 29);
            this.labelProvinceName.TabIndex = 4;
            this.labelProvinceName.Text = "Name";
            this.labelProvinceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countryCodeTextBox
            // 
            this.countryCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryCodeTextBox.Location = new System.Drawing.Point(591, 285);
            this.countryCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countryCodeTextBox.Name = "countryCodeTextBox";
            this.countryCodeTextBox.Size = new System.Drawing.Size(96, 35);
            this.countryCodeTextBox.TabIndex = 7;
            // 
            // labelCountryCode
            // 
            this.labelCountryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryCode.Location = new System.Drawing.Point(375, 291);
            this.labelCountryCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountryCode.Name = "labelCountryCode";
            this.labelCountryCode.Size = new System.Drawing.Size(207, 29);
            this.labelCountryCode.TabIndex = 6;
            this.labelCountryCode.Text = "Country Code";
            this.labelCountryCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxCodeTextBox
            // 
            this.taxCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxCodeTextBox.Location = new System.Drawing.Point(591, 354);
            this.taxCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taxCodeTextBox.Name = "taxCodeTextBox";
            this.taxCodeTextBox.Size = new System.Drawing.Size(96, 35);
            this.taxCodeTextBox.TabIndex = 9;
            // 
            // labelTaxCode
            // 
            this.labelTaxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxCode.Location = new System.Drawing.Point(375, 360);
            this.labelTaxCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaxCode.Name = "labelTaxCode";
            this.labelTaxCode.Size = new System.Drawing.Size(207, 29);
            this.labelTaxCode.TabIndex = 8;
            this.labelTaxCode.Text = "Tax Code";
            this.labelTaxCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxRateTextBox
            // 
            this.taxRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxRateTextBox.Location = new System.Drawing.Point(591, 423);
            this.taxRateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taxRateTextBox.Name = "taxRateTextBox";
            this.taxRateTextBox.Size = new System.Drawing.Size(96, 35);
            this.taxRateTextBox.TabIndex = 11;
            // 
            // labelTaxRate
            // 
            this.labelTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxRate.Location = new System.Drawing.Point(375, 429);
            this.labelTaxRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaxRate.Name = "labelTaxRate";
            this.labelTaxRate.Size = new System.Drawing.Size(207, 29);
            this.labelTaxRate.TabIndex = 10;
            this.labelTaxRate.Text = "Tax Rate";
            this.labelTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // includesFederalTaxCheckBox
            // 
            this.includesFederalTaxCheckBox.AutoSize = true;
            this.includesFederalTaxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includesFederalTaxCheckBox.Location = new System.Drawing.Point(591, 486);
            this.includesFederalTaxCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.includesFederalTaxCheckBox.Name = "includesFederalTaxCheckBox";
            this.includesFederalTaxCheckBox.Size = new System.Drawing.Size(221, 29);
            this.includesFederalTaxCheckBox.TabIndex = 12;
            this.includesFederalTaxCheckBox.Text = "Includes Federal Tax";
            this.includesFederalTaxCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecord.Location = new System.Drawing.Point(380, 558);
            this.btnNewRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(178, 48);
            this.btnNewRecord.TabIndex = 13;
            this.btnNewRecord.Text = "New Record";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(567, 558);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(681, 558);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 48);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(795, 558);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 48);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(994, 694);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewRecord);
            this.Controls.Add(this.includesFederalTaxCheckBox);
            this.Controls.Add(this.taxRateTextBox);
            this.Controls.Add(this.labelTaxRate);
            this.Controls.Add(this.taxCodeTextBox);
            this.Controls.Add(this.labelTaxCode);
            this.Controls.Add(this.countryCodeTextBox);
            this.Controls.Add(this.labelCountryCode);
            this.Controls.Add(this.provinceNameTextBox);
            this.Controls.Add(this.labelProvinceName);
            this.Controls.Add(this.provinceCodeTextBox);
            this.Controls.Add(this.labelProvinceCode);
            this.Controls.Add(this.provinceCodeListBox);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Province Maintenance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox provinceCodeListBox;
        private System.Windows.Forms.Label labelProvinceCode;
        private System.Windows.Forms.TextBox provinceCodeTextBox;
        private System.Windows.Forms.TextBox provinceNameTextBox;
        private System.Windows.Forms.Label labelProvinceName;
        private System.Windows.Forms.TextBox countryCodeTextBox;
        private System.Windows.Forms.Label labelCountryCode;
        private System.Windows.Forms.TextBox taxCodeTextBox;
        private System.Windows.Forms.Label labelTaxCode;
        private System.Windows.Forms.TextBox taxRateTextBox;
        private System.Windows.Forms.Label labelTaxRate;
        private System.Windows.Forms.CheckBox includesFederalTaxCheckBox;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}

