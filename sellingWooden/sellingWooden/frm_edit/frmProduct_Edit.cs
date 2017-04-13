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
    public partial class frmProduct_Edit : Form
    {
        SQLHelp help = new SQLHelp();

        string ProductID, NOP, TypeID, Note;
        string Quanty, Size;
        string Price;

        public frmProduct_Edit()
        {
            InitializeComponent();
            initTypeCbb();
        }
        private void initTypeCbb()
        {
            //khoi tao combobox
            cbo_frmProduct_Edit_TypeID.DataSource = help.getDataCbb("Type");
            //hien thi ten loai len dtgv
            cbo_frmProduct_Edit_TypeID.DisplayMember = "TypeName";
            //gia tri cua cbb la type id
            cbo_frmProduct_Edit_TypeID.ValueMember = "TypeID";
        }
        // dat gia tri cho bien
        public void setProductID(string id)
        {
            ProductID = id;
        }
        public void setNOP(string name)
        {
            NOP = name;
        }
        public void setTypeID(string id)
        {
            TypeID = id;
        }
        public void setNote(string s)
        {
            Note = s;
        }
        public void setQuanty(string i)
        {
            Quanty = i;
        }
        public void setPrice(string i)
        {
            Price = i;
        }
        public void setSize(string i)
        {
            Size = i;
        }
        // xu li nhap
        private void txt_frmProduct_Edit_Quanty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_frmProduct_Edit_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_frmProduct_Edit_Size_KeyPress(object sender, KeyPressEventArgs e)
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

        private void but_frmProduct_Edit_Ok_Click(object sender, EventArgs e)
        {

            string sql = "UPDATE Product SET ProductTypeID ='" + cbo_frmProduct_Edit_TypeID.SelectedValue + "',"
                       + "ProductName = N'" + txt_frmProduct_Edit_NOP.Text + "',"
                       + "Quanty = " + txt_frmProduct_Edit_Quanty.Text + ","
                       + "Price = " + txt_frmProduct_Edit_Price.Text + ","
                       + "Size = '" + txt_frmProduct_Edit_Size.Text + "',"
                       + "Note = N'" + txt_frmProduct_Edit_Note.Text + "'"
                       + "WHERE ProductID = '" + txt_frmProduct_Edit_ProductID.Text + "'";
            help.Excute_query(sql);
            this.Close();
        }

        private void but_frmProduct_Edit_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_frmProduct_Edit_Quanty_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_frmProduct_Edit_Quanty.Text) != true)
            {
                MessageBox.Show("Chỉ được nhập số !!", "NOTICE!");
                txt_frmProduct_Edit_Quanty.Text = "";
            }
        }

        private void txt_frmProduct_Edit_Price_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_frmProduct_Edit_Price.Text) != true)
            {
                MessageBox.Show("Chỉ được nhập số !!", "NOTICE!");
                txt_frmProduct_Edit_Price.Text = "";
            }
        }

        private void txt_frmProduct_Edit_Size_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txt_frmProduct_Edit_Size.Text) != true)
            {
                MessageBox.Show("Chỉ được nhập số !!", "NOTICE!");
                txt_frmProduct_Edit_Size.Text = "";
            }
        }

        //////////////////////////////
        //hien thong tin len cac box

        public void showInformation()
        {
            txt_frmProduct_Edit_ProductID.Text = ProductID;
            txt_frmProduct_Edit_NOP.Text = NOP;
            cbo_frmProduct_Edit_TypeID.Text = TypeID;
            txt_frmProduct_Edit_Quanty.Text = Quanty;
            txt_frmProduct_Edit_Note.Text = Note;
            txt_frmProduct_Edit_Price.Text = Price;
            txt_frmProduct_Edit_Size.Text = Size;
        }

    }
}
