namespace Login_Form
{
    partial class Customer
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
            this.lbl_customers = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_customers = new System.Windows.Forms.DataGridView();
            this.btn_cust_back = new System.Windows.Forms.Button();
            this.btn_cust_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_customers
            // 
            this.lbl_customers.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customers.Location = new System.Drawing.Point(359, 25);
            this.lbl_customers.Name = "lbl_customers";
            this.lbl_customers.Size = new System.Drawing.Size(131, 29);
            this.lbl_customers.TabIndex = 15;
            this.lbl_customers.Text = "Customers";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(741, 78);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(636, 78);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(527, 78);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // dgv_customers
            // 
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customers.Location = new System.Drawing.Point(99, 161);
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.Size = new System.Drawing.Size(690, 319);
            this.dgv_customers.TabIndex = 11;
            // 
            // btn_cust_back
            // 
            this.btn_cust_back.Location = new System.Drawing.Point(12, 12);
            this.btn_cust_back.Name = "btn_cust_back";
            this.btn_cust_back.Size = new System.Drawing.Size(27, 23);
            this.btn_cust_back.TabIndex = 16;
            this.btn_cust_back.Text = "<-";
            this.btn_cust_back.UseVisualStyleBackColor = true;
            // 
            // btn_cust_next
            // 
            this.btn_cust_next.Location = new System.Drawing.Point(45, 12);
            this.btn_cust_next.Name = "btn_cust_next";
            this.btn_cust_next.Size = new System.Drawing.Size(27, 23);
            this.btn_cust_next.TabIndex = 17;
            this.btn_cust_next.Text = "->";
            this.btn_cust_next.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 505);
            this.Controls.Add(this.btn_cust_next);
            this.Controls.Add(this.btn_cust_back);
            this.Controls.Add(this.lbl_customers);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_customers);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_customers;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_customers;
        private System.Windows.Forms.Button btn_cust_back;
        private System.Windows.Forms.Button btn_cust_next;
    }
}