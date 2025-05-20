using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Services;

namespace BLL
{
    public class BLLEvento
    {
        private DALEvento dalEvento = new DALEvento();

        public void RegistrarEvento(Evento evento)
        {
            evento.Fecha = DateTime.Today.ToString("yyyy-MM-dd");
            evento.Hora = DateTime.Now.ToString("HH:mm");
            dalEvento.RegistrarEvento(evento);
        }

        public List<Evento> TraerListaEventos()
        {
            List<Evento> lista = new List<Evento>();
            DataTable tabla = dalEvento.TraerListaEventos();

            foreach (DataRow row in tabla.Rows)
            {
                Evento evento = new Evento(row[1].ToString(), row[2].ToString(), row[3].ToString(), Convert.ToInt32(row[4]));

                evento.Fecha = row[5].ToString();
                evento.Hora = row[6].ToString();

                evento.CodEvento = Convert.ToInt64(row[0]);
                lista.Add(evento);
            }
            return lista;
        }

    }
}
