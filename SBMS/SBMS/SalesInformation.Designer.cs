namespace SBMS
{
    partial class SalesInformation
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
            this.loyalityPointTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.toatlMrpTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.submiitButton = new System.Windows.Forms.Button();
            this.payableAmountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.discountAmountTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.salesdDtaGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesdDtaGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loyalityPointTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customerComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // loyalityPointTextBox
            // 
            this.loyalityPointTextBox.Location = new System.Drawing.Point(73, 84);
            this.loyalityPointTextBox.Name = "loyalityPointTextBox";
            this.loyalityPointTextBox.Size = new System.Drawing.Size(166, 20);
            this.loyalityPointTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(73, 58);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(168, 20);
            this.dateTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loyality Point";
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(73, 30);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(166, 21);
            this.customerComboBox.TabIndex = 1;
            this.customerComboBox.SelectionChangeCommitted += new System.EventHandler(this.customerComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.toatlMrpTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.mrpTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.availableQuantityTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.productComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(56, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(184, 168);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // toatlMrpTextBox
            // 
            this.toatlMrpTextBox.Location = new System.Drawing.Point(100, 141);
            this.toatlMrpTextBox.Name = "toatlMrpTextBox";
            this.toatlMrpTextBox.Size = new System.Drawing.Size(166, 20);
            this.toatlMrpTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total MRP (TK)";
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(100, 116);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(166, 20);
            this.mrpTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "MRP (TK)";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(100, 92);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(166, 20);
            this.quantityTextBox.TabIndex = 7;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity";
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(100, 68);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.Size = new System.Drawing.Size(166, 20);
            this.availableQuantityTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Available  Quantity";
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(100, 44);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(166, 21);
            this.productComboBox.TabIndex = 3;
            this.productComboBox.SelectionChangeCommitted += new System.EventHandler(this.productComboBox_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(100, 20);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(166, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryComboBox_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.submiitButton);
            this.groupBox3.Controls.Add(this.payableAmountTextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.discountAmountTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.discountTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.grandTotalTextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.salesdDtaGridView);
            this.groupBox3.Location = new System.Drawing.Point(340, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 350);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Products Detials";
            // 
            // submiitButton
            // 
            this.submiitButton.Location = new System.Drawing.Point(247, 318);
            this.submiitButton.Name = "submiitButton";
            this.submiitButton.Size = new System.Drawing.Size(75, 23);
            this.submiitButton.TabIndex = 13;
            this.submiitButton.Text = "Submit";
            this.submiitButton.UseVisualStyleBackColor = true;
            this.submiitButton.Click += new System.EventHandler(this.submiitButton_Click);
            // 
            // payableAmountTextBox
            // 
            this.payableAmountTextBox.Location = new System.Drawing.Point(153, 276);
            this.payableAmountTextBox.Name = "payableAmountTextBox";
            this.payableAmountTextBox.Size = new System.Drawing.Size(169, 20);
            this.payableAmountTextBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Payable Amount (TK)";
            // 
            // discountAmountTextBox
            // 
            this.discountAmountTextBox.Location = new System.Drawing.Point(153, 251);
            this.discountAmountTextBox.Name = "discountAmountTextBox";
            this.discountAmountTextBox.Size = new System.Drawing.Size(169, 20);
            this.discountAmountTextBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Discount Amount (TK)";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(153, 227);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(169, 20);
            this.discountTextBox.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Discount (%)";
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Location = new System.Drawing.Point(153, 203);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.Size = new System.Drawing.Size(169, 20);
            this.grandTotalTextBox.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Grand Total (TK)";
            // 
            // salesdDtaGridView
            // 
            this.salesdDtaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesdDtaGridView.Location = new System.Drawing.Point(18, 19);
            this.salesdDtaGridView.Name = "salesdDtaGridView";
            this.salesdDtaGridView.Size = new System.Drawing.Size(559, 150);
            this.salesdDtaGridView.TabIndex = 0;
            this.salesdDtaGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesdDtaGridView_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Search);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.searchTextBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(340, 398);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(84, 57);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "SalesCode";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(84, 29);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(101, 20);
            this.searchTextBox.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 10;
            // 
            // SalesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 528);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesInformation";
            this.Text = "SalesInformation";
            this.Load += new System.EventHandler(this.SalesInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesdDtaGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox loyalityPointTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox toatlMrpTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView salesdDtaGridView;
        private System.Windows.Forms.TextBox payableAmountTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox discountAmountTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button submiitButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label15;
    }
}