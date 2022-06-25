using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class conexion
    {
        static MySqlConnection con;
        public static MySqlConnection AbrirBD()
        {
            //MySqlConnection conexion = new MySqlConnection();
            // conexion.ConnectionString = "Server=localhost;Database=Nombre_de_la_base_de_datos; Uid=Nombre_de_usuario_local;Pwd=contraseña_local;";
            con = new MySqlConnection("Server=localhost; Database = colores; Uid=root;Pwd=;SslMode=none;");
            try
            {
                con.Open();

                return con;
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show("Error en la conexio" + error.Message);
                con.Close();
                return null;


            }
        }
        public static MySqlConnection cerrarBD()
        {
            con.Close();
            return con;
        }
    }
}
