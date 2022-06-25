using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class registrar_ingreso_lavado
    {

        MySqlConnection con;

        public registrar_ingreso_lavado()
        {

            con = conexion.AbrirBD();


        }
        public MySqlCommand Registrar(string placa, string encargado, string vehiculo, DateTime fecha,int total)
        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;

            string sql = "Insert into ingreso_lavado (placa,encargado,vehiculo,fecha,total) values (@placa,@encar,@vehi,@fecha,@total)";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            ejecutarSQL.Parameters.AddWithValue("@encar", encargado);
            ejecutarSQL.Parameters.AddWithValue("@vehi", vehiculo);
            ejecutarSQL.Parameters.AddWithValue("@fecha", fecha);
            ejecutarSQL.Parameters.AddWithValue("@total", total);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return null;

        }

    }
}
