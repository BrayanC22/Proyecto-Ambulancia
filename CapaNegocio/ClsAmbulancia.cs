using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class ClsAmbulancia
    {
        protected String modelo;
        protected String tipoAmbulancia;  //Asistenciales, no asistenciales.
        protected String placa;
        protected String matricula;
    

        private List<Object> lst_obj;
        ClsManejador M = new ClsManejador();

        public ClsAmbulancia() { }
        public ClsAmbulancia(String modelo, String tipoAmbulancia,String placa, String matricula)
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

        

        public String registrar()
        {
            string msj = "";


            //Lista genérica de parámetros
            List<ClsParametrosAmbulancia> lst = new List<ClsParametrosAmbulancia>();

            try
            {
                
                    //Pasar los parámetros hacia la capa de acceso a datos
                    lst.Add(new ClsParametrosAmbulancia(Modelo, TipoAmbulancia, Placa, Matricula));
                    M.insertar_ambulancia(lst);


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

        public  List<Object> listar()
        {
            return M.listar_ambulancia();
        }
        public  List<Object> buscar(String placa)
        {
            return M.buscar_ambulancia(placa);

        }
        public  void eliminar(String placa)
        {
            if (buscar(placa) != null)
                M.eliminar_ambulancia(placa);
        }
        /*
        public int actualizar_x_placa(string cedula, string nombre, string apellido, string edad, string direccion, string sexo, string nacionalidad, string provincias, string cantones, string imagen, string semestre)
        {
           return M.actualizar_alumno_individual(cedula, nombre, apellido, edad, direccion, sexo, nacionalidad, provincias, cantones, imagen, semestre);
        }
    */}

}

