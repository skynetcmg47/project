namespace sellingWooden
{
    partial class Employee
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
            this.cbo_Employee_Sex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Employee_Note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Employee_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Employee_TEL = new System.Windows.Forms.TextBox();
            this.txt_Employee_EmployeeID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Employee_NOE = new System.Windows.Forms.TextBox();
            this.txt_Employee_Position = new System.Windows.Forms.ComboBox();
            this.dtm_Employee_DOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.but_Employee_Statistic = new System.Windows.Forms.Button();
            this.but_Employee_Edit = new System.Windows.Forms.Button();
            this.but_Employee_Delete = new System.Windows.Forms.Button();
            this.but_Employee_Refresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_Employee_Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Employee_InformationEmployeeDetail = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_InformationEmployeeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Employee_Sex
            // 
            this.cbo_Employee_Sex.FormattingEnabled = true;
            this.cbo_Employee_Sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_Employee_Sex.Location = new System.Drawing.Point(109, 119);
            this.cbo_Employee_Sex.Name = "cbo_Employee_Sex";
            this.cbo_Employee_Sex.Size = new System.Drawing.Size(71, 21);
            this.cbo_Employee_Sex.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên :";
            // 
            // txt_Employee_Note
            // 
            this.txt_Employee_Note.AllowDrop = true;
            this.txt_Employee_Note.Location = new System.Drawing.Point(369, 119);
            this.txt_Employee_Note.Multiline = true;
            this.txt_Employee_Note.Name = "txt_Employee_Note";
            this.txt_Employee_Note.Size = new System.Drawing.Size(185, 66);
            this.txt_Employee_Note.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ghi Chú :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh :";
            // 
            // txt_Employee_Address
            // 
            this.txt_Employee_Address.Location = new System.Drawing.Point(369, 86);
            this.txt_Employee_Address.Name = "txt_Employee_Address";
            this.txt_Employee_Address.Size = new System.Drawing.Size(185, 20);
            this.txt_Employee_Address.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới Tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Địa Chỉ :";
            // 
            // txt_Employee_TEL
            // 
            this.txt_Employee_TEL.Location = new System.Drawing.Point(369, 56);
            this.txt_Employee_TEL.Name = "txt_Employee_TEL";
            this.txt_Employee_TEL.Size = new System.Drawing.Size(110, 20);
            this.txt_Employee_TEL.TabIndex = 12;
            // 
            // txt_Employee_EmployeeID
            // 
            this.txt_Employee_EmployeeID.Location = new System.Drawing.Point(109, 26);
            this.txt_Employee_EmployeeID.Name = "txt_Employee_EmployeeID";
            this.txt_Employee_EmployeeID.Size = new System.Drawing.Size(176, 20);
            this.txt_Employee_EmployeeID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "SĐT :";
            // 
            // txt_Employee_NOE
            // 
            this.txt_Employee_NOE.Location = new System.Drawing.Point(109, 56);
            this.txt_Employee_NOE.Name = "txt_Employee_NOE";
            this.txt_Employee_NOE.Size = new System.Drawing.Size(176, 20);
            this.txt_Employee_NOE.TabIndex = 7;
            // 
            // txt_Employee_Position
            // 
            this.txt_Employee_Position.FormattingEnabled = true;
            this.txt_Employee_Position.Location = new System.Drawing.Point(369, 25);
            this.txt_Employee_Position.Name = "txt_Employee_Position";
            this.txt_Employee_Position.Size = new System.Drawing.Size(79, 21);
            this.txt_Employee_Position.TabIndex = 10;
            // 
            // dtm_Employee_DOB
            // 
            this.dtm_Employee_DOB.Location = new System.Drawing.Point(109, 86);
            this.dtm_Employee_DOB.Name = "dtm_Employee_DOB";
            this.dtm_Employee_DOB.Size = new System.Drawing.Size(176, 20);
            this.dtm_Employee_DOB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Chức Vụ :";
            // 
            // but_Employee_Statistic
            // 
            this.but_Employee_Statistic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Employee_Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Employee_Statistic.Location = new System.Drawing.Point(5, 132);
            this.but_Employee_Statistic.Name = "but_Employee_Statistic";
            this.but_Employee_Statistic.Size = new System.Drawing.Size(125, 53);
            this.but_Employee_Statistic.TabIndex = 4;
            this.but_Employee_Statistic.Text = "Thống Kê";
            this.but_Employee_Statistic.UseVisualStyleBackColor = false;
            // 
            // but_Employee_Edit
            // 
            this.but_Employee_Edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Employee_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Employee_Edit.Location = new System.Drawing.Point(70, 19);
            this.but_Employee_Edit.Name = "but_Employee_Edit";
            this.but_Employee_Edit.Size = new System.Drawing.Size(60, 71);
            this.but_Employee_Edit.TabIndex = 3;
            this.but_Employee_Edit.Text = "Sửa ";
            this.but_Employee_Edit.UseVisualStyleBackColor = false;
            // 
            // but_Employee_Delete
            // 
            this.but_Employee_Delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Employee_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Employee_Delete.Location = new System.Drawing.Point(69, 76);
            this.but_Employee_Delete.Name = "but_Employee_Delete";
            this.but_Employee_Delete.Size = new System.Drawing.Size(61, 70);
            this.but_Employee_Delete.TabIndex = 2;
            this.but_Employee_Delete.Text = "Xóa";
            this.but_Employee_Delete.UseVisualStyleBackColor = false;
            this.but_Employee_Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // but_Employee_Refresh
            // 
            this.but_Employee_Refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Employee_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Employee_Refresh.Location = new System.Drawing.Point(5, 76);
            this.but_Employee_Refresh.Name = "but_Employee_Refresh";
            this.but_Employee_Refresh.Size = new System.Drawing.Size(61, 70);
            this.but_Employee_Refresh.TabIndex = 1;
            this.but_Employee_Refresh.Text = "Làm Mới";
            this.but_Employee_Refresh.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_Employee_Statistic);
            this.groupBox2.Controls.Add(this.but_Employee_Edit);
            this.groupBox2.Controls.Add(this.but_Employee_Delete);
            this.groupBox2.Controls.Add(this.but_Employee_Refresh);
            this.groupBox2.Controls.Add(this.but_Employee_Add);
            this.groupBox2.Location = new System.Drawing.Point(587, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 195);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // but_Employee_Add
            // 
            this.but_Employee_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Employee_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_Employee_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Employee_Add.ImageKey = "(none)";
            this.but_Employee_Add.Location = new System.Drawing.Point(5, 19);
            this.but_Employee_Add.Name = "but_Employee_Add";
            this.but_Employee_Add.Size = new System.Drawing.Size(61, 71);
            this.but_Employee_Add.TabIndex = 0;
            this.but_Employee_Add.Text = "Thêm";
            this.but_Employee_Add.UseVisualStyleBackColor = false;
            this.but_Employee_Add.Click += new System.EventHandler(this.but_Employee_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.cbo_Employee_Sex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Employee_Note);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Employee_Address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Employee_TEL);
            this.groupBox1.Controls.Add(this.txt_Employee_EmployeeID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Employee_NOE);
            this.groupBox1.Controls.Add(this.txt_Employee_Position);
            this.groupBox1.Controls.Add(this.dtm_Employee_DOB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(17, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 195);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 73);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thông tin Nhân Viên";
            // 
            // dgv_Employee_InformationEmployeeDetail
            // 
            this.dgv_Employee_InformationEmployeeDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee_InformationEmployeeDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_InformationEmployeeDetail.Location = new System.Drawing.Point(16, 308);
            this.dgv_Employee_InformationEmployeeDetail.Name = "dgv_Employee_InformationEmployeeDetail";
            this.dgv_Employee_InformationEmployeeDetail.Size = new System.Drawing.Size(724, 186);
            this.dgv_Employee_InformationEmployeeDetail.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Thông tin nhân viên chi tiết";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 520);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Employee_InformationEmployeeDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_InformationEmployeeDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Employee_Sex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Employee_Note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Employee_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Employee_TEL;
        private System.Windows.Forms.TextBox txt_Employee_EmployeeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Employee_NOE;
        private System.Windows.Forms.ComboBox txt_Employee_Position;
        private System.Windows.Forms.DateTimePicker dtm_Employee_DOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button but_Employee_Statistic;
        private System.Windows.Forms.Button but_Employee_Edit;
        private System.Windows.Forms.Button but_Employee_Delete;
        private System.Windows.Forms.Button but_Employee_Refresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_Employee_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Employee_InformationEmployeeDetail;
        private System.Windows.Forms.Label label10;
    }
}