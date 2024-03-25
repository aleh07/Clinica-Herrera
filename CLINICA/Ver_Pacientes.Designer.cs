namespace CLINICA
{
    partial class Ver_Pacientes
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
            this.DgvPacientes = new System.Windows.Forms.DataGridView();
            this.LblClave = new System.Windows.Forms.Label();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.LblCampo = new System.Windows.Forms.Label();
            this.LblBusqueda = new System.Windows.Forms.Label();
            this.LblModificar = new System.Windows.Forms.Label();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.LblAgregarTel = new System.Windows.Forms.Label();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.BtnAgregarTel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPacientes
            // 
            this.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientes.Location = new System.Drawing.Point(31, 120);
            this.DgvPacientes.Name = "DgvPacientes";
            this.DgvPacientes.Size = new System.Drawing.Size(880, 184);
            this.DgvPacientes.TabIndex = 33;
            this.DgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPacientes_CellContentClick);
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Location = new System.Drawing.Point(565, 79);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(37, 14);
            this.LblClave.TabIndex = 56;
            this.LblClave.Text = "Clave";
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCriterio.Location = new System.Drawing.Point(289, 77);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(49, 14);
            this.LblCriterio.TabIndex = 55;
            this.LblCriterio.Text = "Criterio";
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo.Location = new System.Drawing.Point(28, 81);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(46, 14);
            this.LblCampo.TabIndex = 54;
            this.LblCampo.Text = "Campo";
            // 
            // LblBusqueda
            // 
            this.LblBusqueda.AutoSize = true;
            this.LblBusqueda.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBusqueda.Location = new System.Drawing.Point(805, 25);
            this.LblBusqueda.Name = "LblBusqueda";
            this.LblBusqueda.Size = new System.Drawing.Size(45, 14);
            this.LblBusqueda.TabIndex = 53;
            this.LblBusqueda.Text = "Buscar";
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModificar.Location = new System.Drawing.Point(373, 326);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(58, 14);
            this.LblModificar.TabIndex = 52;
            this.LblModificar.Text = "Modificar";
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEliminar.Location = new System.Drawing.Point(605, 326);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(51, 14);
            this.LblEliminar.TabIndex = 51;
            this.LblEliminar.Text = "Eliminar";
            // 
            // LblAgregarTel
            // 
            this.LblAgregarTel.AutoSize = true;
            this.LblAgregarTel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarTel.Location = new System.Drawing.Point(128, 326);
            this.LblAgregarTel.Name = "LblAgregarTel";
            this.LblAgregarTel.Size = new System.Drawing.Size(71, 14);
            this.LblAgregarTel.TabIndex = 50;
            this.LblAgregarTel.Text = "Agregar Tel\r\n";
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackgroundImage = global::CLINICA.Properties.Resources.lupa;
            this.BtnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBusqueda.Location = new System.Drawing.Point(808, 42);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(103, 52);
            this.BtnBusqueda.TabIndex = 49;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // BtnAgregarTel
            // 
            this.BtnAgregarTel.BackgroundImage = global::CLINICA.Properties.Resources.telefono;
            this.BtnAgregarTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarTel.Location = new System.Drawing.Point(131, 341);
            this.BtnAgregarTel.Name = "BtnAgregarTel";
            this.BtnAgregarTel.Size = new System.Drawing.Size(75, 65);
            this.BtnAgregarTel.TabIndex = 48;
            this.BtnAgregarTel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(608, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 47;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(344, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CLINICA.Properties.Resources.eliminar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(608, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CLINICA.Properties.Resources.modificar2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(376, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 65);
            this.button2.TabIndex = 43;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Ver_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(923, 431);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.LblBusqueda);
            this.Controls.Add(this.LblModificar);
            this.Controls.Add(this.LblEliminar);
            this.Controls.Add(this.LblAgregarTel);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.BtnAgregarTel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DgvPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ver_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_Pacientes";
            this.Load += new System.EventHandler(this.Ver_Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPacientes;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.Label LblBusqueda;
        private System.Windows.Forms.Label LblModificar;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Label LblAgregarTel;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Button BtnAgregarTel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}