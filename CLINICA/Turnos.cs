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
    public partial class Turnos : Form
    {
        public Turnos()
        {
            InitializeComponent();
        }

        private void Turnos_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnCargarTurnos_Click(object sender, EventArgs e)
        {
            Alta_Turnos Pantalla = new Alta_Turnos();
            Pantalla.ShowDialog();
        }

        private void BtnVerTurnos_Click(object sender, EventArgs e)
        {
            Ver_Turnos Pantalla = new Ver_Turnos();
            Pantalla.ShowDialog();
        }

        private void Turnos_FormClosed(object sender, FormClosedEventArgs e)
        {

            
        }
    }
}
