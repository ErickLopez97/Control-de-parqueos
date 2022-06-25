namespace colores
{
    partial class egresos
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btncobrar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 31);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.Visible = false;
            // 
            // btncobrar
            // 
            this.btncobrar.Enabled = false;
            this.btncobrar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btncobrar.Image = global::colores.Properties.Resources.images__1_;
            this.btncobrar.Location = new System.Drawing.Point(607, 204);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(308, 243);
            this.btncobrar.TabIndex = 32;
            this.btncobrar.Text = "Registrar";
            this.btncobrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Font = new System.Drawing.Font("Tahoma", 48F);
            this.txtdescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtdescripcion.Location = new System.Drawing.Point(196, 100);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(719, 85);
            this.txtdescripcion.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descripcion :";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Tahoma", 48F);
            this.txttotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txttotal.Location = new System.Drawing.Point(196, 216);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(396, 85);
            this.txttotal.TabIndex = 36;
            this.txttotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(105, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Valor :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.SystemColors.Control;
            this.lblhora.Font = new System.Drawing.Font("Tahoma", 48F);
            this.lblhora.ForeColor = System.Drawing.Color.Black;
            this.lblhora.Location = new System.Drawing.Point(555, 9);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(201, 77);
            this.lblhora.TabIndex = 38;
            this.lblhora.Text = "label5";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.SystemColors.Control;
            this.lblfecha.Font = new System.Drawing.Font("Tahoma", 36F);
            this.lblfecha.ForeColor = System.Drawing.Color.Black;
            this.lblfecha.Location = new System.Drawing.Point(83, 22);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(150, 58);
            this.lblfecha.TabIndex = 37;
            this.lblfecha.Text = "label3";
            // 
            // egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 505);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncobrar);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "egresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egresos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.TextBox txtdescripcion;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
    }
}