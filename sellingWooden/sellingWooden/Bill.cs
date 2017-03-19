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
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                help.deleteData("Bill", "BillID", sid);
                this.InitBillDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }
    }
}
