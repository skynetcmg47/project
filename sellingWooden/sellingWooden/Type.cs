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
                help.deleteData("Type", "TypeID", sid);
                this.InitTypeDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }
    }
}
