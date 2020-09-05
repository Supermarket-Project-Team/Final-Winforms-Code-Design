namespace Login_Form
{
    partial class SubCategory
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
            this.lbl_subcategory = new System.Windows.Forms.Label();
            this.link_Category = new System.Windows.Forms.LinkLabel();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.txt_subcate_name = new System.Windows.Forms.TextBox();
            this.lbl_category_name = new System.Windows.Forms.Label();
            this.btn_subcate_next = new System.Windows.Forms.Button();
            this.btn_subcate_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_category_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_subcategory
            // 
            this.lbl_subcategory.AutoSize = true;
            this.lbl_subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subcategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_subcategory.Location = new System.Drawing.Point(334, 18);
            this.lbl_subcategory.Name = "lbl_subcategory";
            this.lbl_subcategory.Size = new System.Drawing.Size(171, 29);
            this.lbl_subcategory.TabIndex = 58;
            this.lbl_subcategory.Text = "Sub Category";
            // 
            // link_Category
            // 
            this.link_Category.AutoSize = true;
            this.link_Category.Location = new System.Drawing.Point(652, 36);
            this.link_Category.Name = "link_Category";
            this.link_Category.Size = new System.Drawing.Size(49, 13);
            this.link_Category.TabIndex = 73;
            this.link_Category.TabStop = true;
            this.link_Category.Text = "Category";
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(69, 198);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.Size = new System.Drawing.Size(713, 296);
            this.dgv_category.TabIndex = 72;
            // 
            // txt_subcate_name
            // 
            this.txt_subcate_name.Location = new System.Drawing.Point(259, 143);
            this.txt_subcate_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_subcate_name.Name = "txt_subcate_name";
            this.txt_subcate_name.Size = new System.Drawing.Size(123, 20);
            this.txt_subcate_name.TabIndex = 71;
            // 
            // lbl_category_name
            // 
            this.lbl_category_name.AutoSize = true;
            this.lbl_category_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category_name.Location = new System.Drawing.Point(112, 114);
            this.lbl_category_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_category_name.Name = "lbl_category_name";
            this.lbl_category_name.Size = new System.Drawing.Size(106, 16);
            this.lbl_category_name.TabIndex = 70;
            this.lbl_category_name.Text = "Category Name:";
            // 
            // btn_subcate_next
            // 
            this.btn_subcate_next.Location = new System.Drawing.Point(45, 12);
            this.btn_subcate_next.Name = "btn_subcate_next";
            this.btn_subcate_next.Size = new System.Drawing.Size(27, 23);
            this.btn_subcate_next.TabIndex = 69;
            this.btn_subcate_next.Text = "->";
            this.btn_subcate_next.UseVisualStyleBackColor = true;
            // 
            // btn_subcate_back
            // 
            this.btn_subcate_back.Location = new System.Drawing.Point(12, 12);
            this.btn_subcate_back.Name = "btn_subcate_back";
            this.btn_subcate_back.Size = new System.Drawing.Size(27, 23);
            this.btn_subcate_back.TabIndex = 68;
            this.btn_subcate_back.Text = "<-";
            this.btn_subcate_back.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(735, 90);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 27);
            this.btn_delete.TabIndex = 66;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(651, 91);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(56, 26);
            this.btn_edit.TabIndex = 65;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(560, 91);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 26);
            this.btn_save.TabIndex = 64;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Sub Category Name:";
            // 
            // cb_category_name
            // 
            this.cb_category_name.FormattingEnabled = true;
            this.cb_category_name.Location = new System.Drawing.Point(259, 108);
            this.cb_category_name.Name = "cb_category_name";
            this.cb_category_name.Size = new System.Drawing.Size(121, 21);
            this.cb_category_name.TabIndex = 75;
            // 
            // SubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 521);
            this.Controls.Add(this.cb_category_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_Category);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.txt_subcate_name);
            this.Controls.Add(this.lbl_category_name);
            this.Controls.Add(this.btn_subcate_next);
            this.Controls.Add(this.btn_subcate_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_subcategory);
            this.Name = "SubCategory";
            this.Text = "SubCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_subcategory;
        private System.Windows.Forms.LinkLabel link_Category;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.TextBox txt_subcate_name;
        private System.Windows.Forms.Label lbl_category_name;
        private System.Windows.Forms.Button btn_subcate_next;
        private System.Windows.Forms.Button btn_subcate_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_category_name;
    }
}