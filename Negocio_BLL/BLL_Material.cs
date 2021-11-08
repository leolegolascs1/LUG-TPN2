﻿using System;
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
   public class BLL_Material:IGestor<BE_Materiales>
   {
        MPP_Material oMPPMaterial;
        public BLL_Material()
        {
            oMPPMaterial = new MPP_Material();
        }
        public bool Guardar(BE_Materiales oBEMaterial)
        {
            return oMPPMaterial.Guardar(oBEMaterial);
        }
        public List<BE_Materiales> ListarTodo()
        {
            return oMPPMaterial.ListarTodo();
        }
        public bool Baja(BE_Materiales oBEMaterial)
        {
            return oMPPMaterial.Baja(oBEMaterial);
        }
    }
}
