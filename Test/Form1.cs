using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //提交测试，测试，测试
            MessageBox.Show("GitHub ，使用方法，先创建项目，（Git更改）再创建仓库（视图->Git更改）");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //提交 1

            //提交 2

            MessageBox.Show("你好");
        }
    }
}
