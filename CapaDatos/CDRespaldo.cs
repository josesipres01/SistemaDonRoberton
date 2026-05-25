using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CapaDatos
{
    public class CDRespaldo
    {
        // Instancia de tu clase Conexión para obtener la cadena
        private Conexión conexion = new Conexión();
        private string rutaPuente = @"C:\BackupsDonRoberton\bridge_db.bak";

        private string ObtenerRutaDefaultSQL(SqlConnection con)
        {
            // Esta consulta le pregunta a SQL su carpeta de "casa"
            string query = "SELECT SERVERPROPERTY('InstanceDefaultBackupPath')";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                var ruta = cmd.ExecuteScalar();
                if (ruta != null && ruta != DBNull.Value) return ruta.ToString();
            }
            // Si falla (en versiones muy viejas), usamos una carpeta temporal del sistema
            return @"C:\temp\";
        }

        public bool GenerarBackup(string rutaDestinoUsuario)
        {
            using (SqlConnection con = new SqlConnection(Conexión.Conn))
            {
                con.Open();
                // 1. Detectamos la zona segura de SQL
                string carpetaSegura = ObtenerRutaDefaultSQL(con);
                string archivoTemporal = Path.Combine(carpetaSegura, "temp_donroberton.bak");

                try
                {
                    // 2. SQL hace el backup en SU propia carpeta (aquí nunca falla por permisos)
                    string query = $@"BACKUP DATABASE [sistemaDonRoberton] TO DISK = '{archivoTemporal}' WITH FORMAT, INIT";
                    new SqlCommand(query, con).ExecuteNonQuery();

                    // 3. C# (que tiene permisos del usuario) lo mueve a donde el usuario quiera
                    if (File.Exists(rutaDestinoUsuario)) File.Delete(rutaDestinoUsuario);
                    File.Move(archivoTemporal, rutaDestinoUsuario);

                    return true;
                }
                catch (Exception ex)
                {
                    File.AppendAllText("error.log", ex.Message);
                    return false;
                }
            }
        }

        public bool RestaurarBackup(string rutaOrigenUsuario)
        {
            string rutaPuente = @"C:\BackupsDonRoberton\temp_restore.bak";
            try
            {
                SqlConnection.ClearAllPools();
                File.Copy(rutaOrigenUsuario, rutaPuente, true);

                string conMaster = "Data Source=.;Initial Catalog=master;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(conMaster))
                {
                    con.Open();
                    // Intentamos expulsar usuarios, si falla no importa, seguimos
                    try
                    {
                        new SqlCommand("ALTER DATABASE [sistemaDonRoberton] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", con).ExecuteNonQuery();
                    }
                    catch { /* Ignoramos si no hay permisos de admin */ }

                    // El comando principal
                    string query = $@"RESTORE DATABASE [sistemaDonRoberton] FROM DISK = '{rutaPuente}' WITH REPLACE";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandTimeout = 0; // Sin límite de tiempo
                    cmd.ExecuteNonQuery();

                    // Volvemos a modo multiusuario
                    try
                    {
                        new SqlCommand("ALTER DATABASE [sistemaDonRoberton] SET MULTI_USER", con).ExecuteNonQuery();
                    }
                    catch { }
                }
                return true;
            }
            catch (Exception ex)
            {
                File.AppendAllText("restore_log.txt", ex.Message);
                return false;
            }
        }
    }
}