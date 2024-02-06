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
    public partial class Form04ModificarSalas : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04ModificarSalas()
        {
            InitializeComponent();
            connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.LoadSalas();
        }

        private void btnModificarSalas_Click(object sender, EventArgs e)
        {
            string nombre = this.lstSalas.SelectedItem.ToString();
            string nuevonombre = this.txtNuevoNombre.Text;
            string sql = "UPDATE SALA SET NOMBRE=@nuevonombre WHERE NOMBRE= @nombre";
            SqlParameter nombrenuevo = new SqlParameter("@nuevonombre", nuevonombre);
            SqlParameter nombreantiguo = new SqlParameter("@nombre", nombre);
            
            this.com.Parameters.Add(nombreantiguo);
            this.com.Parameters.Add(nombrenuevo);


            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            
            this.cn.Open();
            //LAS CONSULTAS DE ACCION DEVUELVEN EL NUMERO DE REGISTROS AFECTADOS
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Salas modificadas " + modificados);
            this.LoadSalas();

        }

        private void LoadSalas()
        {
            this.lstSalas.Items.Clear();    
            string sql = "SELECT * FROM SALA";
            this.com.Connection = cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while(this.reader.Read()) 
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
