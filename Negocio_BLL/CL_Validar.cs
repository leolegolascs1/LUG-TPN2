using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Negocio_BLL
{
    public static class CL_Validar
    {
        static public bool EsNumerico(object num)
        {
            try
            {
                return Regex.IsMatch(num.ToString(), "^([0-9]+$)"); 
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
