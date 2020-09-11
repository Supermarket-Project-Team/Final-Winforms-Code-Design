namespace Login_Form
{
    partial class form_Staff
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
            this.btn_staff_next = new System.Windows.Forms.Button();
            this.btn_staff_back = new System.Windows.Forms.Button();
            this.lbl_staff = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.lbl_jdate = new System.Windows.Forms.Label();
            this.lbl_staffname = new System.Windows.Forms.Label();
            this.txt_staff_name = new System.Windows.Forms.TextBox();
            this.dt_jdate = new System.Windows.Forms.DateTimePicker();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_staff_next
            // 
            this.btn_staff_next.Location = new System.Drawing.Point(44, 12);
            this.btn_staff_next.Name = "btn_staff_next";
            this.btn_staff_next.Size = new System.Drawing.Size(27, 23);
            this.btn_staff_next.TabIndex = 59;
            this.btn_staff_next.Text = "->";
            this.btn_staff_next.UseVisualStyleBackColor = true;
            // 
            // btn_staff_back
            // 
            this.btn_staff_back.Location = new System.Drawing.Point(11, 12);
            this.btn_staff_back.Name = "btn_staff_back";
            this.btn_staff_back.Size = new System.Drawing.Size(27, 23);
            this.btn_staff_back.TabIndex = 58;
            this.btn_staff_back.Text = "<-";
            this.btn_staff_back.UseVisualStyleBackColor = true;
            this.btn_staff_back.Click += new System.EventHandler(this.btn_staff_back_Click);
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_staff.Location = new System.Drawing.Point(341, 18);
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.Size = new System.Drawing.Size(65, 29);
            this.lbl_staff.TabIndex = 57;
            this.lbl_staff.Text = "Staff";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(719, 76);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 27);
            this.btn_delete.TabIndex = 56;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(635, 77);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(56, 26);
            this.btn_edit.TabIndex = 55;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(544, 77);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 26);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salary.Location = new System.Drawing.Point(80, 177);
            this.lbl_salary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(50, 16);
            this.lbl_salary.TabIndex = 62;
            this.lbl_salary.Text = "Salary:";
            // 
            // lbl_jdate
            // 
            this.lbl_jdate.AutoSize = true;
            this.lbl_jdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jdate.Location = new System.Drawing.Point(80, 141);
            this.lbl_jdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_jdate.Name = "lbl_jdate";
            this.lbl_jdate.Size = new System.Drawing.Size(86, 16);
            this.lbl_jdate.TabIndex = 61;
            this.lbl_jdate.Text = "Joining Date:";
            // 
            // lbl_staffname
            // 
            this.lbl_staffname.AutoSize = true;
            this.lbl_staffname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffname.Location = new System.Drawing.Point(80, 112);
            this.lbl_staffname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_staffname.Name = "lbl_staffname";
            this.lbl_staffname.Size = new System.Drawing.Size(77, 16);
            this.lbl_staffname.TabIndex = 60;
            this.lbl_staffname.Text = "Staff Name:";
            // 
            // txt_staff_name
            // 
            this.txt_staff_name.Location = new System.Drawing.Point(189, 108);
            this.txt_staff_name.Name = "txt_staff_name";
            this.txt_staff_name.Size = new System.Drawing.Size(128, 20);
            this.txt_staff_name.TabIndex = 63;
            // 
            // dt_jdate
            // 
            this.dt_jdate.Location = new System.Drawing.Point(189, 141);
            this.dt_jdate.Name = "dt_jdate";
            this.dt_jdate.Size = new System.Drawing.Size(128, 20);
            this.dt_jdate.TabIndex = 64;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(189, 176);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(128, 20);
            this.txt_salary.TabIndex = 65;
            // 
            // dgv_staff
            // 
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(64, 248);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.Size = new System.Drawing.Size(711, 243);
            this.dgv_staff.TabIndex = 66;
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            // 
            // form_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 536);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.dt_jdate);
            this.Controls.Add(this.txt_staff_name);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.lbl_jdate);
            this.Controls.Add(this.lbl_staffname);
            this.Controls.Add(this.btn_staff_next);
            this.Controls.Add(this.btn_staff_back);
            this.Controls.Add(this.lbl_staff);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Name = "form_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_staff_next;
        private System.Windows.Forms.Button btn_staff_back;
        private System.Windows.Forms.Label lbl_staff;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.Label lbl_jdate;
        private System.Windows.Forms.Label lbl_staffname;
        private System.Windows.Forms.TextBox txt_staff_name;
        private System.Windows.Forms.DateTimePicker dt_jdate;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.DataGridView dgv_staff;
    }
}