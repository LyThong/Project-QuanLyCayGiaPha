namespace QuanLyCayGiaPha
{
    partial class baocao_thanhtich
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLCGPDataSet = new QuanLyCayGiaPha.QLCGPDataSet();
            this.GhiNhanThanhTich1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GhiNhanThanhTich1TableAdapter = new QuanLyCayGiaPha.QLCGPDataSetTableAdapters.GhiNhanThanhTich1TableAdapter();
            this.txt_TuNam = new System.Windows.Forms.TextBox();
            this.txt_DenNam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QLCGPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhiNhanThanhTich1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1_baocao_thanhtich";
            reportDataSource1.Value = this.GhiNhanThanhTich1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCayGiaPha.baocao_thanhtich.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(514, 223);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLCGPDataSet
            // 
            this.QLCGPDataSet.DataSetName = "QLCGPDataSet";
            this.QLCGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GhiNhanThanhTich1BindingSource
            // 
            this.GhiNhanThanhTich1BindingSource.DataMember = "GhiNhanThanhTich1";
            this.GhiNhanThanhTich1BindingSource.DataSource = this.QLCGPDataSet;
            // 
            // GhiNhanThanhTich1TableAdapter
            // 
            this.GhiNhanThanhTich1TableAdapter.ClearBeforeFill = true;
            // 
            // txt_TuNam
            // 
            this.txt_TuNam.Location = new System.Drawing.Point(115, 10);
            this.txt_TuNam.Name = "txt_TuNam";
            this.txt_TuNam.Size = new System.Drawing.Size(100, 20);
            this.txt_TuNam.TabIndex = 1;
            // 
            // txt_DenNam
            // 
            this.txt_DenNam.Location = new System.Drawing.Point(290, 11);
            this.txt_DenNam.Name = "txt_DenNam";
            this.txt_DenNam.Size = new System.Drawing.Size(100, 20);
            this.txt_DenNam.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến năm";
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(418, 10);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 5;
            this.but_OK.Text = "OK";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // baocao_thanhtich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 261);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DenNam);
            this.Controls.Add(this.txt_TuNam);
            this.Controls.Add(this.reportViewer1);
            this.Name = "baocao_thanhtich";
            this.Text = "baocao_thanhtich";
            this.Load += new System.EventHandler(this.baocao_thanhtich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLCGPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhiNhanThanhTich1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GhiNhanThanhTich1BindingSource;
        private QLCGPDataSet QLCGPDataSet;
        private QLCGPDataSetTableAdapters.GhiNhanThanhTich1TableAdapter GhiNhanThanhTich1TableAdapter;
        private System.Windows.Forms.TextBox txt_TuNam;
        private System.Windows.Forms.TextBox txt_DenNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_OK;
    }
}