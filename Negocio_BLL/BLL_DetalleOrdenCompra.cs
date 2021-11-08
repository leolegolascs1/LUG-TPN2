using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Abstraccion;
using MPP;
using BE;
namespace Negocio_BLL
{
    public class BLL_DetalleOrdenCompra : IGestor<BE_DetalleOrdenCompra>
    {
        MPP_DetalleOrdenCompra oMPPDetalleOrdenCompra;
        public BLL_DetalleOrdenCompra() 
        {
            oMPPDetalleOrdenCompra = new MPP_DetalleOrdenCompra();
        }
        public bool Baja(BE_DetalleOrdenCompra Objeto)
        {
            return oMPPDetalleOrdenCompra.Baja(Objeto);
        }
        public bool Guardar(BE_DetalleOrdenCompra Objeto)
        {
            return oMPPDetalleOrdenCompra.Guardar(Objeto);
        }
        public List<BE_DetalleOrdenCompra> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
