namespace CLINICA
{
    partial class Ver_Medicos
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
            this.DgvMedicos = new System.Windows.Forms.DataGridView();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.CboCriterio = new System.Windows.Forms.ComboBox();
            this.CboCampo = new System.Windows.Forms.ComboBox();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.BtnAgregarTel = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblAgregarTel = new System.Windows.Forms.Label();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.LblModificar = new System.Windows.Forms.Label();
            this.LblBusqueda = new System.Windows.Forms.Label();
            this.LblCampo = new System.Windows.Forms.Label();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMedicos
            // 
            this.DgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMedicos.Location = new System.Drawing.Point(12, 113);
            this.DgvMedicos.MultiSelect = false;
            this.DgvMedicos.Name = "DgvMedicos";
            this.DgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMedicos.Size = new System.Drawing.Size(899, 222);
            this.DgvMedicos.TabIndex = 21;
            this.DgvMedicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicos_CellContentClick);
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(608, 86);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(163, 20);
            this.TxtClave.TabIndex = 32;
            // 
            // CboCriterio
            // 
            this.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCriterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboCriterio.FormattingEnabled = true;
            this.CboCriterio.Location = new System.Drawing.Point(344, 86);
            this.CboCriterio.Name = "CboCriterio";
            this.CboCriterio.Size = new System.Drawing.Size(163, 21);
            this.CboCriterio.TabIndex = 31;
            // 
            // CboCampo
            // 
            this.CboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboCampo.FormattingEnabled = true;
            this.CboCampo.Location = new System.Drawing.Point(80, 87);
            this.CboCampo.Name = "CboCampo";
            this.CboCampo.Size = new System.Drawing.Size(163, 21);
            this.CboCampo.TabIndex = 30;
            this.CboCampo.SelectedIndexChanged += new System.EventHandler(this.CboCampo_SelectedIndexChanged);
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackgroundImage = global::CLINICA.Properties.Resources.lupa;
            this.BtnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBusqueda.Location = new System.Drawing.Point(808, 55);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(103, 52);
            this.BtnBusqueda.TabIndex = 34;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarTel
            // 
            this.BtnAgregarTel.BackgroundImage = global::CLINICA.Properties.Resources.telefono;
            this.BtnAgregarTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarTel.Location = new System.Drawing.Point(131, 354);
            this.BtnAgregarTel.Name = "BtnAgregarTel";
            this.BtnAgregarTel.Size = new System.Drawing.Size(75, 65);
            this.BtnAgregarTel.TabIndex = 33;
            this.BtnAgregarTel.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackgroundImage = global::CLINICA.Properties.Resources.eliminar;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.Location = new System.Drawing.Point(608, 354);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 65);
            this.BtnEliminar.TabIndex = 29;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackgroundImage = global::CLINICA.Properties.Resources.modificar2;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificar.Location = new System.Drawing.Point(376, 354);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 65);
            this.BtnModificar.TabIndex = 28;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblAgregarTel
            // 
            this.LblAgregarTel.AutoSize = true;
            this.LblAgregarTel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarTel.Location = new System.Drawing.Point(128, 339);
            this.LblAgregarTel.Name = "LblAgregarTel";
            this.LblAgregarTel.Size = new System.Drawing.Size(71, 14);
            this.LblAgregarTel.TabIndex = 35;
            this.LblAgregarTel.Text = "Agregar Tel\r\n";
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEliminar.Location = new System.Drawing.Point(605, 339);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(51, 14);
            this.LblEliminar.TabIndex = 36;
            this.LblEliminar.Text = "Eliminar";
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModificar.Location = new System.Drawing.Point(373, 339);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(58, 14);
            this.LblModificar.TabIndex = 37;
            this.LblModificar.Text = "Modificar";
            // 
            // LblBusqueda
            // 
            this.LblBusqueda.AutoSize = true;
            this.LblBusqueda.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBusqueda.Location = new System.Drawing.Point(805, 38);
            this.LblBusqueda.Name = "LblBusqueda";
            this.LblBusqueda.Size = new System.Drawing.Size(45, 14);
            this.LblBusqueda.TabIndex = 38;
            this.LblBusqueda.Text = "Buscar";
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo.Location = new System.Drawing.Point(28, 94);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(46, 14);
            this.LblCampo.TabIndex = 39;
            this.LblCampo.Text = "Campo";
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCriterio.Location = new System.Drawing.Point(289, 90);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(49, 14);
            this.LblCriterio.TabIndex = 40;
            this.LblCriterio.Text = "Criterio";
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Location = new System.Drawing.Point(565, 92);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(37, 14);
            this.LblClave.TabIndex = 41;
            this.LblClave.Text = "Clave";
            // 
            // Ver_Medicos
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
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.CboCriterio);
            this.Controls.Add(this.CboCampo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.DgvMedicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ver_Medicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_Medicos";
            this.Load += new System.EventHandler(this.Ver_Medicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DataGridView DgvMedicos;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.ComboBox CboCriterio;
        private System.Windows.Forms.ComboBox CboCampo;
        private System.Windows.Forms.Button BtnAgregarTel;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Label LblAgregarTel;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Label LblModificar;
        private System.Windows.Forms.Label LblBusqueda;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.Label LblClave;
    }
}