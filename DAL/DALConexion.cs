using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexion
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=TechEmpire;Integrated Security=True");

        private void Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        SqlTransaction tran;

        #region MODO CONECTADO

        public DataTable ConsultaProcAlmacenado(string nombreProc, SqlParameter[] parametros)
        {
            DataTable tabla = new DataTable();

            using (SqlCommand command = new SqlCommand(nombreProc, con))
            {
                command.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter parametro in parametros)
                {
                    if (parametro.Value == null)
                    {
                        parametro.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parametro);
                }

                Conectar();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
                con.Close();
            }

            return tabla;
        }



        public void EjecutarProcAlmacenado(string nombreProc, SqlParameter[] parametros)
        {
            try
            {
                Conectar();
                tran = con.BeginTransaction();
                using (SqlCommand command = new SqlCommand(nombreProc, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Transaction = tran;
                    foreach (SqlParameter parametro in parametros)
                    {
                        if (parametro.Value == null)
                        {
                            parametro.Value = DBNull.Value;
                        }
                        command.Parameters.Add(parametro);
                    }
                    command.ExecuteNonQuery();
                    tran.Commit();
                    con.Close();
                }
            }
            catch (Exception ex) { tran.Rollback(); throw ex; }
        }

        public int EjecutarYTraerId(string nombreProc, SqlParameter[] parametros)
        {
            int idGenerado = 0;
            try
            {
                Conectar();
                tran = con.BeginTransaction();
                using (SqlCommand command = new SqlCommand(nombreProc, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Transaction = tran;
                    foreach (SqlParameter parametro in parametros)
                    {
                        if (parametro.Value == null)
                        {
                            parametro.Value = DBNull.Value;
                        }
                        command.Parameters.Add(parametro);
                    }
                    idGenerado = Convert.ToInt32(command.ExecuteScalar());
                    tran.Commit();
                    con.Close();
                    return idGenerado;
                }
            }
            catch (Exception ex) { tran.Rollback(); return idGenerado; throw ex; }

        }


        //Metodo para ejecutar comandos pasandole directamente la query
        public void EjecutarComando(string comando)
        {
            try
            {
                Conectar();
                using (SqlCommand command = new SqlCommand(comando, con))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        public void EstablecerConexionConMaster()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.ConnectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            Conectar();
        }


        #endregion




        #region MODO DESCONECTADO
        DataSet dataSet;
        SqlDataAdapter adapter;


        public void CargarDataSet(string nombreTabla)
        {
            try
            {
                Conectar();
                dataSet = new DataSet();

                tran = con.BeginTransaction();

                SqlCommand command = new SqlCommand($"SELECT * FROM {nombreTabla}", con);
                command.Transaction = tran;

                adapter = new SqlDataAdapter(command);
                adapter.FillSchema(dataSet, SchemaType.Source, nombreTabla);
                adapter.Fill(dataSet, nombreTabla);

                tran.Commit();
                con.Close();
            }
            catch (Exception ex) { tran.Rollback(); throw ex; }
        }

        public DataTable TraerTabla(string tabla)
        {

            CargarDataSet(tabla);

            DataTable Tabla = dataSet.Tables[tabla];
            return Tabla;
        }
        #endregion



    }
}
