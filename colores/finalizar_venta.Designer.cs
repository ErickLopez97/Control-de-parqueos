namespace colores
{
    partial class finalizar_venta
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
            this.txtrecibo = new System.Windows.Forms.TextBox();
            this.lbldevolver = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtrecibo
            // 
            this.txtrecibo.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.txtrecibo.ForeColor = System.Drawing.Color.Green;
            this.txtrecibo.Location = new System.Drawing.Point(209, 98);
            this.txtrecibo.Name = "txtrecibo";
            this.txtrecibo.Size = new System.Drawing.Size(100, 52);
            this.txtrecibo.TabIndex = 26;
            this.txtrecibo.Text = "0";
            this.txtrecibo.TextChanged += new System.EventHandler(this.txtrecibo_TextChanged);
            // 
            // lbldevolver
            // 
            this.lbldevolver.AutoSize = true;
            this.lbldevolver.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lbldevolver.Location = new System.Drawing.Point(213, 187);
            this.lbldevolver.Name = "lbldevolver";
            this.lbldevolver.Size = new System.Drawing.Size(40, 45);
            this.lbldevolver.TabIndex = 25;
            this.lbldevolver.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label6.Location = new System.Drawing.Point(22, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 45);
            this.label6.TabIndex = 24;
            this.label6.Text = "Devolver :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 45);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ricibido :";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lbltotal.Location = new System.Drawing.Point(201, 28);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(100, 45);
            this.lbltotal.TabIndex = 22;
            this.lbltotal.Text = "1200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 45);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total : ";
            // 
            // finalizar_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 262);
            this.Controls.Add(this.txtrecibo);
            this.Controls.Add(this.lbldevolver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label4);
            this.Name = "finalizar_venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "finalizar_venta";
            this.Load += new System.EventHandler(this.finalizar_venta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtrecibo;
        private System.Windows.Forms.Label lbldevolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label4;
    }
}