using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CLINICA.clases;

namespace BLL
{
     public class NacionalidadService
    {
        public IList<Pais> traerPaises()
        {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Pais> lista = new List<Pais>();

            try
            {
                accesoDatos.setearComandoText("Select ID_PAIS, NOMBRE From pais");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Pais pa = new Pais();
                    pa.id_pais = accesoDatos.Lector.GetInt32(0);
                    pa.nombre = accesoDatos.Lector.GetString(1);
                    
                    lista.Add(pa);
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
