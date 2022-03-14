using CapaNegocio.ConexionBD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Pagos
{
    public class clsSolicitudes
    {
        private String cedulaCliente;
        private String nombreCliente;
        private String hospitalOrigen;
        private String hospitalDestino;
        private String placaAmbulancia;
        private String descripcionSolicitud;
        private float totalPagar;


        /// <summary>
        /// getter y setter de los atributos de la clase.
        /// </summary>
        public String CedulaCliente
        {
            get { return cedulaCliente; }
            set { cedulaCliente = value; }
        }
        public String NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        public String HospitalOrigen
        {
            get { return hospitalOrigen; }
            set { hospitalOrigen = value; }
        }
        public String HospitalDestino
        {
            get { return hospitalDestino; }
            set { hospitalDestino = value; }
        }
        public String PlacaAmbulancia
        {
            get { return placaAmbulancia; }
            set { placaAmbulancia = value; }
        }
        public String DescripcionSolicitud
        {
            get { return descripcionSolicitud; }
            set { descripcionSolicitud = value; }
        }
        public float TotalPagar
        {
            get { return totalPagar; }
            set { totalPagar = value; }
        }

        clsBaseDatos baseDatos = new clsBaseDatos();

        public Tuple<String, bool> registrarSolicitud()
        {
            String mensaje = "";
            bool ingreso = false;
            try
            {
                SqlConnection conexionAbierta = baseDatos.abrir_conexion();
                SqlCommand command = new SqlCommand();
                command.Connection = conexionAbierta;
                //CedulaCliente, NombreCliente, hospitalOrigen, hospitalDestino, placaAmbulancia, descripcionSolicitud, totalPagar
                command.CommandText = "SolicitudInsertCommand";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //valores para cada parámetro dado en el query
                command.Parameters.AddWithValue("@CedulaCliente", CedulaCliente);
                command.Parameters.AddWithValue("@NombreCliente", NombreCliente);
                command.Parameters.AddWithValue("@hospitalOrigen", HospitalOrigen);
                command.Parameters.AddWithValue("@hospitalDestino", HospitalDestino);
                command.Parameters.AddWithValue("@placaAmbulancia", PlacaAmbulancia);
                command.Parameters.AddWithValue("@descripcionSolicitud", DescripcionSolicitud);
                command.Parameters.AddWithValue("@totalPagar", TotalPagar);

                int t = Convert.ToInt32(command.ExecuteNonQuery());
                mensaje = "Pago registrado con éxito";
                ingreso = true;
                baseDatos.cerrar_conexion(conexionAbierta);
            }
            catch (SqlException ex)
            {
                mensaje = "Motivos de error:\n\n- No se puede acceder a la base de datos\n- Los datos ingresados ya existen";
                Console.WriteLine(ex.Message);
            }
            return Tuple.Create(mensaje, ingreso);
        }


        public List<Object> listarSolicitudes()
        {
            List<Object> lstSolicitudes = new List<Object>();

            SqlConnection conexion = baseDatos.abrir_conexion();

            SqlCommand comannd = new SqlCommand();

            comannd.Connection = conexion;
            comannd.CommandText = "SolicitudSelectCommand";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader registros = comannd.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.

            while (registros.Read())  // leo la informacion almacenada en registro
            {
                var tmp = new
                {
                    id_solicitud = registros["Id_Solicitud"].ToString(),
                    cedulaCliente = registros["CedulaCliente"].ToString(),
                    nombreCliente = registros["NombreCliente"].ToString(),  // para asignar valores de la base a la variable cedula
                    hospitalOrigen = registros["hospitalOrigen"].ToString(),
                    HospitalDestino = registros["hospitalDestino"].ToString(),
                    placaAmbulancia = registros["placaAmbulancia"].ToString(),
                    descripcionSolicitud = registros["descripcionSolicitud"].ToString(),
                    totalPagar = registros["totalPagar"].ToString(),
                };

                lstSolicitudes.Add(tmp);
            }
            baseDatos.cerrar_conexion(conexion);
            return lstSolicitudes;


        }
    }


}
