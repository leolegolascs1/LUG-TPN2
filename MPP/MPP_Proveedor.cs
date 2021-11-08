using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using DAL;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
namespace MPP
{
    public class MPP_Proveedor : IGestor<BE_Proveedor>
    {
        Acceso oDatos;
        ArrayList AL;
        public bool Baja(BE_Proveedor Objeto)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Eliminar_Proveedor";

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@NroProveedor";
            Param1.Value = Objeto.Codigo;
            Param1.SqlDbType = SqlDbType.Int;
            AL.Add(Param1);
            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }
        public bool Guardar(BE_Proveedor pOproveedor)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Guardar_Proveedores";
            if (pOproveedor.Codigo != 0) //Si teng codigo es un updata
            {
                SqlParameter Param0 = new SqlParameter();
                Param0.ParameterName = "@NroProveedor";
                Param0.Value = pOproveedor.Codigo;
                Param0.SqlDbType = SqlDbType.Int;
                AL.Add(Param0);
                Consulta_SQL = "s_Modificar_Proveedores";
            }

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Nombre";
            Param1.Value = pOproveedor.Nombre;
            Param1.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param1);

            SqlParameter Param2 = new SqlParameter();
            Param2.ParameterName = "@Apellido";
            Param2.Value = pOproveedor.Apellido;
            Param2.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param2);

            SqlParameter Param3 = new SqlParameter();
            Param3.ParameterName = "@RazonSocial";
            Param3.Value = pOproveedor.RazonSocial;
            Param3.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param3);

            SqlParameter Param4 = new SqlParameter();
            Param4.ParameterName = "@CUIT";
            Param4.Value = pOproveedor.CUIT;
            Param4.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param4);

            SqlParameter Param5 = new SqlParameter();
            Param5.ParameterName = "@EMail";
            Param5.Value = pOproveedor.EMail;
            Param5.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param5);

            SqlParameter Param6 = new SqlParameter();
            Param6.ParameterName = "@Telefono";
            Param6.Value = pOproveedor.EMail;
            Param6.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param6);

            SqlParameter Params7 = new SqlParameter();
            Params7.ParameterName = "@Localidad";
            Params7.Value = pOproveedor.Localidad;
            Params7.SqlDbType = SqlDbType.VarChar;
            AL.Add(Params7);

            SqlParameter Param8 = new SqlParameter();
            Param8.ParameterName = "@Direccion";
            Param8.Value = pOproveedor.Direccion;
            Param8.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param8);
            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }
        public List<BE_Proveedor> ListarTodo()
        {
            List<BE_Proveedor> Lista = new List<BE_Proveedor>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds;
            string Store = "s_Listar_Proveedor";
            oDatos = new Acceso();
            Ds = oDatos.Leer3(Store, null); //paso nulo porque es solo consulta.

            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    BE_Proveedor oBEProveedor;
                    oBEProveedor = new BE_Proveedor();

                    oBEProveedor.Codigo = int.Parse(fila["NroProveedor"].ToString());
                    oBEProveedor.Nombre = (fila["Nombre"].ToString());
                    oBEProveedor.Apellido = (fila["Apellido"].ToString());
                    oBEProveedor.RazonSocial = (fila["RazonSocial"].ToString());
                    oBEProveedor.CUIT = (fila["CUIT"].ToString());
                    oBEProveedor.Localidad = (fila["Localidad"].ToString());
                    oBEProveedor.Direccion = (fila["Direccion"].ToString());
                    oBEProveedor.EMail = (fila["EMail"].ToString());
                    oBEProveedor.Telefono = (fila["Telefono"].ToString());

                    Lista.Add(oBEProveedor);
                }
            }
            else
            {
                Lista = null;
            }
            return Lista;
            //List<BE_Proveedor> Lista = new List<BE_Proveedor>();
            ////Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            //DataSet Ds;
            //string Consulta = "Select * from TbProveedores";
            //oDatos = new Acceso();
            //Ds = oDatos.Leer2(Consulta);
            ////rcorro la tabla dentro del Dataset y la paso a lista
            //if (Ds.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataRow fila in Ds.Tables[0].Rows)
            //    {
            //        BE_Proveedor oBEProveedor;
            //        oBEProveedor = new BE_Proveedor();

            //        oBEProveedor.Codigo = int.Parse(fila["NroProveedor"].ToString());
            //        oBEProveedor.Nombre = (fila["Nombre"].ToString());
            //        oBEProveedor.Apellido = (fila["Apellido"].ToString());
            //        oBEProveedor.RazonSocial = (fila["RazonSocial"].ToString());
            //        oBEProveedor.CUIT = (fila["CUIT"].ToString());
            //        oBEProveedor.Localidad = (fila["Localidad"].ToString());
            //        oBEProveedor.Direccion = (fila["Direccion"].ToString());
            //        oBEProveedor.EMail = (fila["EMail"].ToString());
            //        oBEProveedor.Telefono = (fila["Telefono"].ToString());

            //        Lista.Add(oBEProveedor);
            //    }
            //}
            //else
            //{
            //    Lista = null;
            //}
            //return Lista;
        }
        public DataTable ListarTodoTable()
        //Metodo hace consulta y devuelve un datatable con la informacion.
        {
            DataTable dt = new DataTable();
            string consulta = "Select TbProveedores.NroProveedor as Codigo, TbProveedores.Nombre, TbProveedores.Apellido, TbProveedores.RazonSocial,TbProveedores.CUIT,TbProveedores.CUIL,TbProveedores.Email,TbProveedores.Telefono,TbProveedores.Localidad,TbProveedores.Direccion FROM TbProveedores";
            oDatos = new Acceso();
            dt = oDatos.Leer(consulta);

            return dt;
        }
        public BE_Proveedor ListarObjeto(BE_Proveedor Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
