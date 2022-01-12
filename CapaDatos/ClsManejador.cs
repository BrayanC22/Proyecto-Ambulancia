using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Usuario;
using CapaDatos.Conductor;

namespace CapaDatos
{
    public class ClsManejador
    {

        private SqlConnection conexion;

        public SqlConnection abrir_conexion()
        {
            try
            {
                string ConnectionString = "server = localhost; database = LosRapidosSAbd; integrated security = true  ";

                conexion = new SqlConnection(ConnectionString);
                conexion.Open();

                Console.WriteLine("Se abrio la conexion desde la capa de acceso a datos");

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return conexion;
        }

        public void cerrar_conexion(SqlConnection conexion)
        {
            conexion.Close();
            Console.WriteLine("Se cerro la conexion desde la capa de acceso a datos");
        }

      
      

        /* ----------------------- Registro de usuario ------------------------- */

        public Tuple<String, bool> RegistrarUsuario(List<clsParametrosUsuario> lst)
        {
            String mensaje = "";
            bool ingreso = false;
            try
            {
                SqlConnection conexionAbierta = abrir_conexion();

                SqlCommand command = new SqlCommand();
                
                command.Connection = conexionAbierta;

                command.CommandText = "UsuarioInsertCommand";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //valores para cada parámetro dado en el query
                command.Parameters.AddWithValue("@Nombre", lst[0].Nombre);
                command.Parameters.AddWithValue("@Apellido", lst[0].Apellido);
                command.Parameters.AddWithValue("@Cedula", lst[0].Cedula);
                command.Parameters.AddWithValue("@NombreUsuario", lst[0].Usuario);
                command.Parameters.AddWithValue("@Password", lst[0].Password);
                command.Parameters.AddWithValue("@Foto", lst[0].RutaImagen);

                int t = Convert.ToInt32(command.ExecuteNonQuery());
                mensaje = "Usuario registrado con éxito";
                ingreso = true;
                cerrar_conexion(conexionAbierta);
            }
            catch (SqlException ex)
            {
                mensaje = "Motivos de error:\n\n- No se puede acceder a la base de datos\n- Los datos ingresados ya existen";
                Console.WriteLine(ex.Message);
            }
            return Tuple.Create(mensaje, ingreso);
        }
        

        /* ----------------------- MÓDULO DE CONDUCTORES ------------------------- */
        public void insertar_conductor(List<ClsParametrosConductor> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = abrir_conexion();
                    string cadena = "INSERT INTO Conductor" +
                                    "(Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Licencia) " +
                                    "VALUES" + " (@cedula, @nombre, @apellido, @edad, @domicilio, @sexo, @licencia)";

                    SqlCommand comannd = new SqlCommand(cadena, conexion);
                    comannd.Parameters.AddWithValue("@cedula", lst[0].Cedula);      //@cedula = campo vacio de referencia que se va a llenar con algún dato
                    comannd.Parameters.AddWithValue("@nombre", lst[0].Nombre);     // lst[0].Cedula = dato con el que llenaremos el campo de referencia, proviene de...
                    comannd.Parameters.AddWithValue("@apellido", lst[0].Apellido);//...la lista creada en la CapaNegocio
                    comannd.Parameters.AddWithValue("@edad", lst[0].Edad);
                    comannd.Parameters.AddWithValue("@domicilio", lst[0].Domicilio);
                    comannd.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                    comannd.Parameters.AddWithValue("@licencia", lst[0].Licencia);
                 
                    int t = Convert.ToInt32(comannd.ExecuteScalar()); // Ejecuta el insert
                    cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Object> buscar_conductor(String cedula)
        {
            List<Object> lstConductor = new List<Object>();
            
            SqlConnection conexion = abrir_conexion();
            string cadena = "Select Cedula, Nombre, Apellido, Edad, Domicilio, Sexo,  Licencia from Conductor WHERE Cedula = @cedula";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@cedula", cedula);

            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    cedula = registros["Cedula"].ToString(),
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    licencia = registros["Licencia"].ToString(),
                };
                
                lstConductor.Add(tmp);
            }

            cerrar_conexion(conexion);
            return lstConductor;
        }

        public void eliminar_conductor(String cedula)
        {
            try
            {
                SqlConnection conexion = abrir_conexion();
                string cadena = "DELETE FROM Conductor WHERE Cedula = @cedula";
                SqlCommand command = new SqlCommand(cadena, conexion);
                command.Parameters.AddWithValue("@cedula", cedula);
                int resultado = Convert.ToInt32(command.ExecuteScalar());
                cerrar_conexion(conexion);
                MessageBox.Show("Eliminado exitosamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar, motivo: " + e);
            }
           
        }

        public List<Object> listar_conductor()
        {
            List<Object> lstConductor = new List<Object>();

            SqlConnection conexion = abrir_conexion();
            string cadena = "Select Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Licencia from Conductor";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.
            while (registros.Read())  // leo la informacion almacenada en registro
            {
                var tmp = new
                {
                    cedula = registros["Cedula"].ToString(),  // para asignar valores de la base a la variable cedula
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    licencia = registros["Licencia"].ToString(),
                };

                lstConductor.Add(tmp);
            }
            cerrar_conexion(conexion);
            return lstConductor;
        }

        public void modificar_conductor(List<ClsParametrosConductor> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = abrir_conexion();
                    string cadena = "UPDATE Conductor set " +
                                    "Cedula=@cedula, Nombre=@nombre, Apellido=@apellido, Edad=@edad, Domicilio=@domicilio, " +
                                    "Sexo=@sexo, Licencia=@licencia " + "WHERE Cedula=@cedula";

                    SqlCommand comannd = new SqlCommand(cadena, conexion);
                    comannd.Parameters.AddWithValue("@cedula", lst[0].Cedula);      //@cedula = campo vacio de referencia que se va a llenar con algún dato
                    comannd.Parameters.AddWithValue("@nombre", lst[0].Nombre);     // lst[0].Cedula = dato con el que llenaremos el campo de referencia, proviene de...
                    comannd.Parameters.AddWithValue("@apellido", lst[0].Apellido);//...la lista creada en la CapaNegocio
                    comannd.Parameters.AddWithValue("@edad", lst[0].Edad);
                    comannd.Parameters.AddWithValue("@domicilio", lst[0].Domicilio);
                    comannd.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                    comannd.Parameters.AddWithValue("@licencia", lst[0].Licencia);

                    comannd.ExecuteNonQuery(); // Ejecuta el update
                    //int t = Convert.ToInt32(comannd.ExecuteScalar()); 
                    cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }

}

