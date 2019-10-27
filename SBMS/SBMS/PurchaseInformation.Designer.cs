namespace SBMS
{
    partial class PurchaseInformation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTextBox = new System.Windows.Forms.DateTimePicker();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expireDateTextBox = new System.Windows.Forms.DateTimePicker();
            this.manufactureDateTextBox = new System.Windows.Forms.DateTimePicker();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.availableQuantitytextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mrtTtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.previousMrtTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.preUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.purchaseIdTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SubmiteButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTextBox);
            this.groupBox1.Controls.Add(this.supplierComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.billNoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTextBox.Location = new System.Drawing.Point(63, 10);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(129, 20);
            this.dateTextBox.TabIndex = 10;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(63, 65);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(129, 21);
            this.supplierComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supplier";
            // 
            // billNoTextBox
            // 
            this.billNoTextBox.Location = new System.Drawing.Point(63, 41);
            this.billNoTextBox.Name = "billNoTextBox";
            this.billNoTextBox.Size = new System.Drawing.Size(129, 20);
            this.billNoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.expireDateTextBox);
            this.groupBox2.Controls.Add(this.manufactureDateTextBox);
            this.groupBox2.Controls.Add(this.productComboBox);
            this.groupBox2.Controls.Add(this.CategoryComboBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.availableQuantitytextBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.remarksTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.unitPriceTextBox);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.mrtTtextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.previousMrtTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.preUnitPriceTextBox);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.totalPriceTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.codeTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // expireDateTextBox
            // 
            this.expireDateTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireDateTextBox.Location = new System.Drawing.Point(106, 141);
            this.expireDateTextBox.Name = "expireDateTextBox";
            this.expireDateTextBox.Size = new System.Drawing.Size(129, 20);
            this.expireDateTextBox.TabIndex = 26;
            // 
            // manufactureDateTextBox
            // 
            this.manufactureDateTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.manufactureDateTextBox.Location = new System.Drawing.Point(106, 119);
            this.manufactureDateTextBox.Name = "manufactureDateTextBox";
            this.manufactureDateTextBox.Size = new System.Drawing.Size(129, 20);
            this.manufactureDateTextBox.TabIndex = 18;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(106, 40);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(161, 21);
            this.productComboBox.TabIndex = 24;
            this.productComboBox.SelectionChangeCommitted += new System.EventHandler(this.productComboBox_SelectionChangeCommitted);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(106, 14);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(161, 21);
            this.CategoryComboBox.TabIndex = 23;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.CategoryComboBox_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Category";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Products";
            // 
            // availableQuantitytextBox
            // 
            this.availableQuantitytextBox.Location = new System.Drawing.Point(106, 92);
            this.availableQuantitytextBox.Name = "availableQuantitytextBox";
            this.availableQuantitytextBox.Size = new System.Drawing.Size(161, 20);
            this.availableQuantitytextBox.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Available Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Manufactured Date";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Location = new System.Drawing.Point(106, 167);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(453, 36);
            this.remarksTextBox.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "EXpired Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Remarks";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(380, 15);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(179, 20);
            this.quantityTextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Quantity";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(380, 38);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(179, 20);
            this.unitPriceTextBox.TabIndex = 11;
            this.unitPriceTextBox.TextChanged += new System.EventHandler(this.unitPriceTextBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(294, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Unit Price (TK)";
            // 
            // mrtTtextBox
            // 
            this.mrtTtextBox.Location = new System.Drawing.Point(380, 140);
            this.mrtTtextBox.Name = "mrtTtextBox";
            this.mrtTtextBox.Size = new System.Drawing.Size(179, 20);
            this.mrtTtextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "MRP (TK)";
            // 
            // previousMrtTextBox
            // 
            this.previousMrtTextBox.Location = new System.Drawing.Point(380, 111);
            this.previousMrtTextBox.Name = "previousMrtTextBox";
            this.previousMrtTextBox.Size = new System.Drawing.Size(179, 20);
            this.previousMrtTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Previoud MRP (TK)";
            // 
            // preUnitPriceTextBox
            // 
            this.preUnitPriceTextBox.Location = new System.Drawing.Point(380, 87);
            this.preUnitPriceTextBox.Name = "preUnitPriceTextBox";
            this.preUnitPriceTextBox.Size = new System.Drawing.Size(179, 20);
            this.preUnitPriceTextBox.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(275, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Pre Unit Price (TK)";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(380, 62);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(179, 20);
            this.totalPriceTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Price (TK)";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(106, 67);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(161, 20);
            this.codeTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(588, 134);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Location = new System.Drawing.Point(7, 338);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.Size = new System.Drawing.Size(1089, 177);
            this.purchaseDataGridView.TabIndex = 2;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(466, 29);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.productIdTextBox.TabIndex = 3;
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.Location = new System.Drawing.Point(466, 59);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplierIdTextBox.TabIndex = 4;
            // 
            // purchaseIdTextBox
            // 
            this.purchaseIdTextBox.Location = new System.Drawing.Point(466, 3);
            this.purchaseIdTextBox.Name = "purchaseIdTextBox";
            this.purchaseIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.purchaseIdTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(460, 85);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search by Code";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(355, 88);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 8;
            // 
            // SubmiteButton
            // 
            this.SubmiteButton.Location = new System.Drawing.Point(939, 248);
            this.SubmiteButton.Name = "SubmiteButton";
            this.SubmiteButton.Size = new System.Drawing.Size(75, 23);
            this.SubmiteButton.TabIndex = 26;
            this.SubmiteButton.Text = "Submite";
            this.SubmiteButton.UseVisualStyleBackColor = true;
            this.SubmiteButton.Click += new System.EventHandler(this.SubmiteButton_Click);
            // 
            // PurchaseInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 527);
            this.Controls.Add(this.SubmiteButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.purchaseIdTextBox);
            this.Controls.Add(this.supplierIdTextBox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseInformation";
            this.Text = "PurchaseInformation";
            this.Load += new System.EventHandler(this.PurchaseInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox billNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox availableQuantitytextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox mrtTtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox previousMrtTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox preUnitPriceTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.TextBox purchaseIdTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DateTimePicker dateTextBox;
        private System.Windows.Forms.DateTimePicker expireDateTextBox;
        private System.Windows.Forms.DateTimePicker manufactureDateTextBox;
        private System.Windows.Forms.Button SubmiteButton;
    }
}