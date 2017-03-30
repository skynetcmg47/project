
//using sellingWooden;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace sellingWooden
{
    public partial class Product : Form
    {
        SQLHelp help = new SQLHelp();


        public Product()
        {
            InitializeComponent();
            //khoi tao dâtgridview
            InitProductDtgv();
            //khoi tao combobox
            initTypeCbb();

        }
        //ham nay dung de khoi tao combobox type
        private void initTypeCbb()
        {
            //khoi tao combobox
            cbb_Product_TypeID.DataSource = help.getDataCbb("Type");
            //hien thi ten loai len dtgv
            cbb_Product_TypeID.DisplayMember = "TypeName";
            //gia tri cua cbb la type id
            cbb_Product_TypeID.ValueMember = "TypeID";
        }
        public void InitProductDtgv()
        {
            help.fillInDTGV(dgv_Product_InformatinProductDetail, "Product");
        }


        //khoi tao dien data de luu gia tri cac bien can luu
        // cac bien kieu text thi de trong dau nhay don 'some thing'
        //cac bien kieu so thi khong de trong dau nhay don
        //cac bien cach nhau boi dau phay ","
        //bien co dang combobox phai dung SelectedValue de lay gia tri
        private void but_Product_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Product_ProductID.Text != ""
                    && txt_Product_NOP.Text != ""
                    && cbb_Product_TypeID.Text != ""
                    && txt_Product_Quanty.Text != ""
                    && txt_Product_Price.Text != "")
                    if (help.checkID("Product", txt_Product_ProductID.Text))
                    {
                        string Data = "'" + txt_Product_ProductID.Text + "'," +
                                      "N" + "'" + cbb_Product_TypeID.SelectedValue + "'," +
                                      "N" + "'" + txt_Product_NOP.Text + "'," +
                                      "N" + "'" + cbb_Product_Status.Text + " '," +
                                      "" + txt_Product_Quanty.Text + "," +
                                      "" + txt_Product_Price.Text + "," +
                                      "'" + txt_Product_Size.Text + " '," +
                                      "N" + "'" + txt_Product_Note.Text + " '";
                        help.addData("Product", Data);
                        InitProductDtgv();
                        goto OPP;
                    }
                    else
                    {
                        MessageBox.Show("Mã Sản Phẩm đã tồn tại");
                        goto OPP;
                    }
                MessageBox.Show("Hãy nhập đầy đủ thông tin sản phẩm");
            OPP:;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi hệ thống, xin vui lòng khởi động lại chương trình");
            }
        }

        private void but_Product_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idnum = dgv_Product_InformatinProductDetail.SelectedRows[0].Index;
                string sid = dgv_Product_InformatinProductDetail.Rows[idnum].Cells[0].Value.ToString();
                help.deleteData("BillDetail", "ProductID", sid);
                help.deleteData("Product", "ProductID", sid);
                this.InitProductDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }
        int index;
        private void dgv_Product_InformatinProductDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv_Product_InformatinProductDetail.CurrentRow.Index;
            txt_Product_ProductID.Text = dgv_Product_InformatinProductDetail.Rows[index].Cells[0].Value.ToString();
            cbb_Product_TypeID.SelectedValue = dgv_Product_InformatinProductDetail.Rows[index].Cells[1].Value.ToString();
            txt_Product_NOP.Text = dgv_Product_InformatinProductDetail.Rows[index].Cells[2].Value.ToString();
            cbb_Product_Status.Text = dgv_Product_InformatinProductDetail.Rows[index].Cells[3].Value.ToString();
            txt_Product_Quanty.Text = dgv_Product_InformatinProductDetail.Rows[index].Cells[4].Value.ToString();
            txt_Product_Price.Text = dgv_Product_InformatinProductDetail.Rows[index].Cells[5].Value.ToString();
            txt_Product_Size.Text = dgv_Product_InformatinProductDetail.Rows[index].Cells[6].Value.ToString();
            txt_Product_Note.Text = dgv_Product_InformatinProductDetail.Rows[index].Cells[7].Value.ToString();

        }

        // khong cho nhap chu vao so luong, gia ca , kich thuoc
        private void txt_Product_Quanty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_Product_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_Product_Size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }

        private void txt_Product_Quanty_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_Product_Quanty.Text) != true)
            {
                MessageBox.Show("Only input number!!!", "NOTICE!");
                txt_Product_Quanty.Text = "";
            }
        }

        private void txt_Product_Price_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_Product_Price.Text) != true)
            {
                MessageBox.Show("Only input number!!!", "NOTICE!");
                txt_Product_Price.Text = "";
            }
        }

        private void txt_Product_Size_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_Product_Size.Text) != true)
            {
                MessageBox.Show("Only input number!!!", "NOTICE!");
                txt_Product_Size.Text = "";
            }
        }
        // nut edit
        private void but_Product_Edit_Click(object sender, EventArgs e)
        {
            frmProduct_Edit run = new frmProduct_Edit();
            try
            {
                run.setProductID(txt_Product_ProductID.Text);
                run.setNOP(txt_Product_NOP.Text);
                run.setTypeID(cbb_Product_TypeID.Text);
                run.setStatus(cbb_Product_Status.Text);
                run.setQuanty(int.Parse(txt_Product_Quanty.Text));
                run.setPrice(double.Parse(txt_Product_Price.Text));
                run.setSize(int.Parse(txt_Product_Size.Text));
                run.setNote(txt_Product_Note.Text);
                run.showInformation();
                run.ShowDialog();
                InitProductDtgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn dòng cần sửa");
            }

        }

        private void btn_Product_Search_Click(object sender, EventArgs e)
        {
            string txtSearch = txt_Product_Search.Text;
            string sql = "ALTER VIEW v_Product_Search AS SELECT * FROM Product WHERE ProductID LIKE '%" + txtSearch + "%'"
                          + "or ProductName LIKE N'%" + txtSearch + "%'"
                          + "or ProductTypeID LIKE '%" + txtSearch + "%'"
                          + "or Status LIKE N'%" + txtSearch + "%'"
                          + "or Quanty LIKE '%" + txtSearch + "%'"
                          + "or Price LIKE '%" + txtSearch + "%'"
                          + "or Size LIKE '%" + txtSearch + "%'"
                          + "or Note LIKE N'%" + txtSearch + "%'";
            help.Excute_query(sql);
            help.fillInDTGV(dgv_Product_InformatinProductDetail, "v_Product_Search");
        }
    }
}
