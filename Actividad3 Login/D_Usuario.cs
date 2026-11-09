using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3_Login
{

    public class D_Usuario
    {
        

        public E_Usuario ObtenerUsuario(string usuario)
        {
            E_Usuario usuarioEncontrado = null;

            using (MySqlConnection cn = D_Conexion.ObtenerConexion())
            {
                cn.Open();

                string sql = @"SELECT iDUsuario, usuario, nombre,
                                      passHash, activo
                               FROM Users
                               WHERE usuario = @usuario";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioEncontrado = new E_Usuario
                            {
                                IdUser = Convert.ToInt32(reader["iDUsuario"]),
                                Usuario = reader["usuario"].ToString(),
                                Nombre = reader["nombre"].ToString(),
                                PassHash = reader["passHash"].ToString(),
                                Activo = Convert.ToBoolean(reader["activo"])
                            };
                        }
                    }
                }
            }

            return usuarioEncontrado;
        }

        public int RegistrarUsuario(E_Usuario usuario)
        {
            using (MySqlConnection cn = D_Conexion.ObtenerConexion())
            {
                cn.Open();

                string sql = @"INSERT INTO Users
                               (usuario, nombre, passHash, activo)
                               VALUES
                               (@usuario, @nombre, @hash, @activo)";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@hash", usuario.PassHash);
                    cmd.Parameters.AddWithValue("@activo", usuario.Activo);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }

}
