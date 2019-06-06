using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace QuanLyCayGiaPha
{
    public partial class Frmlogin : Form
    {

        public Frmlogin()
        {
            InitializeComponent();
        }
        dulieuDataContext dulieu = new dulieuDataContext();
        static public string taikhoan = string.Empty;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtb_User.Text == "" || txtb_Pass.Text == "")
            {
                MessageBox.Show("Hãy điền tên tài khoản hoặc mật khẩu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else ktadmin();
        }
        private void ktadmin()
        {
            var kt = (from NguoiDung in dulieu.NguoiDungs
                      where NguoiDung.TaiKhoan.Trim() == txtb_User.Text && NguoiDung.matkhau.Trim() == txtb_Pass.Text
                      select NguoiDung).SingleOrDefault();

            if (kt == null)
            {
                MessageBox.Show("Tài khoản này không tồn tại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                taikhoan = txtb_User.Text;
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                using (frmmain frmain = new frmmain())
                    if (frmain.ShowDialog() == DialogResult.OK)
                        Application.Run(new frmmain());
                Application.Exit();

            }
            //  private void Frmlogin_Load(object sender, EventArgs e)
            //  {

            //  }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}