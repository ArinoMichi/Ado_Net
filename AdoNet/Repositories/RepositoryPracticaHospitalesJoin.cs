using AdoNet.Helpers;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region PROCEDIMIENTOS VISTAS SQL
//create view V_DOCTORES_PLANTILLA
//as
//	select DOCTOR_NO AS IDEMPLEADO, APELLIDO, DOCTOR.SALARIO, DOCTOR.HOSPITAL_COD 
//	from DOCTOR 
//	union
//	select EMPLEADO_NO, apellido, salario, HOSPITAL_COD from plantilla 
//go

//alter procedure SP_DOCTORES_PLANTILLA_HOSPITAL
//(@nombre nvarchar(50)
//, @suma int OUT, @media int OUT, @personas int OUT)
//as
//    declare @idhospital int
//	select @idhospital = HOSPITAL_COD from HOSPITAL
//	where NOMBRE = @nombre
//	select * from V_DOCTORES_PLANTILLA
//	where HOSPITAL_COD=@idhospital
//	select @suma = sum(SALARIO), @media = avg(SALARIO), 
//	@personas = count(IDEMPLEADO)

//    from V_DOCTORES_PLANTILLA

//    where HOSPITAL_COD = @idhospital
//go
#endregion

namespace AdoNet.Repositories
{
    internal class RepositoryPracticaHospitalesJoin
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryPracticaHospitalesJoin()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public List<Hospital> GetHospitales()
        {
            string sql = "SELECT * FROM HOSPITAL";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Hospital> hospitales = new List<Hospital>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                string nom = this.reader["NOMBRE"].ToString();
                string dire = this.reader["DIRECCION"].ToString();
                string telf = this.reader["TELEFONO"].ToString();
                int numCama = int.Parse(this.reader["NUM_CAMA"].ToString());

                Hospital hosp = new Hospital(id, nom, dire, telf, numCama);
                hospitales.Add(hosp);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }
        public ResumenHospitales GetResumenHospitales(string nombre)
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_HOSPITAL";
            this.com.Parameters.Add(new SqlParameter("@NOMBRE_HOSP", nombre));
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
            paramPersonas.ParameterName = "@EMPLEADOS";
            paramPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramPersonas);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            ResumenHospitales resumen = new ResumenHospitales();
            resumen.apellidoSalario = new List<string>();
            while (this.reader.Read())
            {
                string cadena = this.reader["APELLIDO"].ToString() + " - "+ this.reader["SALARIO"].ToString();
                resumen.apellidoSalario.Add(cadena);
            }
            this.reader.Close();
            //ALMACENAMOS LOS PARAMETROS 
            //POSDEMOS COMPROBAR SI EXISTEN PERSONAS
            if (resumen.apellidoSalario.Count != 0)
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
