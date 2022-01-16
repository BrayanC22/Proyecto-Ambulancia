using System;
using CapaDatos;
using CapaDatos.Conductor;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Conductor
{
    public class ClsConductores : ClsPersona
    {

        protected String licencia;

        public ClsConductores(){}

        public ClsConductores(String cedula, String nombre, String apellido, Int16 edad, String domicilio, String sexo, String licencia) : base(cedula, nombre, apellido, edad, domicilio, sexo)
        {
            this.licencia = licencia;
        }
        public string Licencia { get => licencia; set => licencia = value; }

        ClsManejadorConductor manejadorConductor = new ClsManejadorConductor();

        public override String registrar()
        {
            string msj = "";


            //Lista genérica de parámetros
            List<ClsParametrosConductor> lst = new List<ClsParametrosConductor>();

            try
            {
                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(new ClsParametrosConductor(Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Licencia));
                manejadorConductor.insertar_conductor(lst);

                msj = "Insertado correctamente";

            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos, motivo: " +ex;
                return msj;
                throw ex;
            }

            return msj;
        }

        public override List<Object> buscar(String cedula)
        {
            List<Object> lst;
            lst= manejadorConductor.buscar_conductor(cedula);
            return lst;
        }

        public override void eliminar(String cedula)
        {
            if (buscar(cedula).Count != 0)
            {
                manejadorConductor.eliminar_conductor(cedula);
            }
        }

        public override List<Object> listar()
        {
            return manejadorConductor.listar_conductor();
        }

        public String actualizar_x_cedula()
        {
            string msj = "";


            //Lista genérica de parámetros
            List<ClsParametrosConductor> lst = new List<ClsParametrosConductor>();

            try
            {
                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(new ClsParametrosConductor(Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Licencia));
                manejadorConductor.modificar_conductor(lst);
                msj = "Modificado correctamente";

            }
            catch (Exception ex)
            {
                msj = "Error al modificar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
    }
}
