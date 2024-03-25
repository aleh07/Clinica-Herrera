using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA
{
    public class Persona
    {
        private string Dni;
        private string Apellido;
        private string Nombres;
        private DateTime FechaNac;
        private string Sexo;
        private string Telefono;
        private string Email;
       

        public string dni
        {
            set { Dni = value; }
            get { return Dni; }

        }

        public string apellido
        {
            set { Apellido = value; }
            get { return Apellido; }

        }

        public string nombres
        {
            set { Nombres = value; }
            get { return Nombres; }
        }

        public DateTime fechanac
        {
            set { FechaNac = value; }
            get { return FechaNac; }

        }

        public string sexo
        {
            set { Sexo = value; }
            get { return Sexo; }

        }

        public string telefono
        {
            set { Telefono = value; }
            get { return Telefono; }

        }

        public string email
        {

            set { Email = value; }
            get { return Email; }
        }     
      
                                                                                                                                                                                        
    }
}
