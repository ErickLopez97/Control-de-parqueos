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
    public partial class liquidar_encargado : Form
    {
        public liquidar_encargado()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string m1 = Convert.ToString(fecha1.Value.Month);
            string a1 = Convert.ToString(fecha1.Value.Year);
            string d1 = Convert.ToString(fecha1.Value.Day);

            if (Convert.ToInt32(d1) < 10) { d1 = 0 + d1; }
            if (Convert.ToInt32(m1) < 10) { m1 = 0 + m1; }
            string f1 = (a1 + m1 + d1);
            liquidacion_encargado tde = new liquidacion_encargado();
            MySqlDataReader My;
            My = tde.totalventas(f1, txtbuscar.Text);
            try
            {
                if (My.Read())
                {
                    lbltotalventas.Text = Convert.ToString(My.GetInt32(0));
                }



                ventas_por_lavador vpl = new ventas_por_lavador();
                DataTable dt = new DataTable();
                dt.Load(vpl.mostrarventas(f1, txtbuscar.Text));
                dataGridView1.DataSource = dt;


            
            }
            catch 
            {
                MessageBox.Show("NO hay servicios de lavados por el momento ! " ,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
}

        private void liquidar_encargado_Load(object sender, EventArgs e)
        {
            txtbuscar.Select();
        }
    }
}
