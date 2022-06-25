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
    public partial class egresos : Form
    {
        public egresos()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        int contador;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btncobrar.Enabled = true;
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            
            Numerodeventa nm = new Numerodeventa();
            MySqlDataReader myReader;
            myReader = nm.ultimoregistro();
            if (myReader.Read())
            {
                contador = Convert.ToInt32(myReader.GetInt32(0) + 1);

            }
            int ejm = 0;
            if ((int.TryParse(txttotal.Text, out ejm)))
            {
                string usuario = Form1.variable;
                ingresoventas igv = new ingresoventas();
                igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker1.Value.Date), lblhora.Text, "", Convert.ToInt32(txttotal.Text), "Egreso", "", txtdescripcion.Text, "", usuario, 0);
                MessageBox.Show("Datos ingresados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Por favor ingresa solo numeros !", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttotal.Clear();
                txtdescripcion.Clear();
                txtdescripcion.Select();
            }
        }
    }
        
}
