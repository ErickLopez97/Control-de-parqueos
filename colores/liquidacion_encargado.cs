using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace colores
{
    class liquidacion_encargado
    {
        MySqlConnection con;

        public liquidacion_encargado()
        {
            con = conexion.AbrirBD();
        }
        public MySqlDataReader totalventas(string fecha1, string nombre)
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select sum(valor) from lavador where nombre like @nomb and fecha = @fecha1 ; ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@fecha1", fecha1);
            ejecutarSQL.Parameters.AddWithValue("@nomb", nombre).Value = nombre + "%";

            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
    }
}
