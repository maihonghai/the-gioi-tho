using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_Login_Control
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class UC_DangNhap : UserControl
    {
        public event EventHandler QuenMKClicked;
        public event EventHandler DangKyClicked;
        public UC_DangNhap()
        {
            InitializeComponent();
        }

        //Hiển thị mật khẩu khi đăng nhập 
        private void cbOpenMK_CheckedChanged_1(object sender, EventArgs e)
        {
            if (txtMK.PasswordChar == '*')
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void UC_DangNhap_Load(object sender, EventArgs e)
        {
            txttenTK.Text = GUI.Properties.Settings.Default.TenTK;
            txtMK.Text = GUI.Properties.Settings.Default.MatKhau;
            if (GUI.Properties.Settings.Default.TenTK != "")
            {
                cbLuumk.Checked = true;
            }
        }
        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        Modify modify = new Modify();
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txttenTK.Text;
            string mk = txtMK.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            else if (mk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên mật khẩu!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            else if (rbtnTho.Checked == false && rbtNguoidung.Checked == false) { MessageBox.Show("Vui lòng chọn Vai trò của bạn!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            else
            {
                if (rbtNguoidung.Checked)
                {
                    string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + mk + "' ";
                    if (modify.TaiKhoans(query).Count > 0) //số phần tử > 0 
                    {
                        Form parentForm = this.FindForm();
                        MessageBox.Show("Đăng Nhập Thành Công!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        parentForm?.Hide();
                        Dashboard User = new Dashboard();
                        User.ShowDialog();
                        // Tìm form cha của UC_DangNhap
                        // Kiểm tra nếu parentForm khác null trước khi gọi Close

                        parentForm?.Close();
                    }

                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbtnTho.Checked)
                {
                    string query = "Select * from TaiKhoanTho where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + mk + "' ";
                    if (modify.TaiKhoans(query).Count > 0) //số phần tử > 0 
                    {
                        Form parentForm = this.FindForm();
                        MessageBox.Show("Đăng Nhập Thành Công!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        parentForm?.Hide();
                        FrmTHO User = new FrmTHO();
                        User.ShowDialog();
                        // Tìm form cha của UC_DangNhap
                        // Kiểm tra nếu parentForm khác null trước khi gọi Close

                        parentForm?.Close();
                    }

                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DangKyClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            // Raise the event when the label is clicked
          
        QuenMKClicked?.Invoke(this, EventArgs.Empty);
           
    }

        private void cbLuumk_CheckedChanged(object sender, EventArgs e)
        {
            if (txttenTK.Text != "" && txtMK.Text != "")
            {
                if (cbLuumk.Checked == true)
                {
                    string mk = txtMK.Text;
                    string tentk = txttenTK.Text;
                    GUI.Properties.Settings.Default.MatKhau = mk;
                    GUI.Properties.Settings.Default.TenTK = tentk;
                    GUI.Properties.Settings.Default.Save();
                }
                else
                {
                    GUI.Properties.Settings.Default.Reset();
                }
            }
        }
    }
}
