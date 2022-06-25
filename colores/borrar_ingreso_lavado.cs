using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class borrar_ingreso_lavado
    {

        MySqlConnection con;
        public borrar_ingreso_lavado()
        {

            con = conexion.AbrirBD();
        }
        public MySqlDataReader borrarplaca(string c)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "delete from ingreso_lavado where placa=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", c);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
    }
}
