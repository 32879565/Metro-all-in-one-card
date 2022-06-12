using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 登录界面
{
    class DBHelper
    {
        public static string connStr = "server=.;database=yikatong;uid =sa;pwd =1234";

        public static SqlConnection conn = new SqlConnection(connStr);

        public static DataTable ExcuteQuery(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.Tables[0];
        }

        //public static bool ExecuteNonQuery(string sql)
        //{
        //    int result;
        //    SqlCommand Comm = new SqlCommand(sql, conn);
        //    conn.Open();
        //    result = Comm.ExecuteNonQuery();
        //    if (result > 0)
        //        return true;
        //    else
        //        return false;
        //}




        //数据库连接字符串
        public static string ConnString = "server=.;database=yikatong;uid =sa;pwd =1234";
        //数据库连接对象
        private static SqlConnection Conn = null;

        //初始化数据库连接
        private static void InitConnection()
        {
            //如果连接对象不存在，则创建连接
            if (Conn == null)
                Conn = new SqlConnection(ConnString);
            //如果连接对象关闭，则打开连接
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            //如果连接中断，则重启连接
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }
        //查询，获取DataReader
        public static SqlDataReader GetDataReader(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            //CommandBehavior.CloseConnection命令行为：当DataReader对象被关闭时，自动关闭占用的连接对象
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //查询，获取DataTable
        public static DataTable GetDataTable(string sqlStr)
        {
            InitConnection();
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sqlStr, Conn);
            dap.Fill(table);
            Conn.Close();
            return table;
        }
        //增删改
        public static bool ExecuteNonQuery(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            return result > 0;
        }
        //执行集合函数
        public static object ExecuteScalar(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            object result = cmd.ExecuteScalar();
            Conn.Close();
            return result;
        }
    }
}
