namespace CLINICA
{
    partial class CLINICA
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
            this.LblBienvenida = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblBienvenida
            // 
            this.LblBienvenida.AutoSize = true;
            this.LblBienvenida.Location = new System.Drawing.Point(205, 109);
            this.LblBienvenida.Name = "LblBienvenida";
            this.LblBienvenida.Size = new System.Drawing.Size(0, 15);
            this.LblBienvenida.TabIndex = 0;
            this.LblBienvenida.UseWaitCursor = true;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEntrar.BackgroundImage = global::CLINICA.Properties.Resources.fondo;
            this.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEntrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.Black;
            this.BtnEntrar.Image = global::CLINICA.Properties.Resources.icono_pantallas;
            this.BtnEntrar.Location = new System.Drawing.Point(325, 200);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(260, 219);
            this.BtnEntrar.TabIndex = 1;
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.UseWaitCursor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.ForeColor = System.Drawing.Color.Red;
            this.LblTexto.Location = new System.Drawing.Point(478, 134);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(397, 32);
            this.LblTexto.TabIndex = 2;
            this.LblTexto.Text = "Bienvenido a su Aplicacion !!";
            // 
            // CLINICA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(923, 431);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.LblBienvenida);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CLINICA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLINICA";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CLINICA_FormClosed);
            this.Load += new System.EventHandler(this.CLINICA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBienvenida;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Label LblTexto;
    }
}

