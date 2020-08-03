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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            sdf_main.SetShadowForm(this);
            pnl_main_rules.BackColor = Color.FromArgb(150, 1, 1, 1);
            pnl_main_userplay.BackColor = Color.FromArgb(150, 1, 1, 1);
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Mini launcher V2.0.0 Created by Kroekchai KC", "Fujino N's!");
        }

        private void btn_setup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณยังไม่ได้ใส่ลิงค์", "Fujino N's!");
            //System.Diagnostics.Process.Start(@"URL");
        }

        private void btn_rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณยังไม่ได้ใส่ลิงค์", "Fujino N's!");
            //System.Diagnostics.Process.Start(@"URL");
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            lib rp = new lib();
            Form_loading_play fp = new Form_loading_play();
            fp.ShowDialog();
        }

        private void btn_tokovoip_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to download TokoVOIP Plugin? | คุณต้องการดาวน์โหลดปลั๊กอิน TokoVOIP หรือไม่";
            const string caption = "Fujino N's!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"https://github.com/Itokoyamato/TokoVOIP_TS3/releases/download/v1.2.5-v1.3.5/tokovoip_1_2_5.ts3_plugin");
            }
        }

        private void btn_ts3_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to download TeamSpeak 3? | คุณต้องการดาวน์โหลด TeamSpeak 3 หรือไม่";
            const string caption = "Fujino N's!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"https://teamspeak.com/en/downloads/");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to close the Launcher? | คุณแน่ใจหรือไม่ว่าต้องการปิด Launcher";
            const string caption = "Fujino N's!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_uninstall_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to uninstall the launcher? | คุณแน่ใจหรือไม่ที่จะถอนการติดตั้ง Launcher?";
            const string caption = "Fujino N's!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("control.exe", "appwiz.cpl");
                Application.Exit();
            }
        }
    }
}
