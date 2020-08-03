using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fivemLuncher;

namespace Mini_Launcher
{
    public partial class Form_loading_play : Form
    {
        lib rp = new lib();
        public Form_loading_play()
        {
            InitializeComponent();
            sdf_loading_play.SetShadowForm(this);
        }

        private void Form_loading_play_Load(object sender, EventArgs e)
        {
            tm_connect.Start();
            rp.closeFivem();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            Lang.hatalimesajbaslik = "Fujino N's!";
            Lang.steamhata = "กรุณาเปิด Steam ก่อนเข้าเล่น! | Please turn on Steam before playing!";
            Lang.muzikhata = "ไม่พบไฟล์ MP4 | Can't find MP4 file";
            Lang.panelhata = "Panel System ERROR!";
            Lang.steam64idgirinhatasi = "รหัสข้อผิดพลาดของ Steam! | Steam error codes!";
            Lang.cokfazlaistekhatasi = "เกิดข้อผิดพลาดในคำขอ! | An error occurred in the request!";
            Lang.uygulamaacmahatasi = "ข้อผิดพลาดในการเปิดคำสั่ง! กรุณาติดต่อแอดมินเพื่อขอความช่วยเหลือ | Error in opening order! Please contact the administrator for assistance.";
            Lang.internethatasi = "ข้อผิดพลาดในการเชื่อมต่ออินเทอร์เน็ต! | Error connecting to the internet!";
        }

        private void tm_connect_Tick(object sender, EventArgs e)
        {
            pgb_connect.Increment(1);
            if (pgb_connect.Value == 100)
            {
                Application.Exit();
            }
            else if (pgb_connect.Value == 1)
            {
                try
                {
                    rp.connectFivem(@"127.0.0.1", "30120"); //แก้ไอพี FiveM ได้ตรงนี้
                }
                catch (Exception)
                {
                    tm_connect.Stop();
                    const string message = "FiveM.exe could not be found. Do you want to download it now? | ไม่พบ FiveM.exe คุณต้องการดาวน์โหลดทันทีหรือไม่";
                    const string caption = "Fujino N's!";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://fivem.net/");
                        Application.Exit();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else if (pgb_connect.Value == 80)
            {
                rp.open(@"ts3server://127.0.0.1"); //แก้ไอพี TS3 ได้ตรงนี้
            }
        }
    }
}
