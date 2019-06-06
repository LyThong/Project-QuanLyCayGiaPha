namespace QuanLyCayGiaPha
{
    partial class baocao_tanggiam
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
            this.but_bcOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bcTuNam = new System.Windows.Forms.TextBox();
            this.txt_bcDenNam = new System.Windows.Forms.TextBox();
            this.QLCGPDataSet = new QuanLyCayGiaPha.QLCGPDataSet();
            this.TangGiamTVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TangGiamTVTableAdapter = new QuanLyCayGiaPha.QLCGPDataSetTableAdapters.TangGiamTVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLCGPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TangGiamTVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet2_bc_tanggiam";
            reportDataSource1.Value = this.TangGiamTVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCayGiaPha.baocao_tanggiam.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(787, 293);
            this.reportViewer1.TabIndex = 0;
            // 
            // but_bcOK
            // 
            this.but_bcOK.Location = new System.Drawing.Point(614, 17);
            this.but_bcOK.Name = "but_bcOK";
            this.but_bcOK.Size = new System.Drawing.Size(75, 23);
            this.but_bcOK.TabIndex = 1;
            this.but_bcOK.Text = "OK";
            this.but_bcOK.UseVisualStyleBackColor = true;
            this.but_bcOK.Click += new System.EventHandler(this.but_bcOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến năm";
            // 
            // txt_bcTuNam
            // 
            this.txt_bcTuNam.Location = new System.Drawing.Point(198, 16);
            this.txt_bcTuNam.Name = "txt_bcTuNam";
            this.txt_bcTuNam.Size = new System.Drawing.Size(100, 20);
            this.txt_bcTuNam.TabIndex = 3;
            // 
            // txt_bcDenNam
            // 
            this.txt_bcDenNam.Location = new System.Drawing.Point(440, 19);
            this.txt_bcDenNam.Name = "txt_bcDenNam";
            this.txt_bcDenNam.Size = new System.Drawing.Size(100, 20);
            this.txt_bcDenNam.TabIndex = 3;
            // 
            // QLCGPDataSet
            // 
            this.QLCGPDataSet.DataSetName = "QLCGPDataSet";
            this.QLCGPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TangGiamTVBindingSource
            // 
            this.TangGiamTVBindingSource.DataMember = "TangGiamTV";
            this.TangGiamTVBindingSource.DataSource = this.QLCGPDataSet;
            // 
            // TangGiamTVTableAdapter
            // 
            this.TangGiamTVTableAdapter.ClearBeforeFill = true;
            // 
            // baocao_tanggiam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 343);
            this.Controls.Add(this.txt_bcDenNam);
            this.Controls.Add(this.txt_bcTuNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_bcOK);
            this.Controls.Add(this.reportViewer1);
            this.Name = "baocao_tanggiam";
            this.Text = "baocao_tanggiam";
            this.Load += new System.EventHandler(this.baocao_tanggiam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLCGPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TangGiamTVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button but_bcOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bcTuNam;
        private System.Windows.Forms.TextBox txt_bcDenNam;
        private System.Windows.Forms.BindingSource TangGiamTVBindingSource;
        private QLCGPDataSet QLCGPDataSet;
        private QLCGPDataSetTableAdapters.TangGiamTVTableAdapter TangGiamTVTableAdapter;
    }
}