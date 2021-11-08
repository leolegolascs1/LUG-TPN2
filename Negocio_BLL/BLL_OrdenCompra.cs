using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using Abstraccion;
using MPP;
using BE;
namespace Negocio_BLL
{
    public class BLL_OrdenCompra : IGestor<BE_OrdenCompra>
    {
        MPP_OrdenCompra oMPPOrdenCompra;
        public BLL_OrdenCompra()
        {
            oMPPOrdenCompra = new MPP_OrdenCompra();
        }
        public bool Guardar(BE_OrdenCompra oBEOrdenCompra)
        {
            return oMPPOrdenCompra.Guardar(oBEOrdenCompra);
        }
        public bool Baja(BE_OrdenCompra Objeto)
        {
            bool estado = true;
            estado = oMPPOrdenCompra.Baja(Objeto); //Elimino orden de la tabla
            estado = oMPPOrdenCompra.BajaItemCompra(Objeto); //Elimino Todos sus items.
            return estado;
        }
        public List<BE_OrdenCompra> ListarTodo()
        {
            return oMPPOrdenCompra.ListarTodo();
        }
        public bool AgregarItemCompra(BE_OrdenCompra oBEOrdenCompra, BE_Materiales oBEMaterial, int pCantidad)
        {
            return oMPPOrdenCompra.AgregarItemCompra(oBEOrdenCompra, oBEMaterial, pCantidad);
        }
    }
}
