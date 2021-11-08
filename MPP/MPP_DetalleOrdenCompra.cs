using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using Abstraccion;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace MPP
{
    public class MPP_DetalleOrdenCompra : IGestor<BE_DetalleOrdenCompra>
    {
        ArrayList AL;
        Acceso oDatos;
        public bool Baja(BE_DetalleOrdenCompra Objeto)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Eliminar_DetalleCompra_Individual";

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@IdDetalle";
            Param1.Value = Objeto.Codigo;
            Param1.SqlDbType = SqlDbType.Int;
            AL.Add(Param1);
            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }

        public bool Guardar(BE_DetalleOrdenCompra Objeto)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Guardar_Detalle_Orden_Compra";
            if (Objeto.Codigo != 0) //Si teng codigo es un updata
            {
                SqlParameter Param6 = new SqlParameter();
                Param6.ParameterName = "@IdDetalle";
                Param6.Value = Objeto.Codigo;
                Param6.SqlDbType = SqlDbType.Int;
                AL.Add(Param6);
                Consulta_SQL = "s_Modificar_Detalle_Orden_Compra";
            }

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@NroOrden";
            Param1.Value = Objeto.NroOrden;
            Param1.SqlDbType = SqlDbType.Int;
            AL.Add(Param1);

            SqlParameter Param2 = new SqlParameter();
            Param2.ParameterName = "@NroItem";
            Param2.Value = Objeto.Item.Codigo;
            Param2.SqlDbType = SqlDbType.Int;
            AL.Add(Param2);

            SqlParameter Param3 = new SqlParameter();
            Param3.ParameterName = "@Cantidad";
            Param3.Value = Objeto.Cantidad;
            Param3.SqlDbType = SqlDbType.Int;
            AL.Add(Param3);

            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }

        public BE_DetalleOrdenCompra ListarObjeto(BE_DetalleOrdenCompra Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE_DetalleOrdenCompra> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public DataTable ListarTodoTable()
        {
            throw new NotImplementedException();
        }
    }
}
