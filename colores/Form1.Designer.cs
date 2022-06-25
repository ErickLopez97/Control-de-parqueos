namespace colores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreprogram = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.txtescriba = new System.Windows.Forms.TextBox();
            this.ckver = new System.Windows.Forms.CheckBox();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btnatras = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosEnLavadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnegresos = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnlavado = new System.Windows.Forms.Button();
            this.btnparqueadero = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombreprogram);
            this.groupBox1.Controls.Add(this.lblmensaje);
            this.groupBox1.Controls.Add(this.txtescriba);
            this.groupBox1.Controls.Add(this.ckver);
            this.groupBox1.Controls.Add(this.btnsiguiente);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.btnatras);
            this.groupBox1.Controls.Add(this.btniniciar);
            this.groupBox1.Location = new System.Drawing.Point(533, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 233);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // nombreprogram
            // 
            this.nombreprogram.AutoSize = true;
            this.nombreprogram.BackColor = System.Drawing.SystemColors.Control;
            this.nombreprogram.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreprogram.ForeColor = System.Drawing.Color.Black;
            this.nombreprogram.Location = new System.Drawing.Point(136, 33);
            this.nombreprogram.Name = "nombreprogram";
            this.nombreprogram.Size = new System.Drawing.Size(154, 26);
            this.nombreprogram.TabIndex = 32;
            this.nombreprogram.Text = "Parqueo Público";
            this.nombreprogram.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.SystemColors.Control;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.ForeColor = System.Drawing.Color.Black;
            this.lblmensaje.Location = new System.Drawing.Point(43, 83);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(77, 18);
            this.lblmensaje.TabIndex = 25;
            this.lblmensaje.Text = "Usuario :";
            // 
            // txtescriba
            // 
            this.txtescriba.Location = new System.Drawing.Point(149, 84);
            this.txtescriba.Name = "txtescriba";
            this.txtescriba.Size = new System.Drawing.Size(116, 20);
            this.txtescriba.TabIndex = 26;
            // 
            // ckver
            // 
            this.ckver.AutoSize = true;
            this.ckver.ForeColor = System.Drawing.Color.Black;
            this.ckver.Location = new System.Drawing.Point(158, 120);
            this.ckver.Name = "ckver";
            this.ckver.Size = new System.Drawing.Size(101, 17);
            this.ckver.TabIndex = 31;
            this.ckver.Text = "Ver contraseña ";
            this.ckver.UseVisualStyleBackColor = true;
            this.ckver.Visible = false;
            this.ckver.CheckedChanged += new System.EventHandler(this.ckver_CheckedChanged);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.Location = new System.Drawing.Point(62, 153);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(267, 33);
            this.btnsiguiente.TabIndex = 27;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Black;
            this.lblusuario.Location = new System.Drawing.Point(182, 33);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(57, 20);
            this.lblusuario.TabIndex = 30;
            this.lblusuario.Text = "label1";
            this.lblusuario.Visible = false;
            // 
            // btnatras
            // 
            this.btnatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Location = new System.Drawing.Point(103, 162);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(75, 33);
            this.btnatras.TabIndex = 28;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Visible = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btniniciar
            // 
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.Location = new System.Drawing.Point(245, 162);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(75, 33);
            this.btniniciar.TabIndex = 29;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Visible = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(669, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasToolStripMenuItem,
            this.nuevoUsuarioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vehiculosToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentaToolStripMenuItem,
            this.liquidarToolStripMenuItem,
            this.carrosEnLavadoToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // reporteDeVentaToolStripMenuItem
            // 
            this.reporteDeVentaToolStripMenuItem.Name = "reporteDeVentaToolStripMenuItem";
            this.reporteDeVentaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reporteDeVentaToolStripMenuItem.Text = "Reporte de venta";
            this.reporteDeVentaToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentaToolStripMenuItem_Click);
            // 
            // liquidarToolStripMenuItem
            // 
            this.liquidarToolStripMenuItem.Name = "liquidarToolStripMenuItem";
            this.liquidarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.liquidarToolStripMenuItem.Text = "Liquidar";
            this.liquidarToolStripMenuItem.Click += new System.EventHandler(this.liquidarToolStripMenuItem_Click);
            // 
            // carrosEnLavadoToolStripMenuItem
            // 
            this.carrosEnLavadoToolStripMenuItem.Name = "carrosEnLavadoToolStripMenuItem";
            this.carrosEnLavadoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.carrosEnLavadoToolStripMenuItem.Text = "Carros en lavado";
            this.carrosEnLavadoToolStripMenuItem.Click += new System.EventHandler(this.carrosEnLavadoToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1458, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Version 1.1 ";
            // 
            // btnegresos
            // 
            this.btnegresos.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnegresos.Image = global::colores.Properties.Resources.download1;
            this.btnegresos.Location = new System.Drawing.Point(554, 372);
            this.btnegresos.Name = "btnegresos";
            this.btnegresos.Size = new System.Drawing.Size(358, 323);
            this.btnegresos.TabIndex = 23;
            this.btnegresos.Text = "SALIDAS";
            this.btnegresos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnegresos.UseVisualStyleBackColor = true;
            this.btnegresos.Visible = false;
            this.btnegresos.Click += new System.EventHandler(this.btnegresos_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnclientes.Image = global::colores.Properties.Resources.download;
            this.btnclientes.Location = new System.Drawing.Point(937, 372);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(358, 323);
            this.btnclientes.TabIndex = 21;
            this.btnclientes.Text = "CLIENTES";
            this.btnclientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Visible = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnlavado
            // 
            this.btnlavado.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlavado.Image = global::colores.Properties.Resources.images;
            this.btnlavado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlavado.Location = new System.Drawing.Point(937, 43);
            this.btnlavado.Name = "btnlavado";
            this.btnlavado.Size = new System.Drawing.Size(358, 323);
            this.btnlavado.TabIndex = 1;
            this.btnlavado.Text = "SERVICIO DE LAVADO";
            this.btnlavado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlavado.UseVisualStyleBackColor = true;
            this.btnlavado.Visible = false;
            this.btnlavado.Click += new System.EventHandler(this.btnlavado_Click);
            // 
            // btnparqueadero
            // 
            this.btnparqueadero.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnparqueadero.Image = global::colores.Properties.Resources.parqueadero;
            this.btnparqueadero.Location = new System.Drawing.Point(139, 43);
            this.btnparqueadero.Name = "btnparqueadero";
            this.btnparqueadero.Size = new System.Drawing.Size(358, 323);
            this.btnparqueadero.TabIndex = 0;
            this.btnparqueadero.UseVisualStyleBackColor = true;
            this.btnparqueadero.Visible = false;
            this.btnparqueadero.Click += new System.EventHandler(this.btnparqueadero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnegresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlavado);
            this.Controls.Add(this.btnparqueadero);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnparqueadero;
        private System.Windows.Forms.Button btnlavado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nombreprogram;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.TextBox txtescriba;
        private System.Windows.Forms.CheckBox ckver;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Button btniniciar;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Button btnclientes;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.Button btnegresos;
        private System.Windows.Forms.ToolStripMenuItem liquidarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosEnLavadoToolStripMenuItem;
    }
}

