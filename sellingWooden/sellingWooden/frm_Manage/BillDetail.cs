using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sellingWooden
{
    public partial class BillDetail : Form
    {
        string BillID, EmployeeID, ProductID;
        string Amount;
        SQLHelp help = new SQLHelp();
        public BillDetail()
        {
            InitializeComponent();
            InitBillDetailDtgv();
            InitBillIDCbb();
            InitEmployeeIDCbb();
            InitProductIDCbb();
        }

        private void InitBillDetailDtgv()
        {
            help.fillInDTGV(dgv_BillDetail_BillDetailDetail, "v_dtgv_BillDetail");
        }
        private void InitBillIDCbb()
        {
            //khoi tao combobox
            cbo_BillDetail_BillID.DataSource = help.getDataCbb("Bill");
            //hien thi ma bill len dtgv
            cbo_BillDetail_BillID.DisplayMember = "BillID";
            //gia tri cua cbb la bill id
            cbo_BillDetail_BillID.ValueMember = "BillID";
        }
        private void InitProductIDCbb()
        {
            //khoi tao combobox
            cbb_BillDetail_ProductID.DataSource = help.getDataCbb("Product");
            //hien thi ten san pham len dtgv
            cbb_BillDetail_ProductID.DisplayMember = "ProductName";
            //gia tri cua cbb la product id
            cbb_BillDetail_ProductID.ValueMember = "ProductID";
        }

        private void InitEmployeeIDCbb()
        {
            //khoi tao combobox
            cbo_BillDetail_EmployeeID.DataSource = help.getDataCbb("Employee");
            //hien thi ten nhan vien len dtgv
            cbo_BillDetail_EmployeeID.DisplayMember = "EmployeeName";
            //gia tri cua cbb la ma nhan vien
            cbo_BillDetail_EmployeeID.ValueMember = "EmployeeID";
        }


        private void but_BillDetail_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idnum = dgv_BillDetail_BillDetailDetail.SelectedRows[0].Index;
                string sid = dgv_BillDetail_BillDetailDetail.Rows[idnum].Cells[0].Value.ToString();
                help.deleteData("BillDetail", "BillID", sid);
                this.InitBillDetailDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }

        private void but_BillDetail_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_BillDetail_BillID.Text != ""
                    && cbb_BillDetail_ProductID.Text != ""
                    && cbo_BillDetail_EmployeeID.Text != ""
                    && txt_BillDetail_Amount.Text != "")
                    if (help.checkIDBillDetail(cbo_BillDetail_BillID.Text, cbb_BillDetail_ProductID.SelectedValue.ToString()))
                    {
                        string Data = "'" + cbo_BillDetail_BillID.Text + "'," +
                                      "'" + cbb_BillDetail_ProductID.SelectedValue + "'," +
                                      "'" + cbo_BillDetail_EmployeeID.SelectedValue + "'," +
                                     "" + txt_BillDetail_Amount.Text + "";
                        help.addData("BillDetail", Data);
                        InitBillDetailDtgv();
                    }
                    else
                    {
                        MessageBox.Show("Mã Hóa Đơn và Mã  Sản phẩm đã tồn tại");
                    }
                else
                    MessageBox.Show("Hãy nhập đầy đủ thông tin ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi hệ thống, xin vui lòng khởi động lại chương trình");
            }
        }

        private void btn_BillDetail_Search_Click(object sender, EventArgs e)
        {
            string txtSearch = txt_BillDetail_Search.Text;
            string sql = "ALTER VIEW v_BillDetail_Search as SELECT dbo.BillDetail.BillID AS[Mã HD], dbo.BillDetail.ProductID AS[Mã SP], dbo.BillDetail.EmployeeID AS[Mã NV], dbo.BillDetail.Amount AS[Số Lượng], dbo.BillDetail.Amount* dbo.Product.Price AS[Thành Tiền]"
                          +" FROM dbo.BillDetail INNER JOIN"
                          +" dbo.Product ON dbo.Product.ProductID = dbo.BillDetail.ProductID WHERE BillDetail.BillID LIKE '%" + txtSearch + "%'"
                          + " or BillDetail.ProductID LIKE '%" + txtSearch + "%'"
                          + " or BillDetail.EmployeeID LIKE '%" + txtSearch + "%'"
                          + " or BillDetail.Amount  =" + txtSearch + "";
            help.Excute_query(sql);
            help.fillInDTGV(dgv_BillDetail_BillDetailDetail, "v_BillDetail_Search");
        }
        //==================Dat=================================
        private void txt_BillDetail_Amount_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_BillDetail_Amount_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_BillDetail_Amount.Text) != true)
            {
                MessageBox.Show("Only input number!!!", "NOTICE!");
                txt_BillDetail_Amount.Text = "";
            }
        }
        //hien thong tin co trong dtg len cac box
        int index;
        private void dgv_BillDetail_BillDetailDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv_BillDetail_BillDetailDetail.CurrentRow.Index;
            cbo_BillDetail_BillID.Text = dgv_BillDetail_BillDetailDetail.Rows[index].Cells[0].Value.ToString();
            BillID = dgv_BillDetail_BillDetailDetail.Rows[index].Cells[0].Value.ToString();

            cbb_BillDetail_ProductID.Text = dgv_BillDetail_BillDetailDetail.Rows[index].Cells[1].Value.ToString();
            ProductID=dgv_BillDetail_BillDetailDetail.Rows[index].Cells[1].Value.ToString();

            cbo_BillDetail_EmployeeID.Text = dgv_BillDetail_BillDetailDetail.Rows[index].Cells[2].Value.ToString();
            EmployeeID = dgv_BillDetail_BillDetailDetail.Rows[index].Cells[2].Value.ToString();

            txt_BillDetail_Amount.Text = dgv_BillDetail_BillDetailDetail.Rows[index].Cells[3].Value.ToString();
            Amount = dgv_BillDetail_BillDetailDetail.Rows[index].Cells[3].Value.ToString();
        }

        private void but_BillDetail_Edit_Click(object sender, EventArgs e)
        {
            frmBillDetail_Edit run = new frmBillDetail_Edit();
            if(BillID!=null&&BillID!="")
                try
                {
                    run.setBillID(BillID);
                    run.setEmployeeID(EmployeeID);
                    run.setProductID(ProductID);
                    run.setAmount(Amount);
                    run.showInformation();
                    run.ShowDialog();
                    InitBillDetailDtgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn chưa chọn dòng cần sửa");
                }
            else MessageBox.Show("Bạn chưa chọn dòng cần sửa");
        }

        private void but_BillDetail_Refresh_Click(object sender, EventArgs e)
        {
            InitBillDetailDtgv();
            InitBillIDCbb();
            InitEmployeeIDCbb();
            InitProductIDCbb();
        }
    }
}
