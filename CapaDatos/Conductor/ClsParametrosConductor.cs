using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Conductor
{
    public class ClsParametrosConductor
    {
        //atributosPersona
        private String cedula;
        private String nombre;
        private String apellido;
        private Int16 edad;
        private String domicilio;
        private String sexo;

        //atributoConductor
        private String licencia;

        public ClsParametrosConductor(String cedula, String nombre, String apellido, Int16 edad, String domicilio, String sexo, String licencia)
        {


            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Domicilio = domicilio;
            this.Sexo = sexo;
            this.licencia = licencia;


        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public short Edad { get => edad; set => edad = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}
