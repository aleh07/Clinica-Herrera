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
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
        }

        private void BtnCargarMedicos_Click(object sender, EventArgs e)
        {
            Alta_Medicos Pantalla = new Alta_Medicos();
            Pantalla.ShowDialog();
        }

        private void BtnVerMedicos_Click(object sender, EventArgs e)
        {
            Ver_Medicos Pantalla = new Ver_Medicos();
            Pantalla.ShowDialog();
        }

        private void Medicos_Load(object sender, EventArgs e)
        {
            
        }

        private void Medicos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void LblCargarMedico_Click(object sender, EventArgs e)
        {

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Pantalla_Principal Pantalla = new Pantalla_Principal();
            Pantalla.ShowDialog();
        }
    }
}
