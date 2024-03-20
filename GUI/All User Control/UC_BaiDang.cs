using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_User_Control
{
    public partial class UC_BaiDang : UserControl
    {
        private bool isUCTrangChuVisible = false;
        public UC_BaiDang()
        {
            InitializeComponent();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_BaiDang_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowpan = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel1, gunaVScrollBar1, true);
            uC_TrangChu1.Visible = false;

            uC_TrangChu1.ButtonDanhMucConClick += UC_TrangChu1_ButtonDanhMucConClick;
        }

        private void UC_TrangChu1_ButtonDanhMucConClick(object sender, string tenDanhMucCon)
        {

        }

        private void uC_BaiDangTho3_Load(object sender, EventArgs e)
        {

        }

        private void gunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnLocTheoDanhMuc_Click(object sender, EventArgs e)
        {
            if (!isUCTrangChuVisible)
            {
                // Hiển thị UC_TrangChu
                uC_TrangChu1.Visible = true;
                uC_TrangChu1.BringToFront();
                isUCTrangChuVisible = true;
            }
            else
            {
                // Ẩn UC_TrangChu
                uC_TrangChu1.Visible = false;
                isUCTrangChuVisible = false;
            }
        }

        private void uC_DanhMuc1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_TrangChu1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
