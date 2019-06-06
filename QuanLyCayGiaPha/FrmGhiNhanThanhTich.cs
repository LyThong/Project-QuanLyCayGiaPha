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
    public partial class FrmGhiNhanThanhTich : Form
    {
        dulieuDataContext dulieu = new dulieuDataContext();
       
        public FrmGhiNhanThanhTich()
        {
            InitializeComponent();
        }
        private void load()
        {

            gvGhiNhan.DataSource = null;         
            var list = (from p in dulieu.GhiNhanThanhTiches
                        select new {p.MaTT,p.MaTV,p.NgayPS,p.LoaiTT }).ToList();
            gvGhiNhan.DataSource = list;
            

        }
        private void loadtv()
        {
            

            var lis = (from p in dulieu.ThanhViens
                       select new { p.HoTenTVM, p.NgayPhatSinh }).ToList();
            cbHoTen.DataSource = lis;
            cbHoTen.DisplayMember = "HoTenTVM";

        }

        private void FrmGhiNhanThanhTich_Load(object sender, EventArgs e)
        {
            load();
            loadtv();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gvGhiNhan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
           DataGridViewRow row = gvGhiNhan.Rows[e.RowIndex];
           int matt = int.Parse(row.Cells["MaTT"].Value.ToString().Trim());
            string matv=row.Cells["MATV"].Value.ToString();
            GhiNhanThanhTich gn = dulieu.GhiNhanThanhTiches.Where(p => p.MaTT == matt&&p.MaTV==matv).SingleOrDefault();
            if (gn != null)
            {

                //cbHoTen.Text = gn.HoTen;
                cbloaithanhtich.Text = gn.LoaiTT;
            }
        
          }

       /* private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GhiNhanThanhTich ghinhan = new GhiNhanThanhTich();
            //ghinhan.HoTen   = cbHoTen.Text;
            ghinhan.NgayPhatSinh = dtngayphasinh.Value;
            ghinhan.LoaiThanhTich = cbloaithanhtich.Text;
          dulieu.GhiNhanThanhTiches.InsertOnSubmit(ghinhan);
          dulieu.SubmitChanges();
            load();
        }*/
           
        }
    }


