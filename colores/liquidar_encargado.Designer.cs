namespace colores
{
    partial class liquidar_encargado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotalventas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 154);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(729, 284);
            this.dataGridView1.TabIndex = 21;
            // 
            // fecha1
            // 
            this.fecha1.CustomFormat = "dd/MM/yyyy";
            this.fecha1.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.fecha1.Location = new System.Drawing.Point(30, 71);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(129, 43);
            this.fecha1.TabIndex = 22;
            this.fecha1.Visible = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.txtbuscar.Location = new System.Drawing.Point(254, 26);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(260, 33);
            this.txtbuscar.TabIndex = 24;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.Location = new System.Drawing.Point(534, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(195, 55);
            this.btnbuscar.TabIndex = 23;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ingrese nombre :";
            // 
            // lbltotalventas
            // 
            this.lbltotalventas.AutoSize = true;
            this.lbltotalventas.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lbltotalventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbltotalventas.Location = new System.Drawing.Point(492, 89);
            this.lbltotalventas.Name = "lbltotalventas";
            this.lbltotalventas.Size = new System.Drawing.Size(40, 45);
            this.lbltotalventas.TabIndex = 27;
            this.lbltotalventas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(189, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 45);
            this.label3.TabIndex = 26;
            this.label3.Text = "Liquidacion :";
            // 
            // liquidar_encargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotalventas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "liquidar_encargado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "liquidar_encargado";
            this.Load += new System.EventHandler(this.liquidar_encargado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalventas;
        private System.Windows.Forms.Label label3;
    }
}