using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CLINICA.clases;


namespace CLINICA
{
   public class PacienteNegocio
    {
       
    

            public IList<Paciente> traerTodos()
            {

                //conexion
                SqlConnection conexion = new SqlConnection();
                //consulta
                SqlCommand comando = new SqlCommand();
                //lector
                SqlDataReader lector;
                //la lista que vamos a devolver
                IList<Paciente> lista = new List<Paciente>();
                

                try
                {

                    conexion.ConnectionString = "initial catalog=HERRERA_CLINICA; data source=(local); integrated security=sspi";
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "SELECT  P.DNI,P.APELLIDO ,P.NOMBRES, P.FECHA_NAC,P.SEXO,P.TELEFONO,P.EMAIL,PA.ID_PAIS,PA.NOMBRE FROM PACIENTE AS P INNER JOIN PAIS AS PA ON P.NACIONALIDAD = PA.ID_PAIS";
                    comando.Connection = conexion;

                    conexion.Open();
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Paciente aux = new Paciente ();
                        aux.dni = lector.GetString(0);
                        aux.apellido = lector.GetString(1);
                        aux.nombres = lector.GetString(2);
                        aux.fechanac = lector.GetDateTime(3);
                        aux.sexo= lector.GetString(4);
                        aux.telefono = lector.GetString(5);
                        aux.email = lector.GetString(6);
                        aux.Nacionalidad = new Pais();
                        aux.Nacionalidad.id_pais = lector.GetInt32(7);
                        aux.Nacionalidad.nombre = lector.GetString(8);
                        lista.Add(aux);
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexion.Close();
                    conexion.Dispose();
                    comando.Dispose();
                }

            }

        }
    }

