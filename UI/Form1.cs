using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;
namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            us.Username = this.txtUsername.Text.Trim();
            us.Pass = this.txtPass.Text.Trim();
            if (UsersManager.Register(us))
            {
                MessageBox.Show("注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users us = null;
            if (UsersManager.Login(ref us,this.txtUsername.Text.Trim(),this.txtPass.Text.Trim()))
            {
                MessageBox.Show("登录成功，你好：" + us.Username);
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
