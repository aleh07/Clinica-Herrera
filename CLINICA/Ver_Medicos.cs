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
    public partial class Ver_Medicos : Form
    {
        public Ver_Medicos()
        {
            InitializeComponent();
        }

        private void Ver_Medicos_Load(object sender, EventArgs e)
        {
            cargarGrilla();  
        }

        private void cargarGrilla()
        {
            MedicoNegocio negMedico = new MedicoNegocio();

            try
            {

                DgvMedicos.DataSource = negMedico.traerTodos();
                DgvMedicos.Columns[0].Visible = false;
                DgvMedicos.Columns[1].Visible = false;
              
              


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DgvMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                Medico  med = (Medico)DgvMedicos.CurrentRow.DataBoundItem;
                Alta_Medicos  modificar = new Alta_Medicos(med);
                modificar.Text = "Modificando";
                modificar.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
