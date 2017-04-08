namespace sellingWooden
{
    partial class Customer
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
            this.dtm_Customer_DOB = new System.Windows.Forms.DateTimePicker();
            this.cbo_Customer_Sex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Customer_Address = new System.Windows.Forms.TextBox();
            this.txt_Customer_Note = new System.Windows.Forms.TextBox();
            this.txt_Customer_TEL = new System.Windows.Forms.TextBox();
            this.txt_Customer_NOC = new System.Windows.Forms.TextBox();
            this.txt_Customer_CustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Customer_search = new System.Windows.Forms.TextBox();
            this.but_Customer_Edit = new System.Windows.Forms.Button();
            this.btn_Customer_Search = new System.Windows.Forms.Button();
            this.but_Customer_Add = new System.Windows.Forms.Button();
            this.but_Customer_Delete = new System.Windows.Forms.Button();
            this.but_Customer_Refresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Customer_InformationCustomerDetail = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_InformationCustomerDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtm_Customer_DOB);
            this.groupBox1.Controls.Add(this.cbo_Customer_Sex);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Customer_Address);
            this.groupBox1.Controls.Add(this.txt_Customer_Note);
            this.groupBox1.Controls.Add(this.txt_Customer_TEL);
            this.groupBox1.Controls.Add(this.txt_Customer_NOC);
            this.groupBox1.Controls.Add(this.txt_Customer_CustomerID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // dtm_Customer_DOB
            // 
            this.dtm_Customer_DOB.Location = new System.Drawing.Point(141, 91);
            this.dtm_Customer_DOB.Name = "dtm_Customer_DOB";
            this.dtm_Customer_DOB.Size = new System.Drawing.Size(145, 20);
            this.dtm_Customer_DOB.TabIndex = 15;
            // 
            // cbo_Customer_Sex
            // 
            this.cbo_Customer_Sex.FormattingEnabled = true;
            this.cbo_Customer_Sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_Customer_Sex.Location = new System.Drawing.Point(396, 23);
            this.cbo_Customer_Sex.Name = "cbo_Customer_Sex";
            this.cbo_Customer_Sex.Size = new System.Drawing.Size(86, 21);
            this.cbo_Customer_Sex.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ :";
            // 
            // txt_Customer_Address
            // 
            this.txt_Customer_Address.Location = new System.Drawing.Point(141, 130);
            this.txt_Customer_Address.MaxLength = 50;
            this.txt_Customer_Address.Name = "txt_Customer_Address";
            this.txt_Customer_Address.Size = new System.Drawing.Size(145, 20);
            this.txt_Customer_Address.TabIndex = 11;
            // 
            // txt_Customer_Note
            // 
            this.txt_Customer_Note.Location = new System.Drawing.Point(396, 100);
            this.txt_Customer_Note.MaxLength = 255;
            this.txt_Customer_Note.Multiline = true;
            this.txt_Customer_Note.Name = "txt_Customer_Note";
            this.txt_Customer_Note.Size = new System.Drawing.Size(166, 53);
            this.txt_Customer_Note.TabIndex = 13;
            // 
            // txt_Customer_TEL
            // 
            this.txt_Customer_TEL.Location = new System.Drawing.Point(396, 53);
            this.txt_Customer_TEL.MaxLength = 11;
            this.txt_Customer_TEL.Name = "txt_Customer_TEL";
            this.txt_Customer_TEL.Size = new System.Drawing.Size(166, 20);
            this.txt_Customer_TEL.TabIndex = 12;
            this.txt_Customer_TEL.TextChanged += new System.EventHandler(this.txt_Customer_TEL_TextChanged);
            this.txt_Customer_TEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Customer_TEL_KeyPress);
            // 
            // txt_Customer_NOC
            // 
            this.txt_Customer_NOC.Location = new System.Drawing.Point(141, 57);
            this.txt_Customer_NOC.MaxLength = 40;
            this.txt_Customer_NOC.Name = "txt_Customer_NOC";
            this.txt_Customer_NOC.Size = new System.Drawing.Size(145, 20);
            this.txt_Customer_NOC.TabIndex = 8;
            // 
            // txt_Customer_CustomerID
            // 
            this.txt_Customer_CustomerID.Location = new System.Drawing.Point(141, 23);
            this.txt_Customer_CustomerID.MaxLength = 5;
            this.txt_Customer_CustomerID.Name = "txt_Customer_CustomerID";
            this.txt_Customer_CustomerID.Size = new System.Drawing.Size(145, 20);
            this.txt_Customer_CustomerID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên của khách hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_Customer_search);
            this.groupBox2.Controls.Add(this.but_Customer_Edit);
            this.groupBox2.Controls.Add(this.btn_Customer_Search);
            this.groupBox2.Controls.Add(this.but_Customer_Add);
            this.groupBox2.Controls.Add(this.but_Customer_Delete);
            this.groupBox2.Controls.Add(this.but_Customer_Refresh);
            this.groupBox2.Location = new System.Drawing.Point(593, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 177);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển";
            // 
            // txt_Customer_search
            // 
            this.txt_Customer_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Customer_search.Location = new System.Drawing.Point(58, 106);
            this.txt_Customer_search.Name = "txt_Customer_search";
            this.txt_Customer_search.Size = new System.Drawing.Size(148, 20);
            this.txt_Customer_search.TabIndex = 5;
            // 
            // but_Customer_Edit
            // 
            this.but_Customer_Edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Customer_Edit.Location = new System.Drawing.Point(162, 20);
            this.but_Customer_Edit.Name = "but_Customer_Edit";
            this.but_Customer_Edit.Size = new System.Drawing.Size(80, 30);
            this.but_Customer_Edit.TabIndex = 4;
            this.but_Customer_Edit.Text = "Sửa";
            this.but_Customer_Edit.UseVisualStyleBackColor = false;
            this.but_Customer_Edit.Click += new System.EventHandler(this.but_Customer_Edit_Click);
            // 
            // btn_Customer_Search
            // 
            this.btn_Customer_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Customer_Search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Customer_Search.Location = new System.Drawing.Point(93, 141);
            this.btn_Customer_Search.Name = "btn_Customer_Search";
            this.btn_Customer_Search.Size = new System.Drawing.Size(80, 30);
            this.btn_Customer_Search.TabIndex = 3;
            this.btn_Customer_Search.Text = "Tìm Kiếm";
            this.btn_Customer_Search.UseVisualStyleBackColor = false;
            this.btn_Customer_Search.Click += new System.EventHandler(this.btn_Customer_Search_Click);
            // 
            // but_Customer_Add
            // 
            this.but_Customer_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Customer_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Customer_Add.Location = new System.Drawing.Point(30, 20);
            this.but_Customer_Add.Name = "but_Customer_Add";
            this.but_Customer_Add.Size = new System.Drawing.Size(80, 30);
            this.but_Customer_Add.TabIndex = 0;
            this.but_Customer_Add.Text = "Thêm";
            this.but_Customer_Add.UseVisualStyleBackColor = false;
            this.but_Customer_Add.Click += new System.EventHandler(this.but_Customer_Add_Click);
            // 
            // but_Customer_Delete
            // 
            this.but_Customer_Delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Customer_Delete.Location = new System.Drawing.Point(162, 56);
            this.but_Customer_Delete.Name = "but_Customer_Delete";
            this.but_Customer_Delete.Size = new System.Drawing.Size(80, 30);
            this.but_Customer_Delete.TabIndex = 2;
            this.but_Customer_Delete.Text = "Xóa";
            this.but_Customer_Delete.UseVisualStyleBackColor = false;
            this.but_Customer_Delete.Click += new System.EventHandler(this.but_Customer_Delete_Click);
            // 
            // but_Customer_Refresh
            // 
            this.but_Customer_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Customer_Refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Customer_Refresh.Location = new System.Drawing.Point(30, 56);
            this.but_Customer_Refresh.Name = "but_Customer_Refresh";
            this.but_Customer_Refresh.Size = new System.Drawing.Size(80, 30);
            this.but_Customer_Refresh.TabIndex = 1;
            this.but_Customer_Refresh.Text = "Làm Mới";
            this.but_Customer_Refresh.UseVisualStyleBackColor = false;
            this.but_Customer_Refresh.Click += new System.EventHandler(this.but_Customer_Refresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, -3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(380, 73);
            this.label8.TabIndex = 17;
            this.label8.Text = "Khách Hàng";
            // 
            // dgv_Customer_InformationCustomerDetail
            // 
            this.dgv_Customer_InformationCustomerDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Customer_InformationCustomerDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_InformationCustomerDetail.Location = new System.Drawing.Point(12, 275);
            this.dgv_Customer_InformationCustomerDetail.Name = "dgv_Customer_InformationCustomerDetail";
            this.dgv_Customer_InformationCustomerDetail.Size = new System.Drawing.Size(838, 229);
            this.dgv_Customer_InformationCustomerDetail.TabIndex = 18;
            this.dgv_Customer_InformationCustomerDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_InformationCustomerDetail_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Thông tin khách hàng chi tiết";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 531);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_Customer_InformationCustomerDetail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_InformationCustomerDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtm_Customer_DOB;
        private System.Windows.Forms.ComboBox cbo_Customer_Sex;
        private System.Windows.Forms.TextBox txt_Customer_Note;
        private System.Windows.Forms.TextBox txt_Customer_TEL;
        private System.Windows.Forms.TextBox txt_Customer_Address;
        private System.Windows.Forms.TextBox txt_Customer_NOC;
        private System.Windows.Forms.TextBox txt_Customer_CustomerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_Customer_Edit;
        private System.Windows.Forms.Button btn_Customer_Search;
        private System.Windows.Forms.Button but_Customer_Add;
        private System.Windows.Forms.Button but_Customer_Refresh;
        private System.Windows.Forms.Button but_Customer_Delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_Customer_InformationCustomerDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Customer_search;
    }
}