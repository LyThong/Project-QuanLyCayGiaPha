namespace QuanLyCayGiaPha
{
    partial class frmCapTaiKhoan
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
            this.txtcapTk = new System.Windows.Forms.TextBox();
            this.txtcapMk = new System.Windows.Forms.TextBox();
            this.btntxoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gvTaiKhaan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhaan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cấp Tài Khoản";
            // 
            // txtcapTk
            // 
            this.txtcapTk.Location = new System.Drawing.Point(180, 70);
            this.txtcapTk.Name = "txtcapTk";
            this.txtcapTk.Size = new System.Drawing.Size(176, 22);
            this.txtcapTk.TabIndex = 1;
            this.txtcapTk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcapMk
            // 
            this.txtcapMk.Location = new System.Drawing.Point(181, 131);
            this.txtcapMk.Name = "txtcapMk";
            this.txtcapMk.Size = new System.Drawing.Size(175, 22);
            this.txtcapMk.TabIndex = 2;
            // 
            // btntxoa
            // 
            this.btntxoa.Location = new System.Drawing.Point(281, 266);
            this.btntxoa.Name = "btntxoa";
            this.btntxoa.Size = new System.Drawing.Size(75, 30);
            this.btntxoa.TabIndex = 3;
            this.btntxoa.Text = "Xóa";
            this.btntxoa.UseVisualStyleBackColor = true;
            this.btntxoa.Click += new System.EventHandler(this.btntxoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(133, 266);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(405, 266);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // gvTaiKhaan
            // 
            this.gvTaiKhaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTaiKhaan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvTaiKhaan.Location = new System.Drawing.Point(0, 332);
            this.gvTaiKhaan.Name = "gvTaiKhaan";
            this.gvTaiKhaan.RowTemplate.Height = 24;
            this.gvTaiKhaan.Size = new System.Drawing.Size(737, 175);
            this.gvTaiKhaan.TabIndex = 4;
            this.gvTaiKhaan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTaiKhaan_RowEnter);
            // 
            // frmCapTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 507);
            this.Controls.Add(this.gvTaiKhaan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btntxoa);
            this.Controls.Add(this.txtcapMk);
            this.Controls.Add(this.txtcapTk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCapTaiKhoan";
            this.Text = "frmCapTaiKhoan";
            this.Load += new System.EventHandler(this.frmCapTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhaan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcapTk;
        private System.Windows.Forms.TextBox txtcapMk;
        private System.Windows.Forms.Button btntxoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView gvTaiKhaan;
    }
}