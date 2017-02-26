﻿//using sellingWooden;
using System;
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
    public partial class Product : Form
    {
        SQLHelp help = new SQLHelp();

        public Product()
        {
            InitializeComponent();
            InitProductDtgv();
            initTypeCbb();

        }
        private void initTypeCbb()
        {
            //khoi tao combobox
            txt_Product_TypeID.DataSource = help.getDataCbb("Type");
            //hien thi ten loai len dtgv
            txt_Product_TypeID.DisplayMember = "TypeName";
            //gia tri cua cbb la type id
            txt_Product_TypeID.ValueMember = "TypeID";
        }
        private void InitProductDtgv()
        {
            help.fillInDTGV(dgv_Product_InformatinProductDetail, "Product");
        }

        private void but_Product_Add_Click(object sender, EventArgs e)
        {
            //khoi tao dien data de luu gia tri cac bien can luu
            // cac bien kieu text thi de trong dau nhay don 'some thing'
            //cac bien kieu so thi khong de trong dau nhay don
            //cac bien cach nhau boi dau phay ","
            //bien co dang combobox phai dung SelectedValue de lay gia tri
            string Data = "'" + txt_Product_ProductID.Text + "'," +
                          "'" + txt_Product_TypeID.SelectedValue + "'," +
                          "'" + txt_Product_NOP.Text + "'," +
                          "'" + txt_Product_Status.Text + "'," +
                          "" + txt_Product_Quanty.Text + "," +
                          "" + txt_Product_Price.Text + "," +
                          "'" + txt_Product_Size.Text + "'," +
                          "'" + txt_Product_Note.Text + "'";
            help.addData("Product", Data);
            InitProductDtgv();
        }

    }
}
