namespace Login_Form
{
    partial class Purchase
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
            this.lbl_orders = new System.Windows.Forms.Label();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.txt_order_date = new System.Windows.Forms.TextBox();
            this.txt_vname = new System.Windows.Forms.TextBox();
            this.txt_order_no = new System.Windows.Forms.TextBox();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.lbl_vendor_name = new System.Windows.Forms.Label();
            this.lbl_order_no = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_orders_back = new System.Windows.Forms.Button();
            this.btn_orders_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders.Location = new System.Drawing.Point(329, 24);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(192, 31);
            this.lbl_orders.TabIndex = 0;
            this.lbl_orders.Text = "Purchase Orders";
            // 
            // dgv_orders
            // 
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Location = new System.Drawing.Point(33, 216);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.Size = new System.Drawing.Size(787, 260);
            this.dgv_orders.TabIndex = 73;
            // 
            // txt_order_date
            // 
            this.txt_order_date.Location = new System.Drawing.Point(215, 156);
            this.txt_order_date.Margin = new System.Windows.Forms.Padding(2);
            this.txt_order_date.Name = "txt_order_date";
            this.txt_order_date.Size = new System.Drawing.Size(123, 20);
            this.txt_order_date.TabIndex = 72;
            // 
            // txt_vname
            // 
            this.txt_vname.Location = new System.Drawing.Point(215, 123);
            this.txt_vname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_vname.Name = "txt_vname";
            this.txt_vname.Size = new System.Drawing.Size(123, 20);
            this.txt_vname.TabIndex = 71;
            // 
            // txt_order_no
            // 
            this.txt_order_no.Location = new System.Drawing.Point(215, 94);
            this.txt_order_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_order_no.Name = "txt_order_no";
            this.txt_order_no.Size = new System.Drawing.Size(123, 20);
            this.txt_order_no.TabIndex = 70;
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.AutoSize = true;
            this.lbl_order_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.Location = new System.Drawing.Point(108, 159);
            this.lbl_order_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(85, 18);
            this.lbl_order_date.TabIndex = 69;
            this.lbl_order_date.Text = "Order Date:";
            // 
            // lbl_vendor_name
            // 
            this.lbl_vendor_name.AutoSize = true;
            this.lbl_vendor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor_name.Location = new System.Drawing.Point(108, 123);
            this.lbl_vendor_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_vendor_name.Name = "lbl_vendor_name";
            this.lbl_vendor_name.Size = new System.Drawing.Size(103, 18);
            this.lbl_vendor_name.TabIndex = 68;
            this.lbl_vendor_name.Text = "Vendor Name:";
            // 
            // lbl_order_no
            // 
            this.lbl_order_no.AutoSize = true;
            this.lbl_order_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_no.Location = new System.Drawing.Point(108, 94);
            this.lbl_order_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_order_no.Name = "lbl_order_no";
            this.lbl_order_no.Size = new System.Drawing.Size(74, 18);
            this.lbl_order_no.TabIndex = 67;
            this.lbl_order_no.Text = "Order No:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(726, 93);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 27);
            this.btn_delete.TabIndex = 66;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(635, 94);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(56, 26);
            this.btn_edit.TabIndex = 65;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(540, 94);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 26);
            this.btn_save.TabIndex = 64;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_orders_back
            // 
            this.btn_orders_back.Location = new System.Drawing.Point(12, 12);
            this.btn_orders_back.Name = "btn_orders_back";
            this.btn_orders_back.Size = new System.Drawing.Size(29, 23);
            this.btn_orders_back.TabIndex = 74;
            this.btn_orders_back.Text = "<-";
            this.btn_orders_back.UseVisualStyleBackColor = true;
            // 
            // btn_orders_next
            // 
            this.btn_orders_next.Location = new System.Drawing.Point(47, 12);
            this.btn_orders_next.Name = "btn_orders_next";
            this.btn_orders_next.Size = new System.Drawing.Size(29, 23);
            this.btn_orders_next.TabIndex = 75;
            this.btn_orders_next.Text = "->";
            this.btn_orders_next.UseVisualStyleBackColor = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 509);
            this.Controls.Add(this.btn_orders_next);
            this.Controls.Add(this.btn_orders_back);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.txt_order_date);
            this.Controls.Add(this.txt_vname);
            this.Controls.Add(this.txt_order_no);
            this.Controls.Add(this.lbl_order_date);
            this.Controls.Add(this.lbl_vendor_name);
            this.Controls.Add(this.lbl_order_no);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_orders);
            this.Name = "Purchase";
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orders;
        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.TextBox txt_order_date;
        private System.Windows.Forms.TextBox txt_vname;
        private System.Windows.Forms.TextBox txt_order_no;
        private System.Windows.Forms.Label lbl_order_date;
        private System.Windows.Forms.Label lbl_vendor_name;
        private System.Windows.Forms.Label lbl_order_no;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_orders_back;
        private System.Windows.Forms.Button btn_orders_next;
    }
}