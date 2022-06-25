﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class total_de_ventas_detallada
    {
        MySqlConnection con;

        public total_de_ventas_detallada()
        {
            con = conexion.AbrirBD();
        }
        public MySqlDataReader totalventasfiltrada(string fecha1, string fecha2)
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select sum(valor) from ventas where fecha between @fecha1 and @fecha2 ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@fecha1", fecha1);
            ejecutarSQL.Parameters.AddWithValue("@fecha2", fecha2);

            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
    }
}
