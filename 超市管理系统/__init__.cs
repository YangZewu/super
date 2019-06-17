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
            __main__ __Main__ = new __main__();
            __Main__.ShowDialog();
            this.Close();
        }
        //对验证码进行验证
        string checkCode;
        private void __init___Load(object sender, EventArgs e)
        {
            checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
            image_Code.Image = MyCode.CreateImage(checkCode);//实现验证码图片
        }
        //登录验证

        private void Btn_Land_Click(object sender, EventArgs e)
        {
            if (checkCode != Code.Text)
            {
                MessageBox.Show("验证码错误");
                checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
                image_Code.Image = MyCode.CreateImage(checkCode);//实现验证码图片
                Code.Text = "";

            }
            else
            {
                int a = userManag.getUser(icNo.Text, Pwd.Text);
                if (a > 0)
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
        }
        //获取验证码
        private void Click_Code_Click(object sender, EventArgs e)
        {
            checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
            image_Code.Image = MyCode.CreateImage(checkCode);//实现验证码图片
        }
    }
}
