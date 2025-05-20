using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Evento
    {
        public string NombreUsuario { get; set; }
        public string Modulo { get; set; }
        public string evento { get; set; }
        public int Criticidad { get; set; }
        public string Fecha {  get; set; }
        public string Hora { get; set; }

        public Evento(string nombreUsuario, string modulo, string evento, int criticidad)
        {
            this.NombreUsuario = nombreUsuario;
            this.Modulo = modulo;
            this.evento = evento;
            this.Criticidad = criticidad;
        }
    }
}
