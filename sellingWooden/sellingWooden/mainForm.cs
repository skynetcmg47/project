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
        public mainForm()
        {
            InitializeComponent();
            InitHomeForm();
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
        private void InitHomeForm()
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.viewPanel.Controls.Clear();
            frmHome frmChild = new frmHome();
            frmChild.Size = viewPanel.Size;
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.viewPanel.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }
        private void InitSettingForm()
        {
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.viewPanel.Controls.Clear();

            setting frmChild = new setting();
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

        private void btn_main_Setting_Click(object sender, EventArgs e)
        {
            InitSettingForm();
        }

        private void btn_main_Statistic_Click(object sender, EventArgs e)
        {

        }

        private void btn_hone_Click(object sender, EventArgs e)
        {
            InitHomeForm();

        }

        private void btn_system_close_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            //su dung bunifu transit 
            if(control_panel.Width == 50)
            {
                control_panel.Visible = false;
                control_panel.Width = 185;
                panelTransit.ShowSync(control_panel);
                viewPanel.Width = this.Size.Width - control_panel.Size.Width;
                // viewPanel.Width = 893;
                //logo transit here
            }
            else
            {
                control_panel.Visible = false;
                control_panel.Width = 50;
                panelTransit.ShowSync(control_panel);
               // viewPanel.Visible = false;
                viewPanel.Width = this.Size.Width - control_panel.Size.Width;
              //  panelTransit.ShowSync(viewPanel);
                
            }
           /* if (btn_main_Manage.selected)
            {
                InitManageForm();

            }
            else if (btn_hone.selected)
                InitHomeForm();
            else if (btn_main_Setting.selected)
                InitSettingForm();*/
            //else InitStatisticForm();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_expand_Click(object sender, EventArgs e)
        {
            if(this.isExpandPress)
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
            else if (btn_hone.selected)
                InitHomeForm();
            else if (btn_main_Setting.selected)
                InitSettingForm();
            //else InitStatisticForm();
               

        }
    }
}
