using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class ingreso_ventas_lavador
    {
        MySqlConnection con;

        public ingreso_ventas_lavador()
        {

            con = conexion.AbrirBD();


        }
        public MySqlCommand Registrar(DateTime fecha, string hora, string nombre, int valor)
        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;

            string sql = "Insert into lavador (fecha,hora,nombre,valor) values (@id,@nombre,@contra,@cargo)";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@id", fecha);
            ejecutarSQL.Parameters.AddWithValue("@nombre", hora);
            ejecutarSQL.Parameters.AddWithValue("@contra", nombre);
            ejecutarSQL.Parameters.AddWithValue("@cargo", valor);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return null;

        }
    }
}
