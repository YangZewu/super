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
    public partial class NewFile : Form
    {
        public NewFile()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void NewFile_Load(object sender, EventArgs e)
        {
            Textbox_icNo.Text = System.DateTime.Now.ToString("yyyymddhhmmss");
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Nonull();
            Add();
        }

        private void Btn_Cloose_Click(object sender, EventArgs e)
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
        public void Nonull()
        {
            if (textBox_Pwd.Text == "" && TextBox_Tel.Text == "" &&
                ".\\images\\" + Textbox_icNo.Text + ".jpg" == "" && Textbox_Name.Text == "" &&
                TextBox_Email.Text == "" && Textbox_address.Text == "" && TextBox_PC.Text == "" &&
                comboBox_sex.Text == "")
            {
                MessageBox.Show("注册信息不能为空");
            }
        }
        public void Add()
        {
            int i = userManag.regUser(Textbox_icNo.Text, textBox_Pwd.Text, TextBox_Tel.Text,
                                        ".\\images\\" + Textbox_icNo.Text + ".jpg", Textbox_Name.Text, Time_Day.Value,
                                        Time_StartDay.Value, Time_Exit.Value, TextBox_Email.Text, Textbox_address.Text, TextBox_PC.Text,
                                        comboBox_sex.Text);
            if (i > 0)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }

    }
}
