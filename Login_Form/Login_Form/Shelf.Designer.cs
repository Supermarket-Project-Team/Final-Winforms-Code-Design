namespace Login_Form
{
    partial class Shelf
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
            this.dgv_shelf = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_shelf_back = new System.Windows.Forms.Button();
            this.btn_shelf_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shelf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_shelf
            // 
            this.dgv_shelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_shelf.Location = new System.Drawing.Point(52, 148);
            this.dgv_shelf.Name = "dgv_shelf";
            this.dgv_shelf.Size = new System.Drawing.Size(690, 273);
            this.dgv_shelf.TabIndex = 9;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(661, 108);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(72, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.Location = new System.Drawing.Point(560, 108);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(72, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(457, 108);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shelf Allocation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_shelf_back
            // 
            this.btn_shelf_back.Location = new System.Drawing.Point(12, 12);
            this.btn_shelf_back.Name = "btn_shelf_back";
            this.btn_shelf_back.Size = new System.Drawing.Size(29, 23);
            this.btn_shelf_back.TabIndex = 10;
            this.btn_shelf_back.Text = "<-";
            this.btn_shelf_back.UseVisualStyleBackColor = true;
            // 
            // btn_shelf_next
            // 
            this.btn_shelf_next.Location = new System.Drawing.Point(52, 12);
            this.btn_shelf_next.Name = "btn_shelf_next";
            this.btn_shelf_next.Size = new System.Drawing.Size(29, 23);
            this.btn_shelf_next.TabIndex = 11;
            this.btn_shelf_next.Text = "->";
            this.btn_shelf_next.UseVisualStyleBackColor = true;
            // 
            // Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_shelf_next);
            this.Controls.Add(this.btn_shelf_back);
            this.Controls.Add(this.dgv_shelf);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Name = "Shelf";
            this.Text = "Shelf";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_shelf;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_shelf_back;
        private System.Windows.Forms.Button btn_shelf_next;
    }
}