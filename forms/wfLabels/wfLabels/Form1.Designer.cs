namespace wfLabels
{
    partial class AplicacionLabel
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
            this.lblJava = new System.Windows.Forms.Label();
            this.lblPhp = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblCs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJava
            // 
            this.lblJava.AutoSize = true;
            this.lblJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJava.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblJava.Location = new System.Drawing.Point(95, 55);
            this.lblJava.Name = "lblJava";
            this.lblJava.Size = new System.Drawing.Size(30, 13);
            this.lblJava.TabIndex = 0;
            this.lblJava.Text = "Java";
            // 
            // lblPhp
            // 
            this.lblPhp.AutoSize = true;
            this.lblPhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPhp.Location = new System.Drawing.Point(95, 121);
            this.lblPhp.Name = "lblPhp";
            this.lblPhp.Size = new System.Drawing.Size(29, 13);
            this.lblPhp.TabIndex = 1;
            this.lblPhp.Text = "PHP";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblC.Location = new System.Drawing.Point(95, 179);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "C";
            // 
            // lblCs
            // 
            this.lblCs.AutoSize = true;
            this.lblCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCs.Location = new System.Drawing.Point(95, 231);
            this.lblCs.Name = "lblCs";
            this.lblCs.Size = new System.Drawing.Size(21, 13);
            this.lblCs.TabIndex = 3;
            this.lblCs.Text = "C#";
            this.lblCs.Click += new System.EventHandler(this.lblCs_Click);
            // 
            // AplicacionLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCs);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblPhp);
            this.Controls.Add(this.lblJava);
            this.Name = "AplicacionLabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJava;
        private System.Windows.Forms.Label lblPhp;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblCs;
    }
}

