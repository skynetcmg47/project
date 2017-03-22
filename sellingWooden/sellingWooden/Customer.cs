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
    public partial class Customer : Form
    {
        SQLHelp help = new SQLHelp();
        public Customer()
        {
            InitializeComponent();
            InitCustomerDtgv();
        }

       
        private void InitCustomerDtgv()
        {
            help.fillInDTGV(dgv_Customer_InformationCustomerDetail, "Customer");
        }
        private void but_Customer_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idnum = dgv_Customer_InformationCustomerDetail.SelectedRows[0].Index;
                string sid = dgv_Customer_InformationCustomerDetail.Rows[idnum].Cells[0].Value.ToString();
                help.deleteData("Bill", "BillID", sid);
                help.deleteData("Customer", "CustomerID", sid);
                this.InitCustomerDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }

        private void but_Customer_Add_Click(object sender, EventArgs e)
        {
            try {
                if (txt_Customer_CustomerID.Text != ""
                    && txt_Customer_NOC.Text != ""
                    && cbo_Customer_Sex.Text != ""
                    && txt_Customer_TEL.Text != ""
                    && txt_Customer_Address.Text != "")
                    if (help.checkID("Customer", txt_Customer_CustomerID.Text))
                    {
                        string day = dtm_Customer_DOB.Value.Day.ToString();
                        string month = dtm_Customer_DOB.Value.Month.ToString();
                        string year = dtm_Customer_DOB.Value.Year.ToString();
                        string dob = year + "/" + month + "/" + day;
                        string Data = "'" + txt_Customer_CustomerID.Text + "'," +
                                      "N" + "'" + txt_Customer_NOC.Text + "'," +
                                      "'" + dob + "'," +
                                      "N" + "'" + cbo_Customer_Sex.Text + "'," +
                                      "N" + "'" + txt_Customer_Address.Text + "'," +
                                      "'" + txt_Customer_TEL.Text + "'," +
                                      "N" + "'" + txt_Customer_Note.Text + "'";
                        help.addData("Customer", Data);
                        InitCustomerDtgv();
                        goto OPP;
                    }
                    else
                    {
                        MessageBox.Show("Mã Khách Hàng đã tồn tại");
                        goto OPP;
                    }
                MessageBox.Show("Hãy nhập đầy đủ thông tin Khách Hàng");
            OPP:;
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, xin vui lòng khởi động lại chương trình");
            }
          }
    }
}
