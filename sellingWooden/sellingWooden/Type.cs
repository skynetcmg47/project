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
                help.Excute_query("DELETE FROM dbo.BillDetail  Where ProductID IN (SELECT ProductID FROM Product WHERE ProductTypeID= '" + sid + "'"+")");
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
    }
}
