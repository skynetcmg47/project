﻿using System;
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
    public partial class account : Form
    {
        commonUtilities cuser = new commonUtilities();

        public account()
        {
            InitializeComponent();
            txt_changeUserName.Text = cuser.getUserName();
            txt_changeUserName.Enabled = false;

        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            string username = txt_userName.Text;
            string pass = txt_pass.Text;
            string repass = txt_repass.Text;
            SQLHelp help = new SQLHelp();
            if (txt_changeUserName.Text.Equals("admin"))
                if (help.checkID("UserNameAndPass", username))
                    if (pass.Equals(repass))
                    {
                        help.Excute_query("INSERT INTO UserNameAndPass VALUES ('" + username + "','" + pass + "')");
                        lb_account.Text = "Tạo tài khoản thành công";
                        lb_account.ForeColor = Color.Green;
                        txt_userName.Text = "";
                    }
                    else
                    {
                        lb_account.Text = "Mật khẩu không trùng khớp";
                        lb_account.ForeColor = Color.Red;
                    }
                else
                {
                    lb_account.Text = "Tên đăng nhập đã tồn tại";
                    lb_account.ForeColor = Color.Red;
                }
            else
            {
                lb_account.Text = "Bạn không có quyền tạo tài khoản";
                lb_account.ForeColor = Color.Red;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {

            if(txt_oldpass.Text.Equals(cuser.getPass()))
            {
                if(txt_newpass.Text.Equals(txt_renewpass.Text))
                {
                    SQLHelp help = new SQLHelp();
                    help.Excute_query("UPDATE UserNameAndPass SET Pass='" + txt_newpass.Text + "' WHERE UserName = '" + txt_changeUserName.Text + "'");
                    lb_account.Text = "Thay đổi mật khẩu thành công";
             
                    lb_account.ForeColor = Color.Green;

                    commonUtilities cuser = new commonUtilities();
                    cuser.setPass(txt_newpass.Text);
                }
                else
                {
                    lb_account.Text = "Mật khẩu không trùng khớp";
                    lb_account.ForeColor = Color.Red;
                }
            }
            else
            {
                lb_account.Text = "Mật khẩu không đúng";
                lb_account.ForeColor = Color.Red;
            }
        }
    }
}
