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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btn_home = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_main_Statistics = new System.Windows.Forms.Button();
            this.btn_main_Manage = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.White;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_home.Location = new System.Drawing.Point(4, 11);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(128, 128);
            this.btn_home.TabIndex = 0;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_main_Statistics);
            this.groupBox1.Controls.Add(this.btn_main_Manage);
            this.groupBox1.Controls.Add(this.btn_home);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 554);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_main_Statistics
            // 
            this.btn_main_Statistics.BackColor = System.Drawing.Color.White;
            this.btn_main_Statistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_main_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_Statistics.Image = ((System.Drawing.Image)(resources.GetObject("btn_main_Statistics.Image")));
            this.btn_main_Statistics.Location = new System.Drawing.Point(4, 279);
            this.btn_main_Statistics.Name = "btn_main_Statistics";
            this.btn_main_Statistics.Size = new System.Drawing.Size(128, 128);
            this.btn_main_Statistics.TabIndex = 2;
            this.btn_main_Statistics.UseVisualStyleBackColor = false;
            // 
            // btn_main_Manage
            // 
            this.btn_main_Manage.BackColor = System.Drawing.Color.White;
            this.btn_main_Manage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_main_Manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_Manage.Image = ((System.Drawing.Image)(resources.GetObject("btn_main_Manage.Image")));
            this.btn_main_Manage.Location = new System.Drawing.Point(5, 145);
            this.btn_main_Manage.Name = "btn_main_Manage";
            this.btn_main_Manage.Size = new System.Drawing.Size(128, 128);
            this.btn_main_Manage.TabIndex = 1;
            this.btn_main_Manage.UseVisualStyleBackColor = false;
            this.btn_main_Manage.Click += new System.EventHandler(this.btn_main_Manage_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Location = new System.Drawing.Point(142, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(885, 546);
            this.mainPanel.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 563);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.Text = "realmainForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btn_main_Statistics;
        private System.Windows.Forms.Button btn_main_Manage;
    }
}