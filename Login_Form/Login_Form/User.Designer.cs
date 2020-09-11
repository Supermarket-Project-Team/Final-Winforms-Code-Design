namespace Login_Form
{
    partial class form_User
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
            this.lbl_usercreation = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_name_user = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_name_user = new System.Windows.Forms.Label();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.lbl_userdetails = new System.Windows.Forms.Label();
            this.dgv_user_create = new System.Windows.Forms.DataGridView();
            this.cb_designation = new System.Windows.Forms.ComboBox();
            this.btn_user_back = new System.Windows.Forms.Button();
            this.btn_user_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_create)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_usercreation
            // 
            this.lbl_usercreation.AutoSize = true;
            this.lbl_usercreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usercreation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_usercreation.Location = new System.Drawing.Point(353, 23);
            this.lbl_usercreation.Name = "lbl_usercreation";
            this.lbl_usercreation.Size = new System.Drawing.Size(137, 24);
            this.lbl_usercreation.TabIndex = 53;
            this.lbl_usercreation.Text = "User Creation";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(735, 73);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 27);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(644, 74);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(56, 26);
            this.btn_edit.TabIndex = 51;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(549, 74);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 26);
            this.btn_save.TabIndex = 50;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(224, 173);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(123, 20);
            this.txt_password.TabIndex = 61;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(224, 136);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(123, 20);
            this.txt_username.TabIndex = 60;
            // 
            // txt_name_user
            // 
            this.txt_name_user.Location = new System.Drawing.Point(224, 103);
            this.txt_name_user.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name_user.Name = "txt_name_user";
            this.txt_name_user.Size = new System.Drawing.Size(123, 20);
            this.txt_name_user.TabIndex = 59;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(135, 176);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(75, 18);
            this.lbl_password.TabIndex = 57;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(135, 139);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 18);
            this.lbl_username.TabIndex = 56;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_name_user
            // 
            this.lbl_name_user.AutoSize = true;
            this.lbl_name_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_user.Location = new System.Drawing.Point(135, 103);
            this.lbl_name_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name_user.Name = "lbl_name_user";
            this.lbl_name_user.Size = new System.Drawing.Size(52, 18);
            this.lbl_name_user.TabIndex = 55;
            this.lbl_name_user.Text = "Name:";
            // 
            // lbl_designation
            // 
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_designation.Location = new System.Drawing.Point(135, 74);
            this.lbl_designation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(90, 18);
            this.lbl_designation.TabIndex = 54;
            this.lbl_designation.Text = "Designation:";
            // 
            // lbl_userdetails
            // 
            this.lbl_userdetails.AutoSize = true;
            this.lbl_userdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userdetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_userdetails.Location = new System.Drawing.Point(360, 240);
            this.lbl_userdetails.Name = "lbl_userdetails";
            this.lbl_userdetails.Size = new System.Drawing.Size(121, 24);
            this.lbl_userdetails.TabIndex = 62;
            this.lbl_userdetails.Text = "User Details";
            // 
            // dgv_user_create
            // 
            this.dgv_user_create.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_create.Location = new System.Drawing.Point(34, 277);
            this.dgv_user_create.Name = "dgv_user_create";
            this.dgv_user_create.Size = new System.Drawing.Size(787, 198);
            this.dgv_user_create.TabIndex = 63;
            // 
            // cb_designation
            // 
            this.cb_designation.FormattingEnabled = true;
            this.cb_designation.Location = new System.Drawing.Point(224, 70);
            this.cb_designation.Name = "cb_designation";
            this.cb_designation.Size = new System.Drawing.Size(121, 21);
            this.cb_designation.TabIndex = 64;
            // 
            // btn_user_back
            // 
            this.btn_user_back.Location = new System.Drawing.Point(12, 12);
            this.btn_user_back.Name = "btn_user_back";
            this.btn_user_back.Size = new System.Drawing.Size(31, 23);
            this.btn_user_back.TabIndex = 65;
            this.btn_user_back.Text = "<-";
            this.btn_user_back.UseVisualStyleBackColor = true;
            this.btn_user_back.Click += new System.EventHandler(this.btn_user_back_Click);
            // 
            // btn_user_next
            // 
            this.btn_user_next.Location = new System.Drawing.Point(49, 12);
            this.btn_user_next.Name = "btn_user_next";
            this.btn_user_next.Size = new System.Drawing.Size(31, 23);
            this.btn_user_next.TabIndex = 66;
            this.btn_user_next.Text = "->";
            this.btn_user_next.UseVisualStyleBackColor = true;
            // 
            // form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 536);
            this.Controls.Add(this.btn_user_next);
            this.Controls.Add(this.btn_user_back);
            this.Controls.Add(this.cb_designation);
            this.Controls.Add(this.dgv_user_create);
            this.Controls.Add(this.lbl_userdetails);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_name_user);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_name_user);
            this.Controls.Add(this.lbl_designation);
            this.Controls.Add(this.lbl_usercreation);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Name = "form_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.form_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_create)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usercreation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_name_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_name_user;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.Label lbl_userdetails;
        private System.Windows.Forms.DataGridView dgv_user_create;
        private System.Windows.Forms.ComboBox cb_designation;
        private System.Windows.Forms.Button btn_user_back;
        private System.Windows.Forms.Button btn_user_next;
    }
}