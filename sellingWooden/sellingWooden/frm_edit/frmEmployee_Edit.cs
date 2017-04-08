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
    public partial class frmEmployee_Edit : Form
    {
        string EmployeeID, NOE, DOB, Sex, Position, Address, Note;
        string TEL;
        public frmEmployee_Edit()
        {
            InitializeComponent();
        }
        public void setEmployeeID(string id)
        {
            EmployeeID = id;
        }
        public void setNOE(string name)
        {
            NOE = name;
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
        public void setPosition(string i)
        {
            Position = i;
        }
        public void setAddress(string i)
        {
            Address = i;
        }

        private void but_frmEmployee_Edit_OK_Click(object sender, EventArgs e)
        {
            SQLHelp help = new SQLHelp();
            string day = dtm_frmEmployee_Edit_DOB.Value.Day.ToString();
            string month = dtm_frmEmployee_Edit_DOB.Value.Month.ToString();
            string year = dtm_frmEmployee_Edit_DOB.Value.Year.ToString();
            string dob = year + "/" + month + "/" + day;
            string sql = "UPDATE Employee SET EmployeeName=N'" + txt_frmEmployee_Edit_NOE.Text + "',"
                        + "DateOfBirth = '" + dob + "',"
                        + "sex = '" + cbo_frmEmployee_Edit_Sex.Text + "',"
                        + "Position = N'" + cbo_frmEmployee_Edit_Position.Text + "',"
                        + "Address = N'" + txt_frmEmployee_Edit_Address.Text + "',"
                        + "PhoneNumber = '" + txt_frmEmployee_Edit_TEL.Text + "',"
                        + "Note = N'" + txt_frmEmployee_Edit_Note.Text + "' Where EmployeeID = '" + txt_frmEmployee_Edit_EmployeeID.Text + "'";
            help.Excute_query(sql);
            this.Close();
        }

        private void but_frmEmployee_Edit_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setTEL(string i)
        {
            TEL = i;
        }

        private void txt_frmEmployee_Edit_TEL_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_frmEmployee_Edit_TEL_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_frmEmployee_Edit_TEL.Text) != true)
            {
                MessageBox.Show("Chỉ được nhập số !!", "NOTICE!");
                txt_frmEmployee_Edit_TEL.Text = "";
            }
        }
        //
        public void showInformation()
        {
            txt_frmEmployee_Edit_EmployeeID.Text = EmployeeID;
            txt_frmEmployee_Edit_NOE.Text = NOE;
            cbo_frmEmployee_Edit_Position.Text = Position;
            txt_frmEmployee_Edit_Address.Text = Address;
            txt_frmEmployee_Edit_TEL.Text = TEL.ToString();
            txt_frmEmployee_Edit_Note.Text = Note;
            cbo_frmEmployee_Edit_Sex.Text = Sex;
            dtm_frmEmployee_Edit_DOB.Text = DOB;
        }
        // ham xu li sua
        public void edit()
        {

        }
    }
}
