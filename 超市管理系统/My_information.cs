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
    public partial class My_information : Form
    {
        public My_information()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        SqlDataReader Lin;
        private void My_information_Load(object sender, EventArgs e)
        {
            Lin = userManag.getDataReader(userManag.icNo);
            while (Lin.Read())
            {
                Label_icNo.Text = userManag.icNo;
                Label_Name.Text = Lin["userName"].ToString();
                Label_CSNY.Text = Lin["userBbir"].ToString();
                Label_email.Text = Lin["email"].ToString();
                Label_sex.Text = Lin["sex"].ToString();
                Label_YB.Text= Lin["postcode"].ToString();
                Label_phone.Text= Lin["userTel"].ToString();
                Label_DZ.Text = Lin["address"].ToString();
                if (Lin["userPhoto"].ToString() == "暂无图片")
                {
                    string car_photo = ".\\images\\暂无图片.jpg";
                    image_Head.Image = Image.FromFile(car_photo);
                }
                else
                {
                    image_Head.Image = Image.FromFile(Lin["userPhoto"].ToString());
                }
                //不知道用什么方法
                //image_Head.Image=File.OpenRead( Lin["userPhoto"].ToString());
            }

            Lin.Close();
        }
    }
}
