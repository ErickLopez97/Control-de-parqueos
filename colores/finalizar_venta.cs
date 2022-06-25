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
    public partial class finalizar_venta : Form
    {
        public finalizar_venta()
        {
            InitializeComponent();
        }

        private void finalizar_venta_Load(object sender, EventArgs e)
        {
            txtrecibo.Focus();
            lbltotal.Text = Convert.ToString(Salida.total);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter)
            {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void txtrecibo_TextChanged(object sender, EventArgs e)
        {
            //Validamos que ingrese numeros, y ademas si lo que entregan es menos de lo que vamos a cobrar saldra en rojo de lo contrario
            //Saldra el verde
            int ejm = 0;
            if (int.TryParse(txtrecibo.Text, out ejm))
            {
                if (Convert.ToInt32(txtrecibo.Text) < Convert.ToInt32(lbltotal.Text))
                {
                    lbldevolver.BackColor = Color.Red;
                }
                else
                { lbldevolver.BackColor = Color.Green; }

                lbldevolver.Text = Convert.ToString(Convert.ToInt32(txtrecibo.Text) - Convert.ToInt32(lbltotal.Text));

            }
            else
            {
                MessageBox.Show("Ingrese Cantidad ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtrecibo.Select();
                txtrecibo.Clear();
            }
        }
    }
}
