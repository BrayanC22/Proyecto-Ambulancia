using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
     public class ClsParametrosCliente
    {

        private String cedula;
        private String nombre;
        private String apellido;
        private Int16 edad;
        private String domicilio;
        private String sexo;

        //Atri-hija
        private string imagen;
        private string codigoCliente;
        public ClsParametrosCliente() { }
       
        //metodos get /set
        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

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
        public Int16 Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public String Sexo
        {

            get { return sexo; }
            set { sexo = value; }
        }

        public String Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public String CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }
    }
}
