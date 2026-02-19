using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDUsuario
    {
        public DataTable ValidarAcceso(string user, string pass)
        {
            using (SqlConnection con = new SqlConnection(Conexión.Conn))
            {
                DataTable dt = new DataTable();
                string query = "SELECT usuario, rol FROM usuarios WHERE usuario = @user AND contrasena = @pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
