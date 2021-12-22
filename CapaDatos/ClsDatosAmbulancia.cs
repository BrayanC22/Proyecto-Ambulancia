using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class ClsDatosAmbulancia
    {
        private String modelo;
        private String tipoAmbulancia;  //Asistenciales, no asistenciales.
        private String placa;
        private String matricula;
        private String fechaActivacion;
        private String estado;
        private String observacion;

        private List<Object> lst_obj;

        public ClsDatosAmbulancia() { }
        public ClsDatosAmbulancia(String modelo, String tipoAmbulancia, String placa, String matricula, String fechaActivacion, String estado, String observacion)
        {
            this.modelo = modelo;
            this.tipoAmbulancia = tipoAmbulancia;
            this.placa = placa;
            this.matricula = matricula;
            this.fechaActivacion = fechaActivacion;
            this.estado = estado;
            this.observacion = observacion;

        }

        //Getter and Setter fields
        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public String TipoAmbulancia
        {
            get { return tipoAmbulancia; }
            set { tipoAmbulancia = value; }
        }

        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public String FechaActivacion
        {
            get { return fechaActivacion; }
            set { fechaActivacion = value; }
        }

        public String Estado
        {

            get { return estado; }
            set { estado = value; }
        }

        public String Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }


    }
}
