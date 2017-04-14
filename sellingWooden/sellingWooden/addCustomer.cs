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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
            InitTxtCustomerID();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            SQLHelp help = new SQLHelp();
            try
            {
                if (txt_customerID.Text != ""
                    && txt_CustomerName.Text != "")
                    if (help.checkID("Customer", txt_customerID.Text))
                    {
                        string day = dtp_dateOfBirth.Value.Day.ToString();
                        string month = dtp_dateOfBirth.Value.Month.ToString();
                        string year = dtp_dateOfBirth.Value.Year.ToString();
                        string dob = year + "/" + month + "/" + day;
                        string Data = "'" + txt_customerID.Text + "'," +
                                      "N" + "'" + txt_CustomerName.Text + "'," +
                                      "'" + dob + "'," +
                                      "N" + "'" + cbb_sex.Text + "'," +
                                      "N" + "'" + txt_Address.Text + "'," +
                                      "'" + txt_phoneNumber.Text + "'," +
                                      "N" + "'" + txt_Note.Text + "'";
                        help.addData("Customer", Data);
                        goto OPP;
                    }
                    else
                    {
                        MessageBox.Show("Mã Khách Hàng đã tồn tại");
                        goto OPP;
                    }
                MessageBox.Show("Hãy nhập đầy đủ thông tin Khách Hàng");
                OPP:;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, xin vui lòng khởi động lại chương trình");
            }
            this.Close();
        }
        private void InitTxtCustomerID()
        {
            SQLHelp help = new SQLHelp();
            if (help.checkID("Customer", "KH0000"))
            {
                txt_customerID.Text = "KH0000";
            }
            else
            {
                Common common = new Common();
                txt_customerID.Text = common.initID("Customer", "CustomerID", "KH");
            }
        }
    }
}
