using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_Tho_Control
{
    public partial class UC_DangBai : UserControl
    {
        public UC_DangBai()
        {
            InitializeComponent();
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bại có chắc chắn đăng bài không?", "Thông Báo", MessageBoxButtons.YesNo);
            
        }

        private void btnLinhVuc_Click(object sender, EventArgs e)
        {
            uC_TrangChu1.Visible = true;
            uC_TrangChu1.BringToFront();
        }

        private void UC_DangBai_Load(object sender, EventArgs e)
        {
            uC_TrangChu1.Visible = false;
        }
    }
}
