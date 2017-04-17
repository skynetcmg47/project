namespace sellingWooden
{
    partial class frmSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSell));
            this.tf_Product_Type = new System.Windows.Forms.ListBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tf_Product = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbCustomerName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_totalPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbb_CustomerID = new System.Windows.Forms.ComboBox();
            this.dtgv_sell = new System.Windows.Forms.DataGridView();
            this.cbb_EmployeeID = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_BillID = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_new = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_PrinBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Add_Customer = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // tf_Product_Type
            // 
            this.tf_Product_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tf_Product_Type.FormattingEnabled = true;
            this.tf_Product_Type.Items.AddRange(new object[] {
            "----Tất cả----"});
            this.tf_Product_Type.Location = new System.Drawing.Point(12, 245);
            this.tf_Product_Type.Name = "tf_Product_Type";
            this.tf_Product_Type.Size = new System.Drawing.Size(140, 251);
            this.tf_Product_Type.TabIndex = 37;
            this.tf_Product_Type.SelectedIndexChanged += new System.EventHandler(this.tf_Product_Type_SelectedIndexChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tf_Product
            // 
            this.tf_Product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tf_Product.FormattingEnabled = true;
            this.tf_Product.Location = new System.Drawing.Point(153, 245);
            this.tf_Product.Name = "tf_Product";
            this.tf_Product.Size = new System.Drawing.Size(139, 251);
            this.tf_Product.TabIndex = 38;
            this.tf_Product.SelectedIndexChanged += new System.EventHandler(this.tf_Product_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(36, 33);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(41, 13);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Mã HD";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(36, 78);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(44, 13);
            this.lbCustomerName.TabIndex = 43;
            this.lbCustomerName.Text = "Tên KH";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(34, 119);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(43, 13);
            this.bunifuCustomLabel2.TabIndex = 49;
            this.bunifuCustomLabel2.Text = "Tên SP";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 160);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 13);
            this.bunifuCustomLabel3.TabIndex = 51;
            this.bunifuCustomLabel3.Text = "Số lượng";
            // 
            // txt_totalPrice
            // 
            this.txt_totalPrice.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_totalPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalPrice.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_totalPrice.BorderThickness = 3;
            this.txt_totalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_totalPrice.Enabled = false;
            this.txt_totalPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_totalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_totalPrice.isPassword = false;
            this.txt_totalPrice.Location = new System.Drawing.Point(650, 69);
            this.txt_totalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalPrice.Name = "txt_totalPrice";
            this.txt_totalPrice.Size = new System.Drawing.Size(204, 28);
            this.txt_totalPrice.TabIndex = 52;
            this.txt_totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(581, 77);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(62, 13);
            this.bunifuCustomLabel4.TabIndex = 53;
            this.bunifuCustomLabel4.Text = "Thành Tiền";
            // 
            // cbb_CustomerID
            // 
            this.cbb_CustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_CustomerID.FormattingEnabled = true;
            this.cbb_CustomerID.Location = new System.Drawing.Point(84, 70);
            this.cbb_CustomerID.Name = "cbb_CustomerID";
            this.cbb_CustomerID.Size = new System.Drawing.Size(174, 21);
            this.cbb_CustomerID.TabIndex = 55;
            // 
            // dtgv_sell
            // 
            this.dtgv_sell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_sell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_sell.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sell.Location = new System.Drawing.Point(298, 219);
            this.dtgv_sell.Name = "dtgv_sell";
            this.dtgv_sell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgv_sell.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_sell.Size = new System.Drawing.Size(593, 279);
            this.dtgv_sell.TabIndex = 58;
            this.dtgv_sell.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sell_CellValueChanged);
            // 
            // cbb_EmployeeID
            // 
            this.cbb_EmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_EmployeeID.FormattingEnabled = true;
            this.cbb_EmployeeID.Location = new System.Drawing.Point(84, 201);
            this.cbb_EmployeeID.Name = "cbb_EmployeeID";
            this.cbb_EmployeeID.Size = new System.Drawing.Size(174, 21);
            this.cbb_EmployeeID.TabIndex = 60;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(36, 209);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(44, 13);
            this.bunifuCustomLabel5.TabIndex = 59;
            this.bunifuCustomLabel5.Text = "Tên NV";
            // 
            // txt_BillID
            // 
            this.txt_BillID.Location = new System.Drawing.Point(84, 30);
            this.txt_BillID.MaxLength = 6;
            this.txt_BillID.Name = "txt_BillID";
            this.txt_BillID.ReadOnly = true;
            this.txt_BillID.Size = new System.Drawing.Size(174, 20);
            this.txt_BillID.TabIndex = 61;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(84, 116);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.ReadOnly = true;
            this.txt_ProductID.Size = new System.Drawing.Size(174, 20);
            this.txt_ProductID.TabIndex = 62;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(84, 160);
            this.txt_amount.MaxLength = 6;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(174, 20);
            this.txt_amount.TabIndex = 63;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // btn_new
            // 
            this.btn_new.ActiveBorderThickness = 1;
            this.btn_new.ActiveCornerRadius = 20;
            this.btn_new.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_new.ActiveForecolor = System.Drawing.Color.White;
            this.btn_new.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_new.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_new.BackgroundImage")));
            this.btn_new.ButtonText = "Hóa Đơn Mới";
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_new.IdleBorderThickness = 1;
            this.btn_new.IdleCornerRadius = 20;
            this.btn_new.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_new.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_new.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_new.Location = new System.Drawing.Point(340, 119);
            this.btn_new.Margin = new System.Windows.Forms.Padding(5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(153, 41);
            this.btn_new.TabIndex = 64;
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Thêm";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_add.Location = new System.Drawing.Point(340, 69);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(153, 41);
            this.btn_add.TabIndex = 56;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_PrinBill
            // 
            this.btn_PrinBill.ActiveBorderThickness = 1;
            this.btn_PrinBill.ActiveCornerRadius = 20;
            this.btn_PrinBill.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_PrinBill.ActiveForecolor = System.Drawing.Color.White;
            this.btn_PrinBill.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_PrinBill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_PrinBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PrinBill.BackgroundImage")));
            this.btn_PrinBill.ButtonText = "In Hóa Đơn";
            this.btn_PrinBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PrinBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrinBill.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_PrinBill.IdleBorderThickness = 1;
            this.btn_PrinBill.IdleCornerRadius = 20;
            this.btn_PrinBill.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_PrinBill.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_PrinBill.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_PrinBill.Location = new System.Drawing.Point(677, 116);
            this.btn_PrinBill.Margin = new System.Windows.Forms.Padding(5);
            this.btn_PrinBill.Name = "btn_PrinBill";
            this.btn_PrinBill.Size = new System.Drawing.Size(153, 41);
            this.btn_PrinBill.TabIndex = 54;
            this.btn_PrinBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PrinBill.Click += new System.EventHandler(this.btn_PrinBill_Click);
            // 
            // btn_Add_Customer
            // 
            this.btn_Add_Customer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add_Customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add_Customer.Image")));
            this.btn_Add_Customer.ImageActive = null;
            this.btn_Add_Customer.Location = new System.Drawing.Point(264, 69);
            this.btn_Add_Customer.Name = "btn_Add_Customer";
            this.btn_Add_Customer.Size = new System.Drawing.Size(33, 26);
            this.btn_Add_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Add_Customer.TabIndex = 47;
            this.btn_Add_Customer.TabStop = false;
            this.btn_Add_Customer.Zoom = 10;
            this.btn_Add_Customer.Click += new System.EventHandler(this.btn_Add_Customer_Click);
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(897, 510);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.txt_BillID);
            this.Controls.Add(this.cbb_EmployeeID);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dtgv_sell);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbb_CustomerID);
            this.Controls.Add(this.btn_PrinBill);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txt_totalPrice);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btn_Add_Customer);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tf_Product);
            this.Controls.Add(this.tf_Product_Type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSell";
            this.Text = "frmSell";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tf_Product_Type;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ListBox tf_Product;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCustomerName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_totalPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton btn_Add_Customer;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_PrinBill;
        private System.Windows.Forms.ComboBox cbb_CustomerID;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private System.Windows.Forms.DataGridView dtgv_sell;
        private System.Windows.Forms.ComboBox cbb_EmployeeID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TextBox txt_BillID;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.TextBox txt_amount;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_new;
    }
}