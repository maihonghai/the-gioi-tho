﻿using System;
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
    public partial class UC_HoatDong : UserControl
    {
        public UC_HoatDong()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void UC_HoatDong_Load(object sender, EventArgs e)
        {

        }

        private void dgvHoatDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            // Thiết lập cấu trúc cột cho DataGridView
            dgvHoatDong.ColumnCount = 5;
            dgvHoatDong.Columns[0].Name = "CongViec";
            dgvHoatDong.Columns[1].Name = "Ngay";
            dgvHoatDong.Columns[2].Name = "Gio";
            dgvHoatDong.Columns[3].Name = "GiaTien";
            dgvHoatDong.Columns[4].Name = "TrangThai";

            // Thêm dữ liệu mẫu
            AddSampleDataToDataGridView();
        }

        private void AddSampleDataToDataGridView()
        {
            dgvHoatDong.Rows.Add(new object[] { "Máy Lạnh", "10/03/2024", "15:00", "100000", "Đang chờ tới lịch" });
            dgvHoatDong.Rows.Add(new object[] { "Bếp Điện", "11/03/2024", "10:30", "0", "Đang làm" });
            dgvHoatDong.Rows.Add(new object[] { "Tủ Lạnh", "12/03/2024", "09:00", "50000", "Đã hoàn thành" });
            dgvHoatDong.Rows.Add(new object[] { "Thông Cống", "14/03/2024", "14:45", "200000", "Đã hủy" });
            dgvHoatDong.Rows.Add(new object[] { "Thiết Kế Nội Thất", "16/03/2024", "16:30", "120000", "Đã hoàn thành" });
            dgvHoatDong.Rows.Add(new object[] { "Dò Nước Rò Rỉ", "18/03/2024", "Không", "0", "Đã hoàn thành" });
            dgvHoatDong.Rows.Add(new object[] { "Sơn Nhà", "20/03/2024", "07:00", "30000", "Đã hoàn thành" });
            dgvHoatDong .Rows.Add(new object[] { "Nồi Cơm Điện", "22/03/2024", "20:00", "0", "Đã hoàn thành" });
            dgvHoatDong.Rows.Add(new object[] { "Máy Quạt", "24/03/2024", "18:15", "150000", "Đã hoàn thành" });
            dgvHoatDong.Rows.Add(new object[] { "Máy Sấy", "26/03/2024", "12:00", "0", "Đã hoàn thành" });
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
