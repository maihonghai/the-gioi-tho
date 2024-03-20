using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_Login_Control
{
    public partial class UC_QuenMK : UserControl
    {
        public event EventHandler BackClicked;
        public UC_QuenMK()
        {
            InitializeComponent();
            lblKetqua.Text = "";
        }

        Modify modify = new Modify();

        private void btnQenMK_Click(object sender, EventArgs e)
        {
            lblKetqua.Visible = true;
            string email = txtEmail.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng ký!"); }
            else
            {
                string query = "Select * from TaiKhoan Where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count() > 0)
                {
                    lblKetqua.ForeColor = Color.Green;
                    lblKetqua.Text = "Mật khẩu : " + modify.TaiKhoans(query)[0].MatKhau;

                }
                else
                {
                    lblKetqua.ForeColor = Color.DarkRed;
                    lblKetqua.Text = "Email này chưa được đăng ký!";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
