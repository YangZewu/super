using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BLL;
using System.Windows.Forms;

namespace 超市管理系统
{
    public partial class Out : Form
    {
        public Out()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }

        private void Out_Load(object sender, EventArgs e)
        {

        }

        private void Btn_GetIC_Click(object sender, EventArgs e)
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
                               Textbox_icNo.Text = R;
                                while (Lin.Read())
                                {
                                    Textbox_Name.Text = Lin["userName"].ToString();
                                    textBox_Pwd.Text = Lin["userPwd"].ToString();
                                    TextBox_SetIcTime.Text = Lin["icStartTime"].ToString();
                                    TextBox_Tel.Text = Lin["userTel"].ToString();
                                    TextBox_DZ.Text = Lin["address"].ToString();
                                    if (Lin["userPhoto"].ToString() == "暂无图片")
                                    {
                                        string car_photo = ".\\images\\暂无图片.jpg";
                                        image_Head.Image = Image.FromFile(car_photo);
                                    }
                                    else
                                    {
                                        image_Head.Image = Image.FromFile(Lin["userPhoto"].ToString());
                                    }

;
                                }

                                MessageBox.Show("读卡成功", "提示", MessageBoxButtons.OK);
                                DCHelper.dc_beep(icdev, 100);
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

        private void Btn_Delect_Click(object sender, EventArgs e)
        {
            if (Textbox_icNo is null)
            {
                MessageBox.Show("请先读卡，然后再进行此操作！","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("请确认是否注销此卡 ，卡号：{0}", "注销提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    userManag.DELECT(Textbox_icNo.Text);
                }
               else
                {
                    this.Close();
                }
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
