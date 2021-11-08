using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
namespace BE
{
    public class BE_DetalleOrdenCompra:IEntidad
    {
        private int _codigo;
        private int _nroOrden;
        private BE_Materiales  _item; 
        private int _cantidad;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public int NroOrden { get => _nroOrden; set => _nroOrden = value; }
        public BE_Materiales Item { get => _item; set => _item = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}
