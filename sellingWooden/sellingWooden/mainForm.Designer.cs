namespace sellingWooden
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.userNameAndPassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainForm_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.userNameAndPassBindingSource)).BeginInit();
            this.mainForm_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameAndPassBindingSource
            // 
            this.userNameAndPassBindingSource.DataMember = "UserNameAndPass";
            // 
            // mainForm_tabControl
            // 
            this.mainForm_tabControl.Controls.Add(this.tabPage1);
            this.mainForm_tabControl.Controls.Add(this.tabPage2);
            this.mainForm_tabControl.Controls.Add(this.tabPage3);
            this.mainForm_tabControl.Controls.Add(this.tabPage4);
            this.mainForm_tabControl.Controls.Add(this.tabPage5);
            this.mainForm_tabControl.Controls.Add(this.tabPage6);
            this.mainForm_tabControl.Location = new System.Drawing.Point(0, 0);
            this.mainForm_tabControl.Name = "mainForm_tabControl";
            this.mainForm_tabControl.SelectedIndex = 0;
            this.mainForm_tabControl.Size = new System.Drawing.Size(899, 607);
            this.mainForm_tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SẢN PHẨM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "KHÁCH HÀNG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(891, 581);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LOẠI SẢN PHẨM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(891, 581);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "HÓA ĐƠN";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(891, 581);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = " CHI TIẾT HÓA ĐƠN";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(891, 581);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "NHÂN VIÊN";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 608);
            this.Controls.Add(this.mainForm_tabControl);
            this.Name = "mainForm";
            this.Text = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.userNameAndPassBindingSource)).EndInit();
            this.mainForm_tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userNameAndPassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl mainForm_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}

