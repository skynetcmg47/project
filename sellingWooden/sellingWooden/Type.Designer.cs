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
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại hàng hóa";
            // 
            // txt_Type_NOT
            // 
            this.txt_Type_NOT.Location = new System.Drawing.Point(94, 62);
            this.txt_Type_NOT.Name = "txt_Type_NOT";
            this.txt_Type_NOT.Size = new System.Drawing.Size(200, 20);
            this.txt_Type_NOT.TabIndex = 3;
            // 
            // txt_Type_TypeID
            // 
            this.txt_Type_TypeID.Location = new System.Drawing.Point(94, 26);
            this.txt_Type_TypeID.Name = "txt_Type_TypeID";
            this.txt_Type_TypeID.Size = new System.Drawing.Size(200, 20);
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
            this.label3.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại Hàng Hóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_Type_Delete);
            this.groupBox2.Controls.Add(this.but_Type_Refresh);
            this.groupBox2.Controls.Add(this.but_Type_Edit);
            this.groupBox2.Controls.Add(this.but_Type_Add);
            this.groupBox2.Location = new System.Drawing.Point(318, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển";
            // 
            // but_Type_Delete
            // 
            this.but_Type_Delete.Location = new System.Drawing.Point(6, 60);
            this.but_Type_Delete.Name = "but_Type_Delete";
            this.but_Type_Delete.Size = new System.Drawing.Size(65, 23);
            this.but_Type_Delete.TabIndex = 4;
            this.but_Type_Delete.Text = "Xóa";
            this.but_Type_Delete.UseVisualStyleBackColor = true;
            // 
            // but_Type_Refresh
            // 
            this.but_Type_Refresh.Location = new System.Drawing.Point(80, 60);
            this.but_Type_Refresh.Name = "but_Type_Refresh";
            this.but_Type_Refresh.Size = new System.Drawing.Size(65, 23);
            this.but_Type_Refresh.TabIndex = 2;
            this.but_Type_Refresh.Text = "Làm mới";
            this.but_Type_Refresh.UseVisualStyleBackColor = true;
            // 
            // but_Type_Edit
            // 
            this.but_Type_Edit.Location = new System.Drawing.Point(80, 26);
            this.but_Type_Edit.Name = "but_Type_Edit";
            this.but_Type_Edit.Size = new System.Drawing.Size(65, 23);
            this.but_Type_Edit.TabIndex = 1;
            this.but_Type_Edit.Text = "Sửa";
            this.but_Type_Edit.UseVisualStyleBackColor = true;
            // 
            // but_Type_Add
            // 
            this.but_Type_Add.Location = new System.Drawing.Point(6, 26);
            this.but_Type_Add.Name = "but_Type_Add";
            this.but_Type_Add.Size = new System.Drawing.Size(65, 23);
            this.but_Type_Add.TabIndex = 0;
            this.but_Type_Add.Text = "Thêm";
            this.but_Type_Add.UseVisualStyleBackColor = true;
            // 
            // dgv_Type_InformationTypeDetail
            // 
            this.dgv_Type_InformationTypeDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Type_InformationTypeDetail.Location = new System.Drawing.Point(12, 181);
            this.dgv_Type_InformationTypeDetail.Name = "dgv_Type_InformationTypeDetail";
            this.dgv_Type_InformationTypeDetail.Size = new System.Drawing.Size(462, 178);
            this.dgv_Type_InformationTypeDetail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thông tin loại hàng hóa chi tiết";
            // 
            // Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 374);
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
    }
}