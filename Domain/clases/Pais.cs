using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA.clases
{
    public class Pais
    {
        private Int32 Id_Pais;
        private string Nombre;

        public Int32 id_pais
        {
            set { Id_Pais = value; }
            get { return Id_Pais; }

        }
        public string nombre
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
