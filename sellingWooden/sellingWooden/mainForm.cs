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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            InitHomeForm();
        }
        private void InitManageForm()
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.mainPanel.Controls.Clear();

            frmManage frmChild = new frmManage();
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.mainPanel.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }
        private void InitHomeForm()
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.mainPanel.Controls.Clear();

            frmHome frmChild = new frmHome();
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.mainPanel.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            InitHomeForm();
        }

        private void btn_main_Manage_Click(object sender, EventArgs e)
        {
            InitManageForm();
        }
    }
}
