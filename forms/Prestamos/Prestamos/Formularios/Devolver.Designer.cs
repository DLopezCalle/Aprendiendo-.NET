namespace Prestamos.Formularios
{
    partial class Devolver
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
            this.dgvNoDevueltos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoDevueltos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNoDevueltos
            // 
            this.dgvNoDevueltos.AllowUserToAddRows = false;
            this.dgvNoDevueltos.AllowUserToDeleteRows = false;
            this.dgvNoDevueltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoDevueltos.Location = new System.Drawing.Point(12, 68);
            this.dgvNoDevueltos.Name = "dgvNoDevueltos";
            this.dgvNoDevueltos.ReadOnly = true;
            this.dgvNoDevueltos.Size = new System.Drawing.Size(776, 183);
            this.dgvNoDevueltos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prestamos sin devolver";
            // 
            // btnDevolver
            // 
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(314, 304);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(170, 62);
            this.btnDevolver.TabIndex = 2;
            this.btnDevolver.Text = "Devolver libro";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // Devolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNoDevueltos);
            this.Name = "Devolver";
            this.Text = "Devolver";
            this.Load += new System.EventHandler(this.Devolver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoDevueltos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNoDevueltos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDevolver;
    }
}