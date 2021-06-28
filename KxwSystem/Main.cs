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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login login =(Login) this.Owner;//获取登录窗体对象
            //判断用户名和密码是否正确
            if (login.userName=="kuaixiang" && login.pwd=="123456")
            {
                this.dataGridView1.AllowUserToAddRows = false;//是否允许用户添加行
                this.dataGridView1.AutoGenerateColumns = false;//是否为数据源中的每个字段自动创建绑定字段
                string sqlStr = "select * from orderinfo";//查询sql语句
                //绑定数据到dataGridView1控件
                this.dataGridView1.DataSource = DbHelper.QueryData(sqlStr);
            }
            else
            {
                Login login1 = new Login();
                login1.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false;//是否允许用户添加行
            this.dataGridView1.AutoGenerateColumns = false;//是否为数据源中的每个字段自动创建绑定字段
            var orderNo = this.OrderNoText.Text.Trim();//订单号
            var planNo = this.PlanNotext.Text.Trim();//预约号
            var suitcaseNo = this.SuitcaseNotext.Text.Trim();//提单号
            StringBuilder sqlStr = new StringBuilder("select * from orderinfo where 1=1");
            
            if (!string.IsNullOrEmpty(orderNo))
            {
                sqlStr.Append(" and orderno like '%"+orderNo+"%'");
            }
            if (!string.IsNullOrEmpty(planNo))
            {
                sqlStr.Append(" and planNo like '%" + planNo + "%'");
            }
            if (!string.IsNullOrEmpty(suitcaseNo))
            {
                sqlStr.Append(" and suitcaseNo like '%" + suitcaseNo + "%'");
            }
           //绑定数据到dataGridView1控件
            this.dataGridView1.DataSource = DbHelper.QueryData(sqlStr.ToString());
        }
    }
}
