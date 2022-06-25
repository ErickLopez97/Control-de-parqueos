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
    public partial class lavado : Form
    {
        public lavado()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        int contador;
        int valor;
        public static string placa;
        public static string vehiculo;
        public static string tipo;
        public static string total;
        public static string fechalavado;
       
        
            private void lavado_Load(object sender, EventArgs e)
            {
            txtplaca.MaxLength = 6;
          
            txtplaca.Select();
            
             }

        private void btncobrar_Click(object sender, EventArgs e)
        {

            if ( string.IsNullOrEmpty(txttotal.Text))
            {
                MessageBox.Show("Por favor completar  los campos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttotal.Select();
                return;

            }
            else
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
                    valor = Convert.ToInt32(txttotal.Text) / 2;
                    string usuario = Form1.variable;
                    ingresoventas igv = new ingresoventas();
                    fechalavado = Convert.ToString(dateTimePicker1.Value);
                    //Ingresamos la venta
                    igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker2.Value.Date), lblhora.Text, lblplaca.Text, 0, lbltipo.Text, "", "Lavadero", "Invitado", usuario, valor);
                    ingreso_ventas_lavador ivl = new ingreso_ventas_lavador();
                    
                    //ingresamos los datos de la persona encargada del lavado
                    ivl.Registrar(Convert.ToDateTime(dateTimePicker2.Value.Date), lblhora.Text, lblencargado.Text, valor);
                    
                    //borramos la placa ingresada
                    borrar_ingreso_lavado bil = new borrar_ingreso_lavado();
                    bil.borrarplaca(lblplaca.Text);

                    total = txttotal.Text;
                    placa = lblplaca.Text;
                    vehiculo = lbltipo.Text;
                    tipo = "Lavadero";
                    impresion_lavado il = new impresion_lavado();
                    il.Show();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Por favor ingresa solo numeros !", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttotal.Clear();
                    txttotal.Select();

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            verificar_placa_lavado vpl = new verificar_placa_lavado();
            MySqlDataReader myReader;
            myReader = vpl.verificar(txtplaca.Text);
            if (myReader.Read())
            {
               lblplaca.Text= myReader.GetString(0);
                lblencargado.Text = myReader.GetString(1);
                lbltipo.Text = myReader.GetString(2);
                txttotal.Text = myReader.GetString(4);
                dateTimePicker1.Visible = true;
                lblencargado.Visible = true;
                lblplaca.Visible = true;
                lbltipo.Visible = true;
                txttotal.Visible = true;
                txttotal.Select();
                


            }
            else
            {
                MessageBox.Show("Placa NO registrada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtplaca.Clear();
                txtplaca.Select();
            }
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            btncobrar.Enabled = true;
        }
    }
}
