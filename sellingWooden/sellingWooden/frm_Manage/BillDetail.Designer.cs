namespace sellingWooden
{
    partial class BillDetail
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
            this.cbb_BillDetail_ProductID = new System.Windows.Forms.ComboBox();
            this.cbo_BillDetail_BillID = new System.Windows.Forms.ComboBox();
            this.txt_BillDetail_Amount = new System.Windows.Forms.TextBox();
            this.cbo_BillDetail_EmployeeID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_BillDetail_BillDetailDetail = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_BillDetail_Search = new System.Windows.Forms.TextBox();
            this.btn_BillDetail_Search = new System.Windows.Forms.Button();
            this.but_BillDetail_Edit = new System.Windows.Forms.Button();
            this.but_BillDetail_Add = new System.Windows.Forms.Button();
            this.but_BillDetail_Refresh = new System.Windows.Forms.Button();
            this.but_BillDetail_Delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillDetail_BillDetailDetail)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_BillDetail_ProductID);
            this.groupBox1.Controls.Add(this.cbo_BillDetail_BillID);
            this.groupBox1.Controls.Add(this.txt_BillDetail_Amount);
            this.groupBox1.Controls.Add(this.cbo_BillDetail_EmployeeID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbb_BillDetail_ProductID
            // 
            this.cbb_BillDetail_ProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_BillDetail_ProductID.FormattingEnabled = true;
            this.cbb_BillDetail_ProductID.Location = new System.Drawing.Point(384, 89);
            this.cbb_BillDetail_ProductID.Name = "cbb_BillDetail_ProductID";
            this.cbb_BillDetail_ProductID.Size = new System.Drawing.Size(121, 21);
            this.cbb_BillDetail_ProductID.TabIndex = 17;
            // 
            // cbo_BillDetail_BillID
            // 
            this.cbo_BillDetail_BillID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_BillDetail_BillID.FormattingEnabled = true;
            this.cbo_BillDetail_BillID.Location = new System.Drawing.Point(152, 49);
            this.cbo_BillDetail_BillID.Name = "cbo_BillDetail_BillID";
            this.cbo_BillDetail_BillID.Size = new System.Drawing.Size(121, 21);
            this.cbo_BillDetail_BillID.TabIndex = 16;
            // 
            // txt_BillDetail_Amount
            // 
            this.txt_BillDetail_Amount.Location = new System.Drawing.Point(384, 50);
            this.txt_BillDetail_Amount.MaxLength = 6;
            this.txt_BillDetail_Amount.Name = "txt_BillDetail_Amount";
            this.txt_BillDetail_Amount.Size = new System.Drawing.Size(94, 20);
            this.txt_BillDetail_Amount.TabIndex = 13;
            this.txt_BillDetail_Amount.TextChanged += new System.EventHandler(this.txt_BillDetail_Amount_TextChanged);
            this.txt_BillDetail_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BillDetail_Amount_KeyPress);
            // 
            // cbo_BillDetail_EmployeeID
            // 
            this.cbo_BillDetail_EmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_BillDetail_EmployeeID.FormattingEnabled = true;
            this.cbo_BillDetail_EmployeeID.Location = new System.Drawing.Point(152, 92);
            this.cbo_BillDetail_EmployeeID.Name = "cbo_BillDetail_EmployeeID";
            this.cbo_BillDetail_EmployeeID.Size = new System.Drawing.Size(121, 21);
            this.cbo_BillDetail_EmployeeID.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sản phẩm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(519, 73);
            this.label9.TabIndex = 1;
            this.label9.Text = "Hóa Đơn Chi Tiết";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Thông tin hóa đơn chi tiết";
            // 
            // dgv_BillDetail_BillDetailDetail
            // 
            this.dgv_BillDetail_BillDetailDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BillDetail_BillDetailDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BillDetail_BillDetailDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_BillDetail_BillDetailDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BillDetail_BillDetailDetail.Location = new System.Drawing.Point(13, 278);
            this.dgv_BillDetail_BillDetailDetail.Name = "dgv_BillDetail_BillDetailDetail";
            this.dgv_BillDetail_BillDetailDetail.Size = new System.Drawing.Size(810, 250);
            this.dgv_BillDetail_BillDetailDetail.TabIndex = 4;
            this.dgv_BillDetail_BillDetailDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BillDetail_BillDetailDetail_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_BillDetail_Search);
            this.groupBox2.Controls.Add(this.btn_BillDetail_Search);
            this.groupBox2.Controls.Add(this.but_BillDetail_Edit);
            this.groupBox2.Controls.Add(this.but_BillDetail_Add);
            this.groupBox2.Controls.Add(this.but_BillDetail_Refresh);
            this.groupBox2.Controls.Add(this.but_BillDetail_Delete);
            this.groupBox2.Location = new System.Drawing.Point(552, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 168);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển";
            // 
            // txt_BillDetail_Search
            // 
            this.txt_BillDetail_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BillDetail_Search.Location = new System.Drawing.Point(57, 106);
            this.txt_BillDetail_Search.Name = "txt_BillDetail_Search";
            this.txt_BillDetail_Search.Size = new System.Drawing.Size(150, 20);
            this.txt_BillDetail_Search.TabIndex = 11;
            // 
            // btn_BillDetail_Search
            // 
            this.btn_BillDetail_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BillDetail_Search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_BillDetail_Search.Location = new System.Drawing.Point(87, 132);
            this.btn_BillDetail_Search.Name = "btn_BillDetail_Search";
            this.btn_BillDetail_Search.Size = new System.Drawing.Size(92, 30);
            this.btn_BillDetail_Search.TabIndex = 10;
            this.btn_BillDetail_Search.Text = "Tìm Kiếm";
            this.btn_BillDetail_Search.UseVisualStyleBackColor = false;
            this.btn_BillDetail_Search.Click += new System.EventHandler(this.btn_BillDetail_Search_Click);
            // 
            // but_BillDetail_Edit
            // 
            this.but_BillDetail_Edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_BillDetail_Edit.Location = new System.Drawing.Point(159, 19);
            this.but_BillDetail_Edit.Name = "but_BillDetail_Edit";
            this.but_BillDetail_Edit.Size = new System.Drawing.Size(92, 30);
            this.but_BillDetail_Edit.TabIndex = 9;
            this.but_BillDetail_Edit.Text = "Sửa";
            this.but_BillDetail_Edit.UseVisualStyleBackColor = false;
            this.but_BillDetail_Edit.Click += new System.EventHandler(this.but_BillDetail_Edit_Click);
            // 
            // but_BillDetail_Add
            // 
            this.but_BillDetail_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_BillDetail_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_BillDetail_Add.Location = new System.Drawing.Point(20, 19);
            this.but_BillDetail_Add.Name = "but_BillDetail_Add";
            this.but_BillDetail_Add.Size = new System.Drawing.Size(92, 30);
            this.but_BillDetail_Add.TabIndex = 5;
            this.but_BillDetail_Add.Text = "Thêm";
            this.but_BillDetail_Add.UseVisualStyleBackColor = false;
            this.but_BillDetail_Add.Click += new System.EventHandler(this.but_BillDetail_Add_Click);
            // 
            // but_BillDetail_Refresh
            // 
            this.but_BillDetail_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_BillDetail_Refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_BillDetail_Refresh.Location = new System.Drawing.Point(20, 59);
            this.but_BillDetail_Refresh.Name = "but_BillDetail_Refresh";
            this.but_BillDetail_Refresh.Size = new System.Drawing.Size(92, 30);
            this.but_BillDetail_Refresh.TabIndex = 6;
            this.but_BillDetail_Refresh.Text = "Làm Mới";
            this.but_BillDetail_Refresh.UseVisualStyleBackColor = false;
            this.but_BillDetail_Refresh.Click += new System.EventHandler(this.but_BillDetail_Refresh_Click);
            // 
            // but_BillDetail_Delete
            // 
            this.but_BillDetail_Delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_BillDetail_Delete.Location = new System.Drawing.Point(159, 57);
            this.but_BillDetail_Delete.Name = "but_BillDetail_Delete";
            this.but_BillDetail_Delete.Size = new System.Drawing.Size(92, 30);
            this.but_BillDetail_Delete.TabIndex = 7;
            this.but_BillDetail_Delete.Text = "Xóa";
            this.but_BillDetail_Delete.UseVisualStyleBackColor = false;
            this.but_BillDetail_Delete.Click += new System.EventHandler(this.but_BillDetail_Delete_Click);
            // 
            // BillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_BillDetail_BillDetailDetail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillDetail";
            this.Text = "BillDetail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillDetail_BillDetailDetail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BillDetail_Amount;
        private System.Windows.Forms.ComboBox cbo_BillDetail_EmployeeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_BillDetail_BillDetailDetail;
        private System.Windows.Forms.ComboBox cbb_BillDetail_ProductID;
        private System.Windows.Forms.ComboBox cbo_BillDetail_BillID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_BillDetail_Search;
        private System.Windows.Forms.Button btn_BillDetail_Search;
        private System.Windows.Forms.Button but_BillDetail_Edit;
        private System.Windows.Forms.Button but_BillDetail_Add;
        private System.Windows.Forms.Button but_BillDetail_Refresh;
        private System.Windows.Forms.Button but_BillDetail_Delete;
    }
}