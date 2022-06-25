namespace colores
{
    partial class lavado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.btncobrar = new System.Windows.Forms.Button();
            this.lbltipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblplaca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblencargado = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese placa :";
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.txtplaca.ForeColor = System.Drawing.Color.Black;
            this.txtplaca.Location = new System.Drawing.Point(63, 93);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(232, 43);
            this.txtplaca.TabIndex = 2;
            // 
            // btncobrar
            // 
            this.btncobrar.Enabled = false;
            this.btncobrar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btncobrar.Image = global::colores.Properties.Resources.images__1_;
            this.btncobrar.Location = new System.Drawing.Point(897, 445);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(308, 243);
            this.btncobrar.TabIndex = 3;
            this.btncobrar.Text = "Registrar";
            this.btncobrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lbltipo.ForeColor = System.Drawing.Color.Black;
            this.lbltipo.Location = new System.Drawing.Point(420, 353);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(90, 45);
            this.lbltipo.TabIndex = 12;
            this.lbltipo.Text = "Tipo";
            this.lbltipo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(55, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo de vehiculo :";
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lblplaca.ForeColor = System.Drawing.Color.Black;
            this.lblplaca.Location = new System.Drawing.Point(420, 466);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(128, 45);
            this.lblplaca.TabIndex = 10;
            this.lblplaca.Text = "Placa :";
            this.lblplaca.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(237, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placa :";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Tahoma", 48F);
            this.lblhora.ForeColor = System.Drawing.Color.Black;
            this.lblhora.Location = new System.Drawing.Point(732, 195);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(201, 77);
            this.lblhora.TabIndex = 15;
            this.lblhora.Text = "label5";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lblfecha.ForeColor = System.Drawing.Color.Black;
            this.lblfecha.Location = new System.Drawing.Point(747, 93);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(150, 58);
            this.lblfecha.TabIndex = 14;
            this.lblfecha.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(239, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 45);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(421, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Visible = false;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Tahoma", 48F);
            this.txttotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txttotal.Location = new System.Drawing.Point(429, 552);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(377, 85);
            this.txttotal.TabIndex = 20;
            this.txttotal.Visible = false;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(150, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 45);
            this.label6.TabIndex = 21;
            this.label6.Text = "Encargado :";
            // 
            // lblencargado
            // 
            this.lblencargado.AutoSize = true;
            this.lblencargado.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lblencargado.ForeColor = System.Drawing.Color.Black;
            this.lblencargado.Location = new System.Drawing.Point(420, 280);
            this.lblencargado.Name = "lblencargado";
            this.lblencargado.Size = new System.Drawing.Size(190, 45);
            this.lblencargado.TabIndex = 22;
            this.lblencargado.Text = "Encargado";
            this.lblencargado.Visible = false;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btnconfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnconfirmar.Location = new System.Drawing.Point(339, 60);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(282, 100);
            this.btnconfirmar.TabIndex = 23;
            this.btnconfirmar.Text = "Aceptar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(55, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 45);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha de recibo :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(410, 420);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 25;
            this.dateTimePicker2.Visible = false;
            // 
            // lavado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1296, 749);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.lblencargado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lavado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lavado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.lavado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblencargado;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}