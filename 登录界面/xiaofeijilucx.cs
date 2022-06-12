using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 登录界面
{
    public partial class xiaofeijilucx : Form
    {
        public xiaofeijilucx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //读取数据库里面的内容
            string stQuery = @"select name 姓名,kahao 卡号,sex 性别,age 年龄 from ID where kahao='" + this.txt_yhkahao.Text + "'";
            DataTable dt = new DataTable();
            dt = DBHelper.ExcuteQuery(stQuery);
            //进行赋值
            txt_yhxm.Text = dt.Rows[0][0].ToString();
            txt_yhxb.Text = dt.Rows[0][2].ToString();
            txt_yhnianlin.Text = dt.Rows[0][3].ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //接收用户输入的信息
            string yhkahao = this.txt_yonghukahao.Text;
            if (yhkahao == "")
            {
                MessageBox.Show("请输入您需要查询用户卡号！");
                return;
            }
            else
            {
                yhkahao = txt_yonghukahao.Text;
                //用户输入信息进行数据库查询
                SqlConnection conn = new SqlConnection(DBHelper.ConnString);
                DataSet ds = new DataSet();
                SqlDataAdapter dap;
                string sqlstr = string.Format("select * from ID where kahao='{0}'", yhkahao);
                dap = new SqlDataAdapter(sqlstr, conn);
                dap.Fill(ds, "XiaoFei");
                SqlCommandBuilder builder = new SqlCommandBuilder(dap);
                this.datavie.AutoGenerateColumns = false;
                this.datavie.DataSource = ds.Tables["XiaoFei"];

                string sql = string.Format("select jine from ID where kahao='{0}'", yhkahao);

                SqlDataReader reader= DBHelper.GetDataReader(sql);
                while (reader.Read())
                {
                    zhanghuyue.Text = reader["jine"].ToString();
                }
                reader.Close();

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string jine=txt_yhczje.Text;
            int je=int.Parse(jine);

            if (je % 100 == 0)
            {
                string kahao = txt_yhkahao.Text;
                string sqlstr = string.Format("update ID set jine+={0} where kahao={1}", jine, kahao);
                bool i = DBHelper.ExecuteNonQuery(sqlstr);
                if (i == true)
                {
                    MessageBox.Show("充值成功！");
                }
            }
            else
            {
                MessageBox.Show("请充值整100数的金额！");
            }
            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void datavie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_yhxb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
