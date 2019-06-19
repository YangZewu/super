using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 超市管理系统
{
    public partial class __main__ : Form
    {
        public __main__()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void __main___Load(object sender, EventArgs e)
        {
            Label_Time1.Text= DateTime.Now.ToLongDateString().ToString();
            Label_Time2.Text= DateTime.Now.ToLongTimeString().ToString();

        }
        //定时器,刷新时间,实现时间一秒更新一次
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Label_Time2.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void 新建会员卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text != "当前时间为：")//后面需要改为区分会员跟管理员的权限
            {
                MessageBox.Show("您没有权限访问,如需办卡請联系管理员办理！","权限提示", MessageBoxButtons.OK);
            }
            else
            {
                NewFile newFile = new NewFile();
                newFile.Show();
            }
        }
    }
}
