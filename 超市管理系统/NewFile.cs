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
using 超市管理系统;
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
        bool zt;
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Nonull();
            if (zt == true)
            {
                if (Check() == true)
                {
                    Add();
                }
            }
           
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
        public bool Nonull()
        {
            
            if (textBox_Pwd.Text == "" || TextBox_Tel.Text == "" ||
                ".\\images\\" + Textbox_icNo.Text + ".jpg" == "" || Textbox_Name.Text == "" ||
                TextBox_Email.Text == "" || Textbox_address.Text == "" || TextBox_PC.Text == "" ||
                comboBox_sex.Text == "")
            {
                MessageBox.Show("注册信息不能为空");
                 zt=false;
               
            }
            else
            {
                zt = true;
            }
            return zt;
        }
        public void Add()
        {
            int icdev = DCHelper.dc_init(100, 115200);
            if (icdev > 0)
            {
                long snr = 0;
                int dccard = DCHelper.dc_card(icdev, 0, ref snr);
                if (dccard == 0)
                {
                    byte[] password = new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
                    int dckey = DCHelper.dc_load_key(icdev, 0, 1, password);
                    if (dckey == 0)
                    {
                        int authkey = DCHelper.dc_authentication(icdev, 0, 1);
                        if (authkey == 0)
                        {
                            int dcwrity = DCHelper.dc_write(icdev, 4, Textbox_icNo.Text);
                            if (dcwrity == 0)
                            {
                                int i = userManag.regUser(Textbox_icNo.Text, textBox_Pwd.Text, TextBox_Tel.Text,
                                                            ".\\images\\" + Textbox_icNo.Text + ".jpg", Textbox_Name.Text, Time_Day.Value,
                                                            Time_StartDay.Value, Time_Exit.Value, TextBox_Email.Text, Textbox_address.Text, TextBox_PC.Text,
                                                            comboBox_sex.Text);
                                if (i > 0)
                                {
                                   
                                        DCHelper.dc_beep(icdev, 100);
                                        MessageBox.Show("发卡成功！");
                                        Close();
                                    
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请正确放置卡！");
                }
            }
            else
            {
                MessageBox.Show("请检查设备！");
            }
        }
        public bool Check()
        {
            if (Textbox_Name.Text != textBox3.Text)
            {
                MessageBox.Show("两次姓名不一致！");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
