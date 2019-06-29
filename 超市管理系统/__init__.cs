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
        //对验证码进行验证
        string checkCode;
        private void __init___Load(object sender, EventArgs e)
        {
            checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
            image_Code.Image = MyCode.CreateImage(checkCode);//实现验证码图片
        }
        //登录验证
        string name;
        private void Btn_Land_Click(object sender, EventArgs e)
        {
            if (icNo.Text == "")
            {
                MessageBox.Show("请先读卡，再进行此操作", "登陆提示", MessageBoxButtons.OK);
            }
            else
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
                        userManag.icNo = icNo.Text;
                        userManag.Name = name;
                        __main__ __Main__ = new __main__();
                        __Main__.Show();
                        Hide();
                        Code.Text = "";
                        icNo.Text = ""; Pwd.Text = "";
                        checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
                        image_Code.Image = MyCode.CreateImage(checkCode);
                    }
                    else
                    {
                        MessageBox.Show("登录失败");
                        Code.Text = "";
                        icNo.Text = ""; Pwd.Text = "";
                        checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
                        image_Code.Image = MyCode.CreateImage(checkCode);
                    }
                }
            }
           
        }
        //获取验证码
        private void Click_Code_Click(object sender, EventArgs e)
        {
            checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
            image_Code.Image = MyCode.CreateImage(checkCode);//实现验证码图片
        }

        private void Btn_GeticNo_Click(object sender, EventArgs e)
        {
            int icdev = DCHelper.dc_init(100, 115200);
            if (icdev > 0)
            {
                long snr = 0;
                int dccard = DCHelper.dc_card(icdev, 0, ref snr);
                if (dccard == 0)
                {
                    byte[] password = new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
                    int loadkey = DCHelper.dc_load_key(icdev, 0, 1, password);
                    if (loadkey == 0)
                    {
                        int auyhkey = DCHelper.dc_authentication(icdev, 0, 1);
                        if (auyhkey == 0)
                        {
                            byte[] data = new byte[16];
                            int dread = DCHelper.dc_read(icdev, 4, data);
                            string R = System.Text.Encoding.Default.GetString(data);
                            SqlDataReader Lin = userManag.getDataReader(R);
                            if (dread == 0)
                            {
                                icNo.Text = R;
                                while (Lin.Read())
                                {
                                    name = Lin["userName"].ToString();
                                    Pwd.Text = Lin["userPwd"].ToString();
                                }

                                MessageBox.Show("读卡成功", "提示", MessageBoxButtons.OK);
                                Lin.Close();
                                //DCHelper.dc_beep(icdev, 100);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请正确放卡");
                }
            }
            else
            {
                MessageBox.Show("请检查设备");
            }
        }
    }
}
