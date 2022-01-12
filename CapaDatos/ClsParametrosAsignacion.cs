using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsParametrosAsignacion
    {

        private Int16 Id_AmbulanciaAsignacion;
        private Int16 Id_ConductorAsignacion;


        private List<Object> lst_obj;

        public ClsParametrosAsignacion() { }
        public ClsParametrosAsignacion(Int16 Id_AmbulanciaAsignacion, Int16 Id_ConductorAsignacion)
        {
            this.Id_AmbulanciaAsignacion = Id_AmbulanciaAsignacion;
            this.Id_ConductorAsignacion = Id_ConductorAsignacion;

        }

        //Getter and Setter fields
        public Int16 ID_AmbulanciaAsignacion
        {
            get { return Id_AmbulanciaAsignacion; }
            set { Id_AmbulanciaAsignacion = value; }
        }

        public Int16 ID_ConductorAsignacion
        {
            get { return Id_ConductorAsignacion; }
            set { Id_ConductorAsignacion = value; }
        }


    }
}
