using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class verificar_placa_lavado
    {
        MySqlConnection con;
        public verificar_placa_lavado()
        {

            con = conexion.AbrirBD();
        }
        public MySqlDataReader verificar(string a)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select * from ingreso_lavado where placa = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            MySqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
    }
}
