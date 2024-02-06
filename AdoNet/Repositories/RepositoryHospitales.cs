using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    internal class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        //METODO PARA RECUPERAR LOS HOSPITALES
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

                Hospital hosp = new Hospital(id,nom, dire, telf,numCama);
                hospitales.Add(hosp);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public int InsertHospital(int codigo, string nombre, string direccion, string telef, int numcamas)
        {
            string sql = "INSERT INTO HOSPITAL VALUES(@cod,@nombre,@direccion,@tlf,@numcamas)";
            SqlParameter pamCodigo = new SqlParameter("@cod", codigo);
            SqlParameter pamNumero = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelef = new SqlParameter("@tlf", telef);
            SqlParameter pamNum = new SqlParameter("@numcamas", numcamas);
            this.com.Parameters.Add(pamCodigo);
            this.com.Parameters.Add(pamNumero);
            this.com.Parameters.Add(pamDireccion);
            this.com.Parameters.Add(pamTelef);
            this.com.Parameters.Add(pamNum);

            this.com.CommandType= System.Data.CommandType.Text;
            this.com.CommandText= sql;
            this.cn.Open();
            int result = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();
            return result;
        }
        public int ModificarHospital(int codigo, string nombre, string direccion, string telef, int numcamas)
        {
            string sql = "UPDATE HOSPITAL SET NOMBRE = @nombre, DIRECCION = " +
                "@direccion, TELEFONO = @tlf, NUM_CAMA = @numcamas WHERE HOSPITAL_COD = @cod";
            SqlParameter pamCodigo = new SqlParameter("@cod", codigo);
            SqlParameter pamNumero = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelef = new SqlParameter("@tlf", telef);
            SqlParameter pamNum = new SqlParameter("@numcamas", numcamas);
            this.com.Parameters.Add(pamCodigo);
            this.com.Parameters.Add(pamNumero);
            this.com.Parameters.Add(pamDireccion);
            this.com.Parameters.Add(pamTelef);
            this.com.Parameters.Add(pamNum);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int result = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();
            return result;

        }

        public int DeleteHospital(int id)
        {
            string sql = "DELETE FROM HOSPITAL WHERE HOSPITAL_COD= @cod";
            SqlParameter pamCodigo = new SqlParameter("@cod", id);
            this.com.Parameters.Add(pamCodigo);

            this.com.CommandType= System.Data.CommandType.Text;
            this.com.CommandText= sql;
            this.cn.Open();

            int result = this.com.ExecuteNonQuery();

            this.cn.Close() ;
            this.com.Parameters.Clear();
            return result;

        }
    }
}
