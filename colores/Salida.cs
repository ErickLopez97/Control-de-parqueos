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
    public partial class Salida : Form
    {
        public static string total;
        public static int cantidadacobrar;
        public static int precio;
        public static int contador;
        public static string placa;
        public static string vehiculo;
        public static string fechaentrada;
        public static string tiempoacobrar;
        public static int totalxdia;
        float dias;


        public Salida()
        {
            InitializeComponent();
        }

        private void Salida_Load(object sender, EventArgs e)
        {
            txtplaca.MaxLength = 7;
            Numerodeventa nm = new Numerodeventa();
            MySqlDataReader myReader;
            myReader = nm.ultimoregistro();
            if (myReader.Read())
            {
                lblcontador.Text = Convert.ToString(myReader.GetInt32(0) + 1);
                contador = Convert.ToInt32(lblcontador.Text);
            }
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            
                
                    placa = txtplaca.Text;
            tiempoacobrar = lbltiempoacobrar.Text;
                    total = lbltotal.Text;
                    string usuario = Form1.variable;
                    //Ingresamos los datos a la tabla ventas
                    ingresoventas iv = new ingresoventas();
                    iv.Registrar_venta(Convert.ToInt32(lblcontador.Text), Convert.ToDateTime(dateTimePicker1.Value.Date), lblhorasalida.Text, txtplaca.Text,0, lbltipo.Text,"", lblparque.Text, "Invitado", usuario,Convert.ToInt32( lbltotal.Text));
           
            borraringreso bi = new borraringreso();
                    //Borramos la plata de la tabla ingreso
                    bi.borrarplaca(txtplaca.Text);

                   
                    impresion_salida_parqueadero ipsp = new impresion_salida_parqueadero();
                    ipsp.Show();
                   
                    lblhorasalida.Visible = false;
                    lblhoraentrada.Visible = false;
                    txtplaca.Focus();

                    this.Close();
                
               
            
             
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
           
            Gestordesalida gs = new Gestordesalida();
            MySqlDataReader myReader;
           
            myReader = gs.verificarplaca(txtplaca.Text);


            if (myReader.Read())
            {




                lblhoraentrada.Visible = true;
                lblhorasalida.Visible = true;
                lbltotal.Visible = true;
                lbltiempoacobrar.Visible = true;
                lblfecha.Visible = true;
                lblhoraentrada.Text = myReader.GetString(1);
                
                DateTime horaentrada = Convert.ToDateTime(lblhoraentrada.Text);
                int totaldehoras = horaentrada.Hour;
                //MessageBox.Show(Convert.ToString(totaldehoras), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vehiculo = myReader.GetString(3).Trim(); 
                lbltipo.Text = myReader.GetString(3);
                fechaentrada = myReader.GetString(0);
                //MessageBox.Show(Convert.ToString(vehiculo), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //verificamos el precio por tipo de vehiculo y lo guardamos en la variable precio
                precioporhora pph = new precioporhora();


                lblhorasalida.Text = DateTime.Now.ToString("HH:mm:ss");
                lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                //dias
                DateTime fentrada = Convert.ToDateTime(fechaentrada);
                //MessageBox.Show(Convert.ToString( fentrada), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DateTime fsalida = dateTimePicker1.Value;
               
               
                
                //es esta variable tenemos los dias que se quedo en el parqueadero

                //MessageBox.Show(Convert.ToString(dias), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Horas
                DateTime entrada = fentrada;
                DateTime salida = fsalida;
                TimeSpan span = salida.Subtract(entrada);
                
              
              
                lbltiempoacobrar.Text =Convert.ToString( span);
                //MessageBox.Show(Convert.ToString(span), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int prueba = Convert.ToInt32(span.TotalMinutes);
                //dias = span.Days;
                
                // Aqui definimos cuantos cobramos dependiendo del vehiculo

                if (vehiculo == "Motocicleta".Trim())
                {
                    if (Convert.ToDouble(prueba) < 60)
                    {
                        lbltotal.Text = "20";
                    }else
                    if (Convert.ToDouble(prueba)>540)
                    {
                        int total = (Convert.ToInt32(prueba) * 7);
                        if (total < 5000)
                        {
                            lbltotal.Text = "60";
                        }
                        else
                        {
                            lbltotal.Text = Convert.ToString(prueba * 7);
                        }
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 360)
                    {

                        lbltotal.Text = "50";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 300)
                    {

                        lbltotal.Text = "40";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 240)
                    {

                        lbltotal.Text = "35";
                    }
                    else
                 
                  if (Convert.ToDouble(prueba) >= 60)
                    {
                        
                        lbltotal.Text = "30";
                    }
                    
                 
                }
                if (vehiculo == "Automovil".Trim())
                {
                    if (Convert.ToDouble(prueba) < 60)
                    {
                        lbltotal.Text = "30";
                    }
                    else
                    if (Convert.ToDouble(prueba) > 540)
                    {
                        int total = (Convert.ToInt32(prueba) * 11);
                        if (total < 8000)
                        {
                            lbltotal.Text = "60";
                        }
                        else
                        {
                            lbltotal.Text = Convert.ToString(prueba * 11);
                        }
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 360)
                    {

                        lbltotal.Text = "50";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 300)
                    {

                        lbltotal.Text = "45";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 240)
                    {

                        lbltotal.Text = "40";
                    }
                    else

                  if (Convert.ToDouble(prueba) >= 60)
                    {

                        lbltotal.Text = "35";
                    }


                }

                if (vehiculo == "Camion sencillo".Trim())
                {
                    if (Convert.ToDouble(prueba) < 60)
                    {
                        lbltotal.Text = "5000";
                    }
                    else
                    if (Convert.ToDouble(prueba) > 540)
                    {
                        int total = (Convert.ToInt32(prueba) * 14);
                        if (total < 10000)
                        {
                            lbltotal.Text = "10000";
                        }
                        else
                        {
                            lbltotal.Text = Convert.ToString(prueba * 14);
                        }
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 360)
                    {

                        lbltotal.Text = "8000";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 300)
                    {

                        lbltotal.Text = "7500";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 240)
                    {

                        lbltotal.Text = "7000";
                    }
                    else

                  if (Convert.ToDouble(prueba) >= 60)
                    {

                        lbltotal.Text = "6500";
                    }

                }
                if (vehiculo == "Doble troque".Trim())
                {
                    if (Convert.ToDouble(prueba) < 60)
                    {
                        lbltotal.Text = "5000";
                    }
                    else
                    if (Convert.ToDouble(prueba) > 540)
                    {
                        int total = (Convert.ToInt32(prueba) * 16);
                        if (total < 11000)
                        {
                            lbltotal.Text = "11000";
                        }
                        else
                        {
                            lbltotal.Text = Convert.ToString(prueba * 16);
                        }
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 360)
                    {

                        lbltotal.Text = "8000";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 300)
                    {

                        lbltotal.Text = "7500";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 240)
                    {

                        lbltotal.Text = "7000";
                    }
                    else

                  if (Convert.ToDouble(prueba) >= 60)
                    {

                        lbltotal.Text = "65000";
                    }



                }
                if (vehiculo == "Tracto mula".Trim())
                {
                    if (Convert.ToDouble(prueba) < 60)
                    {
                        lbltotal.Text = "6000";
                    }
                    else
                    if (Convert.ToDouble(prueba) > 540)
                    {
                        int total = (Convert.ToInt32(prueba) * 20);
                        if (total < 14000)
                        {
                            lbltotal.Text = "14000";
                        }
                        else
                        {
                            lbltotal.Text = Convert.ToString(prueba * 20);
                        }
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 360)
                    {

                        lbltotal.Text = "10000";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 300)
                    {

                        lbltotal.Text = "9500";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 240)
                    {

                        lbltotal.Text = "9000";
                    }
                    else

                  if (Convert.ToDouble(prueba) >= 60)
                    {

                        lbltotal.Text = "8500";
                    }


                }


              


                btncobrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Placa no encontrada", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtplaca.Clear();
                txtplaca.Focus();
            }



            }

        private void txtplaca_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    
}
