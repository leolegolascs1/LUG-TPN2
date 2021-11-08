using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Vistas
{
    public class VistaItemOrden
    {
        public int IdDetalle { get; set; }
        public int Codigo_Art { get; set; }
        public string Descripcion { get; set; }  
        public string Cantidad { get; set; }

        public List<VistaItemOrden> CargarGridVista(List<BE_DetalleOrdenCompra> pLista) //Recorro la lista de beneficiarios y voy generando la lista a mostrar en la grilla
        {
            List<VistaItemOrden> _lstVistaFin = new List<VistaItemOrden>();

            //Creo una lista que se enviará a la grilla
            foreach (BE_DetalleOrdenCompra item in pLista) //Recorro la lista original y popula lista nueva
            {
                VistaItemOrden vistaN = new VistaItemOrden();

                vistaN.IdDetalle  = item.Codigo;
                vistaN.Codigo_Art  = item.Item.Codigo;
                vistaN.Descripcion = item.Item.Descripcion_material;
                vistaN.Cantidad = item.Cantidad.ToString();

                _lstVistaFin.Add(vistaN);
            }
            return _lstVistaFin;
        }

    }
}
