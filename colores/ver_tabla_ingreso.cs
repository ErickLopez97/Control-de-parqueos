using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class ver_tabla_ingreso
    {
        MySqlConnection con;
        public ver_tabla_ingreso()
        {

            con = conexion.AbrirBD();
        }
        public MySqlDataReader verificar()
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select * from ingreso ";
            ejecutarSQL.CommandText = SQL;
           
            MySqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
    }
}
