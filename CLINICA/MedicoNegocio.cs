using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CLINICA.clases;
namespace CLINICA
{
    public class MedicoNegocio
    {
        public IList<Medico
            > traerTodos()
        {

            //conexion
            SqlConnection conexion = new SqlConnection();
            //consulta
            SqlCommand comando = new SqlCommand();
            //lector
            SqlDataReader lector;
            //la lista que vamos a devolver
            IList<Medico> lista = new List<Medico>();


            try
            {

                conexion.ConnectionString = "initial catalog=HERRERA_CLINICA; data source=(local); integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT  M.DNI,M.APELLIDO ,M.NOMBRES, M.FECHA_NAC,M.SEXO,M.TELEFONO,M.EMAIL,PA.ID_PAIS,PA.NOMBRE,E.ID_ESPECIALIDAD,E.NOMBRE,U.ID_USUARIO, U.USUARIO FROM MEDICO AS M INNER JOIN PAIS AS PA ON M.NACIONALIDAD = PA.ID_PAIS INNER JOIN ESPECIALIDAD AS E ON M.ID_ESPECILIDAD = E.ID_ESPECIALIDAD INNER JOIN USUARIO AS U ON M.ID_USUARIO = U.ID_USUARIO";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Medico aux = new Medico();
                    aux.dni = lector.GetString(0);
                    aux.apellido = lector.GetString(1);
                    aux.nombres = lector.GetString(2);
                    aux.fechanac = lector.GetDateTime(3);
                    aux.sexo = lector.GetString(4);
                    aux.telefono = lector.GetString(5);
                    aux.email = lector.GetString(6);
                    aux.Nacionalidad = new Pais();
                    aux.Nacionalidad.id_pais = lector.GetInt32(7);
                    aux.Nacionalidad.nombre = lector.GetString(8);
                    aux.Especialidad = new Especialidad();
                    aux.Especialidad.id_especialidad = lector.GetInt32(9);
                    aux.Especialidad.nombre = lector.GetString(10);
                    aux.Usuario = new Usuario();
                    aux.Usuario.id_usuario = lector.GetInt64(11);
                    aux.Usuario.nombre = lector.GetString(12);
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
