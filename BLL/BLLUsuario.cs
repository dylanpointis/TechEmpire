using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Runtime.InteropServices;
using Services;

namespace BLL
{
    public class BLLUsuario
    {
        private DALUsuario dalUsuario = new DALUsuario();

        public BEUsuario Login(string username, string clave)
        {

            BEUsuario user = ValidarUsuario(username, 0, ""); //verifica si existe el usuario por el username
            if (user == null)
                throw new Exception("El usuario ingresado no existe");
            
            if(Encriptacion.EncriptarSHA256(clave) != user.Clave)
            {
                throw new Exception("Las credenciales no coinciden");
            }
            return user;
        }

        public BEUsuario ValidarUsuario(string nombreusuario, int dni, string email)
        {
            BEUsuario user = dalUsuario.ValidarUsuario(nombreusuario, dni, email);
            return user;
        }
    }
}
