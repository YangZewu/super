using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace 超市管理系统
{
    public partial class Personal_Center : Form
    {
        public Personal_Center()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        SqlDataReader Lin;
        private void Personal_Center_Load(object sender, EventArgs e)
        {
            
            Lin = userManag.getJF(userManag.icNo);
            while (Lin.Read())
            {
                Label_name.Text = Lin["userName"].ToString();
                Get_label_JF.Text = Lin["JF"].ToString();
                Get_label_ye.Text = Lin["YE"].ToString();
                if (Lin["userPhoto"].ToString() == "暂无图片")
                {
                    string car_photo = ".\\images\\暂无图片.jpg";
                    image_Head.Image = Image.FromFile(car_photo);
                }
                else
                {
                    image_Head.Image = Image.FromFile(Lin["userPhoto"].ToString());
                }
            }
            

            Lin.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            integral integral = new integral();
            integral.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CZYE zYE = new CZYE();
            zYE.Show();
        }
    }
}
