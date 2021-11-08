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
    public class MPP_Personal : IGestor<BE_Personal>
    {
        ArrayList AL;
        Acceso oDatos;

        public bool Guardar(BE_Personal pOPersonal)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Guardar_Personal";
            if (pOPersonal.Codigo != 0) //Si teng codigo es un updata
            {
                SqlParameter Param6 = new SqlParameter();
                Param6.ParameterName = "@NroPersonal";
                Param6.Value = pOPersonal.Codigo;
                Param6.SqlDbType = SqlDbType.Int;
                AL.Add(Param6);
                Consulta_SQL = "s_Modificar_Personal";
            }
        
                SqlParameter Param1 = new SqlParameter();
                Param1.ParameterName = "@Nombre";
                Param1.Value = pOPersonal.Nombre;
                Param1.SqlDbType = SqlDbType.VarChar;
                AL.Add(Param1);
       
                SqlParameter Param2 = new SqlParameter();
                Param2.ParameterName = "@Apellido";
                Param2.Value = pOPersonal.Apellido ;
                Param2.SqlDbType = SqlDbType.VarChar;
                AL.Add(Param2);
   
                SqlParameter Param3 = new SqlParameter();
                Param3.ParameterName = "@Documento";
                Param3.Value = pOPersonal.Documento;
                Param3.SqlDbType = SqlDbType.Int;
                AL.Add(Param3);

                SqlParameter Param4 = new SqlParameter();
                Param4.ParameterName = "@Salario";
                Param4.Value = pOPersonal.Salario;
                Param4.SqlDbType = SqlDbType.Int;
                AL.Add(Param4);

                SqlParameter Param5 = new SqlParameter();
                Param5.ParameterName = "@Rol";
                Param5.Value = pOPersonal.Tipo_Personal;
                Param5.SqlDbType = SqlDbType.Text;
                AL.Add(Param5);

            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }
        public bool Baja(BE_Personal pOPersonal)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Eliminar_Personal";

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@NroPersonal";
            Param1.Value = pOPersonal.Codigo;
            Param1.SqlDbType = SqlDbType.Int;
            AL.Add(Param1);
            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }
        public List<BE_Personal> ListarTodo()
        {
            List<BE_Personal> ListaPersonal = new List<BE_Personal>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds;
            string Store = "s_Listar_Personal";
            oDatos = new Acceso();
            Ds = oDatos.Leer3(Store, null); //paso nulo porque es solo consulta.

            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    string Rol = fila["Rol"].ToString();
                    BE_Personal oPersonal;
                    if (Rol == "Mostrador")
                    {
                        oPersonal = new BE_PersonalMostrador();
                        ListaPersonal.Add(CargarDatos(oPersonal, fila));
                    }
                    else if (Rol == "Fabrica")
                    {
                        oPersonal = new BE_PersonalFabrica();
                        ListaPersonal.Add(CargarDatos(oPersonal, fila));

                    }
                    else if (Rol == "Administrador")
                    {
                        oPersonal = new BE_PersonalAdministrador();
                        ListaPersonal.Add(CargarDatos(oPersonal, fila));
                    }
                    else
                    {
                        oPersonal = null;
                    }
                }
            }
            else
            {
                ListaPersonal = null;
            }
            return ListaPersonal;
        }
        private BE_Personal CargarDatos(BE_Personal oBEPersonal, DataRow fila)
        {
            oBEPersonal.Codigo = int.Parse(fila["NroPersonal"].ToString());
            oBEPersonal.Nombre = fila["Nombre"].ToString();
            oBEPersonal.Apellido = fila["Apellido"].ToString();
            oBEPersonal.Documento = Convert.ToInt32(fila["Documento"]);
            oBEPersonal.Password = fila["Password"].ToString();

            return oBEPersonal;
        }
        public bool GuardarPassword(BE_Personal oBEPersonal)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Guardar_Password";

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@NroCliente";
            Param1.Value = oBEPersonal.Codigo;
            Param1.SqlDbType = SqlDbType.Int;
            AL.Add(Param1);

            SqlParameter Param2 = new SqlParameter();
            Param2.ParameterName = "@Password";
            Param2.Value = oBEPersonal.Password;
            Param2.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param2);

            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }
 


        public DataTable ListarTodoTable()
        {
            throw new NotImplementedException();
        }
        public BE_Personal ListarObjeto(BE_Personal Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
