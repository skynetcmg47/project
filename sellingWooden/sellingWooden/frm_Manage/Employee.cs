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
    public partial class Employee : Form
    {
        string EmployeeID, NOE, DOB, Sex, Position, Address, Note;
        string TEL;
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

        private void but_Employee_Edit_Click(object sender, EventArgs e)
        {
            frmEmployee_Edit run = new frmEmployee_Edit();
            if (EmployeeID != null && EmployeeID != "")
                try
                {
                    run.setEmployeeID(EmployeeID);
                    run.setNOE(NOE);
                    run.setDOB(DOB);
                    run.setAddress(Address);
                    run.setNote(Note);
                    run.setSex(Sex);
                    run.setTEL(TEL);
                    run.setPosition(Position);
                    run.showInformation();
                    run.ShowDialog();
                    InitEmployeetDtgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn chưa chọn dòng cần sửa");
                }
            else MessageBox.Show("Bạn chưa chọn dòng cần sửa");

        }

        private void btn_Employee_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string txtSearch = txt_Employee_Search.Text.Trim();
                string sql = "ALTER VIEW v_Employee_Search AS SELECT * FROM Employee WHERE EmployeeID LIKE '%" + txtSearch + "%'"
                              + "or EmployeeName LIKE N'%" + txtSearch + "%'"
                              //+ "or DAY(DateOfBirth) LIKE '%" + txtSearch.Substring(0,2) + "%'"
                              + "or sex LIKE N'%" + txtSearch + "%'"
                              + "or Position LIKE N'%" + txtSearch + "%'"
                              + "or Address LIKE N'%" + txtSearch + "%'"
                              + "or PhoneNumber LIKE '%" + txtSearch + "%'"
                              + "or Note LIKE N'%" + txtSearch + "%'";
                help.Excute_query(sql);
                help.fillInDTGV(dgv_Employee_InformationEmployeeDetail, "v_Employee_Search");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Định dạng ngày không đúng");
            }
        }


        //======================================Dat============================
        //khong nhap so vao TEL
        private void txt_Employee_TEL_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Employee_TEL_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_Employee_TEL.Text) != true)
            {
                MessageBox.Show("Only input number!!!", "NOTICE!");
                txt_Employee_TEL.Text = "";
            }
        }

        //hien thong tin len box
        int index;
        private void dgv_Employee_InformationEmployeeDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv_Employee_InformationEmployeeDetail.CurrentRow.Index;
            txt_Employee_EmployeeID.Text = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[0].Value.ToString();
            EmployeeID=dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[0].Value.ToString();

            txt_Employee_NOE.Text = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[1].Value.ToString();
            NOE = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[1].Value.ToString();

            dtm_Employee_DOB.Text = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[2].Value.ToString();
            DOB = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[2].Value.ToString();

            cbo_Employee_Sex.Text = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[3].Value.ToString();
            Sex = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[3].Value.ToString();

            txt_Employee_Position.Text = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[4].Value.ToString();
            Position = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[4].Value.ToString();

            txt_Employee_Address.Text = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[5].Value.ToString();
            Address = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[5].Value.ToString();

            txt_Employee_TEL.Text = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[6].Value.ToString();
            TEL = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[6].Value.ToString();

            txt_Employee_Note.Text = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[7].Value.ToString();
            Note = dgv_Employee_InformationEmployeeDetail.Rows[index].Cells[7].Value.ToString();

        }

        private void but_Employee_Refresh_Click(object sender, EventArgs e)
        {
            InitEmployeetDtgv();

        }
        //========================================================================
    }
}
