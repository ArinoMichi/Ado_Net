using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryParametrosSalida
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryParametrosSalida() 
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> departamentos = new List<string>();
            while (this.reader.Read())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public ResumenEmpleados GetResumenEmpleados(string dnombre)
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_DEPARTAMENTO";
            this.com.Parameters.Add(new SqlParameter("@NOMBRE", dnombre));
            // Un parámetro de salida no lleva valor, lo recuperamos en el procedimiento
            // Dirección del parámetro -> ParameterDirection.Output
            SqlParameter paramSuma = new SqlParameter();
            paramSuma.Value = 0;
            paramSuma.ParameterName = "@SUMA";
            paramSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramSuma);
            SqlParameter paramMedia = new SqlParameter();
            paramMedia.Value = 0;
            paramMedia.ParameterName = "@MEDIA";
            paramMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramMedia);
            SqlParameter paramPersonas = new SqlParameter();
            paramPersonas.Value = 0;
            paramPersonas.ParameterName = "@PERSONAS";
            paramPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramPersonas);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            ResumenEmpleados resumen = new ResumenEmpleados();
            resumen.Apellidos = new List<string>();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                resumen.Apellidos.Add(apellido);
            }
            this.reader.Close();
            //ALMACENAMOS LOS PARAMETROS 
            //POSDEMOS COMPROBAR SI EXISTEN PERSONAS
            if (resumen.Apellidos.Count != 0)
            {
                resumen.SumaSalarial = int.Parse(paramSuma.Value.ToString());
                resumen.MediaSalarial = int.Parse(paramMedia.Value.ToString());
                resumen.Personas = int.Parse(paramPersonas.Value.ToString());
            }
            this.cn.Close();
            this.com.Parameters.Clear();
            return resumen;
        }
    }
}
