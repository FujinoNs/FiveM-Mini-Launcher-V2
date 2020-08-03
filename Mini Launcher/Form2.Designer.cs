namespace Mini_Launcher
{
    partial class Form_loading_play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_loading_play));
            this.tm_connect = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pgb_connect = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.sdf_loading_play = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.SuspendLayout();
            // 
            // tm_connect
            // 
            this.tm_connect.Interval = 20;
            this.tm_connect.Tick += new System.EventHandler(this.tm_connect_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connect To Server";
            // 
            // pgb_connect
            // 
            this.pgb_connect.BackColor = System.Drawing.Color.Transparent;
            this.pgb_connect.BorderColor = System.Drawing.Color.Transparent;
            this.pgb_connect.BorderRadius = 3;
            this.pgb_connect.BorderThickness = 5;
            this.pgb_connect.FillColor = System.Drawing.Color.White;
            this.pgb_connect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pgb_connect.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.pgb_connect.Location = new System.Drawing.Point(12, 43);
            this.pgb_connect.Name = "pgb_connect";
            this.pgb_connect.ProgressColor = System.Drawing.Color.Red;
            this.pgb_connect.ProgressColor2 = System.Drawing.Color.Red;
            this.pgb_connect.ShadowDecoration.Parent = this.pgb_connect;
            this.pgb_connect.Size = new System.Drawing.Size(256, 8);
            this.pgb_connect.TabIndex = 4;
            this.pgb_connect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Form_loading_play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(280, 63);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgb_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_loading_play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Server...";
            this.Load += new System.EventHandler(this.Form_loading_play_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tm_connect;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar pgb_connect;
        private Guna.UI2.WinForms.Guna2ShadowForm sdf_loading_play;
    }
}