using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCayGiaPha
{
    public partial class frmCapTaiKhoan : Form
    {
        dulieuDataContext dulieu = new dulieuDataContext();
        public frmCapTaiKhoan()
        {
            InitializeComponent();
        }
        
        private void load()
        {

            gvTaiKhaan.DataSource = null;
            var list = (from p in dulieu.NguoiDungs
                        select new { p.TaiKhoan, p.matkhau }).ToList();
            gvTaiKhaan.DataSource = list;
            
            
        }
        private void frmCapTaiKhoan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gvTaiKhaan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = gvTaiKhaan.Rows[e.RowIndex];
            string taikhoan = row.Cells["TaiKhoan"].Value.ToString();
            NguoiDung nd = dulieu.NguoiDungs.Where(p=> p.TaiKhoan == taikhoan).SingleOrDefault();
            if( nd != null ){
                txtcapTk.Text = nd.TaiKhoan;
                txtcapMk.Text = nd.matkhau;        
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();

            nd.TaiKhoan = txtcapTk.Text;
            nd.matkhau = txtcapMk.Text;
            dulieu.NguoiDungs.InsertOnSubmit(nd);
            dulieu.SubmitChanges();          
            load();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btntxoa_Click(object sender, EventArgs e)
        {
           
           if (txtcapTk.Text.Trim() != "admin")
            {
                    NguoiDung nd = dulieu.NguoiDungs.Where(p => p.TaiKhoan == txtcapMk.Text).SingleOrDefault();
                    if (nd != null)
                    {
                        dulieu.NguoiDungs.DeleteOnSubmit(nd);
                        dulieu.SubmitChanges();
                        load();         
                 }          
            }
          else
          {

               MessageBox.Show("Bạn Không Thể Xóa Tài Khoản Admin");
           }
             
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            NguoiDung nd = dulieu.NguoiDungs.Where(p => p.TaiKhoan == txtcapTk.Text).SingleOrDefault();
            if (nd != null)
            {
                nd.TaiKhoan = txtcapTk.Text;
                nd.matkhau = txtcapMk.Text;
                dulieu.SubmitChanges();
                load();
            }
        }
    }
}
