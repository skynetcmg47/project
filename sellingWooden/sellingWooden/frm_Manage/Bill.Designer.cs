namespace sellingWooden
{
    partial class Bill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_Bill_CustomerID = new System.Windows.Forms.ComboBox();
            this.dtm_Bill_DateSell = new System.Windows.Forms.DateTimePicker();
            this.txt_Bill_Note = new System.Windows.Forms.TextBox();
            this.txt_Bill_BillID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Bill_Search = new System.Windows.Forms.Button();
            this.but_Bill_Edit = new System.Windows.Forms.Button();
            this.but_Bill_Add = new System.Windows.Forms.Button();
            this.but_Bill_Delete = new System.Windows.Forms.Button();
            this.but_Bill_Refresh = new System.Windows.Forms.Button();
            this.dgv_Bill_InformatinBillDetail = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Bill_Search = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_InformatinBillDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_Bill_CustomerID);
            this.groupBox1.Controls.Add(this.dtm_Bill_DateSell);
            this.groupBox1.Controls.Add(this.txt_Bill_Note);
            this.groupBox1.Controls.Add(this.txt_Bill_BillID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbb_Bill_CustomerID
            // 
            this.cbb_Bill_CustomerID.FormattingEnabled = true;
            this.cbb_Bill_CustomerID.Location = new System.Drawing.Point(113, 85);
            this.cbb_Bill_CustomerID.Name = "cbb_Bill_CustomerID";
            this.cbb_Bill_CustomerID.Size = new System.Drawing.Size(121, 21);
            this.cbb_Bill_CustomerID.TabIndex = 8;
            // 
            // dtm_Bill_DateSell
            // 
            this.dtm_Bill_DateSell.Location = new System.Drawing.Point(397, 33);
            this.dtm_Bill_DateSell.Name = "dtm_Bill_DateSell";
            this.dtm_Bill_DateSell.Size = new System.Drawing.Size(200, 20);
            this.dtm_Bill_DateSell.TabIndex = 7;
            // 
            // txt_Bill_Note
            // 
            this.txt_Bill_Note.Location = new System.Drawing.Point(397, 82);
            this.txt_Bill_Note.MaxLength = 322;
            this.txt_Bill_Note.Multiline = true;
            this.txt_Bill_Note.Name = "txt_Bill_Note";
            this.txt_Bill_Note.Size = new System.Drawing.Size(200, 53);
            this.txt_Bill_Note.TabIndex = 6;
            // 
            // txt_Bill_BillID
            // 
            this.txt_Bill_BillID.Location = new System.Drawing.Point(113, 30);
            this.txt_Bill_BillID.MaxLength = 5;
            this.txt_Bill_BillID.Name = "txt_Bill_BillID";
            this.txt_Bill_BillID.Size = new System.Drawing.Size(200, 20);
            this.txt_Bill_BillID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 73);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Bill_Search);
            this.groupBox2.Controls.Add(this.btn_Bill_Search);
            this.groupBox2.Controls.Add(this.but_Bill_Edit);
            this.groupBox2.Controls.Add(this.but_Bill_Add);
            this.groupBox2.Controls.Add(this.but_Bill_Delete);
            this.groupBox2.Controls.Add(this.but_Bill_Refresh);
            this.groupBox2.Location = new System.Drawing.Point(636, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển";
            // 
            // btn_Bill_Search
            // 
            this.btn_Bill_Search.Location = new System.Drawing.Point(71, 138);
            this.btn_Bill_Search.Name = "btn_Bill_Search";
            this.btn_Bill_Search.Size = new System.Drawing.Size(78, 23);
            this.btn_Bill_Search.TabIndex = 4;
            this.btn_Bill_Search.Text = "Tìm Kiếm";
            this.btn_Bill_Search.UseVisualStyleBackColor = true;
            this.btn_Bill_Search.Click += new System.EventHandler(this.btn_Bill_Search_Click);
            // 
            // but_Bill_Edit
            // 
            this.but_Bill_Edit.Location = new System.Drawing.Point(129, 17);
            this.but_Bill_Edit.Name = "but_Bill_Edit";
            this.but_Bill_Edit.Size = new System.Drawing.Size(78, 23);
            this.but_Bill_Edit.TabIndex = 1;
            this.but_Bill_Edit.Text = "Sửa";
            this.but_Bill_Edit.UseVisualStyleBackColor = true;
            this.but_Bill_Edit.Click += new System.EventHandler(this.but_Bill_Edit_Click);
            // 
            // but_Bill_Add
            // 
            this.but_Bill_Add.Location = new System.Drawing.Point(20, 17);
            this.but_Bill_Add.Name = "but_Bill_Add";
            this.but_Bill_Add.Size = new System.Drawing.Size(78, 23);
            this.but_Bill_Add.TabIndex = 0;
            this.but_Bill_Add.Text = "Thêm";
            this.but_Bill_Add.UseVisualStyleBackColor = true;
            this.but_Bill_Add.Click += new System.EventHandler(this.but_Bill_Add_Click);
            // 
            // but_Bill_Delete
            // 
            this.but_Bill_Delete.Location = new System.Drawing.Point(129, 53);
            this.but_Bill_Delete.Name = "but_Bill_Delete";
            this.but_Bill_Delete.Size = new System.Drawing.Size(78, 23);
            this.but_Bill_Delete.TabIndex = 3;
            this.but_Bill_Delete.Text = "Xóa";
            this.but_Bill_Delete.UseVisualStyleBackColor = true;
            this.but_Bill_Delete.Click += new System.EventHandler(this.but_Bill_Delete_Click);
            // 
            // but_Bill_Refresh
            // 
            this.but_Bill_Refresh.Location = new System.Drawing.Point(20, 53);
            this.but_Bill_Refresh.Name = "but_Bill_Refresh";
            this.but_Bill_Refresh.Size = new System.Drawing.Size(78, 23);
            this.but_Bill_Refresh.TabIndex = 2;
            this.but_Bill_Refresh.Text = "Làm mới";
            this.but_Bill_Refresh.UseVisualStyleBackColor = true;
            // 
            // dgv_Bill_InformatinBillDetail
            // 
            this.dgv_Bill_InformatinBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bill_InformatinBillDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Bill_InformatinBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill_InformatinBillDetail.Location = new System.Drawing.Point(12, 269);
            this.dgv_Bill_InformatinBillDetail.Name = "dgv_Bill_InformatinBillDetail";
            this.dgv_Bill_InformatinBillDetail.Size = new System.Drawing.Size(851, 236);
            this.dgv_Bill_InformatinBillDetail.TabIndex = 3;
            this.dgv_Bill_InformatinBillDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Bill_InformatinBillDetail_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thông tin hóa đơn chi tiết";
            // 
            // txt_Bill_Search
            // 
            this.txt_Bill_Search.Location = new System.Drawing.Point(40, 106);
            this.txt_Bill_Search.Name = "txt_Bill_Search";
            this.txt_Bill_Search.Size = new System.Drawing.Size(156, 20);
            this.txt_Bill_Search.TabIndex = 5;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Bill_InformatinBillDetail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.Text = "Bill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill_InformatinBillDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtm_Bill_DateSell;
        private System.Windows.Forms.TextBox txt_Bill_Note;
        private System.Windows.Forms.TextBox txt_Bill_BillID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_Bill_Delete;
        private System.Windows.Forms.Button but_Bill_Refresh;
        private System.Windows.Forms.Button but_Bill_Edit;
        private System.Windows.Forms.Button but_Bill_Add;
        private System.Windows.Forms.DataGridView dgv_Bill_InformatinBillDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_Bill_CustomerID;
        private System.Windows.Forms.Button btn_Bill_Search;
        private System.Windows.Forms.TextBox txt_Bill_Search;
    }
}