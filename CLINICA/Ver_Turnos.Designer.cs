namespace CLINICA
{
    partial class Ver_Turnos
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
            this.LblClave = new System.Windows.Forms.Label();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.LblCampo = new System.Windows.Forms.Label();
            this.LblModificar = new System.Windows.Forms.Label();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.LblAgregarTel = new System.Windows.Forms.Label();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.BtnAgregarTel = new System.Windows.Forms.Button();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.CboCriterio = new System.Windows.Forms.ComboBox();
            this.CboCampo = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.DgvMedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Location = new System.Drawing.Point(565, 70);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(37, 14);
            this.LblClave.TabIndex = 55;
            this.LblClave.Text = "Clave";
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCriterio.Location = new System.Drawing.Point(289, 68);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(49, 14);
            this.LblCriterio.TabIndex = 54;
            this.LblCriterio.Text = "Criterio";
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo.Location = new System.Drawing.Point(28, 72);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(46, 14);
            this.LblCampo.TabIndex = 53;
            this.LblCampo.Text = "Campo";
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModificar.Location = new System.Drawing.Point(373, 317);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(58, 14);
            this.LblModificar.TabIndex = 52;
            this.LblModificar.Text = "Modificar";
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEliminar.Location = new System.Drawing.Point(605, 317);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(51, 14);
            this.LblEliminar.TabIndex = 51;
            this.LblEliminar.Text = "Eliminar";
            // 
            // LblAgregarTel
            // 
            this.LblAgregarTel.AutoSize = true;
            this.LblAgregarTel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarTel.Location = new System.Drawing.Point(128, 317);
            this.LblAgregarTel.Name = "LblAgregarTel";
            this.LblAgregarTel.Size = new System.Drawing.Size(71, 14);
            this.LblAgregarTel.TabIndex = 50;
            this.LblAgregarTel.Text = "Agregar Tel\r\n";
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackgroundImage = global::CLINICA.Properties.Resources.lupa;
            this.BtnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBusqueda.Location = new System.Drawing.Point(808, 33);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(103, 52);
            this.BtnBusqueda.TabIndex = 49;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarTel
            // 
            this.BtnAgregarTel.BackgroundImage = global::CLINICA.Properties.Resources.telefono;
            this.BtnAgregarTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarTel.Location = new System.Drawing.Point(131, 332);
            this.BtnAgregarTel.Name = "BtnAgregarTel";
            this.BtnAgregarTel.Size = new System.Drawing.Size(75, 65);
            this.BtnAgregarTel.TabIndex = 48;
            this.BtnAgregarTel.UseVisualStyleBackColor = true;
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(608, 64);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(163, 20);
            this.TxtClave.TabIndex = 47;
            // 
            // CboCriterio
            // 
            this.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCriterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboCriterio.FormattingEnabled = true;
            this.CboCriterio.Location = new System.Drawing.Point(344, 64);
            this.CboCriterio.Name = "CboCriterio";
            this.CboCriterio.Size = new System.Drawing.Size(163, 21);
            this.CboCriterio.TabIndex = 46;
            // 
            // CboCampo
            // 
            this.CboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboCampo.FormattingEnabled = true;
            this.CboCampo.Location = new System.Drawing.Point(80, 65);
            this.CboCampo.Name = "CboCampo";
            this.CboCampo.Size = new System.Drawing.Size(163, 21);
            this.CboCampo.TabIndex = 45;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackgroundImage = global::CLINICA.Properties.Resources.eliminar;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.Location = new System.Drawing.Point(608, 332);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 65);
            this.BtnEliminar.TabIndex = 44;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackgroundImage = global::CLINICA.Properties.Resources.modificar2;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificar.Location = new System.Drawing.Point(376, 332);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 65);
            this.BtnModificar.TabIndex = 43;
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // DgvMedicos
            // 
            this.DgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMedicos.Location = new System.Drawing.Point(12, 91);
            this.DgvMedicos.MultiSelect = false;
            this.DgvMedicos.Name = "DgvMedicos";
            this.DgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMedicos.Size = new System.Drawing.Size(899, 222);
            this.DgvMedicos.TabIndex = 42;
            // 
            // Ver_Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(923, 431);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.LblCampo);
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
            this.Name = "Ver_Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_Turnos";
            this.Load += new System.EventHandler(this.Ver_Turnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.Label LblModificar;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Label LblAgregarTel;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Button BtnAgregarTel;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.ComboBox CboCriterio;
        private System.Windows.Forms.ComboBox CboCampo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.DataGridView DgvMedicos;
    }
}