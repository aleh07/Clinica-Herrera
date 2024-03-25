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
    public partial class Pantalla_Principal : Form
    {
        public Pantalla_Principal()
        {
            InitializeComponent();
        }
        
        private void BtnTurnos_Click(object sender, EventArgs e)
        {
            Turnos pantalla = new Turnos ();
            pantalla.ShowDialog();
        }

        private void BtnMedicos_Click(object sender, EventArgs e)
        {
            Medicos Pantalla = new Medicos();
            Pantalla.ShowDialog();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            Pacientes Pantalla = new Pacientes();
            Pantalla.ShowDialog();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void Pantalla_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblTexto_Click(object sender, EventArgs e)
        {

        }
    }
}
