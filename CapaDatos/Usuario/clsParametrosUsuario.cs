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
        private String correo;
        private String password;
        private String rutaImagen;


        /* Constructor parametrizado*/
        public clsParametrosUsuario(String nombre, String apellido, String cedula, String correo, String password, String rutaImagen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.correo = correo;
            this.password = password;
            this.rutaImagen = rutaImagen;
        }


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

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
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
