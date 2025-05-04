namespace CoffeePointSystem
{
    partial class MainPage
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
            this.lblSignIn = new System.Windows.Forms.Label();
            this.txtSignIn = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.lblPointsAvailable = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.lblPointApply = new System.Windows.Forms.Label();
            this.txtPointApply = new System.Windows.Forms.TextBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.lblPointMultiplier = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lstBasket = new System.Windows.Forms.ListBox();
            this.lstPromotions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Location = new System.Drawing.Point(30, 40);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(138, 20);
            this.lblSignIn.TabIndex = 0;
            this.lblSignIn.Text = "Customer Number";
            // 
            // txtSignIn
            // 
            this.txtSignIn.Location = new System.Drawing.Point(190, 40);
            this.txtSignIn.Name = "txtSignIn";
            this.txtSignIn.Size = new System.Drawing.Size(224, 26);
            this.txtSignIn.TabIndex = 1;
            this.txtSignIn.TextChanged += new System.EventHandler(this.txtSignIn_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(375, 553);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(72, 20);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(531, 553);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(104, 20);
            this.lblDiscountAmount.TabIndex = 5;
            this.lblDiscountAmount.Text = "Disc. Amount";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(807, 25);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(176, 50);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Log In Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Enabled = false;
            this.btnComplete.Location = new System.Drawing.Point(807, 585);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(177, 51);
            this.btnComplete.TabIndex = 8;
            this.btnComplete.Text = "Complete Purchase";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Enabled = false;
            this.btnDiscount.Location = new System.Drawing.Point(807, 518);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(177, 49);
            this.btnDiscount.TabIndex = 9;
            this.btnDiscount.Text = "Apply Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // lblPointsAvailable
            // 
            this.lblPointsAvailable.AutoSize = true;
            this.lblPointsAvailable.Location = new System.Drawing.Point(30, 305);
            this.lblPointsAvailable.Name = "lblPointsAvailable";
            this.lblPointsAvailable.Size = new System.Drawing.Size(120, 20);
            this.lblPointsAvailable.TabIndex = 10;
            this.lblPointsAvailable.Text = "Points Available";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Enabled = false;
            this.lblPoints.Location = new System.Drawing.Point(186, 305);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(96, 20);
            this.lblPoints.TabIndex = 11;
            this.lblPoints.Text = "Pts. Amount";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(375, 588);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(82, 20);
            this.lblFinalPrice.TabIndex = 14;
            this.lblFinalPrice.Text = "Final Price";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(531, 588);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(40, 20);
            this.lblFinal.TabIndex = 15;
            this.lblFinal.Text = "0.00";
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Location = new System.Drawing.Point(375, 518);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(101, 20);
            this.lblOriginalPrice.TabIndex = 16;
            this.lblOriginalPrice.Text = "Original Price";
            this.lblOriginalPrice.Click += new System.EventHandler(this.lblOriginalPrice_Click);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(531, 518);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(100, 20);
            this.lblOriginal.TabIndex = 17;
            this.lblOriginal.Text = "First Amount";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(807, 100);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(176, 50);
            this.btnNewCustomer.TabIndex = 18;
            this.btnNewCustomer.Text = "Register Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // lblPointApply
            // 
            this.lblPointApply.AutoSize = true;
            this.lblPointApply.Location = new System.Drawing.Point(30, 384);
            this.lblPointApply.Name = "lblPointApply";
            this.lblPointApply.Size = new System.Drawing.Size(110, 20);
            this.lblPointApply.TabIndex = 12;
            this.lblPointApply.Text = "Points Applied";
            // 
            // txtPointApply
            // 
            this.txtPointApply.Enabled = false;
            this.txtPointApply.Location = new System.Drawing.Point(190, 378);
            this.txtPointApply.Name = "txtPointApply";
            this.txtPointApply.Size = new System.Drawing.Size(136, 26);
            this.txtPointApply.TabIndex = 13;
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(190, 112);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(169, 28);
            this.cmbSection.TabIndex = 19;
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged_1);
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(30, 115);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(63, 20);
            this.lblSection.TabIndex = 20;
            this.lblSection.Text = "Section";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(30, 155);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(41, 20);
            this.lblItem.TabIndex = 21;
            this.lblItem.Text = "Item";
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(190, 147);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(169, 28);
            this.cmbItem.TabIndex = 22;
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.Location = new System.Drawing.Point(30, 341);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(111, 20);
            this.lblMultiply.TabIndex = 23;
            this.lblMultiply.Text = "Point Multiplier";
            this.lblMultiply.Click += new System.EventHandler(this.lblMultiply_Click);
            // 
            // lblPointMultiplier
            // 
            this.lblPointMultiplier.AutoSize = true;
            this.lblPointMultiplier.Enabled = false;
            this.lblPointMultiplier.Location = new System.Drawing.Point(186, 341);
            this.lblPointMultiplier.Name = "lblPointMultiplier";
            this.lblPointMultiplier.Size = new System.Drawing.Size(103, 20);
            this.lblPointMultiplier.TabIndex = 24;
            this.lblPointMultiplier.Text = "Mult. Amount";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(34, 201);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(121, 42);
            this.btnAddItem.TabIndex = 25;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(190, 201);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(121, 42);
            this.btnRemoveItem.TabIndex = 26;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(807, 175);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(176, 50);
            this.btnInfo.TabIndex = 28;
            this.btnInfo.Text = "Customer Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Location = new System.Drawing.Point(30, 507);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(208, 20);
            this.lblSpecial.TabIndex = 30;
            this.lblSpecial.Text = "Special Promotion Available:";
            // 
            // lstBasket
            // 
            this.lstBasket.FormattingEnabled = true;
            this.lstBasket.ItemHeight = 20;
            this.lstBasket.Location = new System.Drawing.Point(452, 147);
            this.lstBasket.Name = "lstBasket";
            this.lstBasket.Size = new System.Drawing.Size(230, 264);
            this.lstBasket.TabIndex = 31;
            // 
            // lstPromotions
            // 
            this.lstPromotions.Enabled = false;
            this.lstPromotions.FormattingEnabled = true;
            this.lstPromotions.ItemHeight = 20;
            this.lstPromotions.Location = new System.Drawing.Point(34, 544);
            this.lstPromotions.Name = "lstPromotions";
            this.lstPromotions.Size = new System.Drawing.Size(277, 64);
            this.lstPromotions.TabIndex = 32;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 648);
            this.Controls.Add(this.lstPromotions);
            this.Controls.Add(this.lstBasket);
            this.Controls.Add(this.lblSpecial);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblPointMultiplier);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.lblOriginalPrice);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.txtPointApply);
            this.Controls.Add(this.lblPointApply);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblPointsAvailable);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtSignIn);
            this.Controls.Add(this.lblSignIn);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.TextBox txtSignIn;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Label lblPointsAvailable;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Label lblPointApply;
        private System.Windows.Forms.TextBox txtPointApply;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label lblMultiply;
        private System.Windows.Forms.Label lblPointMultiplier;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.ListBox lstBasket;
        private System.Windows.Forms.ListBox lstPromotions;
    }
}

