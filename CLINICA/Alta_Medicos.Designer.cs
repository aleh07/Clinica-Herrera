namespace CLINICA
{
    partial class Alta_Medicos
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
            this.CbNacionalidad = new System.Windows.Forms.ComboBox();
            this.LblNacionalidad = new System.Windows.Forms.Label();
            this.RbsexoM = new System.Windows.Forms.RadioButton();
            this.RbsexoF = new System.Windows.Forms.RadioButton();
            this.LblFechaNac = new System.Windows.Forms.Label();
            this.DtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.LblDni = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.CbEspecialidad = new System.Windows.Forms.ComboBox();
            this.LblEspecialidad = new System.Windows.Forms.Label();
            this.GbSexo = new System.Windows.Forms.GroupBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCancelar = new System.Windows.Forms.Label();
            this.LblAceptar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CbNacionalidad
            // 
            this.CbNacionalidad.FormattingEnabled = true;
            this.CbNacionalidad.Location = new System.Drawing.Point(675, 162);
            this.CbNacionalidad.Name = "CbNacionalidad";
            this.CbNacionalidad.Size = new System.Drawing.Size(100, 21);
            this.CbNacionalidad.TabIndex = 50;
            // 
            // LblNacionalidad
            // 
            this.LblNacionalidad.AutoSize = true;
            this.LblNacionalidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNacionalidad.Location = new System.Drawing.Point(558, 171);
            this.LblNacionalidad.Name = "LblNacionalidad";
            this.LblNacionalidad.Size = new System.Drawing.Size(92, 16);
            this.LblNacionalidad.TabIndex = 49;
            this.LblNacionalidad.Text = "Nacionalidad";
            // 
            // RbsexoM
            // 
            this.RbsexoM.AutoSize = true;
            this.RbsexoM.Checked = true;
            this.RbsexoM.Location = new System.Drawing.Point(6, 19);
            this.RbsexoM.Name = "RbsexoM";
            this.RbsexoM.Size = new System.Drawing.Size(90, 20);
            this.RbsexoM.TabIndex = 47;
            this.RbsexoM.TabStop = true;
            this.RbsexoM.Text = "Masculino";
            this.RbsexoM.UseVisualStyleBackColor = true;
            // 
            // RbsexoF
            // 
            this.RbsexoF.AutoSize = true;
            this.RbsexoF.Location = new System.Drawing.Point(117, 19);
            this.RbsexoF.Name = "RbsexoF";
            this.RbsexoF.Size = new System.Drawing.Size(90, 20);
            this.RbsexoF.TabIndex = 46;
            this.RbsexoF.Text = "Femenino";
            this.RbsexoF.UseVisualStyleBackColor = true;
            // 
            // LblFechaNac
            // 
            this.LblFechaNac.AutoSize = true;
            this.LblFechaNac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNac.Location = new System.Drawing.Point(124, 194);
            this.LblFechaNac.Name = "LblFechaNac";
            this.LblFechaNac.Size = new System.Drawing.Size(88, 32);
            this.LblFechaNac.TabIndex = 45;
            this.LblFechaNac.Text = "Fecha \r\nNaciemiento";
            // 
            // DtpFechaNac
            // 
            this.DtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNac.Location = new System.Drawing.Point(240, 198);
            this.DtpFechaNac.Name = "DtpFechaNac";
            this.DtpFechaNac.Size = new System.Drawing.Size(99, 20);
            this.DtpFechaNac.TabIndex = 44;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(606, 136);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(44, 16);
            this.LblEmail.TabIndex = 42;
            this.LblEmail.Text = "Email";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.Color.Red;
            this.LblDescripcion.Location = new System.Drawing.Point(373, 29);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(177, 22);
            this.LblDescripcion.TabIndex = 41;
            this.LblDescripcion.Text = "Ingrese  los Datos";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(239, 167);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(100, 20);
            this.TxtNombres.TabIndex = 40;
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(148, 167);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(64, 16);
            this.LblNombres.TabIndex = 39;
            this.LblNombres.Text = "Nombres";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(674, 104);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 38;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(587, 104);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(63, 16);
            this.LblTelefono.TabIndex = 37;
            this.LblTelefono.Text = "Telefono";
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(239, 101);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(100, 20);
            this.TxtDni.TabIndex = 36;
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDni.Location = new System.Drawing.Point(183, 103);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(29, 16);
            this.LblDni.TabIndex = 35;
            this.LblDni.Text = "Dni";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(239, 134);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 34;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(151, 135);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(61, 16);
            this.LblApellido.TabIndex = 33;
            this.LblApellido.Text = "Apellido";
            // 
            // CbEspecialidad
            // 
            this.CbEspecialidad.FormattingEnabled = true;
            this.CbEspecialidad.Location = new System.Drawing.Point(675, 193);
            this.CbEspecialidad.Name = "CbEspecialidad";
            this.CbEspecialidad.Size = new System.Drawing.Size(100, 21);
            this.CbEspecialidad.TabIndex = 54;
            // 
            // LblEspecialidad
            // 
            this.LblEspecialidad.AutoSize = true;
            this.LblEspecialidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEspecialidad.Location = new System.Drawing.Point(561, 200);
            this.LblEspecialidad.Name = "LblEspecialidad";
            this.LblEspecialidad.Size = new System.Drawing.Size(89, 16);
            this.LblEspecialidad.TabIndex = 53;
            this.LblEspecialidad.Text = "Especialidad";
            // 
            // GbSexo
            // 
            this.GbSexo.Controls.Add(this.RbsexoM);
            this.GbSexo.Controls.Add(this.RbsexoF);
            this.GbSexo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSexo.Location = new System.Drawing.Point(127, 245);
            this.GbSexo.Name = "GbSexo";
            this.GbSexo.Size = new System.Drawing.Size(213, 47);
            this.GbSexo.TabIndex = 55;
            this.GbSexo.TabStop = false;
            this.GbSexo.Text = "Sexo";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(674, 133);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(114, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 247);
            this.panel1.TabIndex = 58;
            // 
            // LblCancelar
            // 
            this.LblCancelar.AutoSize = true;
            this.LblCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCancelar.ForeColor = System.Drawing.Color.Red;
            this.LblCancelar.Location = new System.Drawing.Point(279, 399);
            this.LblCancelar.Name = "LblCancelar";
            this.LblCancelar.Size = new System.Drawing.Size(55, 14);
            this.LblCancelar.TabIndex = 59;
            this.LblCancelar.Text = "Cancelar";
            this.LblCancelar.Click += new System.EventHandler(this.LblCancelar_Click);
            // 
            // LblAceptar
            // 
            this.LblAceptar.AutoSize = true;
            this.LblAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblAceptar.Location = new System.Drawing.Point(623, 399);
            this.LblAceptar.Name = "LblAceptar";
            this.LblAceptar.Size = new System.Drawing.Size(50, 14);
            this.LblAceptar.TabIndex = 60;
            this.LblAceptar.Text = "Aceptar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CLINICA.Properties.Resources.inicio;
            this.pictureBox1.Location = new System.Drawing.Point(390, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 142);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackgroundImage = global::CLINICA.Properties.Resources.fondo;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Image = global::CLINICA.Properties.Resources.tldes1;
            this.BtnAceptar.Location = new System.Drawing.Point(609, 325);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 71);
            this.BtnAceptar.TabIndex = 32;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::CLINICA.Properties.Resources.fondo;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.Image = global::CLINICA.Properties.Resources.tilde_cancelada1;
            this.BtnCancelar.Location = new System.Drawing.Point(265, 325);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 71);
            this.BtnCancelar.TabIndex = 31;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // Alta_Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(923, 431);
            this.Controls.Add(this.LblAceptar);
            this.Controls.Add(this.LblCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.CbEspecialidad);
            this.Controls.Add(this.LblEspecialidad);
            this.Controls.Add(this.CbNacionalidad);
            this.Controls.Add(this.LblNacionalidad);
            this.Controls.Add(this.LblFechaNac);
            this.Controls.Add(this.DtpFechaNac);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.GbSexo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta_Medicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta_Medicos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Alta_Medicos_FormClosed);
            this.Load += new System.EventHandler(this.Alta_Medicos_Load);
            this.GbSexo.ResumeLayout(false);
            this.GbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbNacionalidad;
        private System.Windows.Forms.Label LblNacionalidad;
        private System.Windows.Forms.RadioButton RbsexoM;
        private System.Windows.Forms.RadioButton RbsexoF;
        private System.Windows.Forms.Label LblFechaNac;
        private System.Windows.Forms.DateTimePicker DtpFechaNac;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CbEspecialidad;
        private System.Windows.Forms.Label LblEspecialidad;
        private System.Windows.Forms.GroupBox GbSexo;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCancelar;
        private System.Windows.Forms.Label LblAceptar;
    }
}