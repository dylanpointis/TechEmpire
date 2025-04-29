using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public class BEUsuario
    {
        public string NombreUsuario { get; set; }
        public int DNI { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

        public int codRol { get; set; }

        public bool Bloqueado { get; set; }
        public bool Activo { get; set; }
        public int ContFallidos { get; set; }




        public BEUsuario(string nombreusuario, int dni, string nombre, string apellido, string email, string clave, int rol, bool bloqueado, bool activo)
        {
            this.NombreUsuario = nombreusuario;
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Clave = clave;
            this.codRol = rol;
            this.Bloqueado = bloqueado;
            this.Activo = activo;
        }
    }
}
