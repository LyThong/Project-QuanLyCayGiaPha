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
using System.Drawing.Imaging;


namespace QuanLyCayGiaPha
{
    public partial class FrmTiepNhanTV : Form
    {
        dulieuDataContext dulieu = new dulieuDataContext();
        public FrmTiepNhanTV()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loadDS()
        {
           
            var ds = (from t in dulieu.ThanhViens
                       select new { t.HoTenTVC,t.HoTenTVM}).ToList();

            cmbTVC.DataSource = ds;
            cmbTVC.DisplayMember ="HoTenTVM";
        
            
           

        }
        private void load()
        {

          
            gvThanhVien.DataSource = null;
         var list = (from p in dulieu.ThanhViens
                     select new { p.MaTV,p.HoTenTVC,p.HoTenTVM,p.GioiTinh,p.LoaiQuanHe,p.NgaySinh,p.NgheNghiep,p.DiaChi}).ToList();
         gvThanhVien.DataSource = list;
                         
        }
        private void FrmTiepNhanTV_Load(object sender, EventArgs e)
        {
            loadDS();
            load();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {       

           try{

               
                ThanhVien tv = new ThanhVien();
                tv.MaTV = txtMaThanhVien.Text;
                tv.HoTenTVC = cmbTVC.Text;//txtThanhVienCu.Text;
                tv.HoTenTVM = txtThanhVienMoi.Text;
                tv.QueQuan = cbQuanHe.Text;
                tv.LoaiQuanHe = cbQuanHe.Text;
                tv.GioiTinh = cbGioiTinh.Text;
                tv.NgaySinh = dtNgaySinh.Value;
                tv.NgayPhatSinh = dtNgayPhatSinh.Value;
                tv.NgheNghiep = cbnghenghiep.Text;
                tv.DiaChi = txtdiachi.Text;
              //  tv.HinhAnh = pictureBox1.Image;

               
                dulieu.ThanhViens.InsertOnSubmit(tv);
                dulieu.SubmitChanges();
                load();

           }catch{
               

               MessageBox.Show("Mã  Thành Viên Không Được Trùng Vui Lòng Nhập Lại","Thông báo", MessageBoxButtons.OK);
                
           }
               
                     
        }

        private void gvThanhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gvThanhVien.Rows[e.RowIndex];
            string maThanhVien = row.Cells["MaTV"].Value.ToString();
            ThanhVien tv = dulieu.ThanhViens.Where(p => p.MaTV == maThanhVien).SingleOrDefault();
            if (tv!=null)
            {
                txtMaThanhVien.Text = tv.MaTV;
                txtThanhVienMoi.Text = tv.HoTenTVM;
                cmbTVC.Text = tv.HoTenTVM;
              //  txtThanhVienCu.Text = tv.HoTenTVC;
                txtThanhVienMoi.Text = tv.HoTenTVM;
                txtdiachi.Text = tv.DiaChi;
                cbGioiTinh.Text = tv.GioiTinh;
                cbnghenghiep.Text = tv.NgheNghiep;
                cbQuanHe.Text = tv.LoaiQuanHe;
                cbQueQuab.Text = tv.QueQuan;
                dtNgaySinh.Value = tv.NgaySinh.Value;
                dtNgayPhatSinh.Value = tv.NgayPhatSinh.Value;
            }
        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhVien tv = dulieu.ThanhViens.Where(p => p.MaTV == txtMaThanhVien.Text).SingleOrDefault();
            if (tv!=null)
            {
                dulieu.ThanhViens.DeleteOnSubmit(tv);
                dulieu.SubmitChanges();
                load();
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhVien tv = dulieu.ThanhViens.Where(p => p.MaTV == txtMaThanhVien.Text).SingleOrDefault();

            if(tv != null)
            {

            tv.HoTenTVC =   //.Text;
            tv.HoTenTVM = txtThanhVienMoi.Text;
            tv.QueQuan = cbQuanHe.Text;
            tv.LoaiQuanHe = cbQuanHe.Text;
            tv.GioiTinh = cbGioiTinh.Text;
            tv.NgaySinh = dtNgaySinh.Value;
            tv.NgayPhatSinh = dtNgayPhatSinh.Value;
            tv.NgheNghiep = cbnghenghiep.Text;
            tv.DiaChi = txtdiachi.Text;       
            dulieu.SubmitChanges();
            load();
            }     
        }

        private void cbQueQuab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
      


            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            PictureBox objpt = new PictureBox();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
                pictureBox1.Image = Image.FromFile(filepath.ToString());
            }

          //  objpt.Image = Image.FromFile(filepath.ToString());
          //  objpt.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}

