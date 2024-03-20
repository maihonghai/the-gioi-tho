using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_TrangChu_Control
{
    public partial class UC_DienTuGiaDung : UserControl
    {
        public event EventHandler<string> ButtonDanhMucConClick;
        public event EventHandler ChuyenSangBaiDang;

        public UC_DienTuGiaDung()
        {
            InitializeComponent();
        }

        private void UC_DienTuGiaDung_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBepDien_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void btnLoa_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void btnNoiComDien_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void btnBepGa_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void btnLoNuong_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void btnTiVi_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }
    }
}
