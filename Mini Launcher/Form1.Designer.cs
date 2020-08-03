namespace Mini_Launcher
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.pnl_main_top = new System.Windows.Forms.Panel();
            this.btn_tokovoip = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ts3 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_main_fill = new System.Windows.Forms.Panel();
            this.pnl_main_userplay = new System.Windows.Forms.Panel();
            this.ptb_logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_play = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_main_rules = new System.Windows.Forms.Panel();
            this.btn_uninstall = new Guna.UI2.WinForms.Guna2Button();
            this.btn_setup = new Guna.UI2.WinForms.Guna2Button();
            this.btn_rules = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sdf_main = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dct_main_top = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_main_top.SuspendLayout();
            this.pnl_main_fill.SuspendLayout();
            this.pnl_main_userplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.pnl_main_rules.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main_top
            // 
            this.pnl_main_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnl_main_top.Controls.Add(this.btn_tokovoip);
            this.pnl_main_top.Controls.Add(this.btn_ts3);
            this.pnl_main_top.Controls.Add(this.label1);
            this.pnl_main_top.Controls.Add(this.btn_exit);
            this.pnl_main_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_main_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_main_top.Name = "pnl_main_top";
            this.pnl_main_top.Size = new System.Drawing.Size(628, 39);
            this.pnl_main_top.TabIndex = 0;
            // 
            // btn_tokovoip
            // 
            this.btn_tokovoip.BorderRadius = 8;
            this.btn_tokovoip.CheckedState.Parent = this.btn_tokovoip;
            this.btn_tokovoip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tokovoip.CustomImages.Parent = this.btn_tokovoip;
            this.btn_tokovoip.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_tokovoip.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tokovoip.ForeColor = System.Drawing.Color.Yellow;
            this.btn_tokovoip.HoverState.Parent = this.btn_tokovoip;
            this.btn_tokovoip.Image = ((System.Drawing.Image)(resources.GetObject("btn_tokovoip.Image")));
            this.btn_tokovoip.ImageSize = new System.Drawing.Size(23, 23);
            this.btn_tokovoip.Location = new System.Drawing.Point(289, 4);
            this.btn_tokovoip.Name = "btn_tokovoip";
            this.btn_tokovoip.ShadowDecoration.Parent = this.btn_tokovoip;
            this.btn_tokovoip.Size = new System.Drawing.Size(117, 30);
            this.btn_tokovoip.TabIndex = 4;
            this.btn_tokovoip.Text = "TokoVOIP";
            this.btn_tokovoip.Click += new System.EventHandler(this.btn_tokovoip_Click);
            // 
            // btn_ts3
            // 
            this.btn_ts3.BorderRadius = 8;
            this.btn_ts3.CheckedState.Parent = this.btn_ts3;
            this.btn_ts3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ts3.CustomImages.Parent = this.btn_ts3;
            this.btn_ts3.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ts3.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ts3.ForeColor = System.Drawing.Color.Yellow;
            this.btn_ts3.HoverState.Parent = this.btn_ts3;
            this.btn_ts3.Image = ((System.Drawing.Image)(resources.GetObject("btn_ts3.Image")));
            this.btn_ts3.ImageSize = new System.Drawing.Size(23, 23);
            this.btn_ts3.Location = new System.Drawing.Point(412, 4);
            this.btn_ts3.Name = "btn_ts3";
            this.btn_ts3.ShadowDecoration.Parent = this.btn_ts3;
            this.btn_ts3.Size = new System.Drawing.Size(128, 30);
            this.btn_ts3.TabIndex = 3;
            this.btn_ts3.Text = "TeamSpeak";
            this.btn_ts3.Click += new System.EventHandler(this.btn_ts3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mini Launcher";
            // 
            // btn_exit
            // 
            this.btn_exit.BorderRadius = 8;
            this.btn_exit.CheckedState.Parent = this.btn_exit;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.CustomImages.Parent = this.btn_exit;
            this.btn_exit.FillColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageSize = new System.Drawing.Size(23, 23);
            this.btn_exit.Location = new System.Drawing.Point(546, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(76, 30);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_main_fill
            // 
            this.pnl_main_fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_main_fill.BackgroundImage")));
            this.pnl_main_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_main_fill.Controls.Add(this.pnl_main_userplay);
            this.pnl_main_fill.Controls.Add(this.pnl_main_rules);
            this.pnl_main_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main_fill.Location = new System.Drawing.Point(0, 39);
            this.pnl_main_fill.Name = "pnl_main_fill";
            this.pnl_main_fill.Size = new System.Drawing.Size(628, 240);
            this.pnl_main_fill.TabIndex = 1;
            // 
            // pnl_main_userplay
            // 
            this.pnl_main_userplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.pnl_main_userplay.Controls.Add(this.ptb_logo);
            this.pnl_main_userplay.Controls.Add(this.btn_play);
            this.pnl_main_userplay.Location = new System.Drawing.Point(449, 13);
            this.pnl_main_userplay.Name = "pnl_main_userplay";
            this.pnl_main_userplay.Size = new System.Drawing.Size(167, 215);
            this.pnl_main_userplay.TabIndex = 1;
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.Color.Transparent;
            this.ptb_logo.Image = ((System.Drawing.Image)(resources.GetObject("ptb_logo.Image")));
            this.ptb_logo.Location = new System.Drawing.Point(3, 3);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.ShadowDecoration.Parent = this.ptb_logo;
            this.ptb_logo.Size = new System.Drawing.Size(161, 145);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BorderRadius = 10;
            this.btn_play.CheckedState.Parent = this.btn_play;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.CustomImages.Parent = this.btn_play;
            this.btn_play.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.HoverState.Parent = this.btn_play;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.Location = new System.Drawing.Point(3, 156);
            this.btn_play.Name = "btn_play";
            this.btn_play.ShadowDecoration.Parent = this.btn_play;
            this.btn_play.Size = new System.Drawing.Size(161, 45);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "PLAY";
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // pnl_main_rules
            // 
            this.pnl_main_rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnl_main_rules.Controls.Add(this.btn_uninstall);
            this.pnl_main_rules.Controls.Add(this.btn_setup);
            this.pnl_main_rules.Controls.Add(this.btn_rules);
            this.pnl_main_rules.Controls.Add(this.label2);
            this.pnl_main_rules.Location = new System.Drawing.Point(12, 13);
            this.pnl_main_rules.Name = "pnl_main_rules";
            this.pnl_main_rules.Size = new System.Drawing.Size(431, 215);
            this.pnl_main_rules.TabIndex = 0;
            // 
            // btn_uninstall
            // 
            this.btn_uninstall.BackColor = System.Drawing.Color.Transparent;
            this.btn_uninstall.BorderRadius = 8;
            this.btn_uninstall.CheckedState.Parent = this.btn_uninstall;
            this.btn_uninstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uninstall.CustomImages.Parent = this.btn_uninstall;
            this.btn_uninstall.FillColor = System.Drawing.Color.Red;
            this.btn_uninstall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uninstall.ForeColor = System.Drawing.Color.White;
            this.btn_uninstall.HoverState.Parent = this.btn_uninstall;
            this.btn_uninstall.Image = ((System.Drawing.Image)(resources.GetObject("btn_uninstall.Image")));
            this.btn_uninstall.ImageSize = new System.Drawing.Size(23, 23);
            this.btn_uninstall.Location = new System.Drawing.Point(261, 171);
            this.btn_uninstall.Name = "btn_uninstall";
            this.btn_uninstall.ShadowDecoration.Parent = this.btn_uninstall;
            this.btn_uninstall.Size = new System.Drawing.Size(147, 30);
            this.btn_uninstall.TabIndex = 7;
            this.btn_uninstall.Text = "ถอนการติดตั้ง";
            this.btn_uninstall.Click += new System.EventHandler(this.btn_uninstall_Click);
            // 
            // btn_setup
            // 
            this.btn_setup.BackColor = System.Drawing.Color.Transparent;
            this.btn_setup.BorderRadius = 8;
            this.btn_setup.CheckedState.Parent = this.btn_setup;
            this.btn_setup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setup.CustomImages.Parent = this.btn_setup;
            this.btn_setup.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_setup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setup.ForeColor = System.Drawing.Color.White;
            this.btn_setup.HoverState.Parent = this.btn_setup;
            this.btn_setup.Image = ((System.Drawing.Image)(resources.GetObject("btn_setup.Image")));
            this.btn_setup.Location = new System.Drawing.Point(125, 171);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.ShadowDecoration.Parent = this.btn_setup;
            this.btn_setup.Size = new System.Drawing.Size(130, 30);
            this.btn_setup.TabIndex = 6;
            this.btn_setup.Text = "วิธีตั้งค่าเสียง";
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // btn_rules
            // 
            this.btn_rules.BackColor = System.Drawing.Color.Transparent;
            this.btn_rules.BorderRadius = 8;
            this.btn_rules.CheckedState.Parent = this.btn_rules;
            this.btn_rules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rules.CustomImages.Parent = this.btn_rules;
            this.btn_rules.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_rules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rules.ForeColor = System.Drawing.Color.White;
            this.btn_rules.HoverState.Parent = this.btn_rules;
            this.btn_rules.Image = ((System.Drawing.Image)(resources.GetObject("btn_rules.Image")));
            this.btn_rules.ImageSize = new System.Drawing.Size(23, 23);
            this.btn_rules.Location = new System.Drawing.Point(27, 171);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.ShadowDecoration.Parent = this.btn_rules;
            this.btn_rules.Size = new System.Drawing.Size(92, 30);
            this.btn_rules.TabIndex = 5;
            this.btn_rules.Text = "อ่านต่อ";
            this.btn_rules.Click += new System.EventHandler(this.btn_rules_Click);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 159);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // dct_main_top
            // 
            this.dct_main_top.TargetControl = this.pnl_main_top;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 279);
            this.Controls.Add(this.pnl_main_fill);
            this.Controls.Add(this.pnl_main_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Launcher";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.pnl_main_top.ResumeLayout(false);
            this.pnl_main_top.PerformLayout();
            this.pnl_main_fill.ResumeLayout(false);
            this.pnl_main_userplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.pnl_main_rules.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main_top;
        private System.Windows.Forms.Panel pnl_main_fill;
        private System.Windows.Forms.Panel pnl_main_userplay;
        private System.Windows.Forms.Panel pnl_main_rules;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_logo;
        private Guna.UI2.WinForms.Guna2Button btn_play;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_tokovoip;
        private Guna.UI2.WinForms.Guna2Button btn_ts3;
        private Guna.UI2.WinForms.Guna2Button btn_setup;
        private Guna.UI2.WinForms.Guna2Button btn_rules;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ShadowForm sdf_main;
        private Guna.UI2.WinForms.Guna2DragControl dct_main_top;
        private Guna.UI2.WinForms.Guna2Button btn_uninstall;
    }
}

