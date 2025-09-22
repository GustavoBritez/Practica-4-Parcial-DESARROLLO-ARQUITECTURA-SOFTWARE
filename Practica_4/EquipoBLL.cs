using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    public class EquipoBLL
    {
        EquipoDAL mapper = new();
        public DataTable Obtener_Equipos()
        {
            DataTable dt = mapper.Obtener_Equipos();
            dt.TableName = "EQUIPOS";
            return dt;
        }
        
        public void UPDATE( DataSet ds )
        {
            mapper.UPDATE( ds );
        }
    }
}
