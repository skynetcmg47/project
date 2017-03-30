using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace sellingWooden
{
    public partial class frmBillDetail_Edit : Form
    {
        SQLHelp help = new SQLHelp();

        string BillID, EmployeeID, ProductID;
        string Amount;
        public frmBillDetail_Edit()
        {
            InitializeComponent();
            InitEmployeeIDCbb();
        }


        private void InitEmployeeIDCbb()
        {
            
            //khoi tao combobox
            cbo_frmBillDetail_Edit_EmployeeID.DataSource = help.getDataCbb("Employee");
            //hien thi ten nhan vien len dtgv
            cbo_frmBillDetail_Edit_EmployeeID.DisplayMember = "EmployeeName";
            //gia tri cua cbb la ma nhan vien
            cbo_frmBillDetail_Edit_EmployeeID.ValueMember = "EmployeeID";
        }

        public void setBillID(string id)
        {
            BillID = id;
        }
        public void setEmployeeID(string id)
        {
            EmployeeID = id;
        }
        public void setProductID(string id)
        {
            ProductID = id;
        }

        private void txt_frmBillDetail_Edit_Amount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_frmBillDetail_Edit_Amount_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_frmBillDetail_Edit_Amount.Text) != true)
            {
                MessageBox.Show("Chỉ được nhập số !!", "NOTICE!");
                txt_frmBillDetail_Edit_Amount.Text = "";
            }
        }

        private void button2but_frmBillDetail_Edit_Ok_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE BillDetail SET EmployeeID = '" + cbo_frmBillDetail_Edit_EmployeeID.SelectedValue + "',"
                        + "Amount = " + txt_frmBillDetail_Edit_Amount.Text + " Where BillID = '" + txt_frmBillDetail_Edit_BillID.Text + "' AND ProductID ='" + txt_frmBillDetail_Edit_ProductID.Text + "'";

            help.Excute_query(sql);
            this.Close();
        }

        public void setAmount(string s)
        {
            Amount = s;
        }
        public void showInformation()
        {
            txt_frmBillDetail_Edit_BillID.Text = BillID;
            cbo_frmBillDetail_Edit_EmployeeID.SelectedValue = EmployeeID;
            txt_frmBillDetail_Edit_ProductID.Text = ProductID;
            txt_frmBillDetail_Edit_Amount.Text = Amount.ToString();
        }
    }
}
