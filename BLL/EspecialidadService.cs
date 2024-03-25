using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLINICA.clases;

namespace BLL
{
     public class EspecialidadService
    {
        public IList<Especialidad> traerEspecialidades()
        {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Especialidad> lista = new List<Especialidad>();

            try
            {
                accesoDatos.setearComandoText("select id_especialidad ,nombre from  especialidad");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Especialidad  espe = new Especialidad();
                    espe.id_especialidad = accesoDatos.Lector.GetInt32(0);
                    espe.nombre = accesoDatos.Lector.GetString(1);

                    lista.Add(espe);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }
    }
}
