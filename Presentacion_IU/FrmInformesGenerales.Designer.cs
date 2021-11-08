namespace Presentacion_IU
{
    partial class FrmInformesGenerales
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
            this.gbxInforme = new System.Windows.Forms.GroupBox();
            this.tbxItemPedidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOrdenes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxProveedores = new System.Windows.Forms.TextBox();
            this.lblCProveedor = new System.Windows.Forms.Label();
            this.tbxPersonal = new System.Windows.Forms.TextBox();
            this.lblCPersonal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DBDematazoDataSet = new Presentacion_IU.DBDematazoDataSet();
            this.TbDetalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TbDetalleCompraTableAdapter = new Presentacion_IU.DBDematazoDataSetTableAdapters.TbDetalleCompraTableAdapter();
            this.TbPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TbPersonalTableAdapter = new Presentacion_IU.DBDematazoDataSetTableAdapters.TbPersonalTableAdapter();
            this.gbxInforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBDematazoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbDetalleCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbPersonalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInforme
            // 
            this.gbxInforme.Controls.Add(this.tbxItemPedidos);
            this.gbxInforme.Controls.Add(this.label3);
            this.gbxInforme.Controls.Add(this.tbxOrdenes);
            this.gbxInforme.Controls.Add(this.label2);
            this.gbxInforme.Controls.Add(this.tbxProveedores);
            this.gbxInforme.Controls.Add(this.lblCProveedor);
            this.gbxInforme.Controls.Add(this.tbxPersonal);
            this.gbxInforme.Controls.Add(this.lblCPersonal);
            this.gbxInforme.Location = new System.Drawing.Point(30, 62);
            this.gbxInforme.Name = "gbxInforme";
            this.gbxInforme.Size = new System.Drawing.Size(309, 235);
            this.gbxInforme.TabIndex = 1;
            this.gbxInforme.TabStop = false;
            this.gbxInforme.Text = "Informes";
            // 
            // tbxItemPedidos
            // 
            this.tbxItemPedidos.Location = new System.Drawing.Point(179, 165);
            this.tbxItemPedidos.Name = "tbxItemPedidos";
            this.tbxItemPedidos.ReadOnly = true;
            this.tbxItemPedidos.Size = new System.Drawing.Size(100, 20);
            this.tbxItemPedidos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de Items Pedidos";
            // 
            // tbxOrdenes
            // 
            this.tbxOrdenes.Location = new System.Drawing.Point(179, 126);
            this.tbxOrdenes.Name = "tbxOrdenes";
            this.tbxOrdenes.ReadOnly = true;
            this.tbxOrdenes.Size = new System.Drawing.Size(100, 20);
            this.tbxOrdenes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de Ordenes Registradas:";
            // 
            // tbxProveedores
            // 
            this.tbxProveedores.Location = new System.Drawing.Point(179, 85);
            this.tbxProveedores.Name = "tbxProveedores";
            this.tbxProveedores.ReadOnly = true;
            this.tbxProveedores.Size = new System.Drawing.Size(100, 20);
            this.tbxProveedores.TabIndex = 1;
            // 
            // lblCProveedor
            // 
            this.lblCProveedor.AutoSize = true;
            this.lblCProveedor.Location = new System.Drawing.Point(43, 88);
            this.lblCProveedor.Name = "lblCProveedor";
            this.lblCProveedor.Size = new System.Drawing.Size(130, 13);
            this.lblCProveedor.TabIndex = 0;
            this.lblCProveedor.Text = "Cantidad de Proveedores:";
            // 
            // tbxPersonal
            // 
            this.tbxPersonal.Location = new System.Drawing.Point(179, 46);
            this.tbxPersonal.Name = "tbxPersonal";
            this.tbxPersonal.ReadOnly = true;
            this.tbxPersonal.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonal.TabIndex = 1;
            // 
            // lblCPersonal
            // 
            this.lblCPersonal.AutoSize = true;
            this.lblCPersonal.Location = new System.Drawing.Point(62, 49);
            this.lblCPersonal.Name = "lblCPersonal";
            this.lblCPersonal.Size = new System.Drawing.Size(111, 13);
            this.lblCPersonal.TabIndex = 0;
            this.lblCPersonal.Text = "Cantidad de Personal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMES";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TbDetalleCompraBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TbPersonalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion_IU.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(374, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(644, 307);
            this.reportViewer1.TabIndex = 3;
            // 
            // DBDematazoDataSet
            // 
            this.DBDematazoDataSet.DataSetName = "DBDematazoDataSet";
            this.DBDematazoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TbDetalleCompraBindingSource
            // 
            this.TbDetalleCompraBindingSource.DataMember = "TbDetalleCompra";
            this.TbDetalleCompraBindingSource.DataSource = this.DBDematazoDataSet;
            // 
            // TbDetalleCompraTableAdapter
            // 
            this.TbDetalleCompraTableAdapter.ClearBeforeFill = true;
            // 
            // TbPersonalBindingSource
            // 
            this.TbPersonalBindingSource.DataMember = "TbPersonal";
            this.TbPersonalBindingSource.DataSource = this.DBDematazoDataSet;
            // 
            // TbPersonalTableAdapter
            // 
            this.TbPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInformesGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 404);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxInforme);
            this.Name = "FrmInformesGenerales";
            this.Text = "FrmInformesGenerales";
            this.Load += new System.EventHandler(this.FrmInformesGenerales_Load);
            this.gbxInforme.ResumeLayout(false);
            this.gbxInforme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBDematazoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbDetalleCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbPersonalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxInforme;
        private System.Windows.Forms.Label lblCPersonal;
        private System.Windows.Forms.TextBox tbxItemPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOrdenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxProveedores;
        private System.Windows.Forms.Label lblCProveedor;
        private System.Windows.Forms.TextBox tbxPersonal;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TbDetalleCompraBindingSource;
        private DBDematazoDataSet DBDematazoDataSet;
        private System.Windows.Forms.BindingSource TbPersonalBindingSource;
        private DBDematazoDataSetTableAdapters.TbDetalleCompraTableAdapter TbDetalleCompraTableAdapter;
        private DBDematazoDataSetTableAdapters.TbPersonalTableAdapter TbPersonalTableAdapter;
    }
}