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
    public partial class Bill : Form
    {
        SQLHelp help = new SQLHelp();
        public Bill()
        {
            InitializeComponent();
            InitBillDtgv();
            InitCustomerCbb();
        }

        private void InitBillDtgv()
        {
            help.fillInDTGV(dgv_Bill_InformatinBillDetail, "Bill");
        }
        private void but_Bill_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idnum = dgv_Bill_InformatinBillDetail.SelectedRows[0].Index;
                string sid = dgv_Bill_InformatinBillDetail.Rows[idnum].Cells[0].Value.ToString();
                help.deleteData("BillDetail", "BillID", sid);
                help.deleteData("Bill", "BillID", sid);
                this.InitBillDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }
        private void InitCustomerCbb()
        {
            //khoi tao combobox
            cbb_Bill_CustomerID.DataSource = help.getDataCbb("Customer");
            //hien thi ten loai len dtgv
            cbb_Bill_CustomerID.DisplayMember = "CustomerName";
            //gia tri cua cbb la type id
            cbb_Bill_CustomerID.ValueMember = "CustomerID";
        }
        private void but_Bill_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Bill_BillID.Text != ""
                    && cbb_Bill_CustomerID.Text != ""
                    && dtm_Bill_DateSell.Text != "")
                    if (help.checkID("Bill", txt_Bill_BillID.Text))
                    {
                        string day = dtm_Bill_DateSell.Value.Day.ToString();
                        string month = dtm_Bill_DateSell.Value.Month.ToString();
                        string year = dtm_Bill_DateSell.Value.Year.ToString();
                        string sellDay = year + "/" + month + "/" + day;
                        string Data = "'" + txt_Bill_BillID.Text + "'," +
                                      "'" + cbb_Bill_CustomerID.SelectedValue + "'," +
                                      "'" + sellDay + "'," +
                                      "N" + "'" + txt_Bill_Note.Text + "'";
                        help.addData("Bill", Data);
                        InitBillDtgv();
                        goto OPP;
                    }
                    else
                    {
                        MessageBox.Show("Mã Hóa Đơn đã tồn tại");
                        goto OPP;
                    }
                MessageBox.Show("Hãy nhập đầy đủ thông tin Hóa Đơn");
            OPP:;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, xin vui lòng khởi động lại chương trình");
            }
        }
        // cai nay la de khi bam vao 1 hang trong dtg thi thong tin se hien len tren cac box
        int index;
        private void dgv_Bill_InformatinBillDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv_Bill_InformatinBillDetail.CurrentRow.Index;
            txt_Bill_BillID.Text = dgv_Bill_InformatinBillDetail.Rows[index].Cells[0].Value.ToString();
            txt_Bill_Note.Text = dgv_Bill_InformatinBillDetail.Rows[index].Cells[3].Value.ToString();
            cbb_Bill_CustomerID.Text = dgv_Bill_InformatinBillDetail.Rows[index].Cells[1].Value.ToString();
            dtm_Bill_DateSell.Text = dgv_Bill_InformatinBillDetail.Rows[index].Cells[2].Value.ToString();
        }

        private void but_Bill_Edit_Click(object sender, EventArgs e)
        {
            frmBill_Edit run = new frmBill_Edit();
            try
            {
                run.setBillID(txt_Bill_BillID.Text);
                run.setCustomerID(cbb_Bill_CustomerID.Text);
                run.setDateSell(dtm_Bill_DateSell.Text);
                run.setNote(txt_Bill_Note.Text);
                run.showInformation();
                run.ShowDialog();
                InitBillDtgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn dòng cần sửa");
            }
        }

        private void btn_Bill_Search_Click(object sender, EventArgs e)
        {
            string txtSearch = txt_Bill_Search.Text;
            string sql = "ALTER VIEW v_Bill_Search AS SELECT * FROM Bill WHERE BillID LIKE '%" + txtSearch + "%'"
                          + "or CustomerID LIKE '%" + txtSearch + "%'"
                          + "or SellDate LIKE '%" + txtSearch + "%'"
                          + "or Note LIKE N'%" + txtSearch + "%'";
            help.Excute_query(sql);
            help.fillInDTGV(dgv_Bill_InformatinBillDetail, "v_Bill_Search");
        }
    }
}
