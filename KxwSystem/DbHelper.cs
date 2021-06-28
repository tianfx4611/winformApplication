using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KxwSystem
{
    public class DbHelper
    {
        private static  MySqlConnection conn;
        /// <summary>
        /// 打开连接
        /// </summary>
        /// <returns></returns>
        public static bool OpenConnection()  
        {
            try
            {
                MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
                sb.Server = "***.***.**.**";//数据库ip
                sb.Port = 3306;//你的数据库端口
                sb.Database = "table";//数据库名称
                sb.UserID = "root";//登录用户
                sb.Password = "******";//登录密码
                sb.AllowUserVariables = true;//是否允许sql中出现用户变量
                conn = new MySqlConnection(sb.ConnectionString);//实例化连接
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
          
        }
        //关闭连接
        public static bool CloseConnection() {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
          
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public static DataTable QueryData(string sqlStr) 
        {
            //DataTable对象(相当于前台的虚拟数据库中的数据表)

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);//实例化数据mysql数据适配器
               //将查询的结果存到虚拟数据库ds中的虚拟表orderinfo中
                da.Fill(ds,"orderinfo");
            }
            CloseConnection();
            return ds.Tables["orderinfo"];
        }
    }
}
