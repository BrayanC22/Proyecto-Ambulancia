using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsParametrosAmbulancia
    {
        private String modelo;
        private String tipoAmbulancia;  //Asistenciales, no asistenciales.
        private String placa;
        private String matricula;

        private List<Object> lst_obj;

        public ClsParametrosAmbulancia() { }
        public ClsParametrosAmbulancia(String modelo, String tipoAmbulancia, String placa, String matricula)
        {
            this.modelo = modelo;
            this.tipoAmbulancia = tipoAmbulancia;
            this.placa = placa;
            this.matricula = matricula;

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
        
    }
}
