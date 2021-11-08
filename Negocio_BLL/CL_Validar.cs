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
        static public bool EsNumerico(object num) //Valido que sea numero
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
        static public bool EsNumericoFloat(object num) //Valido que sea numero
        {
            try
            {
                return Regex.IsMatch(num.ToString(), "^[0-9]+(.[0-9]+)?$");
            }
            catch (Exception)
            {
                return false;
            }
        }
        static public bool EsTexto(object num) //Valido que sean solo letras.
        {
            try
            {
                return Regex.IsMatch(num.ToString(), "^([a-zA-Z ]+$)");
            }
            catch (Exception)
            {
                return false;
            }
        }
        static public bool ValidarFormatoMail(object num) //Valido que sean solo letras.
        {
            try
            {           
                return Regex.IsMatch(num.ToString(), "^([\\w-]+\\.)*?[\\w-]+@[\\w-]+\\.([\\w-]+\\.)*?[\\w]+$");
            }
            catch (Exception)
            {
                return false;
            }
        }
        static public bool ValidarCUIT(object num) //Valido que sean solo letras.
        {
            try
            {
                return Regex.IsMatch(num.ToString(), "^([\\w-]+\\.)*?[\\w-]+@[\\w-]+\\.([\\w-]+\\.)*?[\\w]+$");
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
