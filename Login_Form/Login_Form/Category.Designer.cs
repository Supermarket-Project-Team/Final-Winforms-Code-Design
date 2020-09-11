namespace Login_Form
{
    partial class Category
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
            this.btn_category_next = new System.Windows.Forms.Button();
            this.btn_category_back = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_category_name = new System.Windows.Forms.TextBox();
            this.lbl_category_name = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.link_SubCategory = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_category_next
            // 
            this.btn_category_next.Location = new System.Drawing.Point(43, 12);
            this.btn_category_next.Name = "btn_category_next";
            this.btn_category_next.Size = new System.Drawing.Size(27, 23);
            this.btn_category_next.TabIndex = 59;
            this.btn_category_next.Text = "->";
            this.btn_category_next.UseVisualStyleBackColor = true;
            // 
            // btn_category_back
            // 
            this.btn_category_back.Location = new System.Drawing.Point(10, 12);
            this.btn_category_back.Name = "btn_category_back";
            this.btn_category_back.Size = new System.Drawing.Size(27, 23);
            this.btn_category_back.TabIndex = 58;
            this.btn_category_back.Text = "<-";
            this.btn_category_back.UseVisualStyleBackColor = true;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_category.Location = new System.Drawing.Point(335, 12);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(118, 29);
            this.lbl_category.TabIndex = 57;
            this.lbl_category.Text = "Category";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(718, 76);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 27);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(634, 77);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(56, 26);
            this.btn_edit.TabIndex = 55;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(543, 77);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 26);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // txt_category_name
            // 
            this.txt_category_name.Location = new System.Drawing.Point(205, 129);
            this.txt_category_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_category_name.Name = "txt_category_name";
            this.txt_category_name.Size = new System.Drawing.Size(123, 20);
            this.txt_category_name.TabIndex = 61;
            // 
            // lbl_category_name
            // 
            this.lbl_category_name.AutoSize = true;
            this.lbl_category_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category_name.Location = new System.Drawing.Point(95, 130);
            this.lbl_category_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_category_name.Name = "lbl_category_name";
            this.lbl_category_name.Size = new System.Drawing.Size(106, 16);
            this.lbl_category_name.TabIndex = 60;
            this.lbl_category_name.Text = "Category Name:";
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(52, 184);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.Size = new System.Drawing.Size(713, 296);
            this.dgv_category.TabIndex = 62;
            // 
            // link_SubCategory
            // 
            this.link_SubCategory.AutoSize = true;
            this.link_SubCategory.Location = new System.Drawing.Point(635, 22);
            this.link_SubCategory.Name = "link_SubCategory";
            this.link_SubCategory.Size = new System.Drawing.Size(71, 13);
            this.link_SubCategory.TabIndex = 63;
            this.link_SubCategory.TabStop = true;
            this.link_SubCategory.Text = "Sub Category";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 536);
            this.Controls.Add(this.link_SubCategory);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.txt_category_name);
            this.Controls.Add(this.lbl_category_name);
            this.Controls.Add(this.btn_category_next);
            this.Controls.Add(this.btn_category_back);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_category_next;
        private System.Windows.Forms.Button btn_category_back;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_category_name;
        private System.Windows.Forms.Label lbl_category_name;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.LinkLabel link_SubCategory;
    }
}