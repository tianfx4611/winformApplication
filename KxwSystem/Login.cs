using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KxwSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string userName = null;
        public string pwd = null;
        private void button1_Click(object sender, EventArgs e)
        {
             userName = this.txtUserName.Text.Trim();//去掉前后空格
             pwd = this.txtPassWord.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(pwd)) { 
                MessageBox.Show("密码不能为空！");
                return;
            }
            //判断用户名是否正确
            if (userName=="kuaixiang" && pwd=="123456")
            {
              
                //实例化主页窗体
                Main main = new Main(); 
                //隐藏当前窗体
                this.Hide();
                //显示主页窗体
                main.ShowDialog(this);
               
            }
            else
            {
                MessageBox.Show("用户名或密码不正确！");
                return;
            }

        }
    }
}

