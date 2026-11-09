using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Actividad3_Login
{
    public class D_Conexion
    {
        private static readonly string CadenaConexion = "Server = localhost;" +
            "Port=3306;" +
            "Database =Parcial3Login;" +
            "Uid =app_controller;" +
            "Pwd=P@rcial3P@ssword;";
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(CadenaConexion);
            return conexion;
        }
    }
}
