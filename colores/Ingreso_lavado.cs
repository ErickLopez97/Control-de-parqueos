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
    public partial class Ingreso_lavado : Form
    {
        public Ingreso_lavado()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtplaca.Text))
            {
                MessageBox.Show("Por favor ingresa la placa", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtplaca.Select();
                return;

            }
            else
            {

                //Cada vez que el usuario selecciones un campo del combobox
                //preciolavada pl = new preciolavada();
                //MySqlDataReader myReader;
                if (comboBox1.Text == "Camion")
                {
                    lbltipo.Text = "Camion";
                    //  myReader = pl.verificarprecio("Camion- Lavado sencillo");
                    //if (myReader.Read()) { txttotal.Text = myReader.GetString(1); }

                }
                else
                if (comboBox1.Text == "Camperos")
                {
                    lbltipo.Text = "Camperos";

                }

                else
                if (comboBox1.Text == "Automovil")
                {
                    lbltipo.Text = "Automovil";

                }

                else
                if (comboBox1.Text == "Otros")
                {
                    lbltipo.Text = "Otros";

                }

                else
                if (comboBox1.Text == "Doble troque")
                {
                    lbltipo.Text = "Doble troque";

                }

                else

                if (comboBox1.Text == "Tracto mula")
                {
                    lbltipo.Text = "Tracto mula";

                }



                lbltipo.Visible = true;
                lblplaca.Text = txtplaca.Text;
                lblplaca.Visible = true;

                label2.Visible = true;
                label3.Visible = true;
                txttotal.Visible = true;
                label4.Visible = true;
                lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
                lblfecha.Visible = true;
                lblhora.Visible = true;
                btncobrar.Enabled = true;
                label6.Visible = true;
                txtencargado.Visible = true;
                txtencargado.Select();
            }
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtplaca.Text)|| string.IsNullOrEmpty(txttotal.Text))
            {
                MessageBox.Show("Por favor llenar todos los campos!!", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;

            }
            else
            {
                verificar_placa_lavado vpl = new verificar_placa_lavado();
                MySqlDataReader myReader;
                myReader = vpl.verificar(lblplaca.Text);
                if (myReader.Read())
                {
                    MessageBox.Show("Placa ya ingresada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtplaca.Select();
                    btncobrar.Enabled = false;


                }
                else
                {
                    if (string.IsNullOrEmpty(txtencargado.Text))
                    {
                        MessageBox.Show("Por favor ingrese nombre del encargado del lavado", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtencargado.Select();
                        return;

                    }
                    else
                    {
                        int ejm = 0;
                        if ((int.TryParse(txttotal.Text, out ejm)))
                        {
                            registrar_ingreso_lavado ril = new registrar_ingreso_lavado();
                            ril.Registrar(lblplaca.Text, txtencargado.Text, lbltipo.Text, dateTimePicker1.Value, Convert.ToInt32(txttotal.Text));
                            MessageBox.Show("Registro exitoso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Solo ingresar numeros !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txttotal.Select();
                        }
                    }
                }
            }
        }

        private void Ingreso_lavado_Load(object sender, EventArgs e)
        {
            txtplaca.Select();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            lavado lva = new lavado();
            lva.Show();
            Close();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
