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
    public partial class baocao_thanhtich : Form
    {
        public baocao_thanhtich()
        {
            InitializeComponent();
        }

        private void baocao_thanhtich_Load(object sender, EventArgs e)
        {
            
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCGPDataSet.GhiNhanThanhTich1' table. You can move, or remove it, as needed.
            this.GhiNhanThanhTich1TableAdapter.Fill(this.QLCGPDataSet.GhiNhanThanhTich1, int.Parse(txt_TuNam.Text), int.Parse(txt_DenNam.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
