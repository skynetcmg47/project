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
        private bool isExpandPress = false;
        private commonUtilities common = new commonUtilities();
        public mainForm()
        {
            InitializeComponent();
            //InitManageForm();
            btn_main_Manage.selected = false;
            initSellForm();
            btn_main_Manage.selected = true;
            if (!common.getAuthorities().Equals("admin"))
                btn_main_Manage.Enabled = false;
        }
        private void InitManageForm()
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.viewPanel.Controls.Clear();

            frmManage frmChild = new frmManage();
            frmChild.Size = viewPanel.Size;
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.viewPanel.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }
        
       

        private void btn_main_Manage_Click(object sender, EventArgs e)
        {
            InitManageForm();

        }
        private void btn_main_Statistic_Click(object sender, EventArgs e)
        {
            InitStatisticForm();
        }

        private void InitStatisticForm()
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.viewPanel.Controls.Clear();
            Statistic_Growth frmChild = new Statistic_Growth();
            frmChild.Size = viewPanel.Size;
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.viewPanel.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }
        private void btn_system_close_Click(object sender, EventArgs e)
        {
            if (this.isExpandPress)
            {
                this.WindowState = FormWindowState.Normal;
                this.isExpandPress = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

                this.isExpandPress = true;
            }
            if (btn_main_Manage.selected)
            {
                InitManageForm();
            }
            else if(btn_main_account.selected)
            {
                InitAccount();
            }
            else if(btn_main_Statistic.selected)
            {
                InitStatisticForm();
            }
            else if(btn_sell.selected)
            {
                initSellForm();
            }

        }

        

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_expand_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();
            
        }

        private void InitAccount()
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.viewPanel.Controls.Clear();

            account frmChild = new account();
            frmChild.Size = viewPanel.Size;
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.viewPanel.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }

        private void btn_main_account_Click(object sender, EventArgs e)
        {
            InitAccount();
        }


        private void btn_sell_Click(object sender, EventArgs e)
        {
            initSellForm();
        }
        private void initSellForm()
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.viewPanel.Controls.Clear();

            frmSell frmChild = new frmSell();
            frmChild.Size = viewPanel.Size;
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.viewPanel.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }

        private void btn_signOut_Click(object sender, EventArgs e)
        {

            DialogResult dl= MessageBox.Show("Bạn có thực sự muốn đăng xuất ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                SignIn signIn = new SignIn();
                this.Hide();
                signIn.ShowDialog();
                this.Close();
            }
            
        }
    }
}
