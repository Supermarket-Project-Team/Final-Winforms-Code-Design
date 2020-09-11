namespace Login_Form
{
    partial class form_Product
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.cbo_subCategory = new System.Windows.Forms.ComboBox();
            this.txt_sgst = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_threshold = new System.Windows.Forms.TextBox();
            this.txt_mrp = new System.Windows.Forms.TextBox();
            this.txt_vendor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cgst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_profit = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_costprice = new System.Windows.Forms.TextBox();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.lbl_profit = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_costprice = new System.Windows.Forms.Label();
            this.lbl_prodname = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.btn_pro_back = new System.Windows.Forms.Button();
            this.btn_pro_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(953, 16);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(70, 29);
            this.btn_delete.TabIndex = 59;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_edit.Location = new System.Drawing.Point(867, 16);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(66, 29);
            this.btn_edit.TabIndex = 57;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save.Location = new System.Drawing.Point(774, 16);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 29);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(21, 305);
            this.dgv_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(1072, 299);
            this.dgv_product.TabIndex = 55;
            // 
            // cbo_subCategory
            // 
            this.cbo_subCategory.FormattingEnabled = true;
            this.cbo_subCategory.Location = new System.Drawing.Point(714, 62);
            this.cbo_subCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_subCategory.Name = "cbo_subCategory";
            this.cbo_subCategory.Size = new System.Drawing.Size(232, 23);
            this.cbo_subCategory.TabIndex = 54;
            // 
            // txt_sgst
            // 
            this.txt_sgst.Location = new System.Drawing.Point(714, 232);
            this.txt_sgst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sgst.Name = "txt_sgst";
            this.txt_sgst.Size = new System.Drawing.Size(232, 21);
            this.txt_sgst.TabIndex = 53;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(714, 195);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(232, 21);
            this.txt_discount.TabIndex = 52;
            // 
            // txt_threshold
            // 
            this.txt_threshold.Location = new System.Drawing.Point(714, 161);
            this.txt_threshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_threshold.Name = "txt_threshold";
            this.txt_threshold.Size = new System.Drawing.Size(232, 21);
            this.txt_threshold.TabIndex = 51;
            // 
            // txt_mrp
            // 
            this.txt_mrp.Location = new System.Drawing.Point(714, 134);
            this.txt_mrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mrp.Name = "txt_mrp";
            this.txt_mrp.Size = new System.Drawing.Size(232, 21);
            this.txt_mrp.TabIndex = 50;
            // 
            // txt_vendor
            // 
            this.txt_vendor.Location = new System.Drawing.Point(714, 97);
            this.txt_vendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_vendor.Name = "txt_vendor";
            this.txt_vendor.Size = new System.Drawing.Size(232, 21);
            this.txt_vendor.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "SGST%:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Discount%:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Threshold Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "MRP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Vendor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Sub Category:";
            // 
            // txt_cgst
            // 
            this.txt_cgst.Location = new System.Drawing.Point(238, 230);
            this.txt_cgst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cgst.Name = "txt_cgst";
            this.txt_cgst.Size = new System.Drawing.Size(218, 21);
            this.txt_cgst.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "CGST %:";
            // 
            // txt_profit
            // 
            this.txt_profit.Location = new System.Drawing.Point(238, 195);
            this.txt_profit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_profit.Name = "txt_profit";
            this.txt_profit.Size = new System.Drawing.Size(218, 21);
            this.txt_profit.TabIndex = 40;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(238, 161);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(218, 21);
            this.txt_qty.TabIndex = 39;
            // 
            // txt_costprice
            // 
            this.txt_costprice.Location = new System.Drawing.Point(238, 131);
            this.txt_costprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_costprice.Name = "txt_costprice";
            this.txt_costprice.Size = new System.Drawing.Size(218, 21);
            this.txt_costprice.TabIndex = 38;
            // 
            // cbo_category
            // 
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(238, 70);
            this.cbo_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(218, 23);
            this.cbo_category.TabIndex = 37;
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(238, 101);
            this.txt_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(218, 21);
            this.txt_product.TabIndex = 36;
            // 
            // lbl_profit
            // 
            this.lbl_profit.AutoSize = true;
            this.lbl_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profit.Location = new System.Drawing.Point(88, 195);
            this.lbl_profit.Name = "lbl_profit";
            this.lbl_profit.Size = new System.Drawing.Size(52, 15);
            this.lbl_profit.TabIndex = 35;
            this.lbl_profit.Text = "Profit %:";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(88, 161);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(54, 15);
            this.lbl_qty.TabIndex = 34;
            this.lbl_qty.Text = "Quantity:";
            // 
            // lbl_costprice
            // 
            this.lbl_costprice.AutoSize = true;
            this.lbl_costprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costprice.Location = new System.Drawing.Point(88, 131);
            this.lbl_costprice.Name = "lbl_costprice";
            this.lbl_costprice.Size = new System.Drawing.Size(65, 15);
            this.lbl_costprice.TabIndex = 33;
            this.lbl_costprice.Text = "Cost Price:";
            // 
            // lbl_prodname
            // 
            this.lbl_prodname.AutoSize = true;
            this.lbl_prodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodname.Location = new System.Drawing.Point(88, 101);
            this.lbl_prodname.Name = "lbl_prodname";
            this.lbl_prodname.Size = new System.Drawing.Size(89, 15);
            this.lbl_prodname.TabIndex = 32;
            this.lbl_prodname.Text = "Product Name:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(88, 77);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(58, 15);
            this.lbl_category.TabIndex = 31;
            this.lbl_category.Text = "Category:";
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(419, 13);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(115, 31);
            this.lbl_heading.TabIndex = 30;
            this.lbl_heading.Text = "Product";
            // 
            // btn_pro_back
            // 
            this.btn_pro_back.Location = new System.Drawing.Point(12, 12);
            this.btn_pro_back.Name = "btn_pro_back";
            this.btn_pro_back.Size = new System.Drawing.Size(32, 23);
            this.btn_pro_back.TabIndex = 60;
            this.btn_pro_back.Text = "<-";
            this.btn_pro_back.UseVisualStyleBackColor = true;
            this.btn_pro_back.Click += new System.EventHandler(this.btn_pro_back_Click);
            // 
            // btn_pro_next
            // 
            this.btn_pro_next.Location = new System.Drawing.Point(50, 12);
            this.btn_pro_next.Name = "btn_pro_next";
            this.btn_pro_next.Size = new System.Drawing.Size(32, 23);
            this.btn_pro_next.TabIndex = 61;
            this.btn_pro_next.Text = "->";
            this.btn_pro_next.UseVisualStyleBackColor = true;
            // 
            // form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1084, 536);
            this.Controls.Add(this.btn_pro_next);
            this.Controls.Add(this.btn_pro_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.cbo_subCategory);
            this.Controls.Add(this.txt_sgst);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_threshold);
            this.Controls.Add(this.txt_mrp);
            this.Controls.Add(this.txt_vendor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cgst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_profit);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_costprice);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.lbl_profit);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_costprice);
            this.Controls.Add(this.lbl_prodname);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_heading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.ComboBox cbo_subCategory;
        private System.Windows.Forms.TextBox txt_sgst;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_threshold;
        private System.Windows.Forms.TextBox txt_mrp;
        private System.Windows.Forms.TextBox txt_vendor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cgst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_profit;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_costprice;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label lbl_profit;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_costprice;
        private System.Windows.Forms.Label lbl_prodname;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Button btn_pro_back;
        private System.Windows.Forms.Button btn_pro_next;
    }
}