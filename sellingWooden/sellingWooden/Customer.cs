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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                help.deleteData("Customer", "CustomerID", sid);
                this.InitCustomerDtgv();
            }
            catch (Exception ex)
            {
                //bat loi khong chon dong can xoa
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            }
        }

        private void cbo_Customer_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
