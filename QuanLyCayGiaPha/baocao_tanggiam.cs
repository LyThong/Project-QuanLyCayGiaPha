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
    public partial class baocao_tanggiam : Form
    {
        public baocao_tanggiam()
        {
            InitializeComponent();
        }

        private void baocao_tanggiam_Load(object sender, EventArgs e)
        {
            

        }

        private void but_bcOK_Click(object sender, EventArgs e)
        {
            this.TangGiamTVTableAdapter.Fill(this.QLCGPDataSet.TangGiamTV, int.Parse(txt_bcTuNam.Text), int.Parse(txt_bcDenNam.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
