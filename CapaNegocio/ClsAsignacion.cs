using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClsAsignacion
    {
        protected Int16 Id_AmbulanciaAsignacion;
        protected Int16 Id_ConductorAsignacion;


        private List<Object> lst_obj;
        ClsManejadorAmbulancia M = new ClsManejadorAmbulancia();

        public ClsAsignacion() { }
        public ClsAsignacion(Int16 Id_AmbulanciaAsignacion, Int16 Id_ConductorAsignacion)
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

        public String registrar()
        {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametrosAsignacion> lst = new List<ClsParametrosAsignacion>();

            try
            {
                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(new ClsParametrosAsignacion(ID_AmbulanciaAsignacion, ID_ConductorAsignacion));
                M.insertar_asignacion(lst);

                msj = "Insertado correctamente";
            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }


    }
}
