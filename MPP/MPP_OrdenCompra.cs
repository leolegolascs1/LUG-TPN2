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
    public class MPP_OrdenCompra : IGestor<BE_OrdenCompra>
    {
        ArrayList AL;
        Acceso oDatos;
   
        public bool Guardar(BE_OrdenCompra POrdenCompra)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Guardar_Orden_Compra";
            if (POrdenCompra.Codigo != 0) //Si teng codigo es un updata
            {
                SqlParameter Param6 = new SqlParameter();
                Param6.ParameterName = "@NroOrdenCompra";
                Param6.Value = POrdenCompra.Codigo;
                Param6.SqlDbType = SqlDbType.Int;
                AL.Add(Param6);
                Consulta_SQL = "s_Modificar_Orden_Compra";
            }

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Fecha";
            Param1.Value = POrdenCompra.Fecha;
            Param1.SqlDbType = SqlDbType.Date;
            AL.Add(Param1);

            SqlParameter Param2 = new SqlParameter();
            Param2.ParameterName = "@NroProveedor";
            Param2.Value = POrdenCompra.NroProveedor;
            Param2.SqlDbType = SqlDbType.Int;
            AL.Add(Param2);

            SqlParameter Param3 = new SqlParameter();
            Param3.ParameterName = "@NroPersonal";
            Param3.Value = POrdenCompra.NroPersonal;
            Param3.SqlDbType = SqlDbType.Int;
            AL.Add(Param3);

            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }

        public bool AgregarItemCompra(BE_OrdenCompra pOrden,BE_Materiales pMaterial, int pCantidad) 
        {
            string Consulta_SQL;
            Consulta_SQL = "Insert INTO TbDetalleCompra(NroOrden,NroItem,Descripcion,Cantidad) VALUES (" + pOrden.Codigo + ", " + pMaterial .Codigo + ",'" + pMaterial.Descripcion_material + "'," + pCantidad + ")";

            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }
        public DataTable ListarTodoTable()
        //Metodo hace consulta y devuelve un datatable con la informacion.
        {
            DataTable dt = new DataTable();
            string consulta = "Select * FROM TbOrdenCompra";

            oDatos = new Acceso();
            dt = oDatos.Leer(consulta);

            return dt;
        }
        public bool Baja(BE_OrdenCompra Objeto)
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Eliminar_OrdenCompra";

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@NroOrdenCompra";
            Param1.Value = Objeto.Codigo;
            Param1.SqlDbType = SqlDbType.Int;
            AL.Add(Param1);
            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }
        public bool BajaItemCompra(BE_OrdenCompra Objeto) 
        {
            AL = new ArrayList();
            string Consulta_SQL = "s_Eliminar_DetalleCompra";

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@NroOrdenCompra";
            Param1.Value = Objeto.Codigo;
            Param1.SqlDbType = SqlDbType.Int;
            AL.Add(Param1);
            oDatos = new Acceso();
            return oDatos.Escribir2(Consulta_SQL, AL);
        }
        public List<BE_OrdenCompra> ListarTodo()
        {
            List<BE_OrdenCompra> Lista = new List<BE_OrdenCompra>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds0;
            string Store = "s_Listar_Orden_Compra";
            oDatos = new Acceso();
            Ds0 = oDatos.Leer3(Store,null);
            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds0.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds0.Tables[0].Rows)
                {
                    BE_OrdenCompra oBEOrdenCompra;
                    oBEOrdenCompra = new BE_OrdenCompra(); //Creo el objeto orden de comprar

                    List<BE_Personal> _lst = new List<BE_Personal>(); //Creo lista de Personal

                    //Cargo los datos al objeto
                    oBEOrdenCompra.Codigo = int.Parse(fila["NroOrdenCompra"].ToString());
                    oBEOrdenCompra.Fecha = DateTime.Parse(fila["Fecha"].ToString());

                    oBEOrdenCompra.NroPersonal = int.Parse(fila["NroPersonal"].ToString());

                    BE_PersonalFabrica oPersonalF = new BE_PersonalFabrica(); //Creo objeto personal fabrica y cargo datos.
                    oPersonalF.Codigo = int.Parse(fila["NroPersonal"].ToString());
                    oPersonalF.Apellido = (fila["Apellido"].ToString());
                    oPersonalF.Nombre = (fila["Nombre"].ToString());
                    oPersonalF.Documento = int.Parse(fila["Documento"].ToString());

                    oBEOrdenCompra.Personal = oPersonalF;

                    oBEOrdenCompra.NroProveedor = int.Parse(fila["NroProveedor"].ToString());
                    BE_Proveedor oProveedor = new BE_Proveedor();
                    oProveedor.Codigo = int.Parse(fila["NroProveedor"].ToString());
                    oProveedor.RazonSocial = (fila["RazonSocial"].ToString());
                    oBEOrdenCompra.Proveedor = oProveedor; //Asigno proveedor.
                    Lista.Add(oBEOrdenCompra);


                    DataSet Ds3;
                    AL = new ArrayList();
                    //Creo parametro para enviar el nroorden
                    SqlParameter Param1 = new SqlParameter();
                    Param1.ParameterName = "@NroOrdenCompra";
                    Param1.Value = oBEOrdenCompra.Codigo;
                    Param1.SqlDbType = SqlDbType.Int;
                    AL.Add(Param1);
                                   
                    string Store2 = "s_Listar_Detalle_Compra";
                    oDatos = new Acceso();
                    Ds3 = oDatos.Leer3(Store2, AL);
                    List<BE_DetalleOrdenCompra> listaDetalle = new List<BE_DetalleOrdenCompra>(); //Creo Lista detalles
                    if (Ds3.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow item in Ds3.Tables[0].Rows) //Recorro
                        {
                            BE_DetalleOrdenCompra oBEDetalleOrden = new BE_DetalleOrdenCompra(); //Creo objeto y cargo datos.

                            oBEDetalleOrden.Codigo = int.Parse(item["IdDetalle"].ToString());

                            BE_Materiales oBEMaterial = new BE_Materiales();

                            oBEMaterial.Codigo = int.Parse(item["Codigo"].ToString());
                            oBEMaterial.Descripcion_material = (item["Descripcion_Articulo"].ToString());
                            oBEDetalleOrden.Item = oBEMaterial;
                     
                            oBEDetalleOrden.Cantidad = int.Parse(item["Cantidad"].ToString());

                            listaDetalle.Add(oBEDetalleOrden); //Agrego a la lista detalles
                        }
                        oBEOrdenCompra.LstItems = listaDetalle; //Asigno la lista a la orden de compra.
                    }
                }
            }
            else
            {
                Lista = null;
            }
            return Lista; //Retorno la lista con las ordenes de compras cargadas.
        }
        public BE_OrdenCompra ListarObjeto(BE_OrdenCompra Objeto)
        {
            throw new NotImplementedException();
        }
        public bool QuitarItemCompra(BE_OrdenCompra oBEOrdenCompra, BE_Materiales oBEMateriales)
        {
            string Consulta = " Delete from TbDetalleCompra where NroOrden = " + oBEOrdenCompra.Codigo + "  and NroItem =" + oBEMateriales.Codigo + "";
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta);
        }
 
    }
}
