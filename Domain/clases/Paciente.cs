using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINICA.clases;


namespace CLINICA
{
   public class Paciente : Persona 
    {
        private Int32 HistoriaClinica;

        public Int32 historiaclinica
        {
            set { HistoriaClinica = value; }
            get { return HistoriaClinica; }

        }
        public Pais Nacionalidad { set; get; }
    }
}
