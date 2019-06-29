using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace 超市管理系统
{
    public partial class __main__ : Form
    {
        //图片轮播的方法
        private void ChangeImage(Image img, int millisecondsTimeOut)
        {
            this.Invoke(new Action(() =>
            {
                images_L.Image = img;
            })
                );
            Thread.Sleep(millisecondsTimeOut);
        }
        public __main__()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        Thread th;
        private void __main___Load(object sender, EventArgs e)
        {
            TSSL_Name.Text = userManag.Name;
            NowTime_HMS.Alignment = ToolStripItemAlignment.Right;
            NowTime_NYR.Alignment = ToolStripItemAlignment.Right;
            NowTime_HMS.Text = DateTime.Now.ToLongTimeString().ToString();
            NowTime_NYR.Text = DateTime.Now.ToLongDateString().ToString();

            th = new Thread
               (
                   delegate ()
                   {
                      
                       for(int i=0; i<3; i++)
                       {
                           ChangeImage(超市管理系统.Properties.Resources.image_2017年物联网2班, 1000);
                           ChangeImage(超市管理系统.Properties.Resources.轮播, 1000);
                           ChangeImage(超市管理系统.Properties.Resources.签到, 1000);
                       }
                   }
               );
            th.IsBackground = true;
            th.Start();
        }
        //定时器,刷新时间,实现时间一秒更新一次
        private void Timer1_Tick(object sender, EventArgs e)
        {
            NowTime_HMS.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void 新建会员卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ZT.Text != "离线中")
            {
                if (userManag.icNo != "20193029023017s")//后面需要改为区分会员跟管理员的权限
                {
                    MessageBox.Show("您没有权限访问,如需办卡請联系管理员办理！", "权限", MessageBoxButtons.OK);
                }
                else
                {
                    NewFile newFile = new NewFile();
                    newFile.Show();

                }
            }
            else
            {
                MessageBox.Show("您当前状态离线中，请先登陆！！");
                Close();
                __init__ init__ = new __init__();
                init__.Show();



            }
        }

        private void 注销会员卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ZT.Text != "离线中")
            {
                Out @out = new Out();
                @out.ShowDialog();
            }
            else
            {
                MessageBox.Show("您当前状态离线中，请先登陆！！");
                Close();
                __init__ init__ = new __init__();
                init__.Show();
            }
           
        }

        private void 退出登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZT.Text = "离线中";
            MessageBox.Show("您已离线！！，要使用本系统，请先登陆");
        }

        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ZT.Text != "离线中")
            {
                signIn @in = new signIn();
                @in.ShowDialog();
            }
            else
            {
                MessageBox.Show("您当前状态离线中，请先登陆！！");
                Close();
                __init__ init__ = new __init__();
                init__.Show();
            }
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ZT.Text != "离线中")
            {
                Personal_Center _Center = new Personal_Center();
                _Center.Show();
            }
            else
            {
                MessageBox.Show("您当前状态离线中，请先登陆！！");
                Close();
                __init__ init__ = new __init__();
                init__.Show();
            }

        }
    }
}
