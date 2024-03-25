using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA.clases
{
     public class Especialidad
    {
        private Int32 Id_Especialidad;
        private String Nombre;

        public Int32 id_especialidad
        {
            set { Id_Especialidad = value; }
            get { return Id_Especialidad; }
        }
        public String nombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public override string ToString()
        {
            return Nombre;
        }

    }
}
