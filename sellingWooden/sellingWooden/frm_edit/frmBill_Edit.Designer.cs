namespace sellingWooden
{
    partial class frmBill_Edit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_frmBill_Edit_CustomerID = new System.Windows.Forms.ComboBox();
            this.dtm_frmBill_Edit_DateSell = new System.Windows.Forms.DateTimePicker();
            this.txt_frmBill_Edit_Note = new System.Windows.Forms.TextBox();
            this.txt_frmBill_Edit_BillID = new System.Windows.Forms.TextBox();
            this.but_frmBill_Edit_Cancel = new System.Windows.Forms.Button();
            this.but_frmBill_Edit_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ghi chú :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày bán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khách hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Hóa Đơn :";
            // 
            // cbo_frmBill_Edit_CustomerID
            // 
            this.cbo_frmBill_Edit_CustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_frmBill_Edit_CustomerID.FormattingEnabled = true;
            this.cbo_frmBill_Edit_CustomerID.Location = new System.Drawing.Point(132, 87);
            this.cbo_frmBill_Edit_CustomerID.Name = "cbo_frmBill_Edit_CustomerID";
            this.cbo_frmBill_Edit_CustomerID.Size = new System.Drawing.Size(121, 21);
            this.cbo_frmBill_Edit_CustomerID.TabIndex = 12;
            // 
            // dtm_frmBill_Edit_DateSell
            // 
            this.dtm_frmBill_Edit_DateSell.Location = new System.Drawing.Point(416, 51);
            this.dtm_frmBill_Edit_DateSell.MinDate = new System.DateTime(1880, 1, 1, 0, 0, 0, 0);
            this.dtm_frmBill_Edit_DateSell.Name = "dtm_frmBill_Edit_DateSell";
            this.dtm_frmBill_Edit_DateSell.Size = new System.Drawing.Size(200, 20);
            this.dtm_frmBill_Edit_DateSell.TabIndex = 11;
            this.dtm_frmBill_Edit_DateSell.Value = new System.DateTime(2017, 4, 7, 0, 0, 0, 0);
            // 
            // txt_frmBill_Edit_Note
            // 
            this.txt_frmBill_Edit_Note.Location = new System.Drawing.Point(416, 84);
            this.txt_frmBill_Edit_Note.MaxLength = 255;
            this.txt_frmBill_Edit_Note.Multiline = true;
            this.txt_frmBill_Edit_Note.Name = "txt_frmBill_Edit_Note";
            this.txt_frmBill_Edit_Note.Size = new System.Drawing.Size(200, 53);
            this.txt_frmBill_Edit_Note.TabIndex = 10;
            // 
            // txt_frmBill_Edit_BillID
            // 
            this.txt_frmBill_Edit_BillID.Location = new System.Drawing.Point(132, 48);
            this.txt_frmBill_Edit_BillID.MaxLength = 5;
            this.txt_frmBill_Edit_BillID.Name = "txt_frmBill_Edit_BillID";
            this.txt_frmBill_Edit_BillID.ReadOnly = true;
            this.txt_frmBill_Edit_BillID.Size = new System.Drawing.Size(185, 20);
            this.txt_frmBill_Edit_BillID.TabIndex = 9;
            // 
            // but_frmBill_Edit_Cancel
            // 
            this.but_frmBill_Edit_Cancel.Location = new System.Drawing.Point(416, 169);
            this.but_frmBill_Edit_Cancel.Name = "but_frmBill_Edit_Cancel";
            this.but_frmBill_Edit_Cancel.Size = new System.Drawing.Size(107, 38);
            this.but_frmBill_Edit_Cancel.TabIndex = 13;
            this.but_frmBill_Edit_Cancel.Text = "Hủy";
            this.but_frmBill_Edit_Cancel.UseVisualStyleBackColor = true;
            this.but_frmBill_Edit_Cancel.Click += new System.EventHandler(this.but_frmBill_Edit_Cancel_Click);
            // 
            // but_frmBill_Edit_OK
            // 
            this.but_frmBill_Edit_OK.Location = new System.Drawing.Point(201, 169);
            this.but_frmBill_Edit_OK.Name = "but_frmBill_Edit_OK";
            this.but_frmBill_Edit_OK.Size = new System.Drawing.Size(107, 38);
            this.but_frmBill_Edit_OK.TabIndex = 14;
            this.but_frmBill_Edit_OK.Text = "Sửa";
            this.but_frmBill_Edit_OK.UseVisualStyleBackColor = true;
            this.but_frmBill_Edit_OK.Click += new System.EventHandler(this.but_frmBill_Edit_OK_Click);
            // 
            // frmBill_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 259);
            this.Controls.Add(this.but_frmBill_Edit_OK);
            this.Controls.Add(this.but_frmBill_Edit_Cancel);
            this.Controls.Add(this.cbo_frmBill_Edit_CustomerID);
            this.Controls.Add(this.dtm_frmBill_Edit_DateSell);
            this.Controls.Add(this.txt_frmBill_Edit_Note);
            this.Controls.Add(this.txt_frmBill_Edit_BillID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBill_Edit";
            this.Text = "Sửa Hóa Đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_frmBill_Edit_CustomerID;
        private System.Windows.Forms.DateTimePicker dtm_frmBill_Edit_DateSell;
        private System.Windows.Forms.TextBox txt_frmBill_Edit_Note;
        private System.Windows.Forms.TextBox txt_frmBill_Edit_BillID;
        private System.Windows.Forms.Button but_frmBill_Edit_Cancel;
        private System.Windows.Forms.Button but_frmBill_Edit_OK;
    }
}