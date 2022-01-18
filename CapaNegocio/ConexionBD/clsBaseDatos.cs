using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.ConexionBD
{
    class clsBaseDatos
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

    }
}
