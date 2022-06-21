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
    public partial class yhzbxxgli : Form
    {
        public yhzbxxgli()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 用户基本信息管理_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                //接收用户输入
            string kaohao = this.yhkh.Text;
            string xinming = this.yhxm.Text;
            string xingbei = this.yhxb.Text;
            string nianli = this.yhnl.Text;
            string chushi = this.chusje.Text;
            string riqi = dateTimePicker1.Text;
            DateTime shijian = DateTime.Parse(riqi);

            //非空验证
            if (kaohao == "" || xinming == "" || xingbei == "" || nianli == "" || chushi == "")
            {
                MessageBox.Show("所有信息不能为空!");
                this.yhkh.Focus();
                this.yhxm.Focus();
                this.yhxb.Focus();
                this.yhnl.Focus();
                this.chusje.Focus();
                return;
            }
            
           

            //连接数据库添加用户基本信息
            string stAdd = string.Format("insert ID(kahao,name,sex,age,jine,tianjia) values('{0}','{1}','{2}','{3}','{4}','{5}')", kaohao, xinming,xingbei,nianli,chushi,shijian);
            bool AddB = DBHelper.ExecuteNonQuery(stAdd);
            //提示用户的信息是否添加成功
            if (AddB)
                MessageBox.Show("用户添加成功！");

               
            else
                MessageBox.Show("用户添加失败！");
        }
       //输入用户姓名，查询用户信息
        private void ZX市_Click(object sender, EventArgs e)
        {
            //提示用户是否输入用户姓名
            string yhxm = this.yhxingm.Text;
            if (yhxm == "")
            {
                MessageBox.Show("请输入您需要查询用户姓名！");
                return;
            }    
            string stQuery = @"select name 姓名,kahao 卡号,sex 性别,age 年龄,jine 金额,tianjia 添加时间 from ID where name='"+this.yhxingm.Text+"'";
            DataTable dt = new DataTable();
            dt = DBHelper.ExcuteQuery(stQuery);
            dgv_userInfo.DataSource = dt;
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        //删除用户信息
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlAdd = string.Format("delete  from ID where name='" + yhxingm.Text + "' ");
            bool add = DBHelper.ExecuteNonQuery(sqlAdd);
            //提示用户信息是否删除成功
            if (add)
                MessageBox.Show("删除成功!");
            else
                MessageBox.Show("删除失败!");
            string stQuery = @"select name 姓名,kahao 卡号,sex 性别,age 年龄,jine 金额 from ID";
            DataTable dt = new DataTable();
            dt = DBHelper.ExcuteQuery(stQuery);
            dgv_userInfo.DataSource = dt;
        }

        private void dgv_userInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
