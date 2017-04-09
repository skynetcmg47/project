namespace sellingWooden
{
    partial class frmCustomer_Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_frmCustomer_Edit_CustomerID = new System.Windows.Forms.TextBox();
            this.txt_frmCustomer_Edit_Address = new System.Windows.Forms.TextBox();
            this.txt_frmCustomer_Edit_Note = new System.Windows.Forms.TextBox();
            this.txt_frmCustomer_Edit_TEL = new System.Windows.Forms.TextBox();
            this.txt_frmCustomer_Edit_NOC = new System.Windows.Forms.TextBox();
            this.dtm_frmCustomer_Edit_DOB = new System.Windows.Forms.DateTimePicker();
            this.cbo_frmCustomer_Edit_Sex = new System.Windows.Forms.ComboBox();
            this.but_fmrCustomer_Edit_Cancel = new System.Windows.Forms.Button();
            this.but_frmCustomer_Edit_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi Chú";
            // 
            // txt_frmCustomer_Edit_CustomerID
            // 
            this.txt_frmCustomer_Edit_CustomerID.Location = new System.Drawing.Point(140, 57);
            this.txt_frmCustomer_Edit_CustomerID.Name = "txt_frmCustomer_Edit_CustomerID";
            this.txt_frmCustomer_Edit_CustomerID.ReadOnly = true;
            this.txt_frmCustomer_Edit_CustomerID.Size = new System.Drawing.Size(161, 20);
            this.txt_frmCustomer_Edit_CustomerID.TabIndex = 7;
            // 
            // txt_frmCustomer_Edit_Address
            // 
            this.txt_frmCustomer_Edit_Address.Location = new System.Drawing.Point(416, 91);
            this.txt_frmCustomer_Edit_Address.MaxLength = 50;
            this.txt_frmCustomer_Edit_Address.Name = "txt_frmCustomer_Edit_Address";
            this.txt_frmCustomer_Edit_Address.Size = new System.Drawing.Size(133, 20);
            this.txt_frmCustomer_Edit_Address.TabIndex = 8;
            // 
            // txt_frmCustomer_Edit_Note
            // 
            this.txt_frmCustomer_Edit_Note.Location = new System.Drawing.Point(416, 131);
            this.txt_frmCustomer_Edit_Note.MaxLength = 255;
            this.txt_frmCustomer_Edit_Note.Multiline = true;
            this.txt_frmCustomer_Edit_Note.Name = "txt_frmCustomer_Edit_Note";
            this.txt_frmCustomer_Edit_Note.Size = new System.Drawing.Size(133, 57);
            this.txt_frmCustomer_Edit_Note.TabIndex = 9;
            // 
            // txt_frmCustomer_Edit_TEL
            // 
            this.txt_frmCustomer_Edit_TEL.Location = new System.Drawing.Point(416, 57);
            this.txt_frmCustomer_Edit_TEL.MaxLength = 11;
            this.txt_frmCustomer_Edit_TEL.Name = "txt_frmCustomer_Edit_TEL";
            this.txt_frmCustomer_Edit_TEL.Size = new System.Drawing.Size(133, 20);
            this.txt_frmCustomer_Edit_TEL.TabIndex = 10;
            this.txt_frmCustomer_Edit_TEL.TextChanged += new System.EventHandler(this.txt_frmCustomer_Edit_TEL_TextChanged);
            this.txt_frmCustomer_Edit_TEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_frmCustomer_Edit_TEL_KeyPress);
            // 
            // txt_frmCustomer_Edit_NOC
            // 
            this.txt_frmCustomer_Edit_NOC.Location = new System.Drawing.Point(140, 91);
            this.txt_frmCustomer_Edit_NOC.MaxLength = 40;
            this.txt_frmCustomer_Edit_NOC.Name = "txt_frmCustomer_Edit_NOC";
            this.txt_frmCustomer_Edit_NOC.Size = new System.Drawing.Size(161, 20);
            this.txt_frmCustomer_Edit_NOC.TabIndex = 11;
            // 
            // dtm_frmCustomer_Edit_DOB
            // 
            this.dtm_frmCustomer_Edit_DOB.Location = new System.Drawing.Point(140, 128);
            this.dtm_frmCustomer_Edit_DOB.Name = "dtm_frmCustomer_Edit_DOB";
            this.dtm_frmCustomer_Edit_DOB.Size = new System.Drawing.Size(184, 20);
            this.dtm_frmCustomer_Edit_DOB.TabIndex = 12;
            // 
            // cbo_frmCustomer_Edit_Sex
            // 
            this.cbo_frmCustomer_Edit_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_frmCustomer_Edit_Sex.FormattingEnabled = true;
            this.cbo_frmCustomer_Edit_Sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_frmCustomer_Edit_Sex.Location = new System.Drawing.Point(140, 167);
            this.cbo_frmCustomer_Edit_Sex.Name = "cbo_frmCustomer_Edit_Sex";
            this.cbo_frmCustomer_Edit_Sex.Size = new System.Drawing.Size(110, 21);
            this.cbo_frmCustomer_Edit_Sex.TabIndex = 13;
            // 
            // but_fmrCustomer_Edit_Cancel
            // 
            this.but_fmrCustomer_Edit_Cancel.Location = new System.Drawing.Point(392, 233);
            this.but_fmrCustomer_Edit_Cancel.Name = "but_fmrCustomer_Edit_Cancel";
            this.but_fmrCustomer_Edit_Cancel.Size = new System.Drawing.Size(85, 33);
            this.but_fmrCustomer_Edit_Cancel.TabIndex = 14;
            this.but_fmrCustomer_Edit_Cancel.Text = "Huỷ";
            this.but_fmrCustomer_Edit_Cancel.UseVisualStyleBackColor = true;
            this.but_fmrCustomer_Edit_Cancel.Click += new System.EventHandler(this.but_fmrCustomer_Edit_Cancel_Click);
            // 
            // but_frmCustomer_Edit_OK
            // 
            this.but_frmCustomer_Edit_OK.Location = new System.Drawing.Point(165, 233);
            this.but_frmCustomer_Edit_OK.Name = "but_frmCustomer_Edit_OK";
            this.but_frmCustomer_Edit_OK.Size = new System.Drawing.Size(85, 33);
            this.but_frmCustomer_Edit_OK.TabIndex = 15;
            this.but_frmCustomer_Edit_OK.Text = "Sửa";
            this.but_frmCustomer_Edit_OK.UseVisualStyleBackColor = true;
            this.but_frmCustomer_Edit_OK.Click += new System.EventHandler(this.but_frmCustomer_Edit_OK_Click);
            // 
            // frmCustomer_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 292);
            this.Controls.Add(this.but_frmCustomer_Edit_OK);
            this.Controls.Add(this.but_fmrCustomer_Edit_Cancel);
            this.Controls.Add(this.cbo_frmCustomer_Edit_Sex);
            this.Controls.Add(this.dtm_frmCustomer_Edit_DOB);
            this.Controls.Add(this.txt_frmCustomer_Edit_NOC);
            this.Controls.Add(this.txt_frmCustomer_Edit_TEL);
            this.Controls.Add(this.txt_frmCustomer_Edit_Note);
            this.Controls.Add(this.txt_frmCustomer_Edit_Address);
            this.Controls.Add(this.txt_frmCustomer_Edit_CustomerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer_Edit";
            this.Text = "Sửa thông tin khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_frmCustomer_Edit_CustomerID;
        private System.Windows.Forms.TextBox txt_frmCustomer_Edit_Address;
        private System.Windows.Forms.TextBox txt_frmCustomer_Edit_Note;
        private System.Windows.Forms.TextBox txt_frmCustomer_Edit_TEL;
        private System.Windows.Forms.TextBox txt_frmCustomer_Edit_NOC;
        private System.Windows.Forms.DateTimePicker dtm_frmCustomer_Edit_DOB;
        private System.Windows.Forms.ComboBox cbo_frmCustomer_Edit_Sex;
        private System.Windows.Forms.Button but_fmrCustomer_Edit_Cancel;
        private System.Windows.Forms.Button but_frmCustomer_Edit_OK;
    }
}