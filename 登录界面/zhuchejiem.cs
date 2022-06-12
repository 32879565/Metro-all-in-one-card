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
    public partial class zc : Form
    {
        public zc()
        {
            InitializeComponent();
        }

        private void zc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //接收用户输入
            string name = this.yhm.Text;
            string miman = this.miman.Text;
            string qrmiman = this.qrmiman.Text;

            //非空验证
            if (name == "" || miman == "")
            {
                MessageBox.Show("用户名或密码不能为空！");
                this.yhm.Focus();
                this.miman.Focus();
                return;
            }

            //提示用户密码和确认密码不一致
            if (miman != qrmiman)
            {
                MessageBox.Show("密码和确认密码不一致！");
                return;
            }

            //把数据赋值到数据库
            string stAdd = string.Format("insert dl values('{0}','{1}')", name, miman);
            bool AddB = DBHelper.ExecuteNonQuery(stAdd);

            //提示用户是否添加成功
            if (AddB)
            {
                MessageBox.Show("用户添加成功！");
                this.Hide();
            }
            else
                MessageBox.Show("用户添加失败！");        
        }
       /* string co = "server=.;database=yikatong;uid=sa;pwd=1234";
        SqlConnection rood = new SqlConnection(co);
        rood.Open();
            string sql = string.Format("insert ID valuse('{0}','{1})'", name, miman);
        SqlCommand cmd = rood.CreateCommand();
            if (cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("用户添加成功！");
                this.Hide();
    }
            else
            {
                MessageBox.Show("用户添加失败！");*/
           
        private void yhm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
