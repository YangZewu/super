using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 超市管理系统
{
    public class DCHelper
    {
        [DllImport("dcrf32.dll")]
        public static extern int dc_init(int port, Int32 baud);//初始化

        [DllImport("dcrf32.dll")]
        public static extern int dc_beep(int icdev, int _Msec);//蜂鸣

        [DllImport("dcrf32.dll")]
        public static extern short dc_card(int icdev, int _Mode, ref long _Snr);    //寻卡

        [DllImport("dcrf32.dll")]
        public static extern int dc_load_key(int icdev, int _Mode, int _SecNr, byte[] _NKey);  //装载密码

        [DllImport("dcrf32.dll")]
        public static extern int dc_authentication(int icdev, int _Mode, int _SecNr);   //验证密码

        [DllImport("dcrf32.dll")]
        public static extern int dc_read(int icdev, int _Adr, byte[] _Data);   //读卡

        [DllImport("dcrf32.dll")]
        public static extern int dc_write(int icdev, int _Adr, string _Data);   //写卡
    }
}
