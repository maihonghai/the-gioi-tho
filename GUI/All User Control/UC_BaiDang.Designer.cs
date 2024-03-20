namespace GUI.All_User_Control
{
    partial class UC_BaiDang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLocTheoDanhMuc = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_TrangChu1 = new GUI.All_User_Control.UC_TrangChu();
            this.uC_BaiDangTho1 = new GUI.All_Tho_Control.UC_BaiDangTho();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.uC_BaiDangTho2 = new GUI.All_Tho_Control.UC_BaiDangTho();
            this.uC_BaiDangTho3 = new GUI.All_Tho_Control.UC_BaiDangTho();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1052, 555);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 79);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.btnLocTheoDanhMuc);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 79);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnLocTheoDanhMuc
            // 
            this.btnLocTheoDanhMuc.BorderRadius = 15;
            this.btnLocTheoDanhMuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocTheoDanhMuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocTheoDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocTheoDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocTheoDanhMuc.FillColor = System.Drawing.Color.LightGreen;
            this.btnLocTheoDanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocTheoDanhMuc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLocTheoDanhMuc.Location = new System.Drawing.Point(9, 14);
            this.btnLocTheoDanhMuc.Name = "btnLocTheoDanhMuc";
            this.btnLocTheoDanhMuc.Size = new System.Drawing.Size(180, 45);
            this.btnLocTheoDanhMuc.TabIndex = 0;
            this.btnLocTheoDanhMuc.Text = "Lọc Theo Danh Mục";
            this.btnLocTheoDanhMuc.Click += new System.EventHandler(this.btnLocTheoDanhMuc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_TrangChu1);
            this.panel1.Controls.Add(this.uC_BaiDangTho1);
            this.panel1.Controls.Add(this.gunaVScrollBar1);
            this.panel1.Controls.Add(this.uC_BaiDangTho2);
            this.panel1.Controls.Add(this.uC_BaiDangTho3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 489);
            this.panel1.TabIndex = 6;
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.BackColor = System.Drawing.Color.White;
            this.uC_TrangChu1.Location = new System.Drawing.Point(3, -80);
            this.uC_TrangChu1.Name = "uC_TrangChu1";
            this.uC_TrangChu1.Size = new System.Drawing.Size(1049, 569);
            this.uC_TrangChu1.TabIndex = 6;
            this.uC_TrangChu1.Load += new System.EventHandler(this.uC_TrangChu1_Load);
            // 
            // uC_BaiDangTho1
            // 
            this.uC_BaiDangTho1.Location = new System.Drawing.Point(654, 41);
            this.uC_BaiDangTho1.Name = "uC_BaiDangTho1";
            this.uC_BaiDangTho1.Size = new System.Drawing.Size(285, 425);
            this.uC_BaiDangTho1.TabIndex = 4;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(1020, 19);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 447);
            this.gunaVScrollBar1.TabIndex = 5;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            this.gunaVScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gunaVScrollBar1_Scroll);
            // 
            // uC_BaiDangTho2
            // 
            this.uC_BaiDangTho2.Location = new System.Drawing.Point(45, 41);
            this.uC_BaiDangTho2.Name = "uC_BaiDangTho2";
            this.uC_BaiDangTho2.Size = new System.Drawing.Size(285, 425);
            this.uC_BaiDangTho2.TabIndex = 4;
            this.uC_BaiDangTho2.Load += new System.EventHandler(this.uC_BaiDangTho3_Load);
            // 
            // uC_BaiDangTho3
            // 
            this.uC_BaiDangTho3.Location = new System.Drawing.Point(350, 41);
            this.uC_BaiDangTho3.Name = "uC_BaiDangTho3";
            this.uC_BaiDangTho3.Size = new System.Drawing.Size(285, 425);
            this.uC_BaiDangTho3.TabIndex = 4;
            this.uC_BaiDangTho3.Load += new System.EventHandler(this.uC_BaiDangTho3_Load);
            // 
            // UC_BaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Name = "UC_BaiDang";
            this.Size = new System.Drawing.Size(1052, 555);
            this.Load += new System.EventHandler(this.UC_BaiDang_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private All_Tho_Control.UC_BaiDangTho uC_BaiDangTho3;
        private All_Tho_Control.UC_BaiDangTho uC_BaiDangTho1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private All_Tho_Control.UC_BaiDangTho uC_BaiDangTho2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLocTheoDanhMuc;
        private UC_TrangChu uC_TrangChu1;
    }
}
