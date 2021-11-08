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
    public class BLL_Personal:IGestor<BE_Personal>
    {
        MPP_Personal oMPPPersonal;
        public BLL_Personal()
        {
            oMPPPersonal = new MPP_Personal();
        }
        public bool Guardar(BE_Personal oBEPersonal)
        {
            return oMPPPersonal.Guardar(oBEPersonal);
        }
        public bool GuardarPassword(BE_Personal oBEPersonal)
        {
            return oMPPPersonal.GuardarPassword(oBEPersonal);
        }
        public bool Baja(BE_Personal oBEPersonal)
        {
            return oMPPPersonal.Baja(oBEPersonal);
        }
        public List<BE_Personal> ListarTodo()
        {
            return oMPPPersonal.ListarTodo();
        }
    }

}
