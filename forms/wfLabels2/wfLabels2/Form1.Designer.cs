namespace wfLabels2
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
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAmarillo = new System.Windows.Forms.Label();
            this.lblResetear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRojo.Location = new System.Drawing.Point(430, 133);
            this.lblRojo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(53, 24);
            this.lblRojo.TabIndex = 0;
            this.lblRojo.Text = "Rojo";
            this.lblRojo.Click += new System.EventHandler(this.lblRojo_Click_1);
            this.lblRojo.MouseHover += new System.EventHandler(this.lblRojo_MouseHover);
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde.Location = new System.Drawing.Point(424, 175);
            this.lblVerde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(67, 24);
            this.lblVerde.TabIndex = 1;
            this.lblVerde.Text = "Verde";
            this.lblVerde.Click += new System.EventHandler(this.lblVerde_Click);
            this.lblVerde.MouseHover += new System.EventHandler(this.lblVerde_MouseHover);
            // 
            // lblAmarillo
            // 
            this.lblAmarillo.AutoSize = true;
            this.lblAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmarillo.Location = new System.Drawing.Point(415, 218);
            this.lblAmarillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmarillo.Name = "lblAmarillo";
            this.lblAmarillo.Size = new System.Drawing.Size(86, 24);
            this.lblAmarillo.TabIndex = 2;
            this.lblAmarillo.Text = "Amarillo";
            this.lblAmarillo.Click += new System.EventHandler(this.lblAmarillo_Click_1);
            this.lblAmarillo.MouseHover += new System.EventHandler(this.lblAmarillo_MouseHover);
            // 
            // lblResetear
            // 
            this.lblResetear.AutoSize = true;
            this.lblResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetear.Location = new System.Drawing.Point(411, 258);
            this.lblResetear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResetear.Name = "lblResetear";
            this.lblResetear.Size = new System.Drawing.Size(93, 24);
            this.lblResetear.TabIndex = 3;
            this.lblResetear.Text = "Resetear";
            this.lblResetear.Click += new System.EventHandler(this.lblResetear_Click);
            this.lblResetear.MouseHover += new System.EventHandler(this.lblResetear_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.lblResetear);
            this.Controls.Add(this.lblAmarillo);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblRojo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAmarillo;
        private System.Windows.Forms.Label lblResetear;
    }
}

