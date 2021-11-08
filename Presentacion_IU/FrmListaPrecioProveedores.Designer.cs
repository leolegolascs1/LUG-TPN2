
namespace Presentacion_IU
{
    partial class FrmListaPrecioProveedores
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
            this.dtgListadoPrecios = new System.Windows.Forms.DataGridView();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxMedidas = new System.Windows.Forms.TextBox();
            this.tbxNatural = new System.Windows.Forms.TextBox();
            this.tbxCantxKilo = new System.Windows.Forms.TextBox();
            this.tbxZincado = new System.Windows.Forms.TextBox();
            this.tbxPrecioxKilo = new System.Windows.Forms.TextBox();
            this.lblMedidas = new System.Windows.Forms.Label();
            this.lblNatural = new System.Windows.Forms.Label();
            this.lblZincado = new System.Windows.Forms.Label();
            this.lblCanxKilo = new System.Windows.Forms.Label();
            this.lblPrecioKilo = new System.Windows.Forms.Label();
            this.gbxGuardar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTituloListadoPrecios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoPrecios)).BeginInit();
            this.gbxGuardar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgListadoPrecios
            // 
            this.dtgListadoPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListadoPrecios.Location = new System.Drawing.Point(12, 51);
            this.dtgListadoPrecios.Name = "dtgListadoPrecios";
            this.dtgListadoPrecios.ReadOnly = true;
            this.dtgListadoPrecios.Size = new System.Drawing.Size(762, 211);
            this.dtgListadoPrecios.TabIndex = 0;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(363, 281);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 49);
            this.btnLeer.TabIndex = 1;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(134, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 39);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxMedidas
            // 
            this.tbxMedidas.Location = new System.Drawing.Point(111, 20);
            this.tbxMedidas.Name = "tbxMedidas";
            this.tbxMedidas.Size = new System.Drawing.Size(81, 20);
            this.tbxMedidas.TabIndex = 3;
            // 
            // tbxNatural
            // 
            this.tbxNatural.Location = new System.Drawing.Point(111, 46);
            this.tbxNatural.Name = "tbxNatural";
            this.tbxNatural.Size = new System.Drawing.Size(125, 20);
            this.tbxNatural.TabIndex = 4;
            // 
            // tbxCantxKilo
            // 
            this.tbxCantxKilo.Location = new System.Drawing.Point(111, 98);
            this.tbxCantxKilo.Name = "tbxCantxKilo";
            this.tbxCantxKilo.Size = new System.Drawing.Size(125, 20);
            this.tbxCantxKilo.TabIndex = 6;
            // 
            // tbxZincado
            // 
            this.tbxZincado.Location = new System.Drawing.Point(111, 72);
            this.tbxZincado.Name = "tbxZincado";
            this.tbxZincado.Size = new System.Drawing.Size(125, 20);
            this.tbxZincado.TabIndex = 5;
            // 
            // tbxPrecioxKilo
            // 
            this.tbxPrecioxKilo.Location = new System.Drawing.Point(111, 125);
            this.tbxPrecioxKilo.Name = "tbxPrecioxKilo";
            this.tbxPrecioxKilo.Size = new System.Drawing.Size(125, 20);
            this.tbxPrecioxKilo.TabIndex = 7;
            // 
            // lblMedidas
            // 
            this.lblMedidas.AutoSize = true;
            this.lblMedidas.Location = new System.Drawing.Point(56, 23);
            this.lblMedidas.Name = "lblMedidas";
            this.lblMedidas.Size = new System.Drawing.Size(50, 13);
            this.lblMedidas.TabIndex = 5;
            this.lblMedidas.Text = "Medidas:";
            // 
            // lblNatural
            // 
            this.lblNatural.AutoSize = true;
            this.lblNatural.Location = new System.Drawing.Point(20, 49);
            this.lblNatural.Name = "lblNatural";
            this.lblNatural.Size = new System.Drawing.Size(86, 13);
            this.lblNatural.TabIndex = 5;
            this.lblNatural.Text = "Precio Natural: $";
            // 
            // lblZincado
            // 
            this.lblZincado.AutoSize = true;
            this.lblZincado.Location = new System.Drawing.Point(15, 75);
            this.lblZincado.Name = "lblZincado";
            this.lblZincado.Size = new System.Drawing.Size(91, 13);
            this.lblZincado.TabIndex = 5;
            this.lblZincado.Text = "Precio Zincado: $";
            // 
            // lblCanxKilo
            // 
            this.lblCanxKilo.AutoSize = true;
            this.lblCanxKilo.Location = new System.Drawing.Point(51, 101);
            this.lblCanxKilo.Name = "lblCanxKilo";
            this.lblCanxKilo.Size = new System.Drawing.Size(54, 13);
            this.lblCanxKilo.TabIndex = 5;
            this.lblCanxKilo.Text = "CantxKilo:";
            // 
            // lblPrecioKilo
            // 
            this.lblPrecioKilo.AutoSize = true;
            this.lblPrecioKilo.Location = new System.Drawing.Point(20, 128);
            this.lblPrecioKilo.Name = "lblPrecioKilo";
            this.lblPrecioKilo.Size = new System.Drawing.Size(87, 13);
            this.lblPrecioKilo.TabIndex = 5;
            this.lblPrecioKilo.Text = "Precio por Kilo: $";
            // 
            // gbxGuardar
            // 
            this.gbxGuardar.Controls.Add(this.lblPrecioKilo);
            this.gbxGuardar.Controls.Add(this.lblCanxKilo);
            this.gbxGuardar.Controls.Add(this.lblZincado);
            this.gbxGuardar.Controls.Add(this.lblNatural);
            this.gbxGuardar.Controls.Add(this.lblMedidas);
            this.gbxGuardar.Controls.Add(this.tbxPrecioxKilo);
            this.gbxGuardar.Controls.Add(this.tbxZincado);
            this.gbxGuardar.Controls.Add(this.tbxCantxKilo);
            this.gbxGuardar.Controls.Add(this.tbxNatural);
            this.gbxGuardar.Controls.Add(this.tbxMedidas);
            this.gbxGuardar.Controls.Add(this.btnGuardar);
            this.gbxGuardar.Location = new System.Drawing.Point(12, 268);
            this.gbxGuardar.Name = "gbxGuardar";
            this.gbxGuardar.Size = new System.Drawing.Size(318, 205);
            this.gbxGuardar.TabIndex = 6;
            this.gbxGuardar.TabStop = false;
            this.gbxGuardar.Text = "Menú Guardar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbxBusqueda);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Location = new System.Drawing.Point(470, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda:";
            // 
            // tbxBusqueda
            // 
            this.tbxBusqueda.Location = new System.Drawing.Point(48, 48);
            this.tbxBusqueda.Name = "tbxBusqueda";
            this.tbxBusqueda.Size = new System.Drawing.Size(206, 20);
            this.tbxBusqueda.TabIndex = 9;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(45, 32);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(96, 13);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar por Medida";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(48, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(179, 74);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTituloListadoPrecios
            // 
            this.lblTituloListadoPrecios.AutoSize = true;
            this.lblTituloListadoPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListadoPrecios.Location = new System.Drawing.Point(206, 13);
            this.lblTituloListadoPrecios.Name = "lblTituloListadoPrecios";
            this.lblTituloListadoPrecios.Size = new System.Drawing.Size(388, 24);
            this.lblTituloListadoPrecios.TabIndex = 8;
            this.lblTituloListadoPrecios.Text = "LISTADO DE PRECIOS DE ARANDELAS";
            // 
            // FrmListaPrecioProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 488);
            this.Controls.Add(this.lblTituloListadoPrecios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.dtgListadoPrecios);
            this.Name = "FrmListaPrecioProveedores";
            this.Text = "FrmListaPrecioProveedores";
            this.Load += new System.EventHandler(this.FrmListaPrecioProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoPrecios)).EndInit();
            this.gbxGuardar.ResumeLayout(false);
            this.gbxGuardar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListadoPrecios;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxMedidas;
        private System.Windows.Forms.TextBox tbxNatural;
        private System.Windows.Forms.TextBox tbxCantxKilo;
        private System.Windows.Forms.TextBox tbxZincado;
        private System.Windows.Forms.TextBox tbxPrecioxKilo;
        private System.Windows.Forms.Label lblMedidas;
        private System.Windows.Forms.Label lblNatural;
        private System.Windows.Forms.Label lblZincado;
        private System.Windows.Forms.Label lblCanxKilo;
        private System.Windows.Forms.Label lblPrecioKilo;
        private System.Windows.Forms.GroupBox gbxGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTituloListadoPrecios;
    }
}