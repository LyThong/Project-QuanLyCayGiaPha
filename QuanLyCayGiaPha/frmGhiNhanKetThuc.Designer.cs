namespace QuanLyCayGiaPha
{
    partial class frmGhiNhanKetThuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHOTE = new System.Windows.Forms.ComboBox();
            this.cmbDiaDiemMT = new System.Windows.Forms.ComboBox();
            this.cmbNguyenNhan = new System.Windows.Forms.ComboBox();
            this.dtNgayGioMat = new System.Windows.Forms.DateTimePicker();
            this.gvKetThuc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvKetThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Và Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nguyên Nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Giờ Mất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Điểm Mai Táng:";
            // 
            // cmbHOTE
            // 
            this.cmbHOTE.FormattingEnabled = true;
            this.cmbHOTE.Location = new System.Drawing.Point(207, 42);
            this.cmbHOTE.Name = "cmbHOTE";
            this.cmbHOTE.Size = new System.Drawing.Size(121, 24);
            this.cmbHOTE.TabIndex = 4;
            // 
            // cmbDiaDiemMT
            // 
            this.cmbDiaDiemMT.FormattingEnabled = true;
            this.cmbDiaDiemMT.Location = new System.Drawing.Point(549, 128);
            this.cmbDiaDiemMT.Name = "cmbDiaDiemMT";
            this.cmbDiaDiemMT.Size = new System.Drawing.Size(173, 24);
            this.cmbDiaDiemMT.TabIndex = 5;
            // 
            // cmbNguyenNhan
            // 
            this.cmbNguyenNhan.FormattingEnabled = true;
            this.cmbNguyenNhan.Location = new System.Drawing.Point(207, 121);
            this.cmbNguyenNhan.Name = "cmbNguyenNhan";
            this.cmbNguyenNhan.Size = new System.Drawing.Size(121, 24);
            this.cmbNguyenNhan.TabIndex = 5;
            // 
            // dtNgayGioMat
            // 
            this.dtNgayGioMat.Location = new System.Drawing.Point(549, 42);
            this.dtNgayGioMat.Name = "dtNgayGioMat";
            this.dtNgayGioMat.Size = new System.Drawing.Size(173, 22);
            this.dtNgayGioMat.TabIndex = 6;
            // 
            // gvKetThuc
            // 
            this.gvKetThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKetThuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvKetThuc.Location = new System.Drawing.Point(0, 279);
            this.gvKetThuc.Name = "gvKetThuc";
            this.gvKetThuc.RowTemplate.Height = 24;
            this.gvKetThuc.Size = new System.Drawing.Size(774, 150);
            this.gvKetThuc.TabIndex = 7;
            // 
            // frmGhiNhanKetThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 429);
            this.Controls.Add(this.gvKetThuc);
            this.Controls.Add(this.dtNgayGioMat);
            this.Controls.Add(this.cmbNguyenNhan);
            this.Controls.Add(this.cmbDiaDiemMT);
            this.Controls.Add(this.cmbHOTE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGhiNhanKetThuc";
            this.Text = "frmGhiNhanKetThuc";
            ((System.ComponentModel.ISupportInitialize)(this.gvKetThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHOTE;
        private System.Windows.Forms.ComboBox cmbDiaDiemMT;
        private System.Windows.Forms.ComboBox cmbNguyenNhan;
        private System.Windows.Forms.DateTimePicker dtNgayGioMat;
        private System.Windows.Forms.DataGridView gvKetThuc;
    }
}