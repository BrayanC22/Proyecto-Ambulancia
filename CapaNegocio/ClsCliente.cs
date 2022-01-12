using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClsCliente : ClsPersona
    {
        private String imagen;
        private String codigoCliente;

        public ClsCliente() { }
        
        //metodos get /set
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

        //Referencia al Manejador de la capa de acceso a datos

        ClsManejadorCliente M = new ClsManejadorCliente();

        public override String registrar()
        {
            string msj = "";
            //Lista genérica de parámetros
            ClsParametrosCliente clienteP = new ClsParametrosCliente();
            List<ClsParametrosCliente> lst = new List<ClsParametrosCliente>();

            try
            {

                clienteP.Nombre = this.Nombre;
                clienteP.Cedula = this.Cedula;
                clienteP.Apellido = this.Apellido;
                clienteP.Edad = this.Edad;
                clienteP.Domicilio = this.Domicilio;
                clienteP.Sexo = this.Sexo;
                clienteP.Imagen = this.Imagen;
                clienteP.CodigoCliente = this.CodigoCliente;

                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(clienteP);
                M.insertar_cliente(lst);


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

        //Lista Cliente
        public override List<Object> listar()
        {
            return M.listar_cliente();
        }
        public override List<Object> buscar(String cedula)
        {
            return M.buscar_cliente(cedula);

        }
        public override void eliminar(String cedula)
        {
            if (buscar(cedula) != null)
                M.eliminar_cliente(cedula);
        }


       /* public override int actualizar_x_cedula(string cedula, string nombre, string apellido, string edad, string domicilio,
         string sexo, string imagen, string codigoCliente)
        {
        return M.actualizar_cliente_individual(cedula, nombre, apellido, edad, domicilio, sexo, imagen, codigoCliente);
        }
       */


    }
}
