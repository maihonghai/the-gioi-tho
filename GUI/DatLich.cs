using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DatLich : Form
    {
        public DatLich()
        {
            InitializeComponent();
            // Thiết lập StartPosition để hiển thị form ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void DatLich_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan formThanhToan = new ThanhToan();
            formThanhToan.ShowDialog();
        }
    }
}
