using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA
{
     public class Turno
    {
        private DateTime Fecha;
        private Int32 Paciente;
        private Int32 Especialidad;
        private DateTime FechaTurno;
        private string Motivo;
        private bool Estado;

        public DateTime fecha
        {
            set { Fecha = value;}
            get { return Fecha; }

        }

        public Int32 paciente
        {
            set { Paciente = value; }
            get { return Paciente; }

        }

        public Int32 especialidad
        {
            set{ Especialidad = value; }
            get { return Especialidad; }

        }

        public DateTime fechaturno
        {
            set { FechaTurno = value; }
            get { return FechaTurno; }

        }

        public string motivo
        {
            set { Motivo = value; }
            get { return Motivo; }

        }

        public bool estado
        {
            set { Estado = value; }
            get { return Estado; }

        }
    }
}
