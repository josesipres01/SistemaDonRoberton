using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDUsuario
    {
        public bool ValidarAccesoAdmin(string user, string pass)
        {
            using (SqlConnection con = new SqlConnection(Conexión.Conn))
            {
                con.Open();
                // Agregamos el filtro AND rol = 'Administrador'
                string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @user AND contrasena = @pass AND rol = 'admin'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
