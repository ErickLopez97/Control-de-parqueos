using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class verificar_usuario
    {
        MySqlConnection con;

        public verificar_usuario()
        {

            con = conexion.AbrirBD();


        }
        public MySqlDataReader verificarusuario(string a)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = con;
            string SQL = "select * from usuarios where Id_user = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            MySqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }

    }
}
