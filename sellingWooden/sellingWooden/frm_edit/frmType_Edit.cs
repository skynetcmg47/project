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
    public partial class frmType_Edit : Form
    {
        string TypeID, NOT;
        public frmType_Edit()
        {
            InitializeComponent();
        }
        public void setTypeID(string id)
        {
            TypeID = id;
        }
        public void setNOT(string name)
        {
            NOT = name;
        }

        private void btn_type_edit_ok_Click(object sender, EventArgs e)
        {
            SQLHelp help = new SQLHelp();
            string sql = "UPDATE Type SET TypeName = '" + txt_frmType_Edit_NOT.Text + "' WHERE TypeID = '" + txt_frmTypeID_Edit_TypeID.Text + "'";
            help.Excute_query(sql);
            this.Close();
        }

        public void showInformation()
        {
            txt_frmTypeID_Edit_TypeID.Text = TypeID;
            txt_frmType_Edit_NOT.Text = NOT;
        }
    }
}
