using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Usuario;

namespace CapaNegocio.Usuario
{
    public class clsUsuario
    {
        String nombre;
        String apellido;
        String cedula;
        String usuario;
        String password;
        Byte[] rutaImagen;


        /* Constructor*/
        public clsUsuario()
        {

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
        public Byte[] RutaImagen
        {
            get { return rutaImagen; }
            set { rutaImagen = value; }
        }

        
        ClsManejador manejadorUsuario = new ClsManejador();
        List<clsParametrosUsuario> lstUsuarios = new List<clsParametrosUsuario>();
        clsParametrosUsuario parametrosUsuario = new clsParametrosUsuario();

        public Tuple<String, bool> registrarUsuario()
        {
            
            /* parametrosUsuario es el objeto intermediario entre los datos ingresados desde la capa vista a la base de datos*/
            parametrosUsuario.Nombre = this.Nombre;
            parametrosUsuario.Apellido = this.Apellido;
            parametrosUsuario.Cedula = this.Cedula;
            parametrosUsuario.Usuario = this.Usuario;
            parametrosUsuario.Password = this.Password;
            parametrosUsuario.RutaImagen = this.RutaImagen;

            lstUsuarios.Add(parametrosUsuario);
            
            return manejadorUsuario.RegistrarUsuario(lstUsuarios); 
        }

    }




}
