namespace Login_Form
{
    partial class form_vendor
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
            this.btn_user_next = new System.Windows.Forms.Button();
            this.btn_vendor_back = new System.Windows.Forms.Button();
            this.dgv_vendor_details = new System.Windows.Forms.DataGridView();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_name_user = new System.Windows.Forms.TextBox();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_phone_vendor = new System.Windows.Forms.Label();
            this.lbl_name_vendor = new System.Windows.Forms.Label();
            this.lbl_vendordetails = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor_details)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_user_next
            // 
            this.btn_user_next.Location = new System.Drawing.Point(68, 19);
            this.btn_user_next.Name = "btn_user_next";
            this.btn_user_next.Size = new System.Drawing.Size(31, 23);
            this.btn_user_next.TabIndex = 79;
            this.btn_user_next.Text = "->";
            this.btn_user_next.UseVisualStyleBackColor = true;
            // 
            // btn_vendor_back
            // 
            this.btn_vendor_back.Location = new System.Drawing.Point(31, 19);
            this.btn_vendor_back.Name = "btn_vendor_back";
            this.btn_vendor_back.Size = new System.Drawing.Size(31, 23);
            this.btn_vendor_back.TabIndex = 78;
            this.btn_vendor_back.Text = "<-";
            this.btn_vendor_back.UseVisualStyleBackColor = true;
            this.btn_vendor_back.Click += new System.EventHandler(this.btn_vendor_back_Click);
            // 
            // dgv_vendor_details
            // 
            this.dgv_vendor_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendor_details.Location = new System.Drawing.Point(53, 284);
            this.dgv_vendor_details.Name = "dgv_vendor_details";
            this.dgv_vendor_details.Size = new System.Drawing.Size(787, 198);
            this.dgv_vendor_details.TabIndex = 77;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(266, 180);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(123, 20);
            this.txt_password.TabIndex = 76;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(266, 143);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(123, 20);
            this.txt_username.TabIndex = 75;
            // 
            // txt_name_user
            // 
            this.txt_name_user.Location = new System.Drawing.Point(266, 110);
            this.txt_name_user.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name_user.Name = "txt_name_user";
            this.txt_name_user.Size = new System.Drawing.Size(123, 20);
            this.txt_name_user.TabIndex = 74;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.Location = new System.Drawing.Point(154, 183);
            this.lbl_location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(69, 18);
            this.lbl_location.TabIndex = 73;
            this.lbl_location.Text = "Location:";
            // 
            // lbl_phone_vendor
            // 
            this.lbl_phone_vendor.AutoSize = true;
            this.lbl_phone_vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone_vendor.Location = new System.Drawing.Point(154, 146);
            this.lbl_phone_vendor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_phone_vendor.Name = "lbl_phone_vendor";
            this.lbl_phone_vendor.Size = new System.Drawing.Size(112, 18);
            this.lbl_phone_vendor.TabIndex = 72;
            this.lbl_phone_vendor.Text = "Phone Number:";
            // 
            // lbl_name_vendor
            // 
            this.lbl_name_vendor.AutoSize = true;
            this.lbl_name_vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_vendor.Location = new System.Drawing.Point(154, 110);
            this.lbl_name_vendor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name_vendor.Name = "lbl_name_vendor";
            this.lbl_name_vendor.Size = new System.Drawing.Size(52, 18);
            this.lbl_name_vendor.TabIndex = 71;
            this.lbl_name_vendor.Text = "Name:";
            // 
            // lbl_vendordetails
            // 
            this.lbl_vendordetails.AutoSize = true;
            this.lbl_vendordetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendordetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_vendordetails.Location = new System.Drawing.Point(372, 30);
            this.lbl_vendordetails.Name = "lbl_vendordetails";
            this.lbl_vendordetails.Size = new System.Drawing.Size(147, 24);
            this.lbl_vendordetails.TabIndex = 70;
            this.lbl_vendordetails.Text = "Vendor Details";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(754, 80);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 27);
            this.btn_delete.TabIndex = 69;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(663, 81);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(56, 26);
            this.btn_edit.TabIndex = 68;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(568, 81);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 26);
            this.btn_save.TabIndex = 67;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // form_vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1084, 536);
            this.Controls.Add(this.btn_user_next);
            this.Controls.Add(this.btn_vendor_back);
            this.Controls.Add(this.dgv_vendor_details);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_name_user);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_phone_vendor);
            this.Controls.Add(this.lbl_name_vendor);
            this.Controls.Add(this.lbl_vendordetails);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Name = "form_vendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vendor";
            this.Load += new System.EventHandler(this.form_vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_user_next;
        private System.Windows.Forms.Button btn_vendor_back;
        private System.Windows.Forms.DataGridView dgv_vendor_details;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_name_user;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_phone_vendor;
        private System.Windows.Forms.Label lbl_name_vendor;
        private System.Windows.Forms.Label lbl_vendordetails;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
    }
}