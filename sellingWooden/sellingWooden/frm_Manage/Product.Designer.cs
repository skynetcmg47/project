﻿namespace sellingWooden
{
    partial class Product
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
            this.cbb_Product_TypeID = new System.Windows.Forms.ComboBox();
            this.txt_Product_Note = new System.Windows.Forms.TextBox();
            this.txt_Product_Size = new System.Windows.Forms.TextBox();
            this.txt_Product_Price = new System.Windows.Forms.TextBox();
            this.txt_Product_Quanty = new System.Windows.Forms.TextBox();
            this.txt_Product_NOP = new System.Windows.Forms.TextBox();
            this.txt_Product_ProductID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_Product_InformatinProductDetail = new System.Windows.Forms.DataGridView();
            this.frcontrol = new System.Windows.Forms.GroupBox();
            this.txt_Product_Search = new System.Windows.Forms.TextBox();
            this.but_Product_Edit = new System.Windows.Forms.Button();
            this.btn_Product_Search = new System.Windows.Forms.Button();
            this.but_Product_Add = new System.Windows.Forms.Button();
            this.but_Product_Refresh = new System.Windows.Forms.Button();
            this.but_Product_Delete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_InformatinProductDetail)).BeginInit();
            this.frcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_Product_TypeID);
            this.groupBox1.Controls.Add(this.txt_Product_Note);
            this.groupBox1.Controls.Add(this.txt_Product_Size);
            this.groupBox1.Controls.Add(this.txt_Product_Price);
            this.groupBox1.Controls.Add(this.txt_Product_Quanty);
            this.groupBox1.Controls.Add(this.txt_Product_NOP);
            this.groupBox1.Controls.Add(this.txt_Product_ProductID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbb_Product_TypeID
            // 
            this.cbb_Product_TypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Product_TypeID.FormattingEnabled = true;
            this.cbb_Product_TypeID.Location = new System.Drawing.Point(127, 103);
            this.cbb_Product_TypeID.MaxLength = 5;
            this.cbb_Product_TypeID.Name = "cbb_Product_TypeID";
            this.cbb_Product_TypeID.Size = new System.Drawing.Size(90, 21);
            this.cbb_Product_TypeID.TabIndex = 16;
            // 
            // txt_Product_Note
            // 
            this.txt_Product_Note.Location = new System.Drawing.Point(393, 140);
            this.txt_Product_Note.MaxLength = 255;
            this.txt_Product_Note.Multiline = true;
            this.txt_Product_Note.Name = "txt_Product_Note";
            this.txt_Product_Note.Size = new System.Drawing.Size(152, 56);
            this.txt_Product_Note.TabIndex = 15;
            // 
            // txt_Product_Size
            // 
            this.txt_Product_Size.Location = new System.Drawing.Point(393, 100);
            this.txt_Product_Size.MaxLength = 6;
            this.txt_Product_Size.Name = "txt_Product_Size";
            this.txt_Product_Size.Size = new System.Drawing.Size(125, 20);
            this.txt_Product_Size.TabIndex = 14;
            this.txt_Product_Size.TextChanged += new System.EventHandler(this.txt_Product_Size_TextChanged);
            this.txt_Product_Size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Product_Size_KeyPress);
            // 
            // txt_Product_Price
            // 
            this.txt_Product_Price.Location = new System.Drawing.Point(393, 60);
            this.txt_Product_Price.MaxLength = 9;
            this.txt_Product_Price.Name = "txt_Product_Price";
            this.txt_Product_Price.Size = new System.Drawing.Size(125, 20);
            this.txt_Product_Price.TabIndex = 13;
            this.txt_Product_Price.TextChanged += new System.EventHandler(this.txt_Product_Price_TextChanged);
            this.txt_Product_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Product_Price_KeyPress);
            // 
            // txt_Product_Quanty
            // 
            this.txt_Product_Quanty.Location = new System.Drawing.Point(393, 20);
            this.txt_Product_Quanty.MaxLength = 6;
            this.txt_Product_Quanty.Name = "txt_Product_Quanty";
            this.txt_Product_Quanty.Size = new System.Drawing.Size(80, 20);
            this.txt_Product_Quanty.TabIndex = 12;
            this.txt_Product_Quanty.TextChanged += new System.EventHandler(this.txt_Product_Quanty_TextChanged);
            this.txt_Product_Quanty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Product_Quanty_KeyPress);
            // 
            // txt_Product_NOP
            // 
            this.txt_Product_NOP.Location = new System.Drawing.Point(127, 60);
            this.txt_Product_NOP.MaxLength = 40;
            this.txt_Product_NOP.Name = "txt_Product_NOP";
            this.txt_Product_NOP.Size = new System.Drawing.Size(166, 20);
            this.txt_Product_NOP.TabIndex = 9;
            // 
            // txt_Product_ProductID
            // 
            this.txt_Product_ProductID.Location = new System.Drawing.Point(127, 20);
            this.txt_Product_ProductID.MaxLength = 6;
            this.txt_Product_ProductID.Name = "txt_Product_ProductID";
            this.txt_Product_ProductID.ReadOnly = true;
            this.txt_Product_ProductID.Size = new System.Drawing.Size(166, 20);
            this.txt_Product_ProductID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi chú :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kich thước  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá cả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã loại :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(179, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(620, 73);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thông Tin Sản Phẩm";
            // 
            // dgv_Product_InformatinProductDetail
            // 
            this.dgv_Product_InformatinProductDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Product_InformatinProductDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_InformatinProductDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Product_InformatinProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_InformatinProductDetail.Location = new System.Drawing.Point(7, 353);
            this.dgv_Product_InformatinProductDetail.Name = "dgv_Product_InformatinProductDetail";
            this.dgv_Product_InformatinProductDetail.Size = new System.Drawing.Size(843, 181);
            this.dgv_Product_InformatinProductDetail.TabIndex = 2;
            this.dgv_Product_InformatinProductDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_InformatinProductDetail_CellClick);
            // 
            // frcontrol
            // 
            this.frcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frcontrol.Controls.Add(this.txt_Product_Search);
            this.frcontrol.Controls.Add(this.but_Product_Edit);
            this.frcontrol.Controls.Add(this.btn_Product_Search);
            this.frcontrol.Controls.Add(this.but_Product_Add);
            this.frcontrol.Controls.Add(this.but_Product_Refresh);
            this.frcontrol.Controls.Add(this.but_Product_Delete);
            this.frcontrol.Location = new System.Drawing.Point(584, 131);
            this.frcontrol.Name = "frcontrol";
            this.frcontrol.Size = new System.Drawing.Size(266, 203);
            this.frcontrol.TabIndex = 3;
            this.frcontrol.TabStop = false;
            this.frcontrol.Text = "Điều khiển";
            // 
            // txt_Product_Search
            // 
            this.txt_Product_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Product_Search.Location = new System.Drawing.Point(67, 133);
            this.txt_Product_Search.Name = "txt_Product_Search";
            this.txt_Product_Search.Size = new System.Drawing.Size(148, 20);
            this.txt_Product_Search.TabIndex = 18;
            // 
            // but_Product_Edit
            // 
            this.but_Product_Edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Product_Edit.Location = new System.Drawing.Point(162, 20);
            this.but_Product_Edit.Name = "but_Product_Edit";
            this.but_Product_Edit.Size = new System.Drawing.Size(80, 30);
            this.but_Product_Edit.TabIndex = 9;
            this.but_Product_Edit.Text = "Sửa";
            this.but_Product_Edit.UseVisualStyleBackColor = false;
            this.but_Product_Edit.Click += new System.EventHandler(this.but_Product_Edit_Click);
            // 
            // btn_Product_Search
            // 
            this.btn_Product_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Product_Search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Product_Search.Location = new System.Drawing.Point(99, 166);
            this.btn_Product_Search.Name = "btn_Product_Search";
            this.btn_Product_Search.Size = new System.Drawing.Size(80, 30);
            this.btn_Product_Search.TabIndex = 8;
            this.btn_Product_Search.Text = "Tìm Kiếm";
            this.btn_Product_Search.UseVisualStyleBackColor = false;
            this.btn_Product_Search.Click += new System.EventHandler(this.btn_Product_Search_Click);
            // 
            // but_Product_Add
            // 
            this.but_Product_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Product_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Product_Add.Location = new System.Drawing.Point(44, 19);
            this.but_Product_Add.Name = "but_Product_Add";
            this.but_Product_Add.Size = new System.Drawing.Size(80, 30);
            this.but_Product_Add.TabIndex = 5;
            this.but_Product_Add.Text = "Thêm";
            this.but_Product_Add.UseVisualStyleBackColor = false;
            this.but_Product_Add.Click += new System.EventHandler(this.but_Product_Add_Click);
            // 
            // but_Product_Refresh
            // 
            this.but_Product_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Product_Refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Product_Refresh.Location = new System.Drawing.Point(44, 74);
            this.but_Product_Refresh.Name = "but_Product_Refresh";
            this.but_Product_Refresh.Size = new System.Drawing.Size(80, 30);
            this.but_Product_Refresh.TabIndex = 6;
            this.but_Product_Refresh.Text = "Làm Mới";
            this.but_Product_Refresh.UseVisualStyleBackColor = false;
            this.but_Product_Refresh.Click += new System.EventHandler(this.but_Product_Refresh_Click);
            // 
            // but_Product_Delete
            // 
            this.but_Product_Delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Product_Delete.Location = new System.Drawing.Point(162, 75);
            this.but_Product_Delete.Name = "but_Product_Delete";
            this.but_Product_Delete.Size = new System.Drawing.Size(80, 30);
            this.but_Product_Delete.TabIndex = 7;
            this.but_Product_Delete.Text = "Xóa";
            this.but_Product_Delete.UseVisualStyleBackColor = false;
            this.but_Product_Delete.Click += new System.EventHandler(this.but_Product_Delete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Thông tin sản phẩm chi tiết";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.frcontrol);
            this.Controls.Add(this.dgv_Product_InformatinProductDetail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_InformatinProductDetail)).EndInit();
            this.frcontrol.ResumeLayout(false);
            this.frcontrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Product_Note;
        private System.Windows.Forms.TextBox txt_Product_Size;
        private System.Windows.Forms.TextBox txt_Product_Price;
        private System.Windows.Forms.TextBox txt_Product_Quanty;
        private System.Windows.Forms.TextBox txt_Product_NOP;
        private System.Windows.Forms.TextBox txt_Product_ProductID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Product_TypeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_Product_InformatinProductDetail;
        private System.Windows.Forms.GroupBox frcontrol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button but_Product_Edit;
        private System.Windows.Forms.Button btn_Product_Search;
        private System.Windows.Forms.Button but_Product_Add;
        private System.Windows.Forms.Button but_Product_Refresh;
        private System.Windows.Forms.Button but_Product_Delete;
        private System.Windows.Forms.TextBox txt_Product_Search;
    }
}