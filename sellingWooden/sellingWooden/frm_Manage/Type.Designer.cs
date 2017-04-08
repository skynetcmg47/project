namespace sellingWooden
{
    partial class Type
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
            this.txt_Type_NOT = new System.Windows.Forms.TextBox();
            this.txt_Type_TypeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Type_Search = new System.Windows.Forms.Button();
            this.txt_Type_Search = new System.Windows.Forms.TextBox();
            this.but_Type_Delete = new System.Windows.Forms.Button();
            this.but_Type_Refresh = new System.Windows.Forms.Button();
            this.but_Type_Edit = new System.Windows.Forms.Button();
            this.but_Type_Add = new System.Windows.Forms.Button();
            this.dgv_Type_InformationTypeDetail = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Type_InformationTypeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Type_NOT);
            this.groupBox1.Controls.Add(this.txt_Type_TypeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại hàng hóa";
            // 
            // txt_Type_NOT
            // 
            this.txt_Type_NOT.Location = new System.Drawing.Point(94, 58);
            this.txt_Type_NOT.MaxLength = 40;
            this.txt_Type_NOT.Name = "txt_Type_NOT";
            this.txt_Type_NOT.Size = new System.Drawing.Size(200, 20);
            this.txt_Type_NOT.TabIndex = 3;
            // 
            // txt_Type_TypeID
            // 
            this.txt_Type_TypeID.Location = new System.Drawing.Point(94, 26);
            this.txt_Type_TypeID.MaxLength = 5;
            this.txt_Type_TypeID.Name = "txt_Type_TypeID";
            this.txt_Type_TypeID.Size = new System.Drawing.Size(86, 20);
            this.txt_Type_TypeID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Loại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 73);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại Hàng Hóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_Type_Search);
            this.groupBox2.Controls.Add(this.txt_Type_Search);
            this.groupBox2.Controls.Add(this.but_Type_Delete);
            this.groupBox2.Controls.Add(this.but_Type_Refresh);
            this.groupBox2.Controls.Add(this.but_Type_Edit);
            this.groupBox2.Controls.Add(this.but_Type_Add);
            this.groupBox2.Location = new System.Drawing.Point(400, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển";
            // 
            // btn_Type_Search
            // 
            this.btn_Type_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Type_Search.Location = new System.Drawing.Point(313, 58);
            this.btn_Type_Search.Name = "btn_Type_Search";
            this.btn_Type_Search.Size = new System.Drawing.Size(85, 31);
            this.btn_Type_Search.TabIndex = 6;
            this.btn_Type_Search.Text = "Tìm Kiếm";
            this.btn_Type_Search.UseVisualStyleBackColor = true;
            this.btn_Type_Search.Click += new System.EventHandler(this.btn_Type_Search_Click);
            // 
            // txt_Type_Search
            // 
            this.txt_Type_Search.Location = new System.Drawing.Point(273, 26);
            this.txt_Type_Search.Name = "txt_Type_Search";
            this.txt_Type_Search.Size = new System.Drawing.Size(163, 20);
            this.txt_Type_Search.TabIndex = 5;
            // 
            // but_Type_Delete
            // 
            this.but_Type_Delete.Location = new System.Drawing.Point(140, 54);
            this.but_Type_Delete.Name = "but_Type_Delete";
            this.but_Type_Delete.Size = new System.Drawing.Size(90, 31);
            this.but_Type_Delete.TabIndex = 4;
            this.but_Type_Delete.Text = "Xóa";
            this.but_Type_Delete.UseVisualStyleBackColor = true;
            this.but_Type_Delete.Click += new System.EventHandler(this.but_Type_Delete_Click);
            // 
            // but_Type_Refresh
            // 
            this.but_Type_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Type_Refresh.Location = new System.Drawing.Point(19, 54);
            this.but_Type_Refresh.Name = "but_Type_Refresh";
            this.but_Type_Refresh.Size = new System.Drawing.Size(90, 31);
            this.but_Type_Refresh.TabIndex = 2;
            this.but_Type_Refresh.Text = "Làm mới";
            this.but_Type_Refresh.UseVisualStyleBackColor = true;
            this.but_Type_Refresh.Click += new System.EventHandler(this.but_Type_Refresh_Click);
            // 
            // but_Type_Edit
            // 
            this.but_Type_Edit.Location = new System.Drawing.Point(140, 17);
            this.but_Type_Edit.Name = "but_Type_Edit";
            this.but_Type_Edit.Size = new System.Drawing.Size(90, 31);
            this.but_Type_Edit.TabIndex = 1;
            this.but_Type_Edit.Text = "Sửa";
            this.but_Type_Edit.UseVisualStyleBackColor = true;
            this.but_Type_Edit.Click += new System.EventHandler(this.but_Type_Edit_Click);
            // 
            // but_Type_Add
            // 
            this.but_Type_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Type_Add.Location = new System.Drawing.Point(19, 17);
            this.but_Type_Add.Name = "but_Type_Add";
            this.but_Type_Add.Size = new System.Drawing.Size(90, 31);
            this.but_Type_Add.TabIndex = 0;
            this.but_Type_Add.Text = "Thêm";
            this.but_Type_Add.UseVisualStyleBackColor = true;
            this.but_Type_Add.Click += new System.EventHandler(this.but_Type_Add_Click);
            // 
            // dgv_Type_InformationTypeDetail
            // 
            this.dgv_Type_InformationTypeDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Type_InformationTypeDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Type_InformationTypeDetail.Location = new System.Drawing.Point(21, 235);
            this.dgv_Type_InformationTypeDetail.Name = "dgv_Type_InformationTypeDetail";
            this.dgv_Type_InformationTypeDetail.Size = new System.Drawing.Size(832, 213);
            this.dgv_Type_InformationTypeDetail.TabIndex = 3;
            this.dgv_Type_InformationTypeDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Type_InformationTypeDetail_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thông tin loại hàng hóa chi tiết";
            // 
            // Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Type_InformationTypeDetail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Type";
            this.Text = "Type";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Type_InformationTypeDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Type_NOT;
        private System.Windows.Forms.TextBox txt_Type_TypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_Type_Delete;
        private System.Windows.Forms.Button but_Type_Refresh;
        private System.Windows.Forms.Button but_Type_Edit;
        private System.Windows.Forms.Button but_Type_Add;
        private System.Windows.Forms.DataGridView dgv_Type_InformationTypeDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Type_Search;
        private System.Windows.Forms.TextBox txt_Type_Search;
    }
}