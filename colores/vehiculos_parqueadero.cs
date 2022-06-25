using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace colores
{
    public partial class vehiculos_parqueadero : Form
    {
        public vehiculos_parqueadero()
        {
            InitializeComponent();
        }

        private void vehiculos_parqueadero_Load(object sender, EventArgs e)
        {
            ver_tabla_ingreso vti = new ver_tabla_ingreso();

            DataTable dt = new DataTable();





            dt.Load(vti.verificar());
            dataGridView1.DataSource = dt;
        }
    }
}
