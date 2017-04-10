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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.control_panel = new System.Windows.Forms.Panel();
            this.btn_main_account = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_main_Statistic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_main_Manage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.top_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_SoftName = new Bunifu.Framework.UI.BunifuImageButton();
            this.SoftWareName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_hide = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_expand = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_system_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelTransit = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.control_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SoftName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_expand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_system_exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // control_panel
            // 
            this.control_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.control_panel.BackColor = System.Drawing.Color.SeaGreen;
            this.control_panel.Controls.Add(this.btn_main_account);
            this.control_panel.Controls.Add(this.btn_main_Statistic);
            this.control_panel.Controls.Add(this.btn_main_Manage);
            this.panelTransit.SetDecoration(this.control_panel, BunifuAnimatorNS.DecorationType.None);
            this.control_panel.Location = new System.Drawing.Point(0, 39);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(185, 549);
            this.control_panel.TabIndex = 5;
            // 
            // btn_main_account
            // 
            this.btn_main_account.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btn_main_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_main_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_main_account.BorderRadius = 0;
            this.btn_main_account.ButtonText = "     Tài Khoản";
            this.btn_main_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransit.SetDecoration(this.btn_main_account, BunifuAnimatorNS.DecorationType.None);
            this.btn_main_account.DisabledColor = System.Drawing.Color.Gray;
            this.btn_main_account.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_main_account.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_main_account.Iconimage")));
            this.btn_main_account.Iconimage_right = null;
            this.btn_main_account.Iconimage_right_Selected = null;
            this.btn_main_account.Iconimage_Selected = null;
            this.btn_main_account.IconMarginLeft = 0;
            this.btn_main_account.IconMarginRight = 0;
            this.btn_main_account.IconRightVisible = true;
            this.btn_main_account.IconRightZoom = 0D;
            this.btn_main_account.IconVisible = true;
            this.btn_main_account.IconZoom = 80D;
            this.btn_main_account.IsTab = true;
            this.btn_main_account.Location = new System.Drawing.Point(0, 303);
            this.btn_main_account.Name = "btn_main_account";
            this.btn_main_account.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_main_account.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_main_account.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_main_account.selected = false;
            this.btn_main_account.Size = new System.Drawing.Size(185, 48);
            this.btn_main_account.TabIndex = 12;
            this.btn_main_account.Text = "     Tài Khoản";
            this.btn_main_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_account.Textcolor = System.Drawing.Color.Black;
            this.btn_main_account.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_account.Click += new System.EventHandler(this.btn_main_account_Click);
            // 
            // btn_main_Statistic
            // 
            this.btn_main_Statistic.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btn_main_Statistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_main_Statistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_main_Statistic.BorderRadius = 0;
            this.btn_main_Statistic.ButtonText = "     Thống Kê";
            this.btn_main_Statistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransit.SetDecoration(this.btn_main_Statistic, BunifuAnimatorNS.DecorationType.None);
            this.btn_main_Statistic.DisabledColor = System.Drawing.Color.Gray;
            this.btn_main_Statistic.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_main_Statistic.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_main_Statistic.Iconimage")));
            this.btn_main_Statistic.Iconimage_right = null;
            this.btn_main_Statistic.Iconimage_right_Selected = null;
            this.btn_main_Statistic.Iconimage_Selected = null;
            this.btn_main_Statistic.IconMarginLeft = 0;
            this.btn_main_Statistic.IconMarginRight = 0;
            this.btn_main_Statistic.IconRightVisible = true;
            this.btn_main_Statistic.IconRightZoom = 0D;
            this.btn_main_Statistic.IconVisible = true;
            this.btn_main_Statistic.IconZoom = 90D;
            this.btn_main_Statistic.IsTab = true;
            this.btn_main_Statistic.Location = new System.Drawing.Point(0, 249);
            this.btn_main_Statistic.Name = "btn_main_Statistic";
            this.btn_main_Statistic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_main_Statistic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_main_Statistic.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_main_Statistic.selected = false;
            this.btn_main_Statistic.Size = new System.Drawing.Size(182, 48);
            this.btn_main_Statistic.TabIndex = 10;
            this.btn_main_Statistic.Text = "     Thống Kê";
            this.btn_main_Statistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_Statistic.Textcolor = System.Drawing.Color.Black;
            this.btn_main_Statistic.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_Statistic.Click += new System.EventHandler(this.btn_main_Statistic_Click);
            // 
            // btn_main_Manage
            // 
            this.btn_main_Manage.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btn_main_Manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_main_Manage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_main_Manage.BorderRadius = 0;
            this.btn_main_Manage.ButtonText = "     Quản Lí";
            this.btn_main_Manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransit.SetDecoration(this.btn_main_Manage, BunifuAnimatorNS.DecorationType.None);
            this.btn_main_Manage.DisabledColor = System.Drawing.Color.Gray;
            this.btn_main_Manage.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_main_Manage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_main_Manage.Iconimage")));
            this.btn_main_Manage.Iconimage_right = null;
            this.btn_main_Manage.Iconimage_right_Selected = null;
            this.btn_main_Manage.Iconimage_Selected = null;
            this.btn_main_Manage.IconMarginLeft = 0;
            this.btn_main_Manage.IconMarginRight = 0;
            this.btn_main_Manage.IconRightVisible = true;
            this.btn_main_Manage.IconRightZoom = 0D;
            this.btn_main_Manage.IconVisible = true;
            this.btn_main_Manage.IconZoom = 90D;
            this.btn_main_Manage.IsTab = true;
            this.btn_main_Manage.Location = new System.Drawing.Point(1, 195);
            this.btn_main_Manage.Name = "btn_main_Manage";
            this.btn_main_Manage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_main_Manage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_main_Manage.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_main_Manage.selected = true;
            this.btn_main_Manage.Size = new System.Drawing.Size(184, 48);
            this.btn_main_Manage.TabIndex = 9;
            this.btn_main_Manage.Text = "     Quản Lí";
            this.btn_main_Manage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_Manage.Textcolor = System.Drawing.Color.Black;
            this.btn_main_Manage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_Manage.Click += new System.EventHandler(this.btn_main_Manage_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top_panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.top_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top_panel.BackgroundImage")));
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.Controls.Add(this.btn_SoftName);
            this.top_panel.Controls.Add(this.SoftWareName);
            this.top_panel.Controls.Add(this.btn_hide);
            this.top_panel.Controls.Add(this.btn_expand);
            this.top_panel.Controls.Add(this.btn_system_exit);
            this.panelTransit.SetDecoration(this.top_panel, BunifuAnimatorNS.DecorationType.None);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.top_panel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.top_panel.GradientTopLeft = System.Drawing.Color.MediumSpringGreen;
            this.top_panel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Quality = 10;
            this.top_panel.Size = new System.Drawing.Size(1074, 39);
            this.top_panel.TabIndex = 2;
            // 
            // btn_SoftName
            // 
            this.btn_SoftName.BackColor = System.Drawing.Color.Transparent;
            this.panelTransit.SetDecoration(this.btn_SoftName, BunifuAnimatorNS.DecorationType.None);
            this.btn_SoftName.Image = ((System.Drawing.Image)(resources.GetObject("btn_SoftName.Image")));
            this.btn_SoftName.ImageActive = null;
            this.btn_SoftName.Location = new System.Drawing.Point(12, 0);
            this.btn_SoftName.Name = "btn_SoftName";
            this.btn_SoftName.Size = new System.Drawing.Size(26, 39);
            this.btn_SoftName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_SoftName.TabIndex = 4;
            this.btn_SoftName.TabStop = false;
            this.btn_SoftName.Zoom = 20;
            // 
            // SoftWareName
            // 
            this.SoftWareName.AutoSize = true;
            this.SoftWareName.BackColor = System.Drawing.Color.Transparent;
            this.panelTransit.SetDecoration(this.SoftWareName, BunifuAnimatorNS.DecorationType.None);
            this.SoftWareName.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftWareName.ForeColor = System.Drawing.Color.White;
            this.SoftWareName.Location = new System.Drawing.Point(36, -2);
            this.SoftWareName.Name = "SoftWareName";
            this.SoftWareName.Size = new System.Drawing.Size(200, 35);
            this.SoftWareName.TabIndex = 3;
            this.SoftWareName.Text = "Quản Lý Bán Hàng";
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.panelTransit.SetDecoration(this.btn_hide, BunifuAnimatorNS.DecorationType.None);
            this.btn_hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide.Image")));
            this.btn_hide.ImageActive = null;
            this.btn_hide.Location = new System.Drawing.Point(996, 0);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(26, 39);
            this.btn_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_hide.TabIndex = 0;
            this.btn_hide.TabStop = false;
            this.btn_hide.Zoom = 20;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_expand
            // 
            this.btn_expand.BackColor = System.Drawing.Color.Transparent;
            this.panelTransit.SetDecoration(this.btn_expand, BunifuAnimatorNS.DecorationType.None);
            this.btn_expand.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_expand.Image = ((System.Drawing.Image)(resources.GetObject("btn_expand.Image")));
            this.btn_expand.ImageActive = null;
            this.btn_expand.Location = new System.Drawing.Point(1022, 0);
            this.btn_expand.Name = "btn_expand";
            this.btn_expand.Size = new System.Drawing.Size(26, 39);
            this.btn_expand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_expand.TabIndex = 2;
            this.btn_expand.TabStop = false;
            this.btn_expand.Zoom = 20;
            this.btn_expand.Click += new System.EventHandler(this.btn_system_close_Click);
            // 
            // btn_system_exit
            // 
            this.btn_system_exit.BackColor = System.Drawing.Color.Transparent;
            this.panelTransit.SetDecoration(this.btn_system_exit, BunifuAnimatorNS.DecorationType.None);
            this.btn_system_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_system_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_system_exit.Image")));
            this.btn_system_exit.ImageActive = null;
            this.btn_system_exit.Location = new System.Drawing.Point(1048, 0);
            this.btn_system_exit.Name = "btn_system_exit";
            this.btn_system_exit.Size = new System.Drawing.Size(26, 39);
            this.btn_system_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_system_exit.TabIndex = 1;
            this.btn_system_exit.TabStop = false;
            this.btn_system_exit.Zoom = 20;
            this.btn_system_exit.Click += new System.EventHandler(this.btn_expand_Click);
            // 
            // panelTransit
            // 
            this.panelTransit.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.panelTransit.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelTransit.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.top_panel);
            this.panel1.Controls.Add(this.viewPanel);
            this.panelTransit.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 588);
            this.panel1.TabIndex = 7;
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.BackColor = System.Drawing.Color.DimGray;
            this.panelTransit.SetDecoration(this.viewPanel, BunifuAnimatorNS.DecorationType.None);
            this.viewPanel.Location = new System.Drawing.Point(181, 39);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewPanel.Size = new System.Drawing.Size(893, 549);
            this.viewPanel.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 588);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.panel1);
            this.panelTransit.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Text = "realmainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.control_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SoftName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_expand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_system_exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel control_panel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_main_Statistic;
        private Bunifu.Framework.UI.BunifuFlatButton btn_main_Manage;
        private Bunifu.Framework.UI.BunifuImageButton btn_hide;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition panelTransit;
        private Bunifu.Framework.UI.BunifuImageButton btn_expand;
        private Bunifu.Framework.UI.BunifuImageButton btn_system_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel viewPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel SoftWareName;
        private Bunifu.Framework.UI.BunifuImageButton btn_SoftName;
        private Bunifu.Framework.UI.BunifuFlatButton btn_main_account;
        private Bunifu.Framework.UI.BunifuGradientPanel top_panel;
    }
}