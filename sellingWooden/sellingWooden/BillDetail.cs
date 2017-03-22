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
    public partial class BillDetail : Form
    {
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
            help.fillInDTGV(dgv_BillDetail_BillDetailDetail, "v_BillDetail");
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
                    if (help.checkIDBillDetail(cbo_BillDetail_BillID.Text, cbb_BillDetail_ProductID.Text))
                    {
                        string Data = "'" + cbo_BillDetail_BillID.Text + "'," +
                                      "'" + cbb_BillDetail_ProductID.SelectedValue + "'," +
                                      "'" + cbo_BillDetail_EmployeeID.SelectedValue + "'," +
                                     "" + txt_BillDetail_Amount.Text + "";
                        help.addData("BillDetail", Data);
                        InitBillDetailDtgv();
                        goto OPP;
                    }
                    else
                    {
                        MessageBox.Show("Mã Hóa Đơn và Mã  Sản phẩm đã tồn tại");
                        goto OPP;
                    }
                MessageBox.Show("Hãy nhập đầy đủ thông tin ");
            OPP:;
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi hệ thống, xin vui lòng khởi động lại chương trình");
            }
        }
    }
}
