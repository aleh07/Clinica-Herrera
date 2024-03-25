using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINICA.clases; 

namespace CLINICA
{
   public class Medico : Persona
    {
        public Int32 MedicoId { set; get; }
        
         private bool Estado;
      
     

        public bool estado
        {

            set { Estado = value; }
            get { return Estado; }
        }

        public Especialidad Especialidad { set; get; }
        public Pais Nacionalidad { set; get; }
       
    }

} 
