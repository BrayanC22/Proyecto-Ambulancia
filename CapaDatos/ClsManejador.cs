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
        

       
    }

}

