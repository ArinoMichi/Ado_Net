using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form03EliminarEnfermos : Form
    {
        string connectionString;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;
        public Form03EliminarEnfermos()
        {
            InitializeComponent();
            this.connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.con = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.LoadEnfermos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string inscripcion = this.txtInscripcion.Text;
            string sql = "DELETE FROM ENFERMO WHERE INSCRIPCION= @inscripcion";
            SqlParameter paraminscripcion = new SqlParameter();
            paraminscripcion.ParameterName = "@inscripcion";
            paraminscripcion.DbType = DbType.Int32;
            paraminscripcion.Value = inscripcion;
            //Direction por defecto es INPUT, por lo que no es necesario
            //Indicarlo a no ser que lo deseemos modificar
            paraminscripcion.Direction = ParameterDirection.Input;
            //AÑADIMOS EL PARAMETRO A LA COLECCION DEL COMMAND
            this.com.Parameters.Add(paraminscripcion);

            this.com.Connection = con;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.con.Open();
            //LAS CONSULTAS DE ACCION DEVUELVEN EL NUMERO DE REGISTROS AFECTADOS
            int eliminados = this.com.ExecuteNonQuery();
            this.con.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Enfermos eliminados " + eliminados);
            this.LoadEnfermos();
        }

        private void LoadEnfermos()
        {
            string sql = "SELECT * FROM ENFERMO";
            this.com.Connection = this.con;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            this.reader.Close();
            this.con.Close();
        }
    }
}
