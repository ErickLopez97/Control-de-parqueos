using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class flitro_pagos_realizados
    {
        MySqlConnection con;

        public flitro_pagos_realizados()
        {
            con = conexion.AbrirBD();
        }
        public MySqlDataReader pagos_realizados(string a)
        {
            //buscamos todo las ventas echas al cliente
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select * from ventas where cliente = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;

        }
    }
}
