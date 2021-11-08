using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstraccion;
namespace BE
{
    public class BE_Arandela:IEntidad
    {
        private int _codigo;
        private string _medidas;
        private string _natural;
        private string _zincado;
        private int _cantxKilo;
        private string _precioxKilo;


        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Medidas { get => _medidas; set => _medidas = value; }
        public string Natural { get => _natural; set => _natural = value; }
        public string Zincado { get => _zincado; set => _zincado = value; }
        public int CantxKilo { get => _cantxKilo; set => _cantxKilo = value; }
        public string PrecioxKilo { get => _precioxKilo; set => _precioxKilo = value; }
        
    }
}
