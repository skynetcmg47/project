namespace sellingWooden
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_userName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lb_userName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_pass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lb_notice = new System.Windows.Forms.Label();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Signin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pn_sign_top = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_SignIn_hide = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_signIn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pn_sign_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SignIn_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_signIn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_userName
            // 
            this.txt_userName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_userName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_userName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_userName.BorderThickness = 3;
            this.txt_userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_userName.isPassword = false;
            this.txt_userName.Location = new System.Drawing.Point(204, 65);
            this.txt_userName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(237, 31);
            this.txt_userName.TabIndex = 3;
            this.txt_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_pass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pass.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_pass.BorderThickness = 3;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pass.isPassword = false;
            this.txt_pass.Location = new System.Drawing.Point(204, 120);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(237, 31);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.Location = new System.Drawing.Point(51, 65);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(142, 26);
            this.lb_userName.TabIndex = 5;
            this.lb_userName.Text = "Tên đăng nhập:";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(51, 125);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(96, 26);
            this.lb_pass.TabIndex = 6;
            this.lb_pass.Text = "Mật khẩu:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_sign_top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lb_notice
            // 
            this.lb_notice.AutoSize = true;
            this.lb_notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_notice.Location = new System.Drawing.Point(200, 41);
            this.lb_notice.Name = "lb_notice";
            this.lb_notice.Size = new System.Drawing.Size(0, 20);
            this.lb_notice.TabIndex = 10;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveBorderThickness = 1;
            this.btn_cancel.ActiveCornerRadius = 20;
            this.btn_cancel.ActiveFillColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cancel.ActiveForecolor = System.Drawing.Color.White;
            this.btn_cancel.ActiveLineColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.ButtonText = "Thoát";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.IdleBorderThickness = 1;
            this.btn_cancel.IdleCornerRadius = 20;
            this.btn_cancel.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancel.IdleForecolor = System.Drawing.Color.White;
            this.btn_cancel.IdleLineColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cancel.Location = new System.Drawing.Point(257, 186);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(153, 41);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Signin
            // 
            this.btn_Signin.ActiveBorderThickness = 1;
            this.btn_Signin.ActiveCornerRadius = 20;
            this.btn_Signin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_Signin.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Signin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_Signin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Signin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Signin.BackgroundImage")));
            this.btn_Signin.ButtonText = "Đăng Nhập";
            this.btn_Signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Signin.IdleBorderThickness = 1;
            this.btn_Signin.IdleCornerRadius = 20;
            this.btn_Signin.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Signin.IdleForecolor = System.Drawing.Color.White;
            this.btn_Signin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_Signin.Location = new System.Drawing.Point(82, 186);
            this.btn_Signin.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(153, 41);
            this.btn_Signin.TabIndex = 8;
            this.btn_Signin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // pn_sign_top
            // 
            this.pn_sign_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pn_sign_top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_sign_top.BackgroundImage")));
            this.pn_sign_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_sign_top.Controls.Add(this.btn_SignIn_hide);
            this.pn_sign_top.Controls.Add(this.btn_signIn_close);
            this.pn_sign_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_sign_top.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pn_sign_top.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pn_sign_top.GradientTopLeft = System.Drawing.Color.MediumSpringGreen;
            this.pn_sign_top.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pn_sign_top.Location = new System.Drawing.Point(0, 0);
            this.pn_sign_top.Name = "pn_sign_top";
            this.pn_sign_top.Quality = 10;
            this.pn_sign_top.Size = new System.Drawing.Size(504, 24);
            this.pn_sign_top.TabIndex = 0;
            // 
            // btn_SignIn_hide
            // 
            this.btn_SignIn_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_SignIn_hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SignIn_hide.Image = ((System.Drawing.Image)(resources.GetObject("btn_SignIn_hide.Image")));
            this.btn_SignIn_hide.ImageActive = null;
            this.btn_SignIn_hide.Location = new System.Drawing.Point(452, 0);
            this.btn_SignIn_hide.Name = "btn_SignIn_hide";
            this.btn_SignIn_hide.Size = new System.Drawing.Size(26, 24);
            this.btn_SignIn_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_SignIn_hide.TabIndex = 3;
            this.btn_SignIn_hide.TabStop = false;
            this.btn_SignIn_hide.Zoom = 20;
            this.btn_SignIn_hide.Click += new System.EventHandler(this.btn_SignIn_hide_Click);
            // 
            // btn_signIn_close
            // 
            this.btn_signIn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_signIn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_signIn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_signIn_close.Image")));
            this.btn_signIn_close.ImageActive = null;
            this.btn_signIn_close.Location = new System.Drawing.Point(478, 0);
            this.btn_signIn_close.Name = "btn_signIn_close";
            this.btn_signIn_close.Size = new System.Drawing.Size(26, 24);
            this.btn_signIn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_signIn_close.TabIndex = 5;
            this.btn_signIn_close.TabStop = false;
            this.btn_signIn_close.Zoom = 20;
            this.btn_signIn_close.Click += new System.EventHandler(this.btn_signIn_close_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.lb_notice);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Signin);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_userName);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.pn_sign_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.pn_sign_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_SignIn_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_signIn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel pn_sign_top;
        private Bunifu.Framework.UI.BunifuImageButton btn_SignIn_hide;
        private Bunifu.Framework.UI.BunifuImageButton btn_signIn_close;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_userName;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_userName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_pass;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_pass;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Signin;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lb_notice;
    }
}