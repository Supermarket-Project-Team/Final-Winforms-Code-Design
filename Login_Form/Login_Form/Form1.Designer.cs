﻿namespace Login_Form
{
    partial class form_login
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
            this.Login_panel = new System.Windows.Forms.Panel();
            this.lbl_username_error = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.Login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_panel
            // 
            this.Login_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_panel.Controls.Add(this.lbl_username_error);
            this.Login_panel.Controls.Add(this.btn_Login);
            this.Login_panel.Controls.Add(this.btn_exit);
            this.Login_panel.Controls.Add(this.txt_password);
            this.Login_panel.Controls.Add(this.txt_username);
            this.Login_panel.Controls.Add(this.lbl_password);
            this.Login_panel.Controls.Add(this.lbl_username);
            this.Login_panel.Controls.Add(this.lbl_login);
            this.Login_panel.Location = new System.Drawing.Point(12, 12);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(385, 260);
            this.Login_panel.TabIndex = 0;
            // 
            // lbl_username_error
            // 
            this.lbl_username_error.AutoSize = true;
            this.lbl_username_error.Location = new System.Drawing.Point(158, 104);
            this.lbl_username_error.Name = "lbl_username_error";
            this.lbl_username_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_username_error.TabIndex = 7;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Login.Location = new System.Drawing.Point(261, 177);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_exit.Location = new System.Drawing.Point(144, 177);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(144, 119);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(192, 20);
            this.txt_password.TabIndex = 4;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(144, 81);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(192, 20);
            this.txt_username.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(43, 121);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(79, 18);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(41, 81);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 18);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_login.Location = new System.Drawing.Point(156, 18);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(70, 25);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(410, 283);
            this.Controls.Add(this.Login_panel);
            this.Name = "form_login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_username_error;
    }
}

