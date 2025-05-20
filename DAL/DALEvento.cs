using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace DAL
{
    public class DALEvento
    {
        DALConexion dalCon = new DALConexion();

        public void RegistrarEvento(Evento evento)
        {
            SqlParameter[] parametros = new SqlParameter[]
             {
                new SqlParameter("@NombreUsuario", evento.NombreUsuario),
                new SqlParameter("@Modulo", evento.Modulo),
                new SqlParameter("@Evento", evento.evento),
                new SqlParameter("@Criticidad", evento.Criticidad),
                new SqlParameter("@Fecha", evento.Fecha),
                new SqlParameter("@Hora", evento.Hora)
             };
            dalCon.EjecutarProcAlmacenado("RegistrarEvento", parametros);
        }
    }
}
