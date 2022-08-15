namespace QuanLyKhoHang
{
    partial class GUIPrint
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qUAN_LY_KHO_HANGDataSet1 = new DoAnCuoiKy.QUAN_LY_KHO_HANGDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hANG_HOATableAdapter1 = new DoAnCuoiKy.QUAN_LY_KHO_HANGDataSetTableAdapters.HANG_HOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHO_HANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "DoAnCuoiKy.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(864, 413);
            this.reportViewer2.TabIndex = 0;
            // 
            // qUAN_LY_KHO_HANGDataSet1
            // 
            this.qUAN_LY_KHO_HANGDataSet1.DataSetName = "QUAN_LY_KHO_HANGDataSet";
            this.qUAN_LY_KHO_HANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "HANG_HOA";
            this.bindingSource1.DataSource = this.qUAN_LY_KHO_HANGDataSet1;
            // 
            // hANG_HOATableAdapter1
            // 
            this.hANG_HOATableAdapter1.ClearBeforeFill = true;
            // 
            // GUIPrint
            // 
            this.ClientSize = new System.Drawing.Size(864, 413);
            this.Controls.Add(this.reportViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUIPrint";
            this.Load += new System.EventHandler(this.GUIPrint_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_KHO_HANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private System.Windows.Forms.BindingSource hANGHOABindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private DoAnCuoiKy.QUAN_LY_KHO_HANGDataSet qUAN_LY_KHO_HANGDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DoAnCuoiKy.QUAN_LY_KHO_HANGDataSetTableAdapters.HANG_HOATableAdapter hANG_HOATableAdapter1;
    }
}