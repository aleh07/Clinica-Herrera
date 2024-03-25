﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BLL
{
    public class DataAccessLayer
    {

        public DataAccessLayer()
        {
            this.Conexion = new SqlConnection();
            this.Comando = new SqlCommand();
        }

        public SqlConnection Conexion { set; get; }
        public SqlCommand Comando { set; get; }
        public SqlDataReader Lector { set; get; }

        public void setearComandoText(String consulta)
        {
            this.Comando.CommandType = System.Data.CommandType.Text;
            this.Comando.CommandText = consulta;
            this.Comando.Connection = this.Conexion;
        }

        public void setearComandoSP(String SP)
        {
            this.Comando.CommandType = System.Data.CommandType.StoredProcedure;
            this.Comando.CommandText = SP;
            this.Comando.Connection = this.Conexion;
        }

        public void ejecutarQuery()
        {
            this.Lector = this.Comando.ExecuteReader();
        }

        public void ejecutarNonQuery()
        {
            this.Comando.ExecuteNonQuery();
        }

        public void abrirConexion()
        {
            this.Conexion.ConnectionString = "initial catalog = HERRERA_CLINICA; data source = DESKTOP-N4F2CD1; integrated security = sspi";
            this.Conexion.Open();
        }

        public void cerrarConexion()
        {
            this.Conexion.Close();
        }



    }
}
