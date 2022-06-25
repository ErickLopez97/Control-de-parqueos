using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class borraringreso
    {
        MySqlConnection con;
        public borraringreso()
        {

            con = conexion.AbrirBD();
        }
        public MySqlDataReader borrarplaca(string c)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "delete from ingreso where placa=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", c);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
    }
}
