using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALProducto
    {

        DALConexion dalCon = new DALConexion();

        public DataTable TraerListaProducto()
        {
            DataTable tabla = dalCon.TraerTabla("Productos");
            return tabla;
        }
    }
}
