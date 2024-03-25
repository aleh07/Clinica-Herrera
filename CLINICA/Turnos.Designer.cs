namespace CLINICA
{
    partial class Turnos
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
            this.BtnCargarTurnos = new System.Windows.Forms.Button();
            this.BtnVerTurnos = new System.Windows.Forms.Button();
            this.PnControles = new System.Windows.Forms.Panel();
            this.LblVerTurno = new System.Windows.Forms.Label();
            this.LblCargarTurno = new System.Windows.Forms.Label();
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
            // BtnCargarTurnos
            // 
            this.BtnCargarTurnos.BackgroundImage = global::CLINICA.Properties.Resources.turnos;
            this.BtnCargarTurnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCargarTurnos.Location = new System.Drawing.Point(40, 41);
            this.BtnCargarTurnos.Name = "BtnCargarTurnos";
            this.BtnCargarTurnos.Size = new System.Drawing.Size(127, 101);
            this.BtnCargarTurnos.TabIndex = 0;
            this.BtnCargarTurnos.UseVisualStyleBackColor = true;
            this.BtnCargarTurnos.Click += new System.EventHandler(this.BtnCargarTurnos_Click);
            // 
            // BtnVerTurnos
            // 
            this.BtnVerTurnos.BackgroundImage = global::CLINICA.Properties.Resources.lupa;
            this.BtnVerTurnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerTurnos.Location = new System.Drawing.Point(328, 41);
            this.BtnVerTurnos.Name = "BtnVerTurnos";
            this.BtnVerTurnos.Size = new System.Drawing.Size(127, 101);
            this.BtnVerTurnos.TabIndex = 1;
            this.BtnVerTurnos.UseVisualStyleBackColor = true;
            this.BtnVerTurnos.VisibleChanged += new System.EventHandler(this.Turnos_Load);
            this.BtnVerTurnos.Click += new System.EventHandler(this.BtnVerTurnos_Click);
            // 
            // PnControles
            // 
            this.PnControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PnControles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnControles.Controls.Add(this.LblVerTurno);
            this.PnControles.Controls.Add(this.LblCargarTurno);
            this.PnControles.Controls.Add(this.BtnVerTurnos);
            this.PnControles.Controls.Add(this.BtnCargarTurnos);
            this.PnControles.ForeColor = System.Drawing.Color.Black;
            this.PnControles.Location = new System.Drawing.Point(213, 131);
            this.PnControles.Name = "PnControles";
            this.PnControles.Size = new System.Drawing.Size(500, 168);
            this.PnControles.TabIndex = 10;
            // 
            // LblVerTurno
            // 
            this.LblVerTurno.AutoSize = true;
            this.LblVerTurno.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerTurno.Location = new System.Drawing.Point(324, 19);
            this.LblVerTurno.Name = "LblVerTurno";
            this.LblVerTurno.Size = new System.Drawing.Size(92, 19);
            this.LblVerTurno.TabIndex = 8;
            this.LblVerTurno.Text = "Ver Turnos";
            // 
            // LblCargarTurno
            // 
            this.LblCargarTurno.AutoSize = true;
            this.LblCargarTurno.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargarTurno.Location = new System.Drawing.Point(36, 19);
            this.LblCargarTurno.Name = "LblCargarTurno";
            this.LblCargarTurno.Size = new System.Drawing.Size(110, 19);
            this.LblCargarTurno.TabIndex = 7;
            this.LblCargarTurno.Text = "Cargar Turno";
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
            // Turnos
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Turnos_FormClosed);
            this.Load += new System.EventHandler(this.Turnos_Load);
            this.PnControles.ResumeLayout(false);
            this.PnControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarTurnos;
        private System.Windows.Forms.Button BtnVerTurnos;
        private System.Windows.Forms.Panel PnControles;
        private System.Windows.Forms.Label LblVerTurno;
        private System.Windows.Forms.Label LblCargarTurno;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}