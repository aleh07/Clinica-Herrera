using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICA
{
    public partial class Ver_Pacientes : Form
    {
        public Ver_Pacientes()
        {
            InitializeComponent();
        }

        private void Ver_Pacientes_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            PacienteNegocio negPaciente = new PacienteNegocio();

            try
            {
                
                DgvPacientes.DataSource = negPaciente.traerTodos();

                DgvPacientes.Columns[0].Visible = false;
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void DgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
