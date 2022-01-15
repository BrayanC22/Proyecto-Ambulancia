using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class ClsManejadorAmbulancia
    {
        private ClsManejador Maneja = new ClsManejador();

        //Método para insertar información
        public void insertar_ambulancia(List<ClsParametrosAmbulancia> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = Maneja.abrir_conexion();


                    SqlCommand command = new SqlCommand();

                    command.Connection = conexion;

                    command.CommandText = "ambInsertCommand";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@modelo", lst[0].Modelo); // a la variable de tip Mysql comand agregar un valor al parametro
                    command.Parameters.AddWithValue("@tipoAmbulancia", lst[0].TipoAmbulancia); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
                    command.Parameters.AddWithValue("@placa", lst[0].Placa);
                    command.Parameters.AddWithValue("@matricula", lst[0].Matricula);


                    int t = Convert.ToInt32(command.ExecuteScalar()); // con esa linea executa el insert a la bd
                    Maneja.cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Object> listar_ambulancia()
        {
           
            List<Object> lstAmbulancia = new List<Object>();

            SqlConnection conexion = Maneja.abrir_conexion();

            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "ambSelectCommand";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader registros = command.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.
            while (registros.Read())  // leo la informacion almacenada en registro
            {
                var tmp = new
                {
                    Id_Ambulancia = Int16.Parse(registros["Id_Ambulancia"].ToString()),
                    modelo = registros["modelo"].ToString(),  // para asignar valores de la base a la variable cedula
                    tipoAmbulancia = registros["tipoAmbulancia"].ToString(),
                    placa = registros["placa"].ToString(),
                    matricula = registros["matricula"].ToString(),

                };
                lstAmbulancia.Add(tmp);
            }
            Maneja.cerrar_conexion(conexion);
            return lstAmbulancia;
        }


        public List<Object> buscar_ambulancia(String placa)
        {
            List<Object> lstAmbulancia = new List<Object>();
            SqlConnection conexion = Maneja.abrir_conexion();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "ambSelectindividualCommand";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@placa", placa);

            SqlDataReader registros = command.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    Id_Ambulancia = Int16.Parse(registros["Id_Ambulancia"].ToString()),
                    modelo = registros["modelo"].ToString(), 
                    tipoAmbulancia = registros["tipoAmbulancia"].ToString(),
                    placa = registros["placa"].ToString(),
                    matricula = registros["matricula"].ToString(),
                };
                lstAmbulancia.Add(tmp);
            }
            Maneja.cerrar_conexion(conexion);
            return lstAmbulancia;
        }


        public int eliminar_ambulancia(String placa)
        {
            SqlConnection conexion = Maneja.abrir_conexion();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "AmbDeleteCommand";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Original_placa", placa);
            int resultado = Convert.ToInt32(command.ExecuteScalar());

            MessageBox.Show("Se a eliminado con exito");
            Maneja.cerrar_conexion(conexion);
            return resultado;
        }


        public int actualizar_ambulancia_individual(String param_modelo, String param_tipo, String param_placa, String param_matricula)
        {
            SqlConnection conexion = Maneja.abrir_conexion();
            SqlCommand command = new SqlCommand();

            command.Connection = conexion;
            command.CommandText = "ambUpdateCommand";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@modelo", param_modelo); 
            command.Parameters.AddWithValue("@tipoAmbulancia", param_tipo); 
            command.Parameters.AddWithValue("@placa", param_placa);
            command.Parameters.AddWithValue("@matricula", param_matricula);

            int resultado_operacion = Convert.ToInt32(command.ExecuteScalar());
            Maneja.cerrar_conexion(conexion);

            return resultado_operacion;

        }

        /*Metodos para asignacion*/

        public void insertar_asignacion(List<ClsParametrosAsignacion> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = Maneja.abrir_conexion();


                    SqlCommand command = new SqlCommand();

                    command.Connection = conexion;

                    command.CommandText = "AsignacionInsertCommand";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Id_AmbulanciaAsignacion", lst[0].ID_AmbulanciaAsignacion); // a la variable de tip Mysql comand agregar un valor al parametro
                    command.Parameters.AddWithValue("@Id_ConductorAsignacion", lst[0].ID_ConductorAsignacion); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica



                    int t = Convert.ToInt32(command.ExecuteScalar()); // con esa linea executa el insert a la bd
                    Maneja.cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }


    }
}
