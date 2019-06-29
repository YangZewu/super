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
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            skinEngine1.SkinFile = Application.StartupPath + "//DeepCyan.ssk";
        }
        string QD;
        string jf;
        string Time;
        private void SignIn_Load(object sender, EventArgs e)
        {
            TextBox_Name.Text = userManag.Name;
            icNo.Text = userManag.icNo;
            Time= DateTime.Now.ToString("yyyyMMdd");
            NowTime.Text= DateTime.Now.ToLongDateString().ToString();
            SqlDataReader Lin = userManag.getDataReader(userManag.icNo);
            while (Lin.Read())
            {
                QD = Lin["QDTime"].ToString();
                jf = Lin["JF"].ToString();
            }
            if (QD == "")
            {
                QDZT.Text = "未签到";
                JF.Text = "0";
                jf = "0";
                
            }
            else if (QD != Time)
            {
                QDZT.Text = "未签到";
                JF.Text = jf;
            }
            else
            {
                QDZT.Text = "已签到";
                JF.Text = jf;
            }
            Lin.Close();

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_QD_Click(object sender, EventArgs e)
        {
            int inJF = Convert.ToInt32(jf);
            if (QDZT.Text == "未签到")
            {
                if (QD == "")
                {
                        int num = inJF + 5;
                        QDZT.Text = "已签到";
                        JF.Text ="05";
                        userManag.XGQDJF(Time,num, icNo.Text);
                        
                }
                else
                {
                    //修改操作
                    int num = inJF + 5;
                    QDZT.Text = "已签到";
                    JF.Text = (inJF + 5).ToString() ;
                    userManag.XGQDJF(Time, num, icNo.Text);
                }
            }
            else if(QDZT.Text=="已签到")
            {
                if (MessageBox.Show("今天已经签到过了，请12点过后再进行签到", "签到提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Close();
                }
            }
        }
    }
}
