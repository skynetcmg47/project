namespace sellingWooden
{
    partial class addCustomer
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
            this.txt_customerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_sex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.RichTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_customerID
            // 
            this.txt_customerID.Location = new System.Drawing.Point(114, 35);
            this.txt_customerID.MaxLength = 6;
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.ReadOnly = true;
            this.txt_customerID.Size = new System.Drawing.Size(127, 20);
            this.txt_customerID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(114, 70);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(127, 20);
            this.txt_CustomerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Sinh";
            // 
            // dtp_dateOfBirth
            // 
            this.dtp_dateOfBirth.Location = new System.Drawing.Point(114, 105);
            this.dtp_dateOfBirth.Name = "dtp_dateOfBirth";
            this.dtp_dateOfBirth.Size = new System.Drawing.Size(127, 20);
            this.dtp_dateOfBirth.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính";
            // 
            // cbb_sex
            // 
            this.cbb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sex.FormattingEnabled = true;
            this.cbb_sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_sex.Location = new System.Drawing.Point(114, 139);
            this.cbb_sex.Name = "cbb_sex";
            this.cbb_sex.Size = new System.Drawing.Size(127, 21);
            this.cbb_sex.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(396, 69);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(127, 20);
            this.txt_phoneNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Địa chỉ";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(396, 34);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(127, 20);
            this.txt_Address.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ghi chú";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(396, 112);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(127, 48);
            this.txt_Note.TabIndex = 15;
            this.txt_Note.Text = "";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(114, 201);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(99, 34);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(351, 201);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 34);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 261);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.cbb_sex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_dateOfBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_customerID);
            this.Name = "addCustomer";
            this.Text = "Thêm Khách Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_customerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_dateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_sex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_Note;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
    }
}