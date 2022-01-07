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
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.domicilio = domicilio;
            this.sexo = sexo;
            this.licencia = licencia;
        }


        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public Int16 Edad { get => edad; set => edad = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Licencia { get => licencia; set => licencia = value; }
    }
}
