﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_PersonalFabrica : BE_Personal
    {
        public BE_PersonalFabrica()  
       {
            this.Tipo_Personal = "Fabrica";
            CalcularSalario();
        }
        public override void CalcularSalario()
        {
            this.Salario = this.SueldBasico += 4000;
        }
    }
}
