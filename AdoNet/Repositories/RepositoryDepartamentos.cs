using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    internal class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentos()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        //METODO PARA RECUPERAR TODOS LOS DEPARTAMENTOS
        public List<Departamento> GetDepartamentos()
        {
            string sql = "SELECT * FROM DEPT";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //DEBEMOS CREAR LA COLECCION PARA DEVOLVER
            //LOS DEPARTAMENTOS
            List<Departamento> departamentos = new List<Departamento>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                Departamento dept = new Departamento();
                dept.IdDepartamento= id;
                dept.Nombre = nombre;
                dept.Localidad = loc;
                departamentos.Add(dept);
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public Departamento FindDepartamento(int idDepartamento)
        {
            string sql = "SELECT * FROM DEPT WHERE DEPT_NO=@id";
            SqlParameter paramId = new SqlParameter("@id", idDepartamento);
            this.com.Parameters.Add(paramId);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            int id = int.Parse(this.reader["DEPT_NO"].ToString());
            string nombre = this.reader["DNOMBRE"].ToString();
            string loc = this.reader["LOC"].ToString();
            Departamento departamento = new Departamento();
            departamento.IdDepartamento = id;
            departamento.Nombre = nombre;
            departamento.Localidad = loc;
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return departamento;
        }

        public int InsertarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "INSERT INTO DEPT VALUES( @id, @nom,@loc)";
            SqlParameter pamIdDept = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nom",nombre);
            SqlParameter pamLocalidad = new SqlParameter("@loc", localidad);
            this.com.Parameters.Add(pamIdDept);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLocalidad);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            
            int numeroFilasAfectadas = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return numeroFilasAfectadas;
        }

        public int ModificarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "UPDATE DEPT SET DNOMBRE=@nom, LOC=@loc " +
                "WHERE DEPT_NO=@id";
            SqlParameter pamIdDept = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nom", nombre);
            SqlParameter pamLocalidad = new SqlParameter("@loc", localidad);

            this.com.Parameters.Add(pamIdDept);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLocalidad);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int numeroFilasAfectadas = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return numeroFilasAfectadas;
        }

        public int EliminarDepartamento(int id)
        {
            string sql = "DELETE FROM DEPT WHERE DEPT_NO=@id";
            SqlParameter paramId = new SqlParameter("@id", id);
            this.com.Parameters.Add(paramId);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int numeroBorrados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return numeroBorrados;
        }
    }
}
