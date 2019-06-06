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
    public partial class frmmain : Form
    {
        dulieuDataContext dulieu = new dulieuDataContext();
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            if (Frmlogin.taikhoan != "admin") quảnLýNgườiDùngToolStripMenuItem.Enabled = false;
        }

        private void tiếpNhậnThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiepNhanTV Tv = new FrmTiepNhanTV();
            Tv.ShowDialog();

        }

        private void traCứuThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuThanhVien tracuu = new frmTraCuuThanhVien();
            tracuu.ShowDialog();

        }

        private void ghiNhậnThànhTíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGhiNhanThanhTich ghinhan = new FrmGhiNhanThanhTich();
            ghinhan.ShowDialog();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Frmlogin.taikhoan == "admin")
            {
                {
                    frmQuyDinh quydinh = new frmQuyDinh();
                    quydinh.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(" Bạn Không Được Quyền Thay Đổi Quy Định ", "Thông Báo ", MessageBoxButtons.OK);
            }
            
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapTaiKhoan ctk = new frmCapTaiKhoan();
            ctk.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frmlogin frmlog = new Frmlogin())
                if (frmlog.ShowDialog() == DialogResult.OK)
                    Application.Run(new Frmlogin());
            Application.Exit();

        }

        private void tăngGiảmThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (baocao_tanggiam frmtg = new baocao_tanggiam())
                if (frmtg.ShowDialog() == DialogResult.OK)
                    Application.Run(new baocao_tanggiam());
            Application.Exit();
        }

        private void thànhTíchThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (baocao_thanhtich frmbc = new baocao_thanhtich())
                if (frmbc.ShowDialog() == DialogResult.OK)
                    Application.Run(new baocao_thanhtich());
            Application.Exit();
        }
    }
}
