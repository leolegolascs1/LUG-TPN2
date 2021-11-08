using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Negocio_BLL;
using BE;
using BE.Vistas;
namespace Presentacion_IU
{
    public partial class FrmListaPrecioProveedores : Form
    {
        BE_Arandela oBEArandela;
        BLL_ListaPrecioProveedores oBLLListaPrecios;
        public FrmListaPrecioProveedores()
        {
            oBEArandela = new BE_Arandela();
            oBLLListaPrecios = new BLL_ListaPrecioProveedores();
            InitializeComponent();
        }

        private void FrmListaPrecioProveedores_Load(object sender, EventArgs e)
        {
            oBLLListaPrecios.ListarTodo();
        }
        private void MostrarGrilla(DataGridView pGrid, object obj)
        {
            pGrid.DataSource = null;
            pGrid.DataSource = obj;
            pGrid.AutoResizeColumns();
            pGrid.AllowUserToResizeColumns = false;
            pGrid.AllowUserToResizeRows = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarGrilla(dtgListadoPrecios, oBLLListaPrecios.ListarTodo());
        }
        private void Limpiar() 
        {
            tbxMedidas.Text = "";
            tbxNatural.Text = "";
            tbxZincado.Text = "";
            tbxCantxKilo.Text = "";
            tbxPrecioxKilo.Text = "";
        
        
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

           if(CL_Validar.EsNumericoFloat(tbxNatural.Text) && CL_Validar.EsNumericoFloat (tbxZincado.Text) ) 
            {
                if(CL_Validar.EsNumerico(tbxCantxKilo.Text) && CL_Validar.EsNumerico(tbxPrecioxKilo.Text)) 
                {
                    oBEArandela.Medidas = tbxMedidas.Text.ToString().Trim();
                    oBEArandela.Natural = tbxNatural.Text.ToString().Trim();
                    oBEArandela.Zincado = tbxZincado.Text.ToString().Trim();
                    oBEArandela.CantxKilo = int.Parse(tbxCantxKilo.Text.ToString().Trim());
                    oBEArandela.PrecioxKilo = tbxPrecioxKilo.Text.ToString().Trim();

                    oBLLListaPrecios.Guardar(oBEArandela);
                    Limpiar();
                    MostrarGrilla(dtgListadoPrecios, oBLLListaPrecios.ListarTodo());
                }
                else
                {
                    MessageBox.Show("Por favor ingrese valores numéricos en catidad por kilo y precio por kilo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese los precios en formato correcto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           MostrarGrilla (dtgListadoPrecios, oBLLListaPrecios.Buscar(tbxBusqueda.Text.Trim()));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            oBLLListaPrecios.ListarTodo();
        }
    }
}
