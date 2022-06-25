using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace colores
{
    class eliminar_cliente
    {
        MySqlConnection con;
        public eliminar_cliente()
        {

            con = conexion.AbrirBD();
        }
        public MySqlDataReader borrarcliente(string  c)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "delete from clientes where cedula=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", c);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
    }
}
