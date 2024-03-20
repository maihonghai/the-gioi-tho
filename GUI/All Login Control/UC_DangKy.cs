using GUI.All_Tho_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI.All_Login_Control
{
    public partial class UC_DangKy : UserControl
    {
        public event EventHandler BackClicked;
        public UC_DangKy()
        {
            InitializeComponent();
        }

        public bool CheckAccount(string acc)//check mat khau va tai khoan
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9]{3,24}$");
        }
        public bool CheckEmail(string em)//check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        Modify modify = new Modify();

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string tentk = txttenTK.Text;
            string mk = txtMK.Text;
            string xnmk = txtXacnhan.Text;
            string email = txtEmail.Text;

            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản với các ký tự chữ và số , chữ hoa và chữ thường!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; };
            if (!CheckAccount(mk)) { MessageBox.Show("Vui lòng nhập mật khẩu với các ký tự chữ và số , chữ hoa và chữ thường!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; };
            if (xnmk != mk) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count() > 0) { MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác! "); return; }
            if(cbphanQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng chọn vai trò của bạn để đăng ký!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else if (cbphanQuyen.Text == "Thợ")
            {
                uC_DangKyTho1.Visible = true;
                //UC_DangKy_XacNhanClicked();

            }
            else
            {
                try
                {
                    string query = "Insert into TaiKhoan values('" + tentk + "','" + mk + "','" + email + "')";
                    modify.Command(query);

                    if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UC_DangNhap dangnhap = new UC_DangNhap();
                        this.Controls.Add(dangnhap); // Add UC_DangNhap to the form's Controls collection
                        dangnhap.Visible = true;
                        dangnhap.BringToFront();
                    }
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản này đã được đăng ký!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UC_DangKy_Load(object sender, EventArgs e)
        {
            uC_DangKyTho1.BackClicked += UC_DangKy_BackClicked;
            uC_DangKyTho1.XacNhanClicked += UC_DangKy_XacNhanClicked;
        }

        private void UC_DangKy_BackClicked(object sender, EventArgs e)
        {
            uC_DangKyTho1.Visible = false;
            // uC_DangNhap1.BringToFront();
        }

        private void UC_DangKy_XacNhanClicked(object sender, EventArgs e)
        {
            string tentk = txttenTK.Text;
            string mk = txtMK.Text;
            string xnmk = txtXacnhan.Text;
            string email = txtEmail.Text;
            string hoten = uC_DangKyTho1.HovaTenText;
            string gioitinh = uC_DangKyTho1.GioiTinhText;
            string sodt = uC_DangKyTho1.SoDTText;
            int sonamkn = int.Parse(uC_DangKyTho1.SoNamKNText);
            string diachi = uC_DangKyTho1.DiaChiText;
            try
            {
                string query = "Insert into TaiKhoanTho values('" + tentk + "','" + mk + "','" + email + "','" + hoten + "','" + gioitinh + "','" + sodt + "','" + sonamkn + "','" + diachi + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UC_DangNhap dangnhap = new UC_DangNhap();
                    this.Controls.Add(dangnhap); // Add UC_DangNhap to the form's Controls collection
                    dangnhap.Visible = true;
                    dangnhap.BringToFront();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký!");
            }
        }

       
    }
}
