using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录界面
{
    public partial class dl : Form
    {
        public dl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dlm = this.textBox1.Text;
            string mm = this.textBox2.Text;
            if (dlm == "" || mm == "")
            {
                MessageBox.Show("账号或者密码不能为空！");
            }
            //连接到数据库，把数据库用户信息提取出来
            string stLogin = @"select*from dl where name='" + textBox1.Text.ToString() + "' and mima='" + textBox2.Text.ToString() + "';";
            DataTable dt = new DataTable();
            dt = DBHelper.ExcuteQuery(stLogin);
            //登录成功跳转至主界面
            if (dt.Rows.Count > 0)
            {
                zhujiem zujiem = new zhujiem();
                zujiem.Show();
                this.Hide();
            }
                //提示用户的账户或者密码不正确
            else
                MessageBox.Show("账号或者密码不对！");

        }
       
        //用户没有账户可以去注册，跳转至注册界面
        private void button2_Click(object sender, EventArgs e)
        {
            zc zcjm = new zc();
            zcjm.Show();

        }

        private void dl_Load(object sender, EventArgs e)
        {

        }

    }
}
           
            

