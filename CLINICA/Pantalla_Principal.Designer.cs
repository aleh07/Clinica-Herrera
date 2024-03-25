namespace CLINICA
{
    partial class Pantalla_Principal
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
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.LblPacientes = new System.Windows.Forms.Label();
            this.LblTurnos = new System.Windows.Forms.Label();
            this.LblMedicos = new System.Windows.Forms.Label();
            this.BtnPacientes = new System.Windows.Forms.Button();
            this.BtnMedicos = new System.Windows.Forms.Button();
            this.BtnTurnos = new System.Windows.Forms.Button();
            this.LblTexto = new System.Windows.Forms.Label();
            this.PnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PnlPrincipal.Controls.Add(this.LblPacientes);
            this.PnlPrincipal.Controls.Add(this.LblTurnos);
            this.PnlPrincipal.Controls.Add(this.LblMedicos);
            this.PnlPrincipal.Controls.Add(this.BtnPacientes);
            this.PnlPrincipal.Controls.Add(this.BtnMedicos);
            this.PnlPrincipal.Controls.Add(this.BtnTurnos);
            this.PnlPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PnlPrincipal.Location = new System.Drawing.Point(158, 133);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(574, 237);
            this.PnlPrincipal.TabIndex = 3;
            this.PnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LblPacientes
            // 
            this.LblPacientes.AutoSize = true;
            this.LblPacientes.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPacientes.ForeColor = System.Drawing.Color.Black;
            this.LblPacientes.Location = new System.Drawing.Point(437, 41);
            this.LblPacientes.Name = "LblPacientes";
            this.LblPacientes.Size = new System.Drawing.Size(84, 19);
            this.LblPacientes.TabIndex = 5;
            this.LblPacientes.Text = "Pacientes";
            // 
            // LblTurnos
            // 
            this.LblTurnos.AutoSize = true;
            this.LblTurnos.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTurnos.ForeColor = System.Drawing.Color.Black;
            this.LblTurnos.Location = new System.Drawing.Point(261, 41);
            this.LblTurnos.Name = "LblTurnos";
            this.LblTurnos.Size = new System.Drawing.Size(63, 19);
            this.LblTurnos.TabIndex = 4;
            this.LblTurnos.Text = "Turnos";
            // 
            // LblMedicos
            // 
            this.LblMedicos.AutoSize = true;
            this.LblMedicos.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicos.ForeColor = System.Drawing.Color.Black;
            this.LblMedicos.Location = new System.Drawing.Point(63, 41);
            this.LblMedicos.Name = "LblMedicos";
            this.LblMedicos.Size = new System.Drawing.Size(73, 19);
            this.LblMedicos.TabIndex = 3;
            this.LblMedicos.Text = "Medicos";
            // 
            // BtnPacientes
            // 
            this.BtnPacientes.Image = global::CLINICA.Properties.Resources.paciente_png;
            this.BtnPacientes.Location = new System.Drawing.Point(411, 102);
            this.BtnPacientes.Name = "BtnPacientes";
            this.BtnPacientes.Size = new System.Drawing.Size(129, 132);
            this.BtnPacientes.TabIndex = 2;
            this.BtnPacientes.UseVisualStyleBackColor = true;
            this.BtnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
            // 
            // BtnMedicos
            // 
            this.BtnMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnMedicos.Image = global::CLINICA.Properties.Resources.medico_2;
            this.BtnMedicos.Location = new System.Drawing.Point(35, 102);
            this.BtnMedicos.Name = "BtnMedicos";
            this.BtnMedicos.Size = new System.Drawing.Size(129, 132);
            this.BtnMedicos.TabIndex = 1;
            this.BtnMedicos.UseVisualStyleBackColor = true;
            this.BtnMedicos.Click += new System.EventHandler(this.BtnMedicos_Click);
            // 
            // BtnTurnos
            // 
            this.BtnTurnos.Image = global::CLINICA.Properties.Resources.turnos;
            this.BtnTurnos.Location = new System.Drawing.Point(223, 102);
            this.BtnTurnos.Name = "BtnTurnos";
            this.BtnTurnos.Size = new System.Drawing.Size(129, 132);
            this.BtnTurnos.TabIndex = 0;
            this.BtnTurnos.UseVisualStyleBackColor = true;
            this.BtnTurnos.Click += new System.EventHandler(this.BtnTurnos_Click);
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.ForeColor = System.Drawing.Color.Red;
            this.LblTexto.Location = new System.Drawing.Point(314, 37);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(252, 32);
            this.LblTexto.TabIndex = 4;
            this.LblTexto.Text = "Elija una opcion !!";
            this.LblTexto.Click += new System.EventHandler(this.LblTexto_Click);
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(923, 431);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.PnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pantalla_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pantalla_Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pantalla_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Pantalla_Principal_Load);
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTurnos;
        private System.Windows.Forms.Button BtnMedicos;
        private System.Windows.Forms.Button BtnPacientes;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Label LblPacientes;
        private System.Windows.Forms.Label LblTurnos;
        private System.Windows.Forms.Label LblMedicos;
        private System.Windows.Forms.Label LblTexto;
    }
}