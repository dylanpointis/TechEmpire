using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUsuario
    {
        DALConexion dalCon = new DALConexion();


        public BEUsuario ValidarUsuario(string nombreusuario, int DNI, string Email)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                 new SqlParameter("@NombreUsuario", nombreusuario),
                 new SqlParameter("@DNI", DNI),
                 new SqlParameter("@Email", Email)
            };


            DataTable tabla = dalCon.ConsultaProcAlmacenado("ValidarUsuario", parametros);

            BEUsuario user = null;
            foreach (DataRow dr in tabla.Rows)
            {
                user = new BEUsuario(Convert.ToString(dr[0]), Convert.ToInt32(dr[1]), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), Convert.ToInt32(dr[6]), Convert.ToBoolean(dr[7]), Convert.ToBoolean(dr[8]));
                user.ContFallidos = Convert.ToInt16(dr[9]);

                break;
                //Solo agarra el primer registro que coincida nombreusuario
            }
            return user;
        }
    }
}
