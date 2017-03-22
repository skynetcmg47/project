
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

namespace sellingWooden
{
    public partial class Product : Form
    {
        SQLHelp help = new SQLHelp();
        string ss = "";

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
        public  void InitProductDtgv()
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
            try {
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
           }catch(Exception ex)
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
            catch(Exception  ex)
           {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
           }
        }
       
        private void dgv_Product_InformatinProductDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ss= dgv_Product_InformatinProductDetail.CurrentRow.Cells[0].Value.ToString();
          //  MessageBox.Show(ss);
        }


    }
}
