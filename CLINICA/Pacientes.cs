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
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void BtnCargarPacientes_Click(object sender, EventArgs e)
        {
            Alta_Pacientes Pantalla = new Alta_Pacientes();
            Pantalla.ShowDialog();
        }

        private void BtnVerPacientes_Click(object sender, EventArgs e)
        {
            Ver_Pacientes Pantalla = new Ver_Pacientes();
            Pantalla.ShowDialog();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
           
        }

        private void Pacientes_FormClosed(object sender, FormClosedEventArgs e)
        {

           
        }
    }
}
