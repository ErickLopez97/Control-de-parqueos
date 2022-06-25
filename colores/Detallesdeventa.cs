using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace colores
{
    public partial class Detallesdeventa : Form
    {
        public Detallesdeventa()
        {
            InitializeComponent();
        }
        int egresos;
        private void btnfiltar_Click(object sender, EventArgs e)
        {
            filtar();
           
            btnreporte.Enabled = true;

        }


        public void filtar()
        {
            string ventas;
            
            //convertimos los datetime en string para su filtracion
            gestordetalledeventa gv = new gestordetalledeventa();
            DataTable dt = new DataTable();
            string m1 = Convert.ToString(fecha1.Value.Month);
            string a1 = Convert.ToString(fecha1.Value.Year);
            string d1 = Convert.ToString(fecha1.Value.Day);

            string m2 = Convert.ToString(fecha2.Value.Month);
            string a2 = Convert.ToString(fecha2.Value.Year);
            string d2 = Convert.ToString(fecha2.Value.Day);
            //Esto lo hago para ponerle un cero a todos los numeros de 1 a 9
            if (Convert.ToInt32(d1) < 10) { d1 = 0 + d1; }
            if (Convert.ToInt32(d2) < 10) { d2 = 0 + d2; }
            if (Convert.ToInt32(m1) < 10) { m1 = 0 + m1; }
            if (Convert.ToInt32(m2) < 10) { m2 = 0 + m2; }
            string f1 = (a1 + m1 + d1);
            string f2 = (a2 + m2 + d2);
            try
            {
                total_de_egresos tde = new total_de_egresos();
                MySqlDataReader My;
                My = tde.totalventasfiltrada(f1, f2);
                if (My.Read())
                {
                    egresos = My.GetInt32(0);
                }

                total_de_ventas_detallada tdvd = new total_de_ventas_detallada();
                MySqlDataReader myReader;
                myReader = tdvd.totalventasfiltrada(f1, f2);
                if (myReader.Read())
                {
                    //Mostrador el total de ventas el un label
                    ventas = Convert.ToString(myReader.GetInt32(0));
                    lbltotalventas.Text =Convert.ToString( Convert.ToInt32( ventas )-  egresos);
                    dt.Load(gv.mostrarventaspormes(f1, f2));
                    dataGridView1.DataSource = dt;




                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Fechas filtradas no tiene ventas. Si tienes dudas hable con encargado de sistema. " + error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

       /* public void flitra2()
        {

            datoscrystal dc = new datoscrystal();

            dc.Registrar(Convert.ToDateTime(fecha1.Value.Date), Convert.ToDateTime(fecha2.Value.Date), Convert.ToInt32(lbltotalventas.Text));
            MySqlDataReader my;
            mostrardatoscrystal mdc = new mostrardatoscrystal();
            DataTable dt1 = new DataTable();
            my = mdc.mostrardatos();
            if (my.Read())
            {
                dt1.Load(mdc.mostrardatos());
                dataGridView2.DataSource = dt1;
            }
            else { MessageBox.Show("hola", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        */
        private void Detallesdeventa_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            string cargo = Form1.cargo;
            if (cargo == "Admi")
            {
                fecha1.Visible = true;
                fecha2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
            
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            try
            {
                //Mostramos lo que tiene la tabla ventas
                DsReports ds = new DsReports();
                int filas = dataGridView1.Rows.Count;

                for (int i = 0; i <= filas - 2; i++)
                {
                    ds.Tables[0].Rows.Add
                        (new object[] { dataGridView1[ 0,i].Value.ToString(),
                    dataGridView1[ 1,i].Value.ToString(),
                    dataGridView1[ 2,i].Value.ToString(),
                    dataGridView1[ 3,i].Value.ToString(),
                    dataGridView1[ 4,i].Value.ToString(),
                    dataGridView1[ 5,i].Value.ToString(),
                    dataGridView1[ 6,i].Value.ToString(),
                    dataGridView1[ 7,i].Value.ToString(),
                    dataGridView1[ 8,i].Value.ToString(),
                    dataGridView1[ 9,i].Value.ToString(),
                    dataGridView1[ 10,i].Value.ToString(),




                        });
                }
                ReportDocument Orep = new ReportDocument();
                 Orep.Load("C:/Users/Cristian cano/Desktop/Programacion C#/Proyectos/colores/colores/Crreports.rpt");
                //Orep.Load("C:/Users/Cristian Cano/Desktop/Instalador/Crreports.rpt");
                Orep.SetDataSource(ds);
                crystalReportViewer1.ReportSource = Orep;
                crystalReportViewer1.Visible = true;
            
            }
            catch (Exception error)
            {
                MessageBox.Show("No se puede ver el reporte. Llame al encargado del programa." + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                


            }

            //mostramos lo que tiene la tabla total_ventas
            /* DsReports ds = new DsReports();
              int filas = dataGridView2.Rows.Count;

              for (int i = 0; i <= filas - 2; i++)
              {
                  ds.Tables[0].Rows.Add
                      (new object[] { dataGridView2[ 0,i].Value.ToString(),
                      dataGridView2[ 1,i].Value.ToString(),
                      dataGridView2[ 2,i].Value.ToString(),




                      });
              }
              ReportDocument Orep = new ReportDocument();
              Orep.Load("C:/Users/Estefania/source/repos/colores/colores/Crreports.rpt");
              Orep.SetDataSource(ds);
              crystalReportViewer1.ReportSource = Orep;
              crystalReportViewer1.Visible = true;
              */
        }
    
    }
}
