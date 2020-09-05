namespace Login_Form
{
    partial class Billing
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
            this.lbl_productdetails = new System.Windows.Forms.Label();
            this.lbl_customerdetails = new System.Windows.Forms.Label();
            this.cb_paymode = new System.Windows.Forms.ComboBox();
            this.txt_totalamt = new System.Windows.Forms.TextBox();
            this.lbl_paymode = new System.Windows.Forms.Label();
            this.lbl_totalamt = new System.Windows.Forms.Label();
            this.dgv_productdetails = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_salesman = new System.Windows.Forms.ComboBox();
            this.txt_loyalty = new System.Windows.Forms.TextBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.txt_billdate = new System.Windows.Forms.TextBox();
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.lbl_salesman = new System.Windows.Forms.Label();
            this.lbl_loyalty = new System.Windows.Forms.Label();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.lbl_cphone = new System.Windows.Forms.Label();
            this.lbl_cname = new System.Windows.Forms.Label();
            this.lbl_billdate = new System.Windows.Forms.Label();
            this.lbl_billno = new System.Windows.Forms.Label();
            this.lbl_billGenerate = new System.Windows.Forms.Label();
            this.btn_bill_print = new System.Windows.Forms.Button();
            this.btn_bill_cancel = new System.Windows.Forms.Button();
            this.btn_bill_back = new System.Windows.Forms.Button();
            this.btn_bill_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_productdetails
            // 
            this.lbl_productdetails.AutoSize = true;
            this.lbl_productdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productdetails.Location = new System.Drawing.Point(293, 127);
            this.lbl_productdetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_productdetails.Name = "lbl_productdetails";
            this.lbl_productdetails.Size = new System.Drawing.Size(151, 20);
            this.lbl_productdetails.TabIndex = 48;
            this.lbl_productdetails.Text = "Products Details :";
            this.lbl_productdetails.Click += new System.EventHandler(this.lbl_productdetails_Click);
            // 
            // lbl_customerdetails
            // 
            this.lbl_customerdetails.AutoSize = true;
            this.lbl_customerdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerdetails.Location = new System.Drawing.Point(47, 127);
            this.lbl_customerdetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customerdetails.Name = "lbl_customerdetails";
            this.lbl_customerdetails.Size = new System.Drawing.Size(157, 20);
            this.lbl_customerdetails.TabIndex = 47;
            this.lbl_customerdetails.Text = "Customer Details :";
            // 
            // cb_paymode
            // 
            this.cb_paymode.FormattingEnabled = true;
            this.cb_paymode.Location = new System.Drawing.Point(626, 441);
            this.cb_paymode.Margin = new System.Windows.Forms.Padding(2);
            this.cb_paymode.Name = "cb_paymode";
            this.cb_paymode.Size = new System.Drawing.Size(132, 21);
            this.cb_paymode.TabIndex = 46;
            // 
            // txt_totalamt
            // 
            this.txt_totalamt.Location = new System.Drawing.Point(626, 400);
            this.txt_totalamt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_totalamt.Name = "txt_totalamt";
            this.txt_totalamt.Size = new System.Drawing.Size(132, 20);
            this.txt_totalamt.TabIndex = 45;
            // 
            // lbl_paymode
            // 
            this.lbl_paymode.AutoSize = true;
            this.lbl_paymode.Location = new System.Drawing.Point(520, 441);
            this.lbl_paymode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_paymode.Name = "lbl_paymode";
            this.lbl_paymode.Size = new System.Drawing.Size(81, 13);
            this.lbl_paymode.TabIndex = 44;
            this.lbl_paymode.Text = "Payment Mode:";
            // 
            // lbl_totalamt
            // 
            this.lbl_totalamt.AutoSize = true;
            this.lbl_totalamt.Location = new System.Drawing.Point(520, 407);
            this.lbl_totalamt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totalamt.Name = "lbl_totalamt";
            this.lbl_totalamt.Size = new System.Drawing.Size(73, 13);
            this.lbl_totalamt.TabIndex = 43;
            this.lbl_totalamt.Text = "Total Amount:";
            // 
            // dgv_productdetails
            // 
            this.dgv_productdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productdetails.Location = new System.Drawing.Point(285, 162);
            this.dgv_productdetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_productdetails.Name = "dgv_productdetails";
            this.dgv_productdetails.RowHeadersWidth = 51;
            this.dgv_productdetails.RowTemplate.Height = 24;
            this.dgv_productdetails.Size = new System.Drawing.Size(539, 234);
            this.dgv_productdetails.TabIndex = 42;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(720, 76);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 27);
            this.btn_delete.TabIndex = 41;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(636, 77);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(56, 26);
            this.btn_edit.TabIndex = 40;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(545, 77);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 26);
            this.btn_save.TabIndex = 39;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // cb_salesman
            // 
            this.cb_salesman.FormattingEnabled = true;
            this.cb_salesman.Location = new System.Drawing.Point(137, 296);
            this.cb_salesman.Margin = new System.Windows.Forms.Padding(2);
            this.cb_salesman.Name = "cb_salesman";
            this.cb_salesman.Size = new System.Drawing.Size(123, 21);
            this.cb_salesman.TabIndex = 38;
            // 
            // txt_loyalty
            // 
            this.txt_loyalty.Location = new System.Drawing.Point(137, 261);
            this.txt_loyalty.Margin = new System.Windows.Forms.Padding(2);
            this.txt_loyalty.Name = "txt_loyalty";
            this.txt_loyalty.Size = new System.Drawing.Size(123, 20);
            this.txt_loyalty.TabIndex = 37;
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(137, 224);
            this.txt_remark.Margin = new System.Windows.Forms.Padding(2);
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(123, 20);
            this.txt_remark.TabIndex = 36;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(137, 191);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(123, 20);
            this.txt_phone.TabIndex = 35;
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(137, 162);
            this.txt_cname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(123, 20);
            this.txt_cname.TabIndex = 34;
            // 
            // txt_billdate
            // 
            this.txt_billdate.Location = new System.Drawing.Point(264, 73);
            this.txt_billdate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_billdate.Name = "txt_billdate";
            this.txt_billdate.Size = new System.Drawing.Size(76, 20);
            this.txt_billdate.TabIndex = 33;
            // 
            // txt_billno
            // 
            this.txt_billno.Location = new System.Drawing.Point(99, 73);
            this.txt_billno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.Size = new System.Drawing.Size(76, 20);
            this.txt_billno.TabIndex = 32;
            // 
            // lbl_salesman
            // 
            this.lbl_salesman.AutoSize = true;
            this.lbl_salesman.Location = new System.Drawing.Point(48, 299);
            this.lbl_salesman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_salesman.Name = "lbl_salesman";
            this.lbl_salesman.Size = new System.Drawing.Size(56, 13);
            this.lbl_salesman.TabIndex = 31;
            this.lbl_salesman.Text = "Salesman:";
            // 
            // lbl_loyalty
            // 
            this.lbl_loyalty.AutoSize = true;
            this.lbl_loyalty.Location = new System.Drawing.Point(48, 264);
            this.lbl_loyalty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loyalty.Name = "lbl_loyalty";
            this.lbl_loyalty.Size = new System.Drawing.Size(75, 13);
            this.lbl_loyalty.TabIndex = 30;
            this.lbl_loyalty.Text = "Loyalty Points:";
            // 
            // lbl_remark
            // 
            this.lbl_remark.AutoSize = true;
            this.lbl_remark.Location = new System.Drawing.Point(48, 227);
            this.lbl_remark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(47, 13);
            this.lbl_remark.TabIndex = 29;
            this.lbl_remark.Text = "Remark:";
            // 
            // lbl_cphone
            // 
            this.lbl_cphone.AutoSize = true;
            this.lbl_cphone.Location = new System.Drawing.Point(48, 191);
            this.lbl_cphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cphone.Name = "lbl_cphone";
            this.lbl_cphone.Size = new System.Drawing.Size(81, 13);
            this.lbl_cphone.TabIndex = 28;
            this.lbl_cphone.Text = "Phone Number:";
            // 
            // lbl_cname
            // 
            this.lbl_cname.AutoSize = true;
            this.lbl_cname.Location = new System.Drawing.Point(48, 162);
            this.lbl_cname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cname.Name = "lbl_cname";
            this.lbl_cname.Size = new System.Drawing.Size(85, 13);
            this.lbl_cname.TabIndex = 27;
            this.lbl_cname.Text = "Customer Name:";
            // 
            // lbl_billdate
            // 
            this.lbl_billdate.AutoSize = true;
            this.lbl_billdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billdate.Location = new System.Drawing.Point(199, 74);
            this.lbl_billdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_billdate.Name = "lbl_billdate";
            this.lbl_billdate.Size = new System.Drawing.Size(61, 16);
            this.lbl_billdate.TabIndex = 26;
            this.lbl_billdate.Text = "Bill Date:";
            // 
            // lbl_billno
            // 
            this.lbl_billno.AutoSize = true;
            this.lbl_billno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billno.Location = new System.Drawing.Point(48, 76);
            this.lbl_billno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_billno.Name = "lbl_billno";
            this.lbl_billno.Size = new System.Drawing.Size(50, 16);
            this.lbl_billno.TabIndex = 25;
            this.lbl_billno.Text = "Bill No:";
            // 
            // lbl_billGenerate
            // 
            this.lbl_billGenerate.AutoSize = true;
            this.lbl_billGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_billGenerate.Location = new System.Drawing.Point(342, 18);
            this.lbl_billGenerate.Name = "lbl_billGenerate";
            this.lbl_billGenerate.Size = new System.Drawing.Size(130, 24);
            this.lbl_billGenerate.TabIndex = 49;
            this.lbl_billGenerate.Text = "Bill Generate";
            // 
            // btn_bill_print
            // 
            this.btn_bill_print.Location = new System.Drawing.Point(685, 475);
            this.btn_bill_print.Name = "btn_bill_print";
            this.btn_bill_print.Size = new System.Drawing.Size(75, 23);
            this.btn_bill_print.TabIndex = 50;
            this.btn_bill_print.Text = "Print";
            this.btn_bill_print.UseVisualStyleBackColor = true;
            // 
            // btn_bill_cancel
            // 
            this.btn_bill_cancel.Location = new System.Drawing.Point(603, 475);
            this.btn_bill_cancel.Name = "btn_bill_cancel";
            this.btn_bill_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_bill_cancel.TabIndex = 51;
            this.btn_bill_cancel.Text = "Cancel";
            this.btn_bill_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_bill_back
            // 
            this.btn_bill_back.Location = new System.Drawing.Point(12, 12);
            this.btn_bill_back.Name = "btn_bill_back";
            this.btn_bill_back.Size = new System.Drawing.Size(27, 23);
            this.btn_bill_back.TabIndex = 52;
            this.btn_bill_back.Text = "<-";
            this.btn_bill_back.UseVisualStyleBackColor = true;
            // 
            // btn_bill_next
            // 
            this.btn_bill_next.Location = new System.Drawing.Point(45, 12);
            this.btn_bill_next.Name = "btn_bill_next";
            this.btn_bill_next.Size = new System.Drawing.Size(27, 23);
            this.btn_bill_next.TabIndex = 53;
            this.btn_bill_next.Text = "->";
            this.btn_bill_next.UseVisualStyleBackColor = true;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.btn_bill_next);
            this.Controls.Add(this.btn_bill_back);
            this.Controls.Add(this.btn_bill_cancel);
            this.Controls.Add(this.btn_bill_print);
            this.Controls.Add(this.lbl_billGenerate);
            this.Controls.Add(this.lbl_productdetails);
            this.Controls.Add(this.lbl_customerdetails);
            this.Controls.Add(this.cb_paymode);
            this.Controls.Add(this.txt_totalamt);
            this.Controls.Add(this.lbl_paymode);
            this.Controls.Add(this.lbl_totalamt);
            this.Controls.Add(this.dgv_productdetails);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_salesman);
            this.Controls.Add(this.txt_loyalty);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.txt_billdate);
            this.Controls.Add(this.txt_billno);
            this.Controls.Add(this.lbl_salesman);
            this.Controls.Add(this.lbl_loyalty);
            this.Controls.Add(this.lbl_remark);
            this.Controls.Add(this.lbl_cphone);
            this.Controls.Add(this.lbl_cname);
            this.Controls.Add(this.lbl_billdate);
            this.Controls.Add(this.lbl_billno);
            this.Name = "Billing";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_productdetails;
        private System.Windows.Forms.Label lbl_customerdetails;
        private System.Windows.Forms.ComboBox cb_paymode;
        private System.Windows.Forms.TextBox txt_totalamt;
        private System.Windows.Forms.Label lbl_paymode;
        private System.Windows.Forms.Label lbl_totalamt;
        private System.Windows.Forms.DataGridView dgv_productdetails;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cb_salesman;
        private System.Windows.Forms.TextBox txt_loyalty;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.TextBox txt_billdate;
        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.Label lbl_salesman;
        private System.Windows.Forms.Label lbl_loyalty;
        private System.Windows.Forms.Label lbl_remark;
        private System.Windows.Forms.Label lbl_cphone;
        private System.Windows.Forms.Label lbl_cname;
        private System.Windows.Forms.Label lbl_billdate;
        private System.Windows.Forms.Label lbl_billno;
        private System.Windows.Forms.Label lbl_billGenerate;
        private System.Windows.Forms.Button btn_bill_print;
        private System.Windows.Forms.Button btn_bill_cancel;
        private System.Windows.Forms.Button btn_bill_back;
        private System.Windows.Forms.Button btn_bill_next;
    }
}