namespace sellingWooden
{
    partial class frmType_Edit
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
            this.txt_frmTypeID_Edit_TypeID = new System.Windows.Forms.TextBox();
            this.txt_frmType_Edit_NOT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_type_edit_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Loại";
            // 
            // txt_frmTypeID_Edit_TypeID
            // 
            this.txt_frmTypeID_Edit_TypeID.Location = new System.Drawing.Point(106, 53);
            this.txt_frmTypeID_Edit_TypeID.Name = "txt_frmTypeID_Edit_TypeID";
            this.txt_frmTypeID_Edit_TypeID.ReadOnly = true;
            this.txt_frmTypeID_Edit_TypeID.Size = new System.Drawing.Size(146, 20);
            this.txt_frmTypeID_Edit_TypeID.TabIndex = 2;
            // 
            // txt_frmType_Edit_NOT
            // 
            this.txt_frmType_Edit_NOT.Location = new System.Drawing.Point(106, 124);
            this.txt_frmType_Edit_NOT.Name = "txt_frmType_Edit_NOT";
            this.txt_frmType_Edit_NOT.Size = new System.Drawing.Size(146, 20);
            this.txt_frmType_Edit_NOT.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_type_edit_ok
            // 
            this.btn_type_edit_ok.Location = new System.Drawing.Point(213, 187);
            this.btn_type_edit_ok.Name = "btn_type_edit_ok";
            this.btn_type_edit_ok.Size = new System.Drawing.Size(88, 33);
            this.btn_type_edit_ok.TabIndex = 5;
            this.btn_type_edit_ok.Text = "OK";
            this.btn_type_edit_ok.UseVisualStyleBackColor = true;
            this.btn_type_edit_ok.Click += new System.EventHandler(this.btn_type_edit_ok_Click);
            // 
            // frmType_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 289);
            this.Controls.Add(this.btn_type_edit_ok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_frmType_Edit_NOT);
            this.Controls.Add(this.txt_frmTypeID_Edit_TypeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmType_Edit";
            this.Text = "frmType_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_frmTypeID_Edit_TypeID;
        private System.Windows.Forms.TextBox txt_frmType_Edit_NOT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_type_edit_ok;
    }
}