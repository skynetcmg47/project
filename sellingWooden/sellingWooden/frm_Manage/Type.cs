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
    public partial class Type : Form
    {
        SQLHelp help = new SQLHelp();
        public Type()
        {
            InitializeComponent();
            InitTypeDtgv();
        }
        private void InitTypeDtgv()
        {
            help.fillInDTGV(dgv_Type_InformationTypeDetail, "Type");
        }
        private void but_Type_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idnum = dgv_Type_InformationTypeDetail.SelectedRows[0].Index;
                string sid = dgv_Type_InformationTypeDetail.Rows[idnum].Cells[0].Value.ToString();
                help.Excute_query("DELETE FROM dbo.BillDetail  Where ProductID IN (SELECT ProductID FROM Product WHERE ProductTypeID= '" + sid + "'" + ")");
                help.deleteData("Product", "ProductTypeID", sid);
                help.deleteData("Type", "TypeID", sid);
                this.InitTypeDtgv();

            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }

        private void but_Type_Add_Click(object sender, EventArgs e)
        {


            if (txt_Type_NOT.Text != ""
                && txt_Type_TypeID.Text != "")
                if (help.checkID("Type", txt_Type_TypeID.Text))
                {
                    string TypeID = txt_Type_TypeID.Text;
                    string TypeName = txt_Type_NOT.Text;
                    string Data = "'" + txt_Type_TypeID.Text + "'," +
                                  "'" + txt_Type_NOT.Text + "')";
                    help.addData("Type", Data);
                    InitTypeDtgv();
                    goto OPP;
                }
                else
                {
                    MessageBox.Show("Mã Loại đã tồn tại");
                    goto OPP;
                }
            MessageBox.Show("Hãy nhập đầy đủ thông tin loại sản phẩm");
        OPP:;
        }

        //hien thong tin len cac box
        int index;
        private void dgv_Type_InformationTypeDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv_Type_InformationTypeDetail.CurrentRow.Index;
            txt_Type_TypeID.Text = dgv_Type_InformationTypeDetail.Rows[index].Cells[0].Value.ToString();
            txt_Type_NOT.Text = dgv_Type_InformationTypeDetail.Rows[index].Cells[1].Value.ToString();
        }

        private void but_Type_Edit_Click(object sender, EventArgs e)
        {
            frmType_Edit run = new frmType_Edit();
            try
            {
                run.setTypeID(txt_Type_TypeID.Text);
                run.setNOT(txt_Type_NOT.Text);
                run.showInformation();

                run.ShowDialog();
                InitTypeDtgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn dòng cần sửa");
            }
        }
        // ham xu li sua
        public void edit()
        {

        }

        private void btn_Type_Search_Click(object sender, EventArgs e)
        {
            string txtSearch = txt_Type_Search.Text;
            string sql = "ALTER VIEW v_Type_Search AS SELECT * FROM Type WHERE TypeID LIKE N'%" + txtSearch + "%'"
                          + "or TypeName LIKE N'%" + txtSearch.Trim() + "%'";
            help.Excute_query(sql);
            help.fillInDTGV(dgv_Type_InformationTypeDetail, "v_Type_Search");
        }
    }
}
