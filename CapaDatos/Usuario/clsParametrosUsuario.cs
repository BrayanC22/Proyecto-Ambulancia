using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Usuario
{
    public class clsParametrosUsuario
    {
        private String nombre;
        private String apellido;
        private String cedula;
        private String usuario;
        private String password;
        private String rutaImagen;

        public clsParametrosUsuario() { }


        /* --------------- Getters y Setters ------------------------- */
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String RutaImagen
        {
            get { return rutaImagen; }
            set { rutaImagen = value; }
        }
    }
}
