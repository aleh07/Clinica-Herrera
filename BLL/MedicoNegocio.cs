using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CLINICA.clases;
using BLL;


namespace CLINICA
{
    public class MedicoNegocio
    {
        public IList<Medico > traerTodos()

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
                comando.CommandText = "SELECT M.ID_MEDICO, M.DNI,M.APELLIDO ,M.NOMBRES, M.FECHA_NAC,M.SEXO,M.TELEFONO,M.EMAIL,PA.ID_PAIS,PA.NOMBRE,E.ID_ESPECIALIDAD,E.NOMBRE FROM MEDICO AS M INNER JOIN PAIS AS PA ON M.NACIONALIDAD = PA.ID_PAIS INNER JOIN ESPECIALIDAD AS E ON M.ID_ESPECIALIDAD = E.ID_ESPECIALIDAD WHERE M.ESTADO = 1";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Medico aux = new Medico();
                    aux.MedicoId = lector.GetInt32(0);
                    aux.dni = lector.GetString(1);
                    aux.apellido = lector.GetString(2);
                    aux.nombres = lector.GetString(3);
                    aux.fechanac = lector.GetDateTime(4);
                    aux.sexo = lector.GetString(5);
                    aux.telefono = lector.GetString(6);
                    aux.email = lector.GetString(7);
                    aux.Nacionalidad = new Pais();
                    aux.Nacionalidad.id_pais = lector.GetInt32(8);
                    aux.Nacionalidad.nombre = lector.GetString(9);
                    aux.Especialidad = new Especialidad();
                    aux.Especialidad.id_especialidad = lector.GetInt32(10);
                    aux.Especialidad.nombre = lector.GetString(11);
          
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

        public void agregarMedico(Medico nuevo)
        {
            SqlConnection conexion = new SqlConnection("initial catalog=HERRERA_CLINICA; data source=DESKTOP-N4F2CD1; integrated security=sspi");
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = "Insert into MEDICO Values ('" + nuevo.dni + "', '" + nuevo.apellido + "', '" + nuevo.nombres + "','" + nuevo.fechanac + "','" + nuevo.sexo + "','" + nuevo.telefono + "','" + nuevo.email + "'," + nuevo.Nacionalidad.id_pais + "," + nuevo.Especialidad.id_especialidad +  ",1)";

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
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

        public void eliminarLogico(Medico med)
        {

            DataAccessLayer acceso = new DataAccessLayer();
            try
            {

                acceso.setearComandoText("Update MEDICO Set Estado = 0 Where ID = " + med.MedicoId.ToString());
                acceso.abrirConexion();
                acceso.ejecutarNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }

        public void modificar(Medico medico)
        {
            DataAccessLayer dato = new DataAccessLayer();
            try
            {
                dato.setearComandoText("Update MEDICO Set Dni = '" + medico.dni + "', Apellido = '" + medico.apellido + "', Nombres = '" + medico.nombres + "', Fecha_Nac = " + medico.fechanac + ", Sexo = '" + medico.sexo + "', Telefono = '" + medico.telefono + "', Email = '" + medico.email + "',Nacionalidad = " + medico.Nacionalidad.id_pais.ToString() + " , Id_Especialidad = " + medico.Especialidad.id_especialidad.ToString()  + " ,1  Where ID_MEDICO = " +  medico.MedicoId.ToString());
                dato.abrirConexion();
                dato.ejecutarNonQuery();
                dato.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarMedicoSP(Medico nuevo)
        {

            DataAccessLayer acceso = new DataAccessLayer();

            try
            {
                acceso.setearComandoSP("AltaMedico");
                acceso.Comando.Parameters.Clear();
                acceso.Comando.Parameters.AddWithValue("@dni", nuevo.dni);
                acceso.Comando.Parameters.AddWithValue("@apellido", nuevo.apellido);
                acceso.Comando.Parameters.AddWithValue("@nombres", nuevo.nombres);
                acceso.Comando.Parameters.AddWithValue("@fecha_nac", nuevo.fechanac);
                acceso.Comando.Parameters.AddWithValue("@sexo", nuevo.sexo);
                acceso.Comando.Parameters.AddWithValue("@telefono", nuevo.telefono);
                acceso.Comando.Parameters.AddWithValue("@email", nuevo.email);
                acceso.Comando.Parameters.AddWithValue("@nacionalidad", nuevo.Nacionalidad.id_pais);
                acceso.Comando.Parameters.AddWithValue("@id_especialidad", nuevo.Especialidad.id_especialidad);
               

                acceso.abrirConexion();
                acceso.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }

        }

        public void ModificarMedicoSP(Medico nuevo)
        {

            DataAccessLayer acceso = new DataAccessLayer();

            try
            {
                acceso.setearComandoSP("ModificarMedico");
                acceso.Comando.Parameters.Clear();
                acceso.Comando.Parameters.AddWithValue("@dni", nuevo.dni);
                acceso.Comando.Parameters.AddWithValue("@apellido", nuevo.apellido);
                acceso.Comando.Parameters.AddWithValue("@nombres", nuevo.nombres);
                acceso.Comando.Parameters.AddWithValue("@fecha_nac", nuevo.fechanac);
                acceso.Comando.Parameters.AddWithValue("@sexo", nuevo.sexo);
                acceso.Comando.Parameters.AddWithValue("@telefono", nuevo.telefono);
                acceso.Comando.Parameters.AddWithValue("@email", nuevo.email);
                acceso.Comando.Parameters.AddWithValue("@nacionalidad", nuevo.Nacionalidad.id_pais);
                acceso.Comando.Parameters.AddWithValue("@id_especialidad", nuevo.Especialidad.id_especialidad);
                acceso.Comando.Parameters.AddWithValue("@id_medico", nuevo.MedicoId);

                acceso.abrirConexion();
                acceso.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }

        }



    }

}
