﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Registrar
    {
        MySqlConnection con;
        public Registrar()
        {

            con = conexion.AbrirBD();
        }
        public MySqlCommand Registrar_ingreso()
        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string sql = "Insert into ingreso select * from temporal_ingreso";
            ejecutarSQL.CommandText = sql;



            int Num = ejecutarSQL.ExecuteNonQuery();
            return null;

        }

    }
}
