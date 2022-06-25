using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class verificarplaca
    {
        MySqlConnection con;
        public verificarplaca()
        {

            con = conexion.AbrirBD();
        }
        public MySqlDataReader verificar(string a)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select * from ingreso where placa = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            MySqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }

    }
}
