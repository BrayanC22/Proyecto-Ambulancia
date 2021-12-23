using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Conductor
{
    public class ClsConductores : ClsPersona
    {

        protected String licencia;

        public ClsConductores()
        {

        }

        public ClsConductores(String cedula, String nombre, String apellido, Int16 edad, String domicilio, String sexo, String licencia) : base(cedula, nombre, apellido, edad, domicilio, sexo)
        {
            this.licencia = licencia;
        }
        public string Licencia { get => licencia; set => licencia = value; }
    }
}
