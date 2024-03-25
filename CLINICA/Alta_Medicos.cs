using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLINICA.clases;
using BLL;

namespace CLINICA
{
    public partial class Alta_Medicos : Form
    {
        private Medico medico;
        public Alta_Medicos()
        {
            InitializeComponent();
            medico = new Medico();
        }
        public Alta_Medicos(Medico med)
        {
            InitializeComponent();
            medico = med;

        }
        private void Alta_Medicos_Load(object sender, EventArgs e)
        {
           
            

            NacionalidadService serv = new NacionalidadService();
            CbNacionalidad.DataSource = serv.traerPaises();
            CbNacionalidad.DisplayMember = "Nombre";
            CbNacionalidad.ValueMember = "Id_Pais";

            EspecialidadService ser_esp = new EspecialidadService();
            CbEspecialidad.DataSource = ser_esp.traerEspecialidades();
            CbEspecialidad.DisplayMember = "Nombre";
            CbEspecialidad.ValueMember = "Id_Especialidad";



            if (this.Text == "Modificando")
            {    
                TxtDni.Text = medico.dni;
                TxtApellido.Text = medico.apellido;
                TxtNombres.Text = medico.nombres;
                DtpFechaNac.Value = medico.fechanac;
                
                TxtTelefono.Text = medico.telefono;
                TxtEmail.Text = medico.email;
                CbNacionalidad.SelectedValue = medico.Nacionalidad.id_pais;
                CbEspecialidad.SelectedValue = medico.Especialidad.id_especialidad;
            }



        }

        private void Alta_Medicos_FormClosed(object sender, FormClosedEventArgs e)
        {

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
           
            MedicoNegocio serviceMedico = new MedicoNegocio();

            try
            {
                medico.dni = TxtDni.Text.Trim();
                medico.apellido = TxtApellido.Text.Trim();
                medico.nombres = TxtNombres.Text.Trim();
                medico.fechanac = DtpFechaNac.Value ;
                if (RbsexoF.Checked)
                {
                    medico.sexo = "F";
                  
                }
                else 
                {
                    medico.sexo = "M";

                }
                medico.telefono = TxtTelefono.Text.Trim();
                medico.email = TxtEmail.Text.Trim();
                medico.Nacionalidad = (Pais)CbNacionalidad.SelectedItem;
                medico.Especialidad = (Especialidad)CbEspecialidad.SelectedItem;
               

                if (this.Text != "Modificando")
                {
                    serviceMedico.AgregarMedicoSP(medico);
                    MessageBox.Show("Medico Agregado correctamente!");
                }
                else
                {
                    serviceMedico.modificar(medico);
                    MessageBox.Show("Medico Modificado correctamente!");
                }

                this.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error FATAL. " + ex.ToString(), "", MessageBoxButtons.OK);
            }

        }

        private void LblCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
