namespace CLINICA
{
    partial class Pacientes
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
            this.BtnVerPacientes = new System.Windows.Forms.Button();
            this.BtnCargarPacientes = new System.Windows.Forms.Button();
            this.PnControles = new System.Windows.Forms.Panel();
            this.LblVerPacientes = new System.Windows.Forms.Label();
            this.LblCargarPacientes = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVerPacientes
            // 
            this.BtnVerPacientes.BackgroundImage = global::CLINICA.Properties.Resources.lupa;
            this.BtnVerPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerPacientes.Location = new System.Drawing.Point(331, 34);
            this.BtnVerPacientes.Name = "BtnVerPacientes";
            this.BtnVerPacientes.Size = new System.Drawing.Size(123, 99);
            this.BtnVerPacientes.TabIndex = 3;
            this.BtnVerPacientes.UseVisualStyleBackColor = true;
            this.BtnVerPacientes.Click += new System.EventHandler(this.BtnVerPacientes_Click);
            // 
            // BtnCargarPacientes
            // 
            this.BtnCargarPacientes.BackgroundImage = global::CLINICA.Properties.Resources.paciente_png;
            this.BtnCargarPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCargarPacientes.Location = new System.Drawing.Point(40, 34);
            this.BtnCargarPacientes.Name = "BtnCargarPacientes";
            this.BtnCargarPacientes.Size = new System.Drawing.Size(123, 99);
            this.BtnCargarPacientes.TabIndex = 2;
            this.BtnCargarPacientes.UseVisualStyleBackColor = true;
            this.BtnCargarPacientes.Click += new System.EventHandler(this.BtnCargarPacientes_Click);
            // 
            // PnControles
            // 
            this.PnControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PnControles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnControles.Controls.Add(this.LblVerPacientes);
            this.PnControles.Controls.Add(this.LblCargarPacientes);
            this.PnControles.Controls.Add(this.BtnCargarPacientes);
            this.PnControles.Controls.Add(this.BtnVerPacientes);
            this.PnControles.ForeColor = System.Drawing.Color.Black;
            this.PnControles.Location = new System.Drawing.Point(213, 131);
            this.PnControles.Name = "PnControles";
            this.PnControles.Size = new System.Drawing.Size(500, 168);
            this.PnControles.TabIndex = 10;
            // 
            // LblVerPacientes
            // 
            this.LblVerPacientes.AutoSize = true;
            this.LblVerPacientes.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerPacientes.Location = new System.Drawing.Point(327, 12);
            this.LblVerPacientes.Name = "LblVerPacientes";
            this.LblVerPacientes.Size = new System.Drawing.Size(113, 19);
            this.LblVerPacientes.TabIndex = 8;
            this.LblVerPacientes.Text = "Ver Pacientes";
            // 
            // LblCargarPacientes
            // 
            this.LblCargarPacientes.AutoSize = true;
            this.LblCargarPacientes.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarPacientes.Location = new System.Drawing.Point(36, 12);
            this.LblCargarPacientes.Name = "LblCargarPacientes";
            this.LblCargarPacientes.Size = new System.Drawing.Size(131, 19);
            this.LblCargarPacientes.TabIndex = 7;
            this.LblCargarPacientes.Text = "Cargar Paciente";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::CLINICA.Properties.Resources.icono;
            this.pictureBox4.Location = new System.Drawing.Point(713, 305);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(126, 125);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::CLINICA.Properties.Resources.icono;
            this.pictureBox3.Location = new System.Drawing.Point(83, 305);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 125);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::CLINICA.Properties.Resources.icono;
            this.pictureBox2.Location = new System.Drawing.Point(713, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 125);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CLINICA.Properties.Resources.icono;
            this.pictureBox1.Location = new System.Drawing.Point(83, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 125);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(923, 431);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnControles);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pacientes_FormClosed);
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.PnControles.ResumeLayout(false);
            this.PnControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVerPacientes;
        private System.Windows.Forms.Button BtnCargarPacientes;
        private System.Windows.Forms.Panel PnControles;
        private System.Windows.Forms.Label LblVerPacientes;
        private System.Windows.Forms.Label LblCargarPacientes;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}