using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class ver_carros_en_lavado
    {
        MySqlConnection con;
        public ver_carros_en_lavado()
        {

            con = conexion.AbrirBD();
        }
        public MySqlDataReader verificar()
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select * from ingreso_lavado ";
            ejecutarSQL.CommandText = SQL;

            MySqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
    }
}
