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
    public partial class zhujiem : Form
    {
        //实例化窗体
         yhzbxxgli yhu = new yhzbxxgli();
         moniditxf moni = new moniditxf();
         xiaofeijilucx xf = new xiaofeijilucx();
        public zhujiem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //点击下一个窗体，隐藏上一个窗体
        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            moni.TopLevel = false;
            panel1.Controls.Add(moni);
            yhu.Hide();
            xf.Hide();
            moni.Show();

           
        }
        //点击下一个窗体，隐藏上一个窗体
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            yhu.TopLevel = false;
            panel1.Controls.Add(yhu);
            moni.Hide();
            xf.Hide();
            yhu.Show();
           
            
        }
        //点击下一个窗体，隐藏上一个窗体
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            xf.TopLevel = false;
            panel1.Controls.Add(xf);
            moni.Hide();
            yhu.Hide();
            xf.Show();
        }
        //退出系统
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出应用程序
        }
        //退出系统
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //此处添加的代码，将在窗体被关闭前自动执行
            //弹出自定义对话框
            DialogResult result = MessageBox.Show("确定要退出本系统吗？","提示：",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //判断用户最终点击了哪个按钮
            if (result == DialogResult.Yes)
            {
                //如果用户选择了“是”则执行窗体关闭事件
            }
            else
            {
                //如果用户选择了“否”则取消窗体关闭事件
                e.Equals(CancelButton);
            }
            Application.Exit();//退出应用程序
        }

        private void zjm_Load(object sender, EventArgs e)
        {


        }
    }
}
