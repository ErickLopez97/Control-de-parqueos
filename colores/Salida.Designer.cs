namespace colores
{
    partial class Salida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblhoraentrada = new System.Windows.Forms.Label();
            this.lblhorasalida = new System.Windows.Forms.Label();
            this.lbltiempoacobrar = new System.Windows.Forms.Label();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btncobrar = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblcontador = new System.Windows.Forms.Label();
            this.lblparque = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese placa :";
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.txtplaca.Location = new System.Drawing.Point(388, 58);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(345, 43);
            this.txtplaca.TabIndex = 1;
            this.txtplaca.TextChanged += new System.EventHandler(this.txtplaca_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora de entrada :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(94, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora de salida :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiempo a cobrar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(86, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 45);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total a cobrar : Q";
            // 
            // lblhoraentrada
            // 
            this.lblhoraentrada.AutoSize = true;
            this.lblhoraentrada.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lblhoraentrada.ForeColor = System.Drawing.Color.Black;
            this.lblhoraentrada.Location = new System.Drawing.Point(411, 274);
            this.lblhoraentrada.Name = "lblhoraentrada";
            this.lblhoraentrada.Size = new System.Drawing.Size(138, 45);
            this.lblhoraentrada.TabIndex = 6;
            this.lblhoraentrada.Text = "Total  :";
            this.lblhoraentrada.Visible = false;
            // 
            // lblhorasalida
            // 
            this.lblhorasalida.AutoSize = true;
            this.lblhorasalida.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lblhorasalida.ForeColor = System.Drawing.Color.Black;
            this.lblhorasalida.Location = new System.Drawing.Point(411, 367);
            this.lblhorasalida.Name = "lblhorasalida";
            this.lblhorasalida.Size = new System.Drawing.Size(138, 45);
            this.lblhorasalida.TabIndex = 7;
            this.lblhorasalida.Text = "Total  :";
            this.lblhorasalida.Visible = false;
            // 
            // lbltiempoacobrar
            // 
            this.lbltiempoacobrar.AutoSize = true;
            this.lbltiempoacobrar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lbltiempoacobrar.ForeColor = System.Drawing.Color.Black;
            this.lbltiempoacobrar.Location = new System.Drawing.Point(411, 454);
            this.lbltiempoacobrar.Name = "lbltiempoacobrar";
            this.lbltiempoacobrar.Size = new System.Drawing.Size(138, 45);
            this.lbltiempoacobrar.TabIndex = 8;
            this.lbltiempoacobrar.Text = "Total  :";
            this.lbltiempoacobrar.Visible = false;
            // 
            // btnactivar
            // 
            this.btnactivar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btnactivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnactivar.Location = new System.Drawing.Point(859, 43);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(308, 87);
            this.btnactivar.TabIndex = 10;
            this.btnactivar.Text = "Activar";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // btncobrar
            // 
            this.btncobrar.Enabled = false;
            this.btncobrar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btncobrar.Image = global::colores.Properties.Resources.images__1_;
            this.btncobrar.Location = new System.Drawing.Point(859, 371);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(308, 243);
            this.btncobrar.TabIndex = 11;
            this.btncobrar.Text = "Cobrar";
            this.btncobrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lblfecha.ForeColor = System.Drawing.Color.Black;
            this.lblfecha.Location = new System.Drawing.Point(411, 165);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(138, 45);
            this.lblfecha.TabIndex = 13;
            this.lblfecha.Text = "Total  :";
            this.lblfecha.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(230, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 45);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha :";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(899, 299);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(40, 13);
            this.lbltipo.TabIndex = 14;
            this.lbltipo.Text = "Total  :";
            this.lbltipo.Visible = false;
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Location = new System.Drawing.Point(884, 248);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(40, 13);
            this.lblcontador.TabIndex = 16;
            this.lblcontador.Text = "Total  :";
            this.lblcontador.Visible = false;
            // 
            // lblparque
            // 
            this.lblparque.AutoSize = true;
            this.lblparque.Location = new System.Drawing.Point(884, 274);
            this.lblparque.Name = "lblparque";
            this.lblparque.Size = new System.Drawing.Size(68, 13);
            this.lblparque.TabIndex = 17;
            this.lblparque.Text = "Parqueadero";
            this.lblparque.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(785, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbltotal.Location = new System.Drawing.Point(411, 559);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(138, 45);
            this.lbltotal.TabIndex = 19;
            this.lbltotal.Text = "Total  :";
            this.lbltotal.Visible = false;
            // 
            // Salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblparque);
            this.Controls.Add(this.lblcontador);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.btnactivar);
            this.Controls.Add(this.lbltiempoacobrar);
            this.Controls.Add(this.lblhorasalida);
            this.Controls.Add(this.lblhoraentrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.label1);
            this.Name = "Salida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida";
            this.Load += new System.EventHandler(this.Salida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblhoraentrada;
        private System.Windows.Forms.Label lblhorasalida;
        private System.Windows.Forms.Label lbltiempoacobrar;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblcontador;
        private System.Windows.Forms.Label lblparque;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbltotal;
    }
}