﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sellingWooden
{
    public partial class frmSell : Form
    {
        private bool isPrintBill = false;
        private SQLHelp help = new SQLHelp();
        private string BillID, CustomerID, ProductID, Amount, EmployeeID;
        public frmSell()
        {
            InitializeComponent();
            help.Excute_query("delete from sell");
            InitTypeTextFiel();
            InitSellDtgv();
            InitCustomerCbb();
            InitEmployeeIDCbb();
            InitTxtBillID();

        }
        private void InitTypeTextFiel()
        {
            string sql = "select Type.TypeID,Type.TypeName from Type";
            tf_Product_Type.DisplayMember = "TypeName";
            tf_Product_Type.ValueMember = "TypeID";
            DataTable tb = help.getDataTable_excute(sql);
            tf_Product_Type.DataSource = tb;

        }
        private void InitEmployeeIDCbb()
        {
            //khoi tao combobox
            cbb_EmployeeID.DataSource = help.getDataCbb("Employee");
            //hien thi ten nhan vien len dtgv
            cbb_EmployeeID.DisplayMember = "EmployeeName";
            //gia tri cua cbb la ma nhan vien
            cbb_EmployeeID.ValueMember = "EmployeeID";
        }

        private void InitProductFiel(string TypeID)
        {
            try
            {
                string sql = "select Product.ProductID,Product.ProductName from Product Where Product.ProductTypeID ='" + TypeID + "'";
                tf_Product.DisplayMember = "ProductName";
                tf_Product.ValueMember = "ProductID";
                DataTable tb = help.getDataTable_excute(sql);
                tf_Product.DataSource = tb;
            }
            catch (Exception ex)
            {
            }

        }
        private void tf_Product_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitProductFiel(tf_Product_Type.SelectedValue.ToString());

        }

        private void tf_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ProductID.Text = tf_Product.SelectedValue.ToString();
        }
        private void InitSellDtgv()
        {
            help.fillInDTGV(dtgv_sell, "v_sell");
        }
        private void InitCustomerCbb()
        {
            //khoi tao combobox
            cbb_CustomerID.DataSource = help.getDataCbb("Customer");
            //hien thi ten loai len dtgv
            cbb_CustomerID.DisplayMember = "CustomerName";
            //gia tri cua cbb la type id
            cbb_CustomerID.ValueMember = "CustomerID";
        }
        

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (help.checkCustomerID(cbb_CustomerID.SelectedValue.ToString()))
            {
                if (help.checkIDBillDetail(txt_BillID.Text, txt_ProductID.Text))
                {
                    if (txt_BillID.Text.Trim() != "" && txt_BillID.Text.Trim() != null
                        && txt_ProductID.Text.Trim() != "" && txt_ProductID.Text.Trim() != null
                        && txt_amount.Text.Trim() != "" && txt_amount.Text.Trim() != null
                    )
                    {
                        try
                        {
                            int day = DateTime.Now.Day;
                            int month = DateTime.Now.Month;
                            int year = DateTime.Now.Year;
                            string date = year + "/" + month + "/" + day;

                            
                            if (help.checkID("Bill", txt_BillID.Text))
                                help.Excute_query("INSERT INTO Bill VALUES ('" + txt_BillID.Text + "','" + cbb_CustomerID.SelectedValue.ToString() + "','" + date + "',''" + ")");
                            help.Excute_query("INSERT INTO BillDetail VALUES ('" + txt_BillID.Text + "','" + txt_ProductID.Text + "','" + cbb_EmployeeID.SelectedValue.ToString() + "'," + txt_amount.Text + ")");
                            help.Excute_query("INSERT INTO sell VALUES ('" + txt_BillID.Text + "','" + cbb_CustomerID.SelectedValue.ToString() + "','" + txt_ProductID.Text + "'," + txt_amount.Text + ")");
                            DataTable tb = help.getDataTable_excute("select sum(dbo.sell.Amount * dbo.Product.Price) AS totalPrice FROM  dbo.sell INNER JOIN dbo.Product ON dbo.Product.ProductID = dbo.sell.ProductID");
                            if (tb.Rows.Count > 0)
                                txt_totalPrice.Text = tb.Rows[0][0].ToString();
                            InitSellDtgv();
                       }
                       catch (Exception ex)
                       {
                              MessageBox.Show("Một Hóa Đơn không thể có hai khách hàng", "Cảnh Báo");
                       }
                    }
                    else
                        MessageBox.Show("Xin Hãy Nhập đầy đủ thông tin", "Cảnh Báo");
                }
                else
                    MessageBox.Show("Trùng sản phẩm");
            }
            else
                MessageBox.Show("Một Hóa đơn không thể có hai khách hàng");


        }

        private void btn_PrinBill_Click(object sender, EventArgs e)
        {
            PrintBill();
        }
        private void PrintBill()
        {
            sellBillReport f = new sellBillReport();
            f.ShowDialog();
            help.Excute_query("delete from sell");
            InitSellDtgv();
            isPrintBill = true;
        }
        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            addCustomer addCust = new addCustomer();
            addCust.ShowDialog();
            InitCustomerCbb();
        }


        private void dtgv_sell_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dtgv_sell.Rows[e.RowIndex].Cells[3].Value.ToString());
            try
            {
                DataTable tb = help.getDataTable_excute("Select * from v_sell");
                if (tb.Rows.Count > 0)
                    txt_totalPrice.Text = tb.Rows[0][4].ToString();
                help.Excute_query("UPDATE  BillDetail SET Amount = " + dtgv_sell.Rows[e.RowIndex].Cells[3].Value.ToString() + " Where BillID = '" + txt_BillID.Text + "' and ProductID ='" + txt_ProductID.Text + "'");
            }
            catch (Exception ex)
            {
            }
        }

        private void InitTxtBillID()
        {
            if (help.checkID("Bill", "HD0000"))
            {
                txt_BillID.Text = "HD0000";
            }
            else
            {
                Common common = new Common();
                txt_BillID.Text = common.initID("Bill","BillID","HD");
            }
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            if (isPrintBill == true)
            {
                InitTxtBillID();
                isPrintBill = false;
                help.Excute_query("delete from sell");
                txt_totalPrice.Text = "";

            }
            else
            {
                DialogResult = MessageBox.Show("Bạn chưa in Hóa Đơn "+txt_BillID.Text+" Bạn có thực sự muốn tạo mới" , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.OK)
                {
                    InitTxtBillID();
                    isPrintBill = false;
                    help.Excute_query("delete from sell");
                    txt_totalPrice.Text = "";
                }
            }
            InitSellDtgv();
        }
    }
}
