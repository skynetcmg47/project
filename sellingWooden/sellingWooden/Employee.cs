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
    public partial class Employee : Form
    {
        SQLHelp help = new SQLHelp();
        public Employee()
        {
            InitializeComponent();
            InitEmployeetDtgv();
        }
        /// <summary>
        /// delete
        /// </summary>
        private void InitEmployeetDtgv()
        {
            help.fillInDTGV(dgv_Employee_InformationEmployeeDetail, "Employee");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int idnum = dgv_Employee_InformationEmployeeDetail.SelectedRows[0].Index;
                string sid = dgv_Employee_InformationEmployeeDetail.Rows[idnum].Cells[0].Value.ToString();
                help.deleteData("Employee", "EmployeeID", sid);
                this.InitEmployeetDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }

        private void but_Employee_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Employee_EmployeeID.Text != ""
                    && txt_Employee_NOE.Text != ""
                    && dtm_Employee_DOB.Text != ""
                    && cbo_Employee_Sex.Text != ""
                    && txt_Employee_Position.Text != ""
                    && txt_Employee_TEL.Text != ""
                    && txt_Employee_Address.Text != "")
                    if (help.checkID("Employee", txt_Employee_EmployeeID.Text))
                    {
                        string day = dtm_Employee_DOB.Value.Day.ToString();
                        string month = dtm_Employee_DOB.Value.Month.ToString();
                        string year = dtm_Employee_DOB.Value.Year.ToString();
                        string dob = year + "/" + month + "/" + day;
                        string Data = "'" + txt_Employee_EmployeeID.Text + "'," +
                                      "N" + "'" + txt_Employee_NOE.Text + "'," +
                                      "'" + dob + "'," +
                                      "N" + "'" + cbo_Employee_Sex.Text + "'," +
                                      "N" + "'" + txt_Employee_Position.Text + "'," +
                                      "N" + "'" + txt_Employee_Address.Text + "'," +
                                      "'" + txt_Employee_TEL.Text + "'," +
                                      "N" + "'" + txt_Employee_Note.Text + "'";
                        help.addData("Employee", Data);
                        InitEmployeetDtgv();
                        goto OPP;
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                        goto OPP;
                    }
                MessageBox.Show("Hãy nhập đầy đủ thông tin nhân viên");
            OPP:;
            }catch(Exception ex)
            {
                MessageBox.Show("lỗi hệ thống, xin vui lòng khởi động lại chương trình");
            }
        }
    }
}
