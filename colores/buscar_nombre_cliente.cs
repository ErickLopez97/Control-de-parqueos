using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class buscar_nombre_cliente
    {
        MySqlConnection con;

        public buscar_nombre_cliente()
        {
            con = conexion.AbrirBD();
        }
        public MySqlDataReader buscarnombre(string c)
        {
            //Esto mostrara todo lo que haya en la lista buscado por el codigo
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select * from clientes where nombre  like @cod;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", c).Value = c + "%";
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;

        }
    }
}
