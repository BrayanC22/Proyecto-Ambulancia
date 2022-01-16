using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.Conductor
{
    public class ClsManejadorConductor
    {
        ClsManejador manejaConductor = new ClsManejador();
        /* ----------------------- MÓDULO DE CONDUCTORES ------------------------- */
        public void insertar_conductor(List<ClsParametrosConductor> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = manejaConductor.abrir_conexion();
                    
                    SqlCommand comannd = new SqlCommand();
                    comannd.Connection = conexion;
                    comannd.CommandText = "CONDUCTORInsertCommand";
                    comannd.CommandType = System.Data.CommandType.StoredProcedure;

                    comannd.Parameters.AddWithValue("@cedula", lst[0].Cedula);      //@cedula = campo vacio de referencia que se va a llenar con algún dato
                    comannd.Parameters.AddWithValue("@nombre", lst[0].Nombre);     // lst[0].Cedula = dato con el que llenaremos el campo de referencia, proviene de...
                    comannd.Parameters.AddWithValue("@apellido", lst[0].Apellido);//...la lista creada en la CapaNegocio
                    comannd.Parameters.AddWithValue("@edad", lst[0].Edad);
                    comannd.Parameters.AddWithValue("@domicilio", lst[0].Domicilio);
                    comannd.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                    comannd.Parameters.AddWithValue("@licencia", lst[0].Licencia);

                    int t = Convert.ToInt32(comannd.ExecuteScalar()); // Ejecuta el insert
                    manejaConductor.cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Object> buscar_conductor(String cedula)
        {
            List<Object> lstConductor = new List<Object>();

            SqlConnection conexion = manejaConductor.abrir_conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "CONDUCTORSelectByCedulaCommand";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@cedula", cedula);

            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    id_conductor = Int16.Parse(registros["Id_Conductor"].ToString()),
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

            manejaConductor.cerrar_conexion(conexion);
            return lstConductor;
        }

        public void eliminar_conductor(String cedula)
        {
            try
            {
                SqlConnection conexion = manejaConductor.abrir_conexion();
                SqlCommand command = new SqlCommand();
                command.Connection= conexion;
                command.CommandText = "CONDUCTORDeleteCommand";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@cedula", cedula);
                int resultado = Convert.ToInt32(command.ExecuteScalar());
                manejaConductor.cerrar_conexion(conexion);
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
            SqlConnection conexion = manejaConductor.abrir_conexion();
            SqlCommand comannd = new SqlCommand();

            comannd.Connection = conexion;
            comannd.CommandText = "CONDUCTORSelectCommand";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader registros = comannd.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.
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
            manejaConductor.cerrar_conexion(conexion);
            return lstConductor;
        }

        public void modificar_conductor(List<ClsParametrosConductor> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = manejaConductor.abrir_conexion();
                    SqlCommand comannd = new SqlCommand();
                    comannd.Connection = conexion;
                    comannd.CommandText = "CONDUCTORUpdateCommand";
                    comannd.CommandType = System.Data.CommandType.StoredProcedure;

                    comannd.Parameters.AddWithValue("@cedula", lst[0].Cedula);      //@cedula = campo vacio de referencia que se va a llenar con algún dato
                    comannd.Parameters.AddWithValue("@nombre", lst[0].Nombre);     // lst[0].Cedula = dato con el que llenaremos el campo de referencia, proviene de...
                    comannd.Parameters.AddWithValue("@apellido", lst[0].Apellido);//...la lista creada en la CapaNegocio
                    comannd.Parameters.AddWithValue("@edad", lst[0].Edad);
                    comannd.Parameters.AddWithValue("@domicilio", lst[0].Domicilio);
                    comannd.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                    comannd.Parameters.AddWithValue("@licencia", lst[0].Licencia);

                    comannd.ExecuteNonQuery(); // Ejecuta el update
                    
                    manejaConductor.cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
