namespace colores
{
    partial class Parqueadero_ingreso
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
            this.components = new System.ComponentModel.Container();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnactivar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblplaca = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncobrar = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.crreports1 = new colores.Crreports();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtplaca
            // 
            this.txtplaca.Enabled = false;
            this.txtplaca.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaca.Location = new System.Drawing.Point(1095, 74);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(196, 43);
            this.txtplaca.TabIndex = 0;
            this.txtplaca.TextChanged += new System.EventHandler(this.txtplaca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(874, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite la placa :";
            // 
            // btnactivar
            // 
            this.btnactivar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btnactivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnactivar.Location = new System.Drawing.Point(1018, 161);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(308, 87);
            this.btnactivar.TabIndex = 4;
            this.btnactivar.Text = "Ingresar";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(194, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Placa :";
            this.label2.Visible = false;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lblplaca.ForeColor = System.Drawing.Color.Black;
            this.lblplaca.Location = new System.Drawing.Point(328, 351);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(128, 45);
            this.lblplaca.TabIndex = 6;
            this.lblplaca.Text = "Placa :";
            this.lblplaca.Visible = false;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.Color.Black;
            this.lbltipo.Location = new System.Drawing.Point(328, 248);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(90, 45);
            this.lbltipo.TabIndex = 8;
            this.lbltipo.Text = "Tipo";
            this.lbltipo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de vehiculo :";
            this.label4.Visible = false;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btnconfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnconfirmar.Location = new System.Drawing.Point(608, 518);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(282, 100);
            this.btnconfirmar.TabIndex = 9;
            this.btnconfirmar.Text = "Aceptar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Visible = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btncancelar.ForeColor = System.Drawing.Color.Red;
            this.btncancelar.Location = new System.Drawing.Point(1009, 518);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(282, 100);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncobrar
            // 
            this.btncobrar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btncobrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncobrar.Image = global::colores.Properties.Resources.images__1_;
            this.btncobrar.Location = new System.Drawing.Point(1018, 254);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(308, 243);
            this.btncobrar.TabIndex = 11;
            this.btncobrar.Text = "Facturar Salida";
            this.btncobrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Black;
            this.lblfecha.Location = new System.Drawing.Point(669, 190);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(150, 58);
            this.lblfecha.TabIndex = 12;
            this.lblfecha.Text = "label3";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.Black;
            this.lblhora.Location = new System.Drawing.Point(646, 319);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(201, 77);
            this.lblhora.TabIndex = 13;
            this.lblhora.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(558, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(82, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seleccione vehiculo ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Motocicleta",
            "Automovil"});
            this.comboBox1.Location = new System.Drawing.Point(90, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 43);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Parqueadero_ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnactivar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtplaca);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "Parqueadero_ingreso";
            this.Text = "Parqueadero_ingreso";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.Parqueadero_ingreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Crreports crreports1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}