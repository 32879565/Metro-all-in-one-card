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
    public partial class 登录 : Form
    {
        public 登录()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = this.textBox1.Text;
            string passWord = this.textBox2.Text;
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("用户名和密码不能为空！");
            }
            else
            {
                if (userName == "admin" && passWord == "admin")
                {
                    基本信息录入 form2 = new 基本信息录入();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
        }
        

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            注册 form3 = new 注册();
            form3.Show();
            this.Hide();

        }
    }
}
