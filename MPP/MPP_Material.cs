using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using Abstraccion;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
namespace MPP
{
    public class MPP_Material : IGestor<BE_Materiales>
    {
        ArrayList AL;
        Acceso oDatos;
        public bool Baja(BE_Materiales Objeto)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Eliminar_Materiales";

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Codigo";
            Param1.Value = Objeto.Codigo;
            Param1.SqlDbType = SqlDbType.Int;
            AL.Add(Param1);
            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }
        public bool Guardar(BE_Materiales Objeto)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Guardar_Materiales";
            if (Objeto.Codigo != 0) //Si teng codigo es un updata
            {
                SqlParameter Param6 = new SqlParameter();
                Param6.ParameterName = "@Codigo";
                Param6.Value = Objeto.Codigo;
                Param6.SqlDbType = SqlDbType.Int;
                AL.Add(Param6);
                Consulta_SQL = "s_Modificar_Materiales";
            }

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Descripcion_Articulo";
            Param1.Value = Objeto.Descripcion_material;
            Param1.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param1);

            SqlParameter Param2 = new SqlParameter();
            Param2.ParameterName = "@Material";
            Param2.Value = Objeto.Material;
            Param2.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param2);
            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }

        public List<BE_Materiales> ListarTodo()
        {
            List<BE_Materiales> Lista = new List<BE_Materiales>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds;
            string Store = "s_Listar_Material";
            oDatos = new Acceso();
            Ds = oDatos.Leer3(Store, null); //paso nulo porque es solo consulta.

            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    BE_Materiales oBEMaterial;
                    oBEMaterial = new BE_Materiales();
                    oBEMaterial.Codigo = int.Parse(fila["Codigo"].ToString());
                    oBEMaterial.Descripcion_material  = (fila["Descripcion_Articulo"].ToString()) +"-"+ (fila["Material"].ToString());
                    oBEMaterial.Material = (fila["Material"].ToString());

                    Lista.Add(oBEMaterial);
                }
            }
            else
            {
                Lista = null;
            }
            return Lista;
        }
    }
}
