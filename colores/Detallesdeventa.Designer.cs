namespace colores
{
    partial class Detallesdeventa
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
            this.lbltotalventas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfiltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnreporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotalventas
            // 
            this.lbltotalventas.AutoSize = true;
            this.lbltotalventas.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lbltotalventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbltotalventas.Location = new System.Drawing.Point(703, 284);
            this.lbltotalventas.Name = "lbltotalventas";
            this.lbltotalventas.Size = new System.Drawing.Size(40, 45);
            this.lbltotalventas.TabIndex = 14;
            this.lbltotalventas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(367, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 45);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total de ventas :";
            // 
            // btnfiltar
            // 
            this.btnfiltar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btnfiltar.Location = new System.Drawing.Point(29, 242);
            this.btnfiltar.Name = "btnfiltar";
            this.btnfiltar.Size = new System.Drawing.Size(308, 87);
            this.btnfiltar.TabIndex = 12;
            this.btnfiltar.Text = "♒ Filtar";
            this.btnfiltar.UseVisualStyleBackColor = true;
            this.btnfiltar.Click += new System.EventHandler(this.btnfiltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(747, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasta";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Desde";
            this.label1.Visible = false;
            // 
            // fecha2
            // 
            this.fecha2.CustomFormat = "dd/MM/yyyy";
            this.fecha2.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.fecha2.Location = new System.Drawing.Point(755, 135);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(516, 43);
            this.fecha2.TabIndex = 9;
            this.fecha2.Visible = false;
            // 
            // fecha1
            // 
            this.fecha1.CustomFormat = "dd/MM/yyyy";
            this.fecha1.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.fecha1.Location = new System.Drawing.Point(29, 135);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(521, 43);
            this.fecha1.TabIndex = 8;
            this.fecha1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 358);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 365);
            this.dataGridView1.TabIndex = 15;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(29, 358);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1256, 368);
            this.crystalReportViewer1.TabIndex = 16;
            this.crystalReportViewer1.Visible = false;
            // 
            // btnreporte
            // 
            this.btnreporte.Enabled = false;
            this.btnreporte.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btnreporte.Location = new System.Drawing.Point(977, 242);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(308, 87);
            this.btnreporte.TabIndex = 17;
            this.btnreporte.Text = "♒ Imprimir";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // Detallesdeventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltotalventas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnfiltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detallesdeventa";
            this.Text = "Detallesdeventa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Detallesdeventa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotalventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfiltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnreporte;
    }
}