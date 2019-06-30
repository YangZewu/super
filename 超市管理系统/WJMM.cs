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
using System.Data.SqlClient;
namespace 超市管理系统
{
    public partial class WJMM : Form
    {
        
        public WJMM()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        SqlDataReader Lin;
        string checkCode;
        private void WJMM_Load(object sender, EventArgs e)
        {
            Lin = userManag.getJF(userManag.icNo);
            while (Lin.Read())
            {
                Get_label_Name.Text = Lin["userName"].ToString();
            }
            Lin.Close();
            checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
            image_Code.Image = MyCode.CreateImage(checkCode);//实现验证码图片
        }

        private void Btn_GG_Click(object sender, EventArgs e)
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
                //验证成功，修改密码
                int i = (int)userManag.XGMM(Pwd.Text, userManag.icNo);
                if (i > 0)
                {
                    MessageBox.Show("已修改成功！，請重新登录");
                    __main__ __Main__ = new __main__();
                    __Main__.Close();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("修改失败！");
                    this.Close();
                }
            }
        }

        private void Click_Code_Click(object sender, EventArgs e)
        {
            checkCode = MyCode.GetRandomCode(4);//获取4个随机的数字或字母
            image_Code.Image = MyCode.CreateImage(checkCode);//实现验证码图片
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
