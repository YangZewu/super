using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace 超市管理系统
{
    public partial class __init__ : Form
    {
        public __init__()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void __init___Load(object sender, EventArgs e)
        {
            string checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
           image_Code.Image = MyCode.CreateImage(checkCode);//实现验证码图片
        }
    }
}
