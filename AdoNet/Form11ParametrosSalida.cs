using AdoNet.Models;
using AdoNet.Repositories;
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
    public partial class Form11ParametrosSalida : Form
    {
        RepositoryParametrosSalida repo;

        public Form11ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosSalida();
            this.LoadDepartamentos();

        }

        private void LoadDepartamentos()
        {
            List<string> departamentos = this.repo.GetDepartamentos();
            foreach (string data in departamentos)
            {
                this.cmbDepartamentos.Items.Add(data);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            this.lstEmpleados.Items.Clear();
          string nombre = this.cmbDepartamentos.SelectedItem.ToString();
          ResumenEmpleados resumen = this.repo.GetResumenEmpleados(nombre);
            this.txtMedia.Text = resumen.MediaSalarial.ToString();
            this.txtSuma.Text = resumen.SumaSalarial.ToString();
            this.txtPersonas.Text = resumen.Personas.ToString();
            foreach (var apellido in resumen.Apellidos)
            {
                this.lstEmpleados.Items.Add(apellido);
            }

        }
    }
}
