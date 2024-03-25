using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA.clases
{
     public class Usuario
    {
        private Int32 Id_Usuario;
        private string Nombre;
        private string Contrasenia;
        private bool Estado;

        public Int32 id_usuario
        {
            set { Id_Usuario = value; }
            get { return Id_Usuario; }
        }

        public string nombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }

        public string contrasenia
        {
            set {Contrasenia = value; }
            get { return Contrasenia; }
        }

        public int  estado
        {
            set { Estado = value; }
            get { return Estado; }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
