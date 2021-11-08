using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_IU
{
    public partial class FrmInformePersonal : Form
    {
        public FrmInformePersonal()
        {
            InitializeComponent();
        }

        private void FrmInformePersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBDematazoDataSet.TbOrdenCompra' Puede moverla o quitarla según sea necesario.
            this.TbOrdenCompraTableAdapter.Fill(this.dBDematazoDataSet.TbOrdenCompra);
            // TODO: esta línea de código carga datos en la tabla 'dBDematazoDataSet.TbProveedores' Puede moverla o quitarla según sea necesario.
            this.TbProveedoresTableAdapter.Fill(this.dBDematazoDataSet.TbProveedores);
            // TODO: esta línea de código carga datos en la tabla 'dBDematazoDataSet.TbPersonal' Puede moverla o quitarla según sea necesario.
            this.tbPersonalTableAdapter.Fill(this.dBDematazoDataSet.TbPersonal);
            this.reportViewer1.RefreshReport();
        }
    }
}
