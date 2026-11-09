using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3_Login
{
    public class D_IntentoLog
    {
       

        public void RegistrarIntento(
            int? idUsuario,
            string usuario,
            bool exitoso)
        {
            using (MySqlConnection cn = D_Conexion.ObtenerConexion())
            {
                cn.Open();

                string sql = @"INSERT INTO TryLog
                               (iDUsuario, UserE, Success)
                               VALUES
                               (@idUsuario, @usuario, @exitoso)";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    if (idUsuario.HasValue)
                    {
                        cmd.Parameters.AddWithValue(
                            "@idUsuario", idUsuario.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue(
                            "@idUsuario", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@exitoso", exitoso);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
