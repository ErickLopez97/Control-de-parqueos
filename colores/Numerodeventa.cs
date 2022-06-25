using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Numerodeventa
    {
        MySqlConnection con;
        public Numerodeventa()
        {

            con = conexion.AbrirBD();
        }
        public MySqlDataReader ultimoregistro()
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select * from ventas where Id_ventas = (SELECT MAX(Id_ventas)from ventas);";
            ejecutarSQL.CommandText = SQL;
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }

    }
}
