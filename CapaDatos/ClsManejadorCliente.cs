using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
   public class ClsManejadorCliente
    {

        private ClsManejador ManejaCliente = new ClsManejador();

        //Cliente
        public void insertar_cliente(List<ClsParametrosCliente> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = ManejaCliente.abrir_conexion();
                   

                    SqlCommand comannd = new SqlCommand();

                    comannd.Connection = conexion;
                    comannd.CommandText = "CLIENTEInsertCommand";
                    comannd.CommandType = System.Data.CommandType.StoredProcedure;

                    comannd.Parameters.AddWithValue("@cedula", lst[0].Cedula); // a la variable de tip Mysql comand agregar un valor al parametro
                    comannd.Parameters.AddWithValue("@nombre", lst[0].Nombre); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
                    comannd.Parameters.AddWithValue("@apellido", lst[0].Apellido);
                    comannd.Parameters.AddWithValue("@edad", lst[0].Edad);
                    comannd.Parameters.AddWithValue("@domicilio", lst[0].Domicilio);
                    comannd.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                    comannd.Parameters.AddWithValue("@imagen", lst[0].Imagen);
                    comannd.Parameters.AddWithValue("@codigoCliente", lst[0].CodigoCliente);

                    int t = Convert.ToInt32(comannd.ExecuteScalar()); // con esa linea executa el insert a la bd
                    ManejaCliente.cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Object> listar_cliente()
        {
            List<Object> lstCliente = new List<Object>();

            SqlConnection conexion = ManejaCliente.abrir_conexion();

            SqlCommand comannd = new SqlCommand();

            comannd.Connection = conexion;
            comannd.CommandText = "CLIENTESelectCommand";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader registros = comannd.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.
            
            while (registros.Read())  // leo la informacion almacenada en registro
            {
                var tmp = new
                {
                    Id_Cliente = Int16.Parse(registros["Id_Cliente"].ToString()),
                    cedula = registros["Cedula"].ToString(),  // para asignar valores de la base a la variable cedula
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    imagen = registros["Imagen"].ToString(),
                    codigoCliente = registros["CodigoCliente"].ToString(),
                };

                lstCliente.Add(tmp);
            }
            ManejaCliente.cerrar_conexion(conexion);
            return lstCliente;
        }

        public List<Object> buscar_cliente(String cedula)
        {
            List<Object> lstCliente = new List<Object>();

            SqlConnection conexion = ManejaCliente.abrir_conexion();

            SqlCommand comannd = new SqlCommand();

            comannd.Connection = conexion;
            comannd.CommandText = "CLIENTESelectindividualCommand";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;
            comannd.Parameters.AddWithValue("@cedula", cedula);

            SqlDataReader registros = comannd.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    Id_Cliente = Int16.Parse(registros["Id_Cliente"].ToString()),
                    cedula = registros["Cedula"].ToString(),
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    imagen = registros["Imagen"].ToString(),
                    codigoCliente = registros["CodigoCliente"].ToString(),
                };
                lstCliente.Add(tmp);
            }

            ManejaCliente.cerrar_conexion(conexion);
            return lstCliente;
        }

        public int eliminar_cliente(String cedula)
        {
            SqlConnection conexion = ManejaCliente.abrir_conexion();

            SqlCommand comannd = new SqlCommand();

            comannd.Connection = conexion;
            comannd.CommandText = "CLIENTEDeleteCommand";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;

            comannd.Parameters.AddWithValue("@Original_Cedula", cedula);
            int resultado = Convert.ToInt32(comannd.ExecuteScalar());

            MessageBox.Show("Se a eliminado con exito");
            ManejaCliente.cerrar_conexion(conexion);
            return resultado;
        }

        public int actualizar_cliente_individual(String param_cedula, String param_nombre, String param_apellido, String param_edad, String param_domicilio, String param_sexo, String param_imagen,String param_codigoCliente)
        {

            SqlConnection conexion = ManejaCliente.abrir_conexion();
            SqlCommand comannd = new SqlCommand();

            comannd.Connection = conexion;
            comannd.CommandText = "CLIENTEUpdateCommand";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;

            comannd.Parameters.AddWithValue("@Cedula", param_cedula);
            comannd.Parameters.AddWithValue("@Nombre", param_nombre); 
            comannd.Parameters.AddWithValue("@Apellido", param_apellido);
            comannd.Parameters.AddWithValue("@Edad", param_edad);
            comannd.Parameters.AddWithValue("@Domicilio", param_domicilio);
            comannd.Parameters.AddWithValue("@Sexo", param_sexo);
            comannd.Parameters.AddWithValue("@Imagen", param_imagen);
            comannd.Parameters.AddWithValue("@CodigoCliente", param_codigoCliente);     

            int resultado_operacion = Convert.ToInt32(comannd.ExecuteScalar());
            ManejaCliente.cerrar_conexion(conexion);

            return resultado_operacion;
        }

    }
}
