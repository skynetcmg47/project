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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            //AcceptButton = (Button)btn_Signin;
            this.KeyPreview = true;

        }

        private void btn_signIn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SignIn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            SignUpAction();
        }
        private void SignUpAction()
        {
            if (txt_userName.Text != "" && txt_pass.Text != "")
            {
                if (checkLogin())
                {
                    mainForm mainform = new mainForm();
                    lb_notice.Text = "";
                    this.Hide();
                    mainform.ShowDialog();
                    this.Close();

                }
                else
                {
                    lb_notice.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                    lb_notice.ForeColor = Color.Red;
                    txt_pass.Text = "";
                    txt_userName.Text = "";

                }
            }
            else
            {
                lb_notice.Text = "Nhập đầy đủ thông tin!";
                lb_notice.ForeColor = Color.Red;
            }
        }
        private bool checkLogin()
        {
            SQLHelp help = new SQLHelp();
            string userName = txt_userName.Text;
            string pass = txt_pass.Text;
            DataTable tb = help.getDataTable_excute("exec sp_checkLogin '" + userName + "' ,'" + pass + "'");
            if(tb.Rows.Count>0)
            {
                commonUtilities setUser = new commonUtilities();
                setUser.setUserName(tb.Rows[0][0].ToString());
                setUser.setPass(tb.Rows[0][1].ToString());
                setUser.setAuthorities(tb.Rows[0][2].ToString());
                return true;
            }
            else
            {
                return false;
            }

        }

        private void SignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SignUpAction();
            }
        }
    }
}
