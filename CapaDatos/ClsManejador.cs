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

        private SqlConnection abrir_conexion()
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

        private void cerrar_conexion(SqlConnection conexion)
        {
            conexion.Close();
            Console.WriteLine("Se cerro la conexion desde la capa de acceso a datos");
        }

        //Método para insertar información
        public void insertar_ambulancia(List<ClsParametrosAmbulancia> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = abrir_conexion();
                    string cadena = "INSERT INTO Ambulancia" +
                                    "(modelo, tipoAmbulancia, placa, matricula) " +
                                    "VALUES" + "(@modelo, @tipoAmbulancia, @placa, @matricula)";

                    SqlCommand comannd = new SqlCommand(cadena, conexion);
                    comannd.Parameters.AddWithValue("@modelo", lst[0].Modelo); // a la variable de tip Mysql comand agregar un valor al parametro
                    comannd.Parameters.AddWithValue("@tipoAmbulancia", lst[0].TipoAmbulancia); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
                    comannd.Parameters.AddWithValue("@placa", lst[0].Placa);
                    comannd.Parameters.AddWithValue("@matricula", lst[0].Matricula);
 

                    int t = Convert.ToInt32(comannd.ExecuteScalar()); // con esa linea executa el insert a la bd
                    cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Object> listar_ambulancia()
        {
            List<Object> lstAmbulancia = new List<Object>();

            SqlConnection conexion = abrir_conexion();
            string cadena = "Select modelo, tipoAmbulancia, placa, matricula from Ambulancia";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.
            while (registros.Read())  // leo la informacion almacenada en registro
            {
                var tmp = new
                {
                    modelo = registros["modelo"].ToString(),  // para asignar valores de la base a la variable cedula
                    tipoAmbulancia = registros["tipoAmbulancia"].ToString(),
                    placa = registros["placa"].ToString(),
                    matricula = registros["matricula"].ToString(),
                  
                };

                lstAmbulancia.Add(tmp);
            }
            cerrar_conexion(conexion);
            return lstAmbulancia;
        }


        public List<Object> buscar_ambulancia(String placa)
        {
            List<Object> lstAmbulancia = new List<Object>();

            SqlConnection conexion = abrir_conexion();
            string cadena = "Select modelo, tipoAmbulancia, placa, matricula from Ambulancia WHERE placa = @placa";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@placa", placa);

            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    modelo = registros["modelo"].ToString(),  // para asignar valores de la base a la variable cedula
                    tipoAmbulancia = registros["tipoAmbulancia"].ToString(),
                    placa = registros["placa"].ToString(),
                    matricula = registros["matricula"].ToString(),

                };
                lstAmbulancia.Add(tmp);
            }
            cerrar_conexion(conexion);
            return lstAmbulancia;
        }


        public int eliminar_ambulancia(String placa)
        {
            SqlConnection conexion = abrir_conexion();
            string cadena = "DELETE FROM Ambulancia WHERE placa = @placa";
            SqlCommand command = new SqlCommand(cadena, conexion);
            command.Parameters.AddWithValue("@placa", placa);
            int resultado = Convert.ToInt32(command.ExecuteScalar());

            MessageBox.Show("Se a eliminado con exito");
            cerrar_conexion(conexion);
            return resultado;
        }

       
        public int actualizar_ambulancia_individual(String param_modelo, String param_tipo, String param_placa, String param_matricula)
        {
            SqlConnection conexion = abrir_conexion();
            string actualizar = "update Ambulancia set modelo=@param_modelo,tipoAmbulancia=@param_tipo, matricula=@param_matricula WHERE placa = @param_placa";
            SqlCommand comannd = new SqlCommand(actualizar, conexion);
            comannd.Parameters.AddWithValue("@param_modelo", param_modelo); // a la variable de tip Mysql comand agregar un valor al parametro
            comannd.Parameters.AddWithValue("@param_tipo", param_tipo); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
            comannd.Parameters.AddWithValue("@param_placa", param_placa);
            comannd.Parameters.AddWithValue("@param_matricula", param_matricula);

            int resultado_operacion = Convert.ToInt32(comannd.ExecuteScalar());
            cerrar_conexion(conexion);

            return resultado_operacion;
        
        } 

        //Cliente
        public void insertar_cliente(List<ClsParametrosCliente> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = abrir_conexion();
                    string cadena = "INSERT INTO Cliente" +
                                    "(Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Imagen ,CodigoCliente) " +
                                    "VALUES" + "(@cedula, @nombre, @apellido, @edad, @domicilio, @sexo,@imagen ,@codigoCliente)";

                    SqlCommand comannd = new SqlCommand(cadena, conexion);
                    comannd.Parameters.AddWithValue("@cedula", lst[0].Cedula); // a la variable de tip Mysql comand agregar un valor al parametro
                    comannd.Parameters.AddWithValue("@nombre", lst[0].Nombre); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
                    comannd.Parameters.AddWithValue("@apellido", lst[0].Apellido);
                    comannd.Parameters.AddWithValue("@edad", lst[0].Edad);
                    comannd.Parameters.AddWithValue("@domicilio", lst[0].Domicilio);
                    comannd.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                    comannd.Parameters.AddWithValue("@imagen", lst[0].Imagen);
                    comannd.Parameters.AddWithValue("@codigoCliente", lst[0].CodigoCliente);

                    int t = Convert.ToInt32(comannd.ExecuteScalar()); // con esa linea executa el insert a la bd
                    cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Object> listar_cliente()
        {
            List<Object> lstCliente = new List<Object>();

            SqlConnection conexion = abrir_conexion();
            string cadena = "Select Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Imagen ,CodigoCliente from Cliente";
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
                    imagen = registros["Imagen"].ToString(),
                    codigoCliente = registros["CodigoCliente"].ToString(),
                };

                lstCliente.Add(tmp);
            }
            cerrar_conexion(conexion);
            return lstCliente;
        }

        public List<Object> buscar_cliente(String cedula)
        {
            List<Object> lstCliente = new List<Object>();

            SqlConnection conexion = abrir_conexion();
            string cadena = "Select Cedula, Nombre, Apellido, Edad, Domicilio, Sexo,  Imagen , CodigoCliente from Cliente WHERE Cedula = @cedula";
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
                    imagen = registros["Imagen"].ToString(),
                    codigoCliente = registros["CodigoCliente"].ToString(),
                };
                lstCliente.Add(tmp);
            }

            cerrar_conexion(conexion);
            return lstCliente;
        }


        public int eliminar_cliente(String cedula)
        {
            SqlConnection conexion = abrir_conexion();
            string cadena = "DELETE FROM Cliente WHERE Cedula = @cedula";
            SqlCommand command = new SqlCommand(cadena, conexion);
            command.Parameters.AddWithValue("@cedula", cedula);
            int resultado = Convert.ToInt32(command.ExecuteScalar());

            MessageBox.Show("Se a eliminado con exito");
            cerrar_conexion(conexion);
            return resultado;
        }


        /* ----------------------- Registro de usuario ------------------------- */
        public String RegistrarUsuario(List<clsParametrosUsuario> lst)
        {
            String mensaje = "";
            try
            {
                SqlConnection conexionAbierta = abrir_conexion();

                string query = "INSERT INTO Usuario " +
                    "(Nombre, Apellido, Cedula, NombreUsuario, Password, RutaImagen)" +
                    " VALUES (@Nombre, @Apellido, @Cedula, @NombreUsuario,@Password, @RutaImagen)";
                SqlCommand command = new SqlCommand(query, conexionAbierta);
                //valores para cada parámetro dado en el query
                command.Parameters.AddWithValue("@Nombre", lst[0].Nombre);
                command.Parameters.AddWithValue("@Apellido", lst[0].Apellido);
                command.Parameters.AddWithValue("@Cedula", lst[0].Cedula);
                command.Parameters.AddWithValue("@NombreUsuario", lst[0].Usuario);
                command.Parameters.AddWithValue("@Password", lst[0].Password);
                command.Parameters.AddWithValue("@RutaImagen", lst[0].RutaImagen);

                int t = Convert.ToInt32(command.ExecuteNonQuery());
                mensaje = "Registrado con éxito, ";
                cerrar_conexion(conexionAbierta);
            }
            catch (SqlException ex)
            {
                mensaje = "Error, base de datos inaccesible. ";
                Console.WriteLine(ex);
            }
            return mensaje;
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
    }

}

