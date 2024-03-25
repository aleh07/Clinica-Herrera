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
    public partial class CLINICA : Form
    {
        public CLINICA()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Pantalla_Principal Pantalla = new Pantalla_Principal();
            Pantalla.ShowDialog();
            
        }

        private void CLINICA_Load(object sender, EventArgs e)
        {
           
        }

        private void CLINICA_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hasta Luego...");
        }
    }
}
