
namespace Presentacion_IU
{
    partial class FrmInformePersonal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TbProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDematazoDataSet = new Presentacion_IU.DBDematazoDataSet();
            this.TbOrdenCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDematazoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPersonalTableAdapter = new Presentacion_IU.DBDematazoDataSetTableAdapters.TbPersonalTableAdapter();
            this.TbProveedoresTableAdapter = new Presentacion_IU.DBDematazoDataSetTableAdapters.TbProveedoresTableAdapter();
            this.TbOrdenCompraTableAdapter = new Presentacion_IU.DBDematazoDataSetTableAdapters.TbOrdenCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDematazoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbOrdenCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDematazoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPersonalBindingSource
            // 
            this.tbPersonalBindingSource.DataMember = "TbPersonal";
            this.tbPersonalBindingSource.DataSource = this.dBDematazoDataSetBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbPersonalBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TbProveedoresBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.TbOrdenCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion_IU.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(969, 669);
            this.reportViewer1.TabIndex = 0;
            // 
            // TbProveedoresBindingSource
            // 
            this.TbProveedoresBindingSource.DataMember = "TbProveedores";
            this.TbProveedoresBindingSource.DataSource = this.dBDematazoDataSet;
            // 
            // dBDematazoDataSet
            // 
            this.dBDematazoDataSet.DataSetName = "DBDematazoDataSet";
            this.dBDematazoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TbOrdenCompraBindingSource
            // 
            this.TbOrdenCompraBindingSource.DataMember = "TbOrdenCompra";
            this.TbOrdenCompraBindingSource.DataSource = this.dBDematazoDataSet;
            // 
            // dBDematazoDataSetBindingSource
            // 
            this.dBDematazoDataSetBindingSource.DataSource = this.dBDematazoDataSet;
            this.dBDematazoDataSetBindingSource.Position = 0;
            // 
            // tbPersonalTableAdapter
            // 
            this.tbPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // TbProveedoresTableAdapter
            // 
            this.TbProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // TbOrdenCompraTableAdapter
            // 
            this.TbOrdenCompraTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInformePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 669);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmInformePersonal";
            this.Text = "FrmInformePersonal";
            this.Load += new System.EventHandler(this.FrmInformePersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDematazoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbOrdenCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDematazoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DBDematazoDataSet dBDematazoDataSet;
        private System.Windows.Forms.BindingSource dBDematazoDataSetBindingSource;
        private System.Windows.Forms.BindingSource tbPersonalBindingSource;
        private DBDematazoDataSetTableAdapters.TbPersonalTableAdapter tbPersonalTableAdapter;
        private System.Windows.Forms.BindingSource TbProveedoresBindingSource;
        private DBDematazoDataSetTableAdapters.TbProveedoresTableAdapter TbProveedoresTableAdapter;
        private System.Windows.Forms.BindingSource TbOrdenCompraBindingSource;
        private DBDematazoDataSetTableAdapters.TbOrdenCompraTableAdapter TbOrdenCompraTableAdapter;
    }
}