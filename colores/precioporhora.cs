using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class precioporhora
    {
        MySqlConnection con;

        public precioporhora()
        {

            con = conexion.AbrirBD();
        }
        public MySqlDataReader verificarprecio(string a)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select * from precio_hora where descripcion = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            MySqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
    }
}
