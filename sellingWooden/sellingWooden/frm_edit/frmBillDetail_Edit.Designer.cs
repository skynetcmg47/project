namespace sellingWooden
{
    partial class frmBillDetail_Edit
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
            this.txt_frmBillDetail_Edit_Amount = new System.Windows.Forms.TextBox();
            this.cbo_frmBillDetail_Edit_EmployeeID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_frmBillDetail_Edit_Cancel = new System.Windows.Forms.Button();
            this.button2but_frmBillDetail_Edit_Ok = new System.Windows.Forms.Button();
            this.txt_frmBillDetail_Edit_BillID = new System.Windows.Forms.TextBox();
            this.txt_frmBillDetail_Edit_ProductID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_frmBillDetail_Edit_Amount
            // 
            this.txt_frmBillDetail_Edit_Amount.Location = new System.Drawing.Point(480, 36);
            this.txt_frmBillDetail_Edit_Amount.MaxLength = 6;
            this.txt_frmBillDetail_Edit_Amount.Name = "txt_frmBillDetail_Edit_Amount";
            this.txt_frmBillDetail_Edit_Amount.Size = new System.Drawing.Size(87, 20);
            this.txt_frmBillDetail_Edit_Amount.TabIndex = 23;
            this.txt_frmBillDetail_Edit_Amount.TextChanged += new System.EventHandler(this.txt_frmBillDetail_Edit_Amount_TextChanged);
            this.txt_frmBillDetail_Edit_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_frmBillDetail_Edit_Amount_KeyPress);
            // 
            // cbo_frmBillDetail_Edit_EmployeeID
            // 
            this.cbo_frmBillDetail_Edit_EmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_frmBillDetail_Edit_EmployeeID.FormattingEnabled = true;
            this.cbo_frmBillDetail_Edit_EmployeeID.Location = new System.Drawing.Point(480, 78);
            this.cbo_frmBillDetail_Edit_EmployeeID.Name = "cbo_frmBillDetail_Edit_EmployeeID";
            this.cbo_frmBillDetail_Edit_EmployeeID.Size = new System.Drawing.Size(121, 21);
            this.cbo_frmBillDetail_Edit_EmployeeID.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Số lượng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã sản phẩm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên nhân viên bán hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã hóa đơn :";
            // 
            // but_frmBillDetail_Edit_Cancel
            // 
            this.but_frmBillDetail_Edit_Cancel.Location = new System.Drawing.Point(391, 143);
            this.but_frmBillDetail_Edit_Cancel.Name = "but_frmBillDetail_Edit_Cancel";
            this.but_frmBillDetail_Edit_Cancel.Size = new System.Drawing.Size(93, 40);
            this.but_frmBillDetail_Edit_Cancel.TabIndex = 26;
            this.but_frmBillDetail_Edit_Cancel.Text = "Hủy";
            this.but_frmBillDetail_Edit_Cancel.UseVisualStyleBackColor = true;
            this.but_frmBillDetail_Edit_Cancel.Click += new System.EventHandler(this.but_frmBillDetail_Edit_Cancel_Click);
            // 
            // button2but_frmBillDetail_Edit_Ok
            // 
            this.button2but_frmBillDetail_Edit_Ok.Location = new System.Drawing.Point(204, 143);
            this.button2but_frmBillDetail_Edit_Ok.Name = "button2but_frmBillDetail_Edit_Ok";
            this.button2but_frmBillDetail_Edit_Ok.Size = new System.Drawing.Size(93, 40);
            this.button2but_frmBillDetail_Edit_Ok.TabIndex = 27;
            this.button2but_frmBillDetail_Edit_Ok.Text = "Sửa";
            this.button2but_frmBillDetail_Edit_Ok.UseVisualStyleBackColor = true;
            this.button2but_frmBillDetail_Edit_Ok.Click += new System.EventHandler(this.button2but_frmBillDetail_Edit_Ok_Click);
            // 
            // txt_frmBillDetail_Edit_BillID
            // 
            this.txt_frmBillDetail_Edit_BillID.Location = new System.Drawing.Point(204, 39);
            this.txt_frmBillDetail_Edit_BillID.MaxLength = 6;
            this.txt_frmBillDetail_Edit_BillID.Name = "txt_frmBillDetail_Edit_BillID";
            this.txt_frmBillDetail_Edit_BillID.ReadOnly = true;
            this.txt_frmBillDetail_Edit_BillID.Size = new System.Drawing.Size(121, 20);
            this.txt_frmBillDetail_Edit_BillID.TabIndex = 28;
            // 
            // txt_frmBillDetail_Edit_ProductID
            // 
            this.txt_frmBillDetail_Edit_ProductID.Location = new System.Drawing.Point(204, 78);
            this.txt_frmBillDetail_Edit_ProductID.MaxLength = 6;
            this.txt_frmBillDetail_Edit_ProductID.Name = "txt_frmBillDetail_Edit_ProductID";
            this.txt_frmBillDetail_Edit_ProductID.ReadOnly = true;
            this.txt_frmBillDetail_Edit_ProductID.Size = new System.Drawing.Size(121, 20);
            this.txt_frmBillDetail_Edit_ProductID.TabIndex = 29;
            // 
            // frmBillDetail_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 242);
            this.Controls.Add(this.txt_frmBillDetail_Edit_ProductID);
            this.Controls.Add(this.txt_frmBillDetail_Edit_BillID);
            this.Controls.Add(this.button2but_frmBillDetail_Edit_Ok);
            this.Controls.Add(this.but_frmBillDetail_Edit_Cancel);
            this.Controls.Add(this.txt_frmBillDetail_Edit_Amount);
            this.Controls.Add(this.cbo_frmBillDetail_Edit_EmployeeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBillDetail_Edit";
            this.Text = "Sửa Hóa Đơn Chi Tiết";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_frmBillDetail_Edit_Amount;
        private System.Windows.Forms.ComboBox cbo_frmBillDetail_Edit_EmployeeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_frmBillDetail_Edit_Cancel;
        private System.Windows.Forms.Button button2but_frmBillDetail_Edit_Ok;
        private System.Windows.Forms.TextBox txt_frmBillDetail_Edit_BillID;
        private System.Windows.Forms.TextBox txt_frmBillDetail_Edit_ProductID;
    }
}