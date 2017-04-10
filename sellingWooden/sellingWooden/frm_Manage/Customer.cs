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
    public partial class Customer : Form
    {
        string CustomerID, NOC, DOB, Sex, Address, Note;
        string TEL;
        SQLHelp help = new SQLHelp();
        public Customer()
        {
            InitializeComponent();
            InitCustomerDtgv();
        }

       
        private void InitCustomerDtgv()
        {
            help.fillInDTGV(dgv_Customer_InformationCustomerDetail, "v_dtgv_Customer");
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
                    && txt_Customer_NOC.Text != "")
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
                                      "'" + txt_Customer_TEL.Text+ "'," +
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

        private void btn_Customer_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idnum = dgv_Customer_InformationCustomerDetail.SelectedRows[0].Index;
                string sid = dgv_Customer_InformationCustomerDetail.Rows[idnum].Cells[0].Value.ToString();
                help.deleteData("Bill", "CustomerID", sid);
                help.deleteData("Customer", "CustomerID", sid);
                this.InitCustomerDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }
        //=======================Dat===============================
        // chi duoc nhap so vao TEL
        private void txt_Customer_TEL_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_Customer_TEL_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_Customer_TEL.Text) != true)
            {
                MessageBox.Show("Only input number!!!", "NOTICE!");
                txt_Customer_TEL.Text = "";
            }
        }

        // hien thong tin len box 
        int index;
        private void dgv_Customer_InformationCustomerDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv_Customer_InformationCustomerDetail.CurrentRow.Index;
            txt_Customer_CustomerID.Text = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[0].Value.ToString();
            CustomerID= dgv_Customer_InformationCustomerDetail.Rows[index].Cells[0].Value.ToString();

            txt_Customer_NOC.Text = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[1].Value.ToString();
            NOC = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[1].Value.ToString();

            dtm_Customer_DOB.Text = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[2].Value.ToString();
            DOB = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[2].Value.ToString();

            cbo_Customer_Sex.Text = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[3].Value.ToString();
            Sex = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[3].Value.ToString();

            txt_Customer_Address.Text = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[4].Value.ToString();
            Address = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[4].Value.ToString();

            txt_Customer_TEL.Text = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[5].Value.ToString();
            TEL = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[5].Value.ToString();

            txt_Customer_Note.Text = dgv_Customer_InformationCustomerDetail.Rows[index].Cells[6].Value.ToString();
            Note= dgv_Customer_InformationCustomerDetail.Rows[index].Cells[6].Value.ToString();

        }

        private void but_Customer_Edit_Click(object sender, EventArgs e)
        {
            frmCustomer_Edit run = new frmCustomer_Edit();
            if (CustomerID != null && CustomerID != "")
                try
                {
                    run.setCustomerID(CustomerID);
                    run.setNOC(NOC);
                    run.setDOB(DOB);
                    run.setAddress(Address);
                    run.setNote(Note);
                    run.setSex(Sex);
                    run.setTEL(TEL);
                    run.showInformation();
                    run.ShowDialog();
                    InitCustomerDtgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn chưa chọn dòng cần sửa");
                }
            else MessageBox.Show("Bạn chưa chọn dòng cần sửa");

        }
        //=================================================================================
        private void btn_Customer_Search_Click(object sender, EventArgs e)
        {
            string txtSearch = txt_Customer_search.Text;
            string sql = "ALTER VIEW v_Customer_Search AS SELECT  CustomerID AS [Mã KH], CustomerName AS [Tên KH], DateOfBirth AS [Ngày sinh], Sex AS [Giới tính], Address AS [Địa chỉ], PhoneNumber AS [Số đt], Note AS [Ghi chú] FROM Customer WHERE CustomerID LIKE '%" + txtSearch + "%'"
                          + "or CustomerName LIKE N'%" + txtSearch + "%'"
                          + "or DateOfBirth LIKE '%" + txtSearch + "%'"
                          + "or Sex LIKE N'%" + txtSearch + "%'"
                          + "or Address LIKE N'%" + txtSearch + "%'"
                          + "or PhoneNumber LIKE '%" + txtSearch + "%'"
                          + "or Note LIKE N'%" + txtSearch + "%'";
            help.Excute_query(sql);
            help.fillInDTGV(dgv_Customer_InformationCustomerDetail, "v_Customer_Search");
        }

        private void but_Customer_Refresh_Click(object sender, EventArgs e)
        {
            InitCustomerDtgv();
        }
    }
}
