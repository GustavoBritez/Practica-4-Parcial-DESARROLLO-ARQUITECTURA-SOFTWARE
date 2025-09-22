using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    public class EquipoDAL
    {
        Access acceso = new();
        public DataTable Obtener_Equipos()
        {

            try
            {
                return acceso.Leer("OBTENER_INVENTARIO",null);
            }
            catch
            {
                throw new ArgumentException();
            }
        }

        public void UPDATE( DataSet ds )
        {
            try
            {
                
                foreach( DataRow fila in ds.Tables["EQUIPOS"].Rows)
                {
                    if ( fila.RowState == DataRowState.Added)
                    {
                        SqlParameter[] sp = new SqlParameter[]
                        {
                            new SqlParameter("@CODIGO",fila["CODIGO"]),
                            new SqlParameter("@FECHA_ALTA",fila["FECHA_ALTA"]),
                            new SqlParameter("@FECHA_BAJA",fila["FECHA_BAJA"]),
                            new SqlParameter("@USO", fila["USO"] ),
                            new SqlParameter("@PRECIO", fila["PRECIO"]),
                            new SqlParameter("@NRO_COMPRA", fila["NRO_COMPRA"])
                        };

                        acceso.Escribir("SP_INSERT_EQUIPOS",sp);
                    }
                    if (fila.RowState == DataRowState.Modified)
                    {
                        SqlParameter[] sp = new SqlParameter[]
                        {
                            new SqlParameter("@CODIGO",fila["CODIGO"]),
                            new SqlParameter("@FECHA_ALTA",fila["FECHA_ALTA"]),
                            new SqlParameter("@FECHA_BAJA",fila["FECHA_BAJA"]),
                            new SqlParameter("@USO", fila["USO"] ),
                            new SqlParameter("@PRECIO", fila["PRECIO"]),
                            new SqlParameter("@NRO_COMPRA", fila["NRO_COMPRA"])
                        };

                        acceso.Escribir("SP_INSERT_EQUIPOS",sp);
                    }
                    if (fila.RowState == DataRowState.Deleted)
                    {
                        SqlParameter[] sp = new SqlParameter[]
                        {
                            new SqlParameter("@CODIGO",fila["CODIGO",DataRowVersion.Original]),
                        };
                        acceso.Escribir("SP_ELIMINAR",sp);
                    }
                }
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}
