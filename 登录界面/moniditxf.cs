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
    public partial class moniditxf : Form
    {
        public moniditxf()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //读取用户输入信息
            string kahao = text_yhkahao.Text;
            //string jine = text_zhifjine.Text;
            string jinzhan = cmbJinRu.Text;
            string chuzhan = cmbChuZhan.Text;
            string caozuojine = text_zhifjine.Text;
            //用户输入信息是否与数据库的内容一致
            string sqlstr = string.Format("update ID set jine-={0},jin='{1}',chu='{2}',caozuojine={3} where kahao={4}", caozuojine,jinzhan,chuzhan,caozuojine, kahao);
            bool i = DBHelper.ExecuteNonQuery(sqlstr);
            if (i == true)
            {
                MessageBox.Show("支付成功！");
            }
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void 模拟地铁刷卡消费_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //把数据库里面的内容进行赋值
            string stuery = @"select name 姓名,kahao 卡号,sex 性别,age 年龄,csje 初始金额 from ID where kahao='" + this.text_yhkahao.Text + "'";
            DataTable dt = new DataTable();
            dt = DBHelper.ExcuteQuery(stuery);

            text_yhxm.Text = dt.Rows[0][0].ToString();
            com_yhxb.Text = dt.Rows[0][2].ToString();
            text_nianlin.Text = dt.Rows[0][3].ToString();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //清空用户的输入信息
           this.text_yhkahao.Clear();
           this.text_yhxm.Clear();
           this.com_yhxb.Items.Clear();
           this.text_nianlin.Clear();
           this.cmbJinRu.Text = "";
           this.cmbChuZhan.Text = "";
           this.text_zhifjine.Clear();
           
          
        }

        private void pi_yuzhu_Click(object sender, EventArgs e)
        {
          
        }

        private void cmbJinRu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //接收进站口，出站口选中的项编号
            int i = cmbJinRu.SelectedIndex;
            int j = cmbChuZhan.SelectedIndex;

            //清空出站口的项
            cmbChuZhan.Items.Clear();
            //根据进站口的项，来加载出站口的项
            switch (i)
            {
                case 0:
                    cmbChuZhan.Items.Add("石埠");
                    cmbChuZhan.Items.Add("南职院");
                    cmbChuZhan.Items.Add("鹏飞路");
                    cmbChuZhan.Items.Add("西乡塘客运站");
                    cmbChuZhan.Items.Add("民族大学");
                    cmbChuZhan.Items.Add("清川");
                    cmbChuZhan.Items.Add("动物园");
                    cmbChuZhan.Items.Add("鲁班路");
                    cmbChuZhan.Items.Add("广西大学");
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 1:
                    cmbChuZhan.Items.Add("南职院");
                    cmbChuZhan.Items.Add("鹏飞路");
                    cmbChuZhan.Items.Add("西乡塘客运站");
                    cmbChuZhan.Items.Add("民族大学");
                    cmbChuZhan.Items.Add("清川");
                    cmbChuZhan.Items.Add("动物园");
                    cmbChuZhan.Items.Add("鲁班路");
                    cmbChuZhan.Items.Add("广西大学");
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                   
                    break;
                case 2:
                    cmbChuZhan.Items.Add("鹏飞路");
                    cmbChuZhan.Items.Add("西乡塘客运站");
                    cmbChuZhan.Items.Add("民族大学");
                    cmbChuZhan.Items.Add("清川");
                    cmbChuZhan.Items.Add("动物园");
                    cmbChuZhan.Items.Add("鲁班路");
                    cmbChuZhan.Items.Add("广西大学");
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 3:
                    cmbChuZhan.Items.Add("西乡塘客运站");
                    cmbChuZhan.Items.Add("民族大学");
                    cmbChuZhan.Items.Add("清川");
                    cmbChuZhan.Items.Add("动物园");
                    cmbChuZhan.Items.Add("鲁班路");
                    cmbChuZhan.Items.Add("广西大学");
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 4:
                    cmbChuZhan.Items.Add("民族大学");
                    cmbChuZhan.Items.Add("清川");
                    cmbChuZhan.Items.Add("动物园");
                    cmbChuZhan.Items.Add("鲁班路");
                    cmbChuZhan.Items.Add("广西大学");
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 5:
                    cmbChuZhan.Items.Add("清川");
                    cmbChuZhan.Items.Add("动物园");
                    cmbChuZhan.Items.Add("鲁班路");
                    cmbChuZhan.Items.Add("广西大学");
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 6:
                    cmbChuZhan.Items.Add("动物园");
                    cmbChuZhan.Items.Add("鲁班路");
                    cmbChuZhan.Items.Add("广西大学");
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 7:
                    cmbChuZhan.Items.Add("鲁班路");
                    cmbChuZhan.Items.Add("广西大学");
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 8:
                    cmbChuZhan.Items.Add("广西大学");
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 9:
                    cmbChuZhan.Items.Add("白苍岭");
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 10:
                    cmbChuZhan.Items.Add("火车站");
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");

                    break;
                case 11:
                    cmbChuZhan.Items.Add("朝阳广场");
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 12:
                    cmbChuZhan.Items.Add("新民路");
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站"); 

                    break;
                case 13:
                    cmbChuZhan.Items.Add("麻村");
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 14:
                    cmbChuZhan.Items.Add("南湖");
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 15:
                    cmbChuZhan.Items.Add("金湖广场");
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 16:
                    cmbChuZhan.Items.Add("会展中心");
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 17:
                    cmbChuZhan.Items.Add("万象城");
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 18:
                    cmbChuZhan.Items.Add("东盟商务区");
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 19:
                    cmbChuZhan.Items.Add("凤岭");
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 20:
                    cmbChuZhan.Items.Add("埌东客运站");
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 21:
                    cmbChuZhan.Items.Add("百花岭");
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 22:
                    cmbChuZhan.Items.Add("佛子岭");
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                case 23:
                    cmbChuZhan.Items.Add("火车东站");
                    break;
                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbChuZhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbChuZhan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //通过进出入站口进行计算金额
            int i = cmbJinRu.SelectedIndex;
            int j = cmbChuZhan.SelectedIndex;

            switch (i)
            {
                case 0:
                    int sum = (j + 1 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 1:
                    sum = (j + 2 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 2:
                    sum = (j + 3 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 3:
                    sum = (j + 4 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 4:
                    sum = (j + 5 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 5:
                    sum = (j + 6 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 6:
                    sum = (j + 7 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 7:
                    sum = (j + 8 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 8:
                    sum = (j + 9 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 9:
                    sum = (j + 10 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 10:
                    sum = (j + 11 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 11:
                    sum = (j + 12- i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 12:
                    sum = (j + 13 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 13:
                    sum = (j + 14 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 14:
                    sum = (j + 15 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 15:
                    sum = (j + 16 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 16:
                    sum = (j + 17 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 17:
                    sum = (j + 18 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 18:
                    sum = (j + 19 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 19:
                    sum = (j + 20 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 20:
                    sum = (j + 21 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 21:
                    sum = (j + 22 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 22:
                    sum = (j + 23 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 23:
                    sum = (j + 24 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                case 24:
                    sum = (j + 25 - i) * 1;
                    text_zhifjine.Text = sum.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
