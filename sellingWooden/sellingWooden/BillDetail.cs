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
    public partial class BillDetail : Form
    {
        SQLHelp help = new SQLHelp();
        public BillDetail()
        {
            InitializeComponent();
            InitBillDetailDtgv();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgv_BillDetail_ProductID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void InitBillDetailDtgv()
        {
            help.fillInDTGV(dgv_BillDetail_BillDetailDetail, "BillDetail");
        }
        private void but_BillDetail_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idnum = dgv_BillDetail_BillDetailDetail.SelectedRows[0].Index;
                string sid = dgv_BillDetail_BillDetailDetail.Rows[idnum].Cells[0].Value.ToString();
                help.deleteData("BillDetail", "BillID", sid);
                this.InitBillDetailDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }
    }
}
