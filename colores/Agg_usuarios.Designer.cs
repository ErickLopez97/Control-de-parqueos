namespace colores
{
    partial class Agg_usuarios
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
            this.ckvercontra = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcontraseña_user = new System.Windows.Forms.TextBox();
            this.txtnombre_user = new System.Windows.Forms.TextBox();
            this.txtcedula_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckvercontra
            // 
            this.ckvercontra.AutoSize = true;
            this.ckvercontra.Location = new System.Drawing.Point(189, 217);
            this.ckvercontra.Name = "ckvercontra";
            this.ckvercontra.Size = new System.Drawing.Size(98, 17);
            this.ckvercontra.TabIndex = 28;
            this.ckvercontra.Text = "Ver contraseña";
            this.ckvercontra.UseVisualStyleBackColor = true;
            this.ckvercontra.CheckedChanged += new System.EventHandler(this.ckvercontra_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.comboBox1.Location = new System.Drawing.Point(182, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cargo :";
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(182, 354);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(123, 36);
            this.btnguardar.TabIndex = 25;
            this.btnguardar.Text = "✔ Crear";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtcontraseña_user
            // 
            this.txtcontraseña_user.Location = new System.Drawing.Point(189, 182);
            this.txtcontraseña_user.Name = "txtcontraseña_user";
            this.txtcontraseña_user.Size = new System.Drawing.Size(116, 20);
            this.txtcontraseña_user.TabIndex = 24;
            this.txtcontraseña_user.UseSystemPasswordChar = true;
            // 
            // txtnombre_user
            // 
            this.txtnombre_user.Location = new System.Drawing.Point(189, 136);
            this.txtnombre_user.Name = "txtnombre_user";
            this.txtnombre_user.Size = new System.Drawing.Size(116, 20);
            this.txtnombre_user.TabIndex = 23;
            // 
            // txtcedula_user
            // 
            this.txtcedula_user.BackColor = System.Drawing.Color.White;
            this.txtcedula_user.ForeColor = System.Drawing.Color.Black;
            this.txtcedula_user.Location = new System.Drawing.Point(189, 93);
            this.txtcedula_user.Name = "txtcedula_user";
            this.txtcedula_user.Size = new System.Drawing.Size(116, 20);
            this.txtcedula_user.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Contraseña :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Creacion de usuarios";
            // 
            // Agg_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 489);
            this.Controls.Add(this.ckvercontra);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcontraseña_user);
            this.Controls.Add(this.txtnombre_user);
            this.Controls.Add(this.txtcedula_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agg_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            this.Load += new System.EventHandler(this.Agg_usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckvercontra;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtcontraseña_user;
        private System.Windows.Forms.TextBox txtnombre_user;
        private System.Windows.Forms.TextBox txtcedula_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}