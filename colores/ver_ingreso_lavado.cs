using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colores
{
    public partial class ver_ingreso_lavado : Form
    {
        public ver_ingreso_lavado()
        {
            InitializeComponent();
        }

        private void ver_ingreso_lavado_Load(object sender, EventArgs e)
        {

            ver_carros_en_lavado vti = new ver_carros_en_lavado();

            DataTable dt = new DataTable();

            dt.Load(vti.verificar());
            dataGridView1.DataSource = dt;




        }
    }
}
