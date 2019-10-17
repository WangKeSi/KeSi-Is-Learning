using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model.userInfo m_userInfo = new Model.userInfo();
        BILL.userBLL b_userAccess = new BILL.userBLL();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //将用户输入的账号密码 赋值给userInfo类 username、psw属性  
            m_userInfo.username = textBox1.Text.Trim().ToString();
            m_userInfo.password = textBox2.Text.Trim().ToString();

            //如果BLL层中 useLogin调用返回记录条数 大于1 则账号密码正确  
            if (b_userAccess.userLogin(m_userInfo) > 0)
            {
                MessageBox.Show("登录成功!","提示");
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();                           
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strCon = "server=127.0.0.1;port=3306;user=root;password=root; database=c#_data;";
            
            
            MySqlConnection conn = new MySqlConnection(strCon);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                textBox1.AppendText("数据库连接成功！");
            }
            else
            {
                textBox1.AppendText("数据库连接失败！");
            }
        }
    }
}
