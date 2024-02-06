using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form12PracticaHospitales : Form
    {
        RepositoryPracticaHospitalesJoin repo;
        public Form12PracticaHospitales()
        {
            this.repo = new RepositoryPracticaHospitalesJoin();
            InitializeComponent();
            this.LoadHospitales();

        }

        private void LoadHospitales()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            foreach (Hospital hospital in hospitales)
            {
                this.cmbHospitales.Items.Add(hospital.Nombre);
            }

        }

        private void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            this.lstEmpleados.Items.Clear();
            ResumenHospitales resumen = this.repo.GetResumenHospitales(nombre);

            this.txtMedia.Text = resumen.MediaSalarial.ToString();
            this.txtSuma.Text = resumen.SumaSalarial.ToString();
            this.txtPersonas.Text = resumen.Personas.ToString();
            foreach (var cadena in resumen.apellidoSalario)
            {
                this.lstEmpleados.Items.Add(cadena);
            }
        }
    }
}
