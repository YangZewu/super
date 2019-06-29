using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace 超市管理系统
{
    public partial class XGXX : Form
    {
        public XGXX()
        {
            InitializeComponent();
        }

        private void BtnXG_Click(object sender, EventArgs e)
        {
            int i = (int)userManag.XGXX(TextBox_Tel.Text, ".\\images\\" + Textbox_icNo.Text+".jpg", Textbox_Name.Text, TextBox_Bir.Value, TextBox_Email.Text, Textbox_address.Text, TextBox_PC.Text, comboBox_sex.Text, Textbox_icNo.Text);
            if (i > 0)
                MessageBox.Show("修改成功！");
            else
                MessageBox.Show("修改失败！");
        }

 

        private void XGXX_Load(object sender, EventArgs e)
        {
            Textbox_icNo.Text = userManag.icNo;
        }

        private void XGTP_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult r = open.ShowDialog();
            //在控件中显示图片
            if (r == DialogResult.OK)
            {
                image_Head.Image = Image.FromFile(open.FileName);
                if (!Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "\\images\\"))
                {
                    Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory + "\\images\\");
                }
                File.Copy(open.FileName, System.AppDomain.CurrentDomain.BaseDirectory + "\\images\\" + Textbox_icNo.Text + ".jpg", true);
            }
        }

        private void BtnClo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
