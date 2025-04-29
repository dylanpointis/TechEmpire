using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLProducto
    {
        private DALProducto dalProd = new DALProducto();

        public List<BEProducto> TraerListaProducto()
        {
            List<BEProducto> lista = new List<BEProducto>();
            DataTable tabla = dalProd.TraerListaProducto();

            foreach (DataRow row in tabla.Rows)
            {
                BEProducto producto = new BEProducto(Convert.ToInt32(row[0]), row[1].ToString(), row[2].ToString(),
                    row[3].ToString(), row[4].ToString(),row[5].ToString(), Convert.ToDouble(row[6]), Convert.ToInt32(row[7]),
                    Convert.ToInt32(row[8]), Convert.ToInt32(row[9]), Convert.ToBoolean(row[10]));
                lista.Add(producto);
            }
            return lista;
        }

    }
}
