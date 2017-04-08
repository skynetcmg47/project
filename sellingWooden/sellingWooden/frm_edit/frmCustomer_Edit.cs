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
    public partial class frmCustomer_Edit : Form
    {
        string CustomerID, NOC, DOB, Sex, Address, Note;
        string TEL;
        public frmCustomer_Edit()
        {
            InitializeComponent();
        }
        public void setCustomerID(string id)
        {
            CustomerID = id;
        }
        public void setNOC(string name)
        {
            NOC = name;
        }
        public void setDOB(string d)
        {
            DOB = d;
        }
        public void setSex(string s)
        {
            Sex = s;
        }
        public void setNote(string s)
        {
            Note = s;
        }
        public void setAddress(string i)
        {
            Address = i;
        }
        public void setTEL(string i)
        {
            TEL = i;
        }

        private void but_frmCustomer_Edit_OK_Click(object sender, EventArgs e)
        {
            string day = dtm_frmCustomer_Edit_DOB.Value.Day.ToString();
            string month = dtm_frmCustomer_Edit_DOB.Value.Month.ToString();
            string year = dtm_frmCustomer_Edit_DOB.Value.Year.ToString();
            string dob = year + "/" + month + "/" + day;
            SQLHelp help = new SQLHelp();
            string sql = "UPDATE Customer SET CustomerName = N'" + txt_frmCustomer_Edit_NOC.Text + "',"
                        + "DateOfBirth = '" + dob + "',"
                        + "Sex = N'" + cbo_frmCustomer_Edit_Sex.Text + "',"
                        + "Address = N'" + txt_frmCustomer_Edit_Address.Text + "',"
                        + "PhoneNumber = '" + txt_frmCustomer_Edit_TEL.Text + "',"
                        + "Note = N'" + txt_frmCustomer_Edit_Note.Text + "' Where CustomerID = '" + txt_frmCustomer_Edit_CustomerID.Text + "'";
            help.Excute_query(sql);
            this.Close();
        }

        private void but_fmrCustomer_Edit_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////////////
        private void txt_frmCustomer_Edit_TEL_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_frmCustomer_Edit_TEL_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_frmCustomer_Edit_TEL.Text) != true)
            {
                MessageBox.Show("Chỉ được nhập số !!", "NOTICE!");
                txt_frmCustomer_Edit_TEL.Text = "";
            }
        }

        //
        public void showInformation()
        {
            txt_frmCustomer_Edit_CustomerID.Text = CustomerID;
            txt_frmCustomer_Edit_NOC.Text = NOC;
            txt_frmCustomer_Edit_Address.Text = Address;
            txt_frmCustomer_Edit_TEL.Text = TEL.ToString();
            txt_frmCustomer_Edit_Note.Text = Note;
            cbo_frmCustomer_Edit_Sex.Text = Sex;
            dtm_frmCustomer_Edit_DOB.Text = DOB;
        }
        // ham xu li sua
        public void edit()
        {

        }
    }
}
