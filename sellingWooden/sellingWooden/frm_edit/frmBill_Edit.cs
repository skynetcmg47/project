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
    public partial class frmBill_Edit : Form
    {
        SQLHelp help = new SQLHelp();
        string BillID, CustomerID, DateSell, Note;
        public frmBill_Edit()
        {
            InitializeComponent();
            InitCustomerCbb();
        }
        private void InitCustomerCbb()
        {
            //khoi tao combobox
            cbo_frmBill_Edit_CustomerID.DataSource = help.getDataCbb("Customer");
            //hien thi ten loai len dtgv
            cbo_frmBill_Edit_CustomerID.DisplayMember = "CustomerName";
            //gia tri cua cbb la type id
            cbo_frmBill_Edit_CustomerID.ValueMember = "CustomerID";
        }
        public void setBillID(string id)
        {
            BillID = id;
        }
        public void setCustomerID(string name)
        {
            CustomerID = name;
        }

        private void but_frmBill_Edit_OK_Click(object sender, EventArgs e)
        { 
            string day = dtm_frmBill_Edit_DateSell.Value.Day.ToString();
            string month = dtm_frmBill_Edit_DateSell.Value.Month.ToString();
            string year = dtm_frmBill_Edit_DateSell.Value.Year.ToString();
            string sellDay = year + "/" + month + "/" + day;
            string query = "UPDATE Bill SET CustomerID = '" + cbo_frmBill_Edit_CustomerID.SelectedValue + "', "
                               + " SellDate = '" + sellDay + "', "
                               + "Note = '" + txt_frmBill_Edit_Note.Text + "' WHERE BillID = '" + txt_frmBill_Edit_BillID.Text + "'";
            help.Excute_query(query);
            this.Close();
        }

        private void but_frmBill_Edit_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setDateSell(string d)
        {
            DateSell = d;
        }
        public void setNote(string s)
        {
            Note = s;
        }
        public void showInformation()
        {
            txt_frmBill_Edit_BillID.Text = BillID;
            cbo_frmBill_Edit_CustomerID.SelectedValue = CustomerID;
            dtm_frmBill_Edit_DateSell.Text = DateSell;
            txt_frmBill_Edit_Note.Text = Note;
        }
    }
}
