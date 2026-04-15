using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDRespaldo
    {
        // Instancia de tu clase Conexión para obtener la cadena
        private Conexión conexion = new Conexión();

        public bool GenerarBackup(string ruta)
        {
            try
            {
                // Usamos la cadena de clase Conexión
                using (SqlConnection con = new SqlConnection(Conexión.Conn))
                {
                    // Importante
                    string query = $@"BACKUP DATABASE [sistemaDonRoberton] 
                             TO DISK = '{ruta}' 
                             WITH FORMAT, NAME = 'Full Backup of sistemaDonRoberton';";

                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en SQL: " + ex.Message);
            }
        }

        public bool RestaurarBackup(string ruta)
        {
            try
            {
                string connectionStringMaster = "Data Source=.;Initial Catalog=master;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionStringMaster))
                {
                    con.Open();
                    string query = $@"ALTER DATABASE [sistemaDonRoberton] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                     RESTORE DATABASE [sistemaDonRoberton] FROM DISK = '{ruta}' WITH REPLACE;
                                     ALTER DATABASE [sistemaDonRoberton] SET MULTI_USER;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception) { return false; }
        }
    }
}